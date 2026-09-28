# Timelocks für alternative Jobtitel

Branch: `feature/alt-title-timelocks`

Baut auf dem Alt-Title-Feature aus Upstream auf (ProjectOmu/OmuStation#1736), das per Merge von `ProjectOmu/OmuStation` master reingekommen ist. Unser `master` ist inzwischen auch auf dem Stand, ein PR gegen `master` enthält also nur die Änderungen hier.

## Was es macht

Alternative Jobtitel können dieselben Requirements bekommen wie Jobs (RoleTimeRequirement, DepartmentTimeRequirement, OverallPlaytimeRequirement, AgeRequirement usw.).

- Charakter-Editor: gesperrte Titel stehen ausgegraut mit "(Locked)" im Dropdown, der Tooltip vom Dropdown listet pro Titel, was fehlt.
- Profil laden/speichern: nicht freigeschaltete Titel fliegen raus (gleiches Prinzip wie bei Loadouts).
- Spawn: erfüllt der Spieler die Requirements nicht, gibt es den normalen Jobtitel.
- Mit `game.role_timers false` gibt es keine Sperren, wie bei Jobs.

## Konfiguration

Datei: `Resources/Prototypes/_Omu/Roles/Jobs/alternate_title_requirements.yml`

```yaml
- type: jobAlternateTitleRequirements
  id: Quartermaster            # Job-ID
  titles:
    job-name-alt-qm-2:         # Deck Chief
    - !type:RoleTimeRequirement
      role: JobQuartermaster
      time: 36000 # 10 hrs
```

- `id` ist die ID des Jobs.
- Die Keys unter `titles` sind die LocIds der Titel aus `alternate_titles.yml` (Prefix + Nummer, Namen stehen in `job-alternate-titles.ftl`).
- Titel ohne Eintrag sind frei.
- `RequirementsMatchTitlesTest` schlägt fehl, wenn Job oder Titel nicht existieren.

Aktuell ist noch kein Titel gesperrt, die Datei enthält nur das auskommentierte Beispiel.

## Code

| Datei | Inhalt |
| --- | --- |
| `Content.Shared/_Omu/Roles/JobAlternateTitleRequirementsPrototype.cs` | Prototyp, Requirements pro Titel |
| `Content.Shared/_Omu/Roles/JobAlternateTitleSystem.cs` | `GetRequirements`, `IsTitleAllowed` (mit Session oder mit Playtimes) |
| `Content.Shared/Preferences/HumanoidCharacterProfile.cs` | `EnsureValid` verwirft gesperrte Titel |
| `Content.Server/GameTicking/GameTicker.Spawning.cs` | Fallback auf Standardtitel vor `DoSpawn` |
| `Content.Client/Lobby/UI/HumanoidProfileEditor.xaml.cs` | ermittelt gesperrte Titel für das Dropdown |
| `Content.Client/Lobby/UI/Roles/RequirementsSelector.xaml.cs` | Dropdown-Einträge sperren, Tooltip |
| `Resources/Locale/en-US/_Omu/job/job-alternate-title-requirements.ftl` | "(Locked)" und Tooltip-Text |
| `Content.IntegrationTests/Tests/_Omu/Roles/JobAlternateTitleRequirementsTest.cs` | Tests |

Designentscheidungen:

- Eigener Prototyp statt Erweiterung der `localizedDataset`-Einträge, damit `alternate_titles.yml` unverändert bleibt und Upstream-Merges nicht kollidieren.
- `IsTitleAllowed` holt die Playtimes nur, wenn es für den Titel überhaupt Requirements gibt. Auf dem Server wirft `GetPlayTimes`, solange die Playtime noch nicht geladen ist.
- Ohne Session (z.B. Spawns ohne Spieler) gilt der Titel als erlaubt.
- Der Client prüft gegen das Profil im Editor, nicht gegen den gespeicherten Charakter, weil der Server beim Speichern auch dieses Profil validiert.

## Offen

- Festlegen, welche Titel wie lange gesperrt werden.
- UI im laufenden Client angucken (siehe unten).
- PR gegen `master`. Diese Datei vorher entfernen, falls sie nicht ins Repo soll.

## Manuell testen (Debug-Server)

`development.toml` schaltet Lobby und Role-Timer aus, und die Dev-Map hat nur Captain, NT-Rep und Blueshield (Captain ist selbst zeitgesperrt). Deshalb auf einer normalen Map mit Cargo Technician testen, der hat Alt-Titel und keine eigenen Requirements.

Test-Sperre in `alternate_title_requirements.yml` eintragen (nicht committen):

```yaml
- type: jobAlternateTitleRequirements
  id: CargoTechnician
  titles:
    job-name-alt-cargotech-1: # Shuttle Pilot
    - !type:RoleTimeRequirement
      role: JobCargoTechnician
      time: 3600 # 1 hr
    job-name-alt-cargotech-2: # Logistics Clerk
    - !type:RoleTimeRequirement
      role: JobCargoTechnician
      time: 360000 # 100 hrs
```

Server und Client starten, dann in der Konsole:

```
cvar game.role_timers true
forcemap Packed
golobby
```

Die Cvars gelten nur bis zum nächsten Server-Neustart.

1. UI-Sperre: Charakter-Editor, Jobs-Tab, Cargo Technician. Shuttle Pilot und Logistics Clerk sind ausgegraut, Tooltip zeigt die fehlende Zeit.
2. Freischalten:
   ```
   playtime_addrole <name> JobCargoTechnician 60
   golobby
   ```
   `golobby` nochmal, weil die Playtimes erst beim Betreten der Lobby an den Client gehen. Shuttle Pilot ist jetzt wählbar, Logistics Clerk nicht. Shuttle Pilot wählen, Cargo Technician auf High, speichern, Ready, `startround`. ID, PDA und Crew-Manifest zeigen "Shuttle Pilot", im Chat kommt die Titel-Erinnerung.
3. Fallback beim Spawn: `cvar game.role_timers false`, `golobby`, Logistics Clerk wählen, speichern, Ready. Dann `cvar game.role_timers true` und `startround`. Man spawnt mit "Cargo Technician" auf der ID und ohne Titel-Erinnerung.
4. Bereinigung beim Laden: Client neu verbinden (Server weiterlaufen lassen). Logistics Clerk ist aus dem Profil verschwunden.

Die Ankunftsdurchsage nutzt den Titel nur beim Late-Join ("Join Game" in laufender Runde).

## Build und Tests

```
dotnet build Content.Server
dotnet build Content.Client
dotnet test Content.IntegrationTests --filter "FullyQualifiedName~JobAlternateTitleRequirementsTest"
```

Sinnvoll zusätzlich: `Tests.Lobby`, `Tests.Preferences`, `Tests.Round.JobTest`, `LocalizedDatasetPrototypeTest`.

Falls der NuGet-Feed `dotnet-eng` (pkgs.dev.azure.com) nicht erreichbar ist:

- Restore mit `dotnet restore <projekt> --ignore-failed-sources -p:NuGetAudit=false`, danach bauen mit `--no-restore -p:NuGetAudit=false`.
- `Content.IntegrationTests` braucht dann trotzdem `Microsoft.DotNet.RemoteExecutor`, das es nur auf diesem Feed gibt. Zum lokalen Testen in `RobustToolbox/Robust.Shared.Maths.Tests` die PackageReference aus der csproj und `NumericsHelpers_Test.cs` vorübergehend entfernen, danach mit `git -C RobustToolbox checkout -- .` zurücksetzen.

Bekannter Flake: `StatusEffectsSystem.StatusEffectPrototypes` ist ein statisches `HashSet`, das Server und Client beim Erstellen des Test-Pairs gleichzeitig befüllen. Gibt ab und zu eine NullReferenceException beim Start, danach werden die restlichen Tests übersprungen. Einfach nochmal laufen lassen, hat nichts mit dem Feature zu tun.

## Upstream

```
git remote add upstream https://github.com/ProjectOmu/OmuStation
git fetch upstream master
git merge upstream/master
```
