# Jobtitel in OmuStation

Übersicht über alle Jobs und ihre alternativen Titel, wie sie im Repo definiert sind. Grundlage für die Entscheidung, welche Alt-Titel ein Timelock bekommen (siehe `docs/alt-title-timelocks.md`).

Quellen:

- Jobs: `type: job` in `Resources/Prototypes/**/Roles/Jobs/` (Namen aus `Resources/Locale/en-US`)
- Abteilungen: `type: department`
- Alt-Titel: `Resources/Prototypes/_Omu/Roles/Jobs/alternate_titles.yml`, Namen in `Resources/Locale/en-US/_Omu/job/job-alternate-titles.ftl`
- Zuordnung Job → Titel über die Dataset-ID `AlternateTitles<JobId>` (`JobAlternateTitleSystem.DatasetId`)

Die LocId in der Spalte „LocId“ ist genau der Key, der in `alternate_title_requirements.yml` unter `titles:` eingetragen wird.

## Zusammenfassung

- **86** Job-Prototypen insgesamt, davon **50** im Charakter-Editor wählbar
- **39** Jobs haben alternative Titel, zusammen **150** Alt-Titel
- Aktuell ist **kein** Alt-Titel zeitgesperrt

| Abteilung | Jobs | davon mit Alt-Titeln | Alt-Titel |
| --- | ---: | ---: | ---: |
| Command (Kommando) | 7 | 4 | 15 |
| Security (Sicherheit) | 9 | 6 | 15 |
| Engineering (Technik) | 4 | 3 | 10 |
| Medical (Medizin) | 7 | 6 | 22 |
| Science (Forschung) | 4 | 3 | 13 |
| Cargo (Logistik) | 5 | 4 | 16 |
| Civilian / Service | 15 | 12 | 56 |
| Station specific | 1 | 1 | 3 |
| Silicon | 2 | 0 | 0 |

## Inhalt

- [Command (Kommando)](#command-kommando)
- [Security (Sicherheit)](#security-sicherheit)
- [Engineering (Technik)](#engineering-technik)
- [Medical (Medizin)](#medical-medizin)
- [Science (Forschung)](#science-forschung)
- [Cargo (Logistik)](#cargo-logistik)
- [Civilian / Service](#civilian--service)
- [Station specific](#station-specific)
- [Silicon](#silicon)
- [Jobs ohne Charakter-Editor (CentComm, ERT, Events)](#jobs-ohne-charakter-editor-centcomm-ert-events)
- [Alphabetischer Index aller Alt-Titel](#alphabetischer-index-aller-alt-titel)
- [Auffälligkeiten](#auffälligkeiten)

## Command (Kommando)

> Die Abteilungsleiter (CE, CMO, HoS, RD, QM) stehen bei ihren Abteilungen. Der Head of Personnel gehört zusätzlich zu Civilian.

### Captain (`Captain`)

- Job-Voraussetzungen: 4 h Engineering; 4 h Medical; 4 h Science; 6 h Security; 20 h Command; 40 h Gesamtspielzeit
- Dataset: `AlternateTitlesCaptain` (6 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Station Commander | `job-name-alt-captain-1` |
| 2 | Commanding Officer | `job-name-alt-captain-2` |
| 3 | Site Manager | `job-name-alt-captain-3` |
| 4 | Head of Command | `job-name-alt-captain-4` |
| 5 | Site Director | `job-name-alt-captain-5` |
| 6 | Site Administrator | `job-name-alt-captain-6` |

### Head of Personnel (`HeadOfPersonnel`)

- Job-Voraussetzungen: 2.5 h Engineering; 2.5 h Medical; 2.5 h Science; 2.5 h Security; 10 h Command
- Dataset: `AlternateTitlesHeadOfPersonnel` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Employment Officer | `job-name-alt-hop-1` |
| 2 | Crew Supervisor | `job-name-alt-hop-2` |
| 3 | Head of Hospitality | `job-name-alt-hop-3` |

### Nanotrasen Representative (`NanotrasenRepresentative`)

- Job-Voraussetzungen: 50 h Command; Alter ≥ 21; 20 h Gesamtspielzeit
- Dataset: `AlternateTitlesNanotrasenRepresentative` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Corporate Liaison | `job-name-alt-ntr-1` |
| 2 | Nanotrasen Compliance Executive | `job-name-alt-ntr-2` |
| 3 | Nanotrasen Advisor | `job-name-alt-ntr-3` |

### Blueshield Officer (`BlueshieldOfficer`)

- Job-Voraussetzungen: 25 h Command; 15 h Medical; 25 h Security; Alter ≥ 21; 20 h Gesamtspielzeit
- Keine alternativen Titel

### Nanotrasen Career Trainer (`NanotrasenCareerTrainer`)

- Job-Voraussetzungen: –
- Keine alternativen Titel

### Administrative Assistant (`AdministrativeAssistant`)

- Job-Voraussetzungen: 10 h Gesamtspielzeit; 5 h Engineering; 5 h Security; 5 h Science; 5 h Medical
- Dataset: `AlternateTitlesAdministrativeAssistant` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Command Secretary | `job-name-alt-admin-assistant-1` |
| 2 | Bridge Clerk | `job-name-alt-admin-assistant-2` |
| 3 | Executive Aide | `job-name-alt-admin-assistant-3` |

### Command Maid (`CommandMaid`) _(nicht im Editor wählbar)_

- Job-Voraussetzungen: 10 h Gesamtspielzeit; 1 h als Janitor
- Keine alternativen Titel

## Security (Sicherheit)

### Head of Security (`HeadOfSecurity`)

- Job-Voraussetzungen: 5 h als Warden; 5 h als Detective; 5 h als Security Officer; 2 h als Corpsman; 30 h Security; 20 h Gesamtspielzeit
- Dataset: `AlternateTitlesHeadOfSecurity` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Security Commander | `job-name-alt-hos-1` |
| 2 | Chief Constable | `job-name-alt-hos-2` |
| 3 | Chief of Security | `job-name-alt-hos-3` |

### Sergeant (`SecuritySergeant`)

- Job-Voraussetzungen: 100 h Gesamtspielzeit; 100 h Security; 10 h als Head of Security; 10 h als Warden; 50 h als Security Officer
- Dataset: `AlternateTitlesSecuritySergeant` (2 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Patrol Leader | `job-name-alt-security-sergeant-1` |
| 2 | Drill Instructor | `job-name-alt-security-sergeant-2` |

### Warden (`Warden`)

- Job-Voraussetzungen: 5 h als Security Officer; 5 h als Corpsman; 15 h Security; 10 h Gesamtspielzeit
- Dataset: `AlternateTitlesWarden` (2 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Dispatcher | `job-name-alt-warden-1` |
| 2 | Surveillance Operator | `job-name-alt-warden-2` |

### Detective (`Detective`)

- Job-Voraussetzungen: 5 h als Security Officer
- Dataset: `AlternateTitlesDetective` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Forensic Investigator | `job-name-alt-detective-1` |
| 2 | Inspector | `job-name-alt-detective-2` |
| 3 | Lead Investigator | `job-name-alt-detective-3` |

### Security Officer (`SecurityOfficer`)

- Job-Voraussetzungen: 5 h Security
- Keine alternativen Titel

### Corpsman (`Brigmedic`)

- Job-Voraussetzungen: 10 h Medical; 10 h Security
- Dataset: `AlternateTitlesBrigmedic` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Combat Medic | `job-name-alt-brigmedic-1` |
| 2 | Field Medic | `job-name-alt-brigmedic-2` |
| 3 | Brigmedic | `job-name-alt-brigmedic-3` |

### Security Cadet (`SecurityCadet`)

- Job-Voraussetzungen: 10 h Gesamtspielzeit; **weniger als** 10 h Security
- Keine alternativen Titel

### Security Clown (`SecurityClown`) _(nicht im Editor wählbar)_

- Job-Voraussetzungen: 10 h Gesamtspielzeit; 1 h als Clown
- Keine alternativen Titel

### Transit Prisoner (`TransitPrisoner`)

- Job-Voraussetzungen: 10 h Security
- Dataset: `AlternateTitlesTransitPrisoner` (2 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Detainee | `job-name-alt-transit-prisoner-1` |
| 2 | Inmate | `job-name-alt-transit-prisoner-2` |

## Engineering (Technik)

### Chief Engineer (`ChiefEngineer`)

- Job-Voraussetzungen: 15 h als Atmospheric Technician; 5 h als Station Engineer; 20 h Engineering; 10 h Gesamtspielzeit
- Dataset: `AlternateTitlesChiefEngineer` (2 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Head of Engineering | `job-name-alt-ce-1` |
| 2 | Engineering Supervisor | `job-name-alt-ce-2` |

### Station Engineer (`StationEngineer`)

- Job-Voraussetzungen: 2.5 h Engineering
- Dataset: `AlternateTitlesStationEngineer` (5 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Maintenance Technician | `job-name-alt-engineer-1` |
| 2 | Mechanic | `job-name-alt-engineer-2` |
| 3 | Electrician | `job-name-alt-engineer-3` |
| 4 | Engine Operator | `job-name-alt-engineer-4` |
| 5 | Emergency Damage Control Technician | `job-name-alt-engineer-5` |

### Atmospheric Technician (`AtmosphericTechnician`)

- Job-Voraussetzungen: 2.5 h Engineering
- Dataset: `AlternateTitlesAtmosphericTechnician` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Fire Suppression Specialist | `job-name-alt-atmostech-1` |
| 2 | Life Support Technician | `job-name-alt-atmostech-2` |
| 3 | EVA Technician | `job-name-alt-atmostech-3` |

### Technical Assistant (`TechnicalAssistant`)

- Job-Voraussetzungen: 5 h Gesamtspielzeit
- Keine alternativen Titel

## Medical (Medizin)

> Psychologist zählt zusätzlich zur Abteilung „Station specific“.

### Chief Medical Officer (`ChiefMedicalOfficer`)

- Job-Voraussetzungen: 15 h als Chemist; 10 h als Medical Doctor; 2.5 h als Paramedic; 10 h Medical; 20 h Medical
- Dataset: `AlternateTitlesChiefMedicalOfficer` (4 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Medical Director | `job-name-alt-cmo-1` |
| 2 | Head of Medical | `job-name-alt-cmo-2` |
| 3 | Chief Physician | `job-name-alt-cmo-3` |
| 4 | Head Physician | `job-name-alt-cmo-4` |

### Medical Doctor (`MedicalDoctor`)

- Job-Voraussetzungen: 2.5 h Medical
- Dataset: `AlternateTitlesMedicalDoctor` (6 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Physician | `job-name-alt-doctor-1` |
| 2 | Nurse | `job-name-alt-doctor-2` |
| 3 | Surgeon | `job-name-alt-doctor-3` |
| 4 | General Practitioner | `job-name-alt-doctor-4` |
| 5 | Medical Resident | `job-name-alt-doctor-5` |
| 6 | Nurse Practitioner | `job-name-alt-doctor-6` |

### Chemist (`Chemist`)

- Job-Voraussetzungen: 5 h Medical
- Dataset: `AlternateTitlesChemist` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Pharmacist | `job-name-alt-chemist-1` |
| 2 | Lab Technician | `job-name-alt-chemist-2` |
| 3 | Pharmacologist | `job-name-alt-chemist-3` |

### Paramedic (`Paramedic`)

- Job-Voraussetzungen: 2.5 h Medical
- Dataset: `AlternateTitlesParamedic` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Trauma Specialist | `job-name-alt-paramedic-1` |
| 2 | Emergency Medical Technician | `job-name-alt-paramedic-2` |
| 3 | Search & Rescue Technician | `job-name-alt-paramedic-3` |

### Virologist (`Virologist`)

- Job-Voraussetzungen: 4 h Medical
- Dataset: `AlternateTitlesVirologist` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Epidemiologist | `job-name-alt-virologist-1` |
| 2 | Pathologist | `job-name-alt-virologist-2` |
| 3 | Immunologist | `job-name-alt-virologist-3` |

### Psychologist (`Psychologist`)

- Job-Voraussetzungen: –
- Dataset: `AlternateTitlesPsychologist` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Therapist | `job-name-alt-psychologist-1` |
| 2 | Guidance Counselor | `job-name-alt-psychologist-2` |
| 3 | Psychiatrist | `job-name-alt-psychologist-3` |

### Medical Intern (`MedicalIntern`)

- Job-Voraussetzungen: 0.5 h Gesamtspielzeit
- Keine alternativen Titel

## Science (Forschung)

### Research Director (`ResearchDirector`)

- Job-Voraussetzungen: 5 h als Cyborg; 10 h als Scientist; 20 h Science; 10 h Gesamtspielzeit
- Dataset: `AlternateTitlesResearchDirector` (5 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Lead Researcher | `job-name-alt-rd-1` |
| 2 | Research Supervisor | `job-name-alt-rd-2` |
| 3 | Chief Science Officer | `job-name-alt-rd-3` |
| 4 | Head of Science | `job-name-alt-rd-4` |
| 5 | Systems Administrator | `job-name-alt-rd-5` |

### Scientist (`Scientist`)

- Job-Voraussetzungen: 2.5 h Science
- Dataset: `AlternateTitlesScientist` (5 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Xenoarchaeologist | `job-name-alt-scientist-1` |
| 2 | Anomaly Researcher | `job-name-alt-scientist-2` |
| 3 | Hardware Technician | `job-name-alt-scientist-3` |
| 4 | Lab Technician | `job-name-alt-scientist-4` |
| 5 | Theoretical Physicist | `job-name-alt-scientist-5` |

### Roboticist (`Roboticist`)

- Job-Voraussetzungen: 2.5 h als Cyborg; 4 h Science
- Dataset: `AlternateTitlesRoboticist` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Biomechanical Engineer | `job-name-alt-roboticist-1` |
| 2 | Mechatronic Specialist | `job-name-alt-roboticist-2` |
| 3 | Cybertronic Technician | `job-name-alt-roboticist-3` |

### Research Assistant (`ResearchAssistant`)

- Job-Voraussetzungen: 0.5 h Gesamtspielzeit
- Keine alternativen Titel

## Cargo (Logistik)

> Der Quartermaster gehört zusätzlich zu Command.

### Quartermaster (`Quartermaster`)

- Job-Voraussetzungen: 10 h als Cargo Technician; 5 h als Salvage Specialist; 20 h Cargo; 10 h Gesamtspielzeit
- Dataset: `AlternateTitlesQuartermaster` (4 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Requisitions Officer | `job-name-alt-qm-1` |
| 2 | Deck Chief | `job-name-alt-qm-2` |
| 3 | Warehouse Supervisor | `job-name-alt-qm-3` |
| 4 | Logistics Coordinator | `job-name-alt-qm-4` |

### Cargo Technician (`CargoTechnician`)

- Job-Voraussetzungen: –
- Dataset: `AlternateTitlesCargoTechnician` (5 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Shuttle Pilot | `job-name-alt-cargotech-1` |
| 2 | Logistics Clerk | `job-name-alt-cargotech-2` |
| 3 | Warehouse Technician | `job-name-alt-cargotech-3` |
| 4 | Deck Worker | `job-name-alt-cargotech-4` |
| 5 | Inventory Associate | `job-name-alt-cargotech-5` |

### Salvage Specialist (`SalvageSpecialist`)

- Job-Voraussetzungen: 2.5 h Cargo
- Dataset: `AlternateTitlesSalvageSpecialist` (4 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Mining Specialist | `job-name-alt-salvagespec-1` |
| 2 | Field Geologist | `job-name-alt-salvagespec-2` |
| 3 | Drill Technician | `job-name-alt-salvagespec-3` |
| 4 | Shipbreaking Specialist | `job-name-alt-salvagespec-4` |

### Shaft Miner (`ShaftMiner`)

- Job-Voraussetzungen: 2.5 h Cargo
- Keine alternativen Titel

### Courier (`Courier`)

- Job-Voraussetzungen: 2.5 h Cargo
- Dataset: `AlternateTitlesCourier` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Mail Carrier | `job-name-alt-courier-1` |
| 2 | Dispatch Runner | `job-name-alt-courier-2` |
| 3 | Delivery Associate | `job-name-alt-courier-3` |

## Civilian / Service

> Reporter zählt zusätzlich zur Abteilung „Station specific“.

### Bartender (`Bartender`)

- Job-Voraussetzungen: 0.5 h Civilian
- Dataset: `AlternateTitlesBartender` (4 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Mixologist | `job-name-alt-bartender-1` |
| 2 | Barista | `job-name-alt-bartender-2` |
| 3 | Hydration Equipment Operator | `job-name-alt-bartender-3` |
| 4 | Barkeeper | `job-name-alt-bartender-4` |

### Botanist (`Botanist`)

- Job-Voraussetzungen: –
- Dataset: `AlternateTitlesBotanist` (5 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Hydroponics Specialist | `job-name-alt-botanist-1` |
| 2 | Herbologist | `job-name-alt-botanist-2` |
| 3 | Hydroponicist | `job-name-alt-botanist-3` |
| 4 | Gardener | `job-name-alt-botanist-4` |
| 5 | Botanical Researcher | `job-name-alt-botanist-5` |

### Chef (`Chef`)

- Job-Voraussetzungen: 0.5 h Civilian
- Dataset: `AlternateTitlesChef` (5 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Sous-chef | `job-name-alt-chef-1` |
| 2 | Line Cook | `job-name-alt-chef-2` |
| 3 | Caterer | `job-name-alt-chef-3` |
| 4 | Butcher | `job-name-alt-chef-4` |
| 5 | Culinary Artist | `job-name-alt-chef-5` |

### Service Worker (`ServiceWorker`)

- Job-Voraussetzungen: 7.5 h Civilian
- Dataset: `AlternateTitlesServiceWorker` (5 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Waiter | `job-name-alt-serviceworker-1` |
| 2 | Junior Cook | `job-name-alt-serviceworker-2` |
| 3 | Bartender Apprentice | `job-name-alt-serviceworker-3` |
| 4 | Croupier | `job-name-alt-serviceworker-4` |
| 5 | Steward | `job-name-alt-serviceworker-5` |

### Janitor (`Janitor`)

- Job-Voraussetzungen: –
- Dataset: `AlternateTitlesJanitor` (4 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Maid | `job-name-alt-janitor-1` |
| 2 | Maintenance Worker | `job-name-alt-janitor-2` |
| 3 | Custodial Technician | `job-name-alt-janitor-3` |
| 4 | Sanitation Specialist | `job-name-alt-janitor-4` |

### Chaplain (`Chaplain`)

- Job-Voraussetzungen: 15 h Gesamtspielzeit
- Dataset: `AlternateTitlesChaplain` (9 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Preacher | `job-name-alt-chaplain-1` |
| 2 | Spiritual Advisor | `job-name-alt-chaplain-2` |
| 3 | Shrine Guardian | `job-name-alt-chaplain-3` |
| 4 | Reverend | `job-name-alt-chaplain-4` |
| 5 | Priest | `job-name-alt-chaplain-5` |
| 6 | Oracle | `job-name-alt-chaplain-6` |
| 7 | Pontifex | `job-name-alt-chaplain-7` |
| 8 | Magister | `job-name-alt-chaplain-8` |
| 9 | Monk | `job-name-alt-chaplain-9` |

### Lawyer (`Lawyer`)

- Job-Voraussetzungen: 2.5 h Gesamtspielzeit
- Dataset: `AlternateTitlesLawyer` (7 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Attorney | `job-name-alt-lawyer-1` |
| 2 | Legal Representative | `job-name-alt-lawyer-2` |
| 3 | Counsel | `job-name-alt-lawyer-3` |
| 4 | Prosecutor | `job-name-alt-lawyer-4` |
| 5 | Legal Clerk | `job-name-alt-lawyer-5` |
| 6 | Public Defender | `job-name-alt-lawyer-6` |
| 7 | Barrister | `job-name-alt-lawyer-7` |

### Librarian (`Librarian`)

- Job-Voraussetzungen: –
- Dataset: `AlternateTitlesLibrarian` (5 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Clerk | `job-name-alt-librarian-1` |
| 2 | Writer | `job-name-alt-librarian-2` |
| 3 | Professor | `job-name-alt-librarian-3` |
| 4 | Curator | `job-name-alt-librarian-4` |
| 5 | Archivist | `job-name-alt-librarian-5` |

### Clown (`Clown`)

- Job-Voraussetzungen: –
- Dataset: `AlternateTitlesClown` (4 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Jester | `job-name-alt-clown-1` |
| 2 | Bouffon | `job-name-alt-clown-2` |
| 3 | Joker | `job-name-alt-clown-3` |
| 4 | Comedian | `job-name-alt-clown-4` |

### Mime (`Mime`)

- Job-Voraussetzungen: 4 h Gesamtspielzeit
- Dataset: `AlternateTitlesMime` (1 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Pantomimist | `job-name-alt-mime-1` |

### Musician (`Musician`)

- Job-Voraussetzungen: –
- Dataset: `AlternateTitlesMusician` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Busker | `job-name-alt-musician-1` |
| 2 | Performer | `job-name-alt-musician-2` |
| 3 | Maestro | `job-name-alt-musician-3` |

### Reporter (`Reporter`)

- Job-Voraussetzungen: –
- Dataset: `AlternateTitlesReporter` (4 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Influencer | `job-name-alt-reporter-1` |
| 2 | Documentarian | `job-name-alt-reporter-2` |
| 3 | Media Coordinator | `job-name-alt-reporter-3` |
| 4 | Journalist | `job-name-alt-reporter-4` |

### Assistant (`Passenger`)

- Job-Voraussetzungen: –
- Keine alternativen Titel

### Visitor (`Visitor`) _(nicht im Editor wählbar)_

- Job-Voraussetzungen: –
- Keine alternativen Titel

### Party Maker (`PartyMaker`) _(nicht im Editor wählbar)_

- Job-Voraussetzungen: –
- Keine alternativen Titel

## Station specific

> Reporter und Psychologist gehören ebenfalls zu dieser Abteilung und sind oben aufgeführt.

### Radio Host (`RadioHost`)

- Job-Voraussetzungen: –
- Dataset: `AlternateTitlesRadioHost` (3 Titel)

| # | Alt-Titel | LocId |
| ---: | --- | --- |
| 1 | Radio DJ | `job-name-alt-radiohost-1` |
| 2 | Broadcaster | `job-name-alt-radiohost-2` |
| 3 | Talk Show Host | `job-name-alt-radiohost-3` |

## Silicon

### Cyborg (`Borg`)

- Job-Voraussetzungen: 10 h Gesamtspielzeit
- Keine alternativen Titel

### Station AI (`StationAi`)

- Job-Voraussetzungen: 10 h als Cyborg; 10 h Gesamtspielzeit
- Keine alternativen Titel

## Jobs ohne Charakter-Editor (CentComm, ERT, Events)

Diese Jobs werden nur über Ghost-Rollen, Events oder Admins vergeben. Keiner davon hat alternative Titel.

| Job | ID | Voraussetzungen |
| --- | --- | --- |
| Centcomm Direggtor | `CentralCommandDireggtor` | Alter ≥ 28<br>Spezies: Harpy |
| CentComm Intern | `CentCommIntern` | Alter ≥ 18 |
| CentComm Official | `CentralCommandOfficial` | Alter ≥ 21 |
| Centcomm Quarantine Officer | `CBURN` | – |
| Central Command Auditor | `Inspector` | Alter ≥ 21 |
| Conquest | `Conquest` | Alter ≥ 21 |
| Custodii Vitellus | `CustodiiVitellus` | – |
| Deathsquad Operative | `DeathSquad` | – |
| Diplomat | `Diplomat` | Alter ≥ 21 |
| ERT Chaplain | `ERTChaplain` | – |
| ERT Chaplain | `ERTChaplainBlue` | – |
| ERT Engineer | `ERTEngineer` | – |
| ERT Engineer | `ERTEngineerBlue` | – |
| ERT Janitor | `ERTJanitor` | – |
| ERT Janitor | `ERTJanitorBlue` | – |
| ERT Leader | `ERTLeader` | – |
| ERT Leader | `ERTLeaderBlue` | 5 h Gesamtspielzeit<br>15 h Security<br>30 h Command |
| ERT Medic | `ERTMedical` | – |
| ERT Medic | `ERTMedicBlue` | – |
| ERT Security | `ERTSecurity` | – |
| ERT Security | `ERTSecurityBlue` | – |
| HECU Operative | `HecuOperative` | – |
| High Commander | `SyndicateHighCommander` | Alter ≥ 21 |
| Mercenary Captain | `MercenaryCaptain` | Alter ≥ 21 |
| Navy Captain | `NavyCaptain` | Alter ≥ 21 |
| Navy Officer | `NavyOfficer` | – |
| Outer Commander | `OuterCommander` | Alter ≥ 21 |
| Overall | `Overall` | – |
| Special Operations Officer | `SpecialOperationsOfficer` | Alter ≥ 21 |
| Spectre Agent | `NanoTrasenSpectre` | 5 h Gesamtspielzeit<br>10 h Security<br>30 h Command |
| The G-Man | `GovernmentMan` | Alter ≥ 21 |
| Undercover Navy Officer | `NavyOfficerUndercover` | Alter ≥ 21 |

## Alphabetischer Index aller Alt-Titel

| Alt-Titel | Job | LocId |
| --- | --- | --- |
| Anomaly Researcher | Scientist | `job-name-alt-scientist-2` |
| Archivist | Librarian | `job-name-alt-librarian-5` |
| Attorney | Lawyer | `job-name-alt-lawyer-1` |
| Barista | Bartender | `job-name-alt-bartender-2` |
| Barkeeper | Bartender | `job-name-alt-bartender-4` |
| Barrister | Lawyer | `job-name-alt-lawyer-7` |
| Bartender Apprentice | Service Worker | `job-name-alt-serviceworker-3` |
| Biomechanical Engineer | Roboticist | `job-name-alt-roboticist-1` |
| Botanical Researcher | Botanist | `job-name-alt-botanist-5` |
| Bouffon | Clown | `job-name-alt-clown-2` |
| Bridge Clerk | Administrative Assistant | `job-name-alt-admin-assistant-2` |
| Brigmedic | Corpsman | `job-name-alt-brigmedic-3` |
| Broadcaster | Radio Host | `job-name-alt-radiohost-2` |
| Busker | Musician | `job-name-alt-musician-1` |
| Butcher | Chef | `job-name-alt-chef-4` |
| Caterer | Chef | `job-name-alt-chef-3` |
| Chief Constable | Head of Security | `job-name-alt-hos-2` |
| Chief of Security | Head of Security | `job-name-alt-hos-3` |
| Chief Physician | Chief Medical Officer | `job-name-alt-cmo-3` |
| Chief Science Officer | Research Director | `job-name-alt-rd-3` |
| Clerk | Librarian | `job-name-alt-librarian-1` |
| Combat Medic | Corpsman | `job-name-alt-brigmedic-1` |
| Comedian | Clown | `job-name-alt-clown-4` |
| Command Secretary | Administrative Assistant | `job-name-alt-admin-assistant-1` |
| Commanding Officer | Captain | `job-name-alt-captain-2` |
| Corporate Liaison | Nanotrasen Representative | `job-name-alt-ntr-1` |
| Counsel | Lawyer | `job-name-alt-lawyer-3` |
| Crew Supervisor | Head of Personnel | `job-name-alt-hop-2` |
| Croupier | Service Worker | `job-name-alt-serviceworker-4` |
| Culinary Artist | Chef | `job-name-alt-chef-5` |
| Curator | Librarian | `job-name-alt-librarian-4` |
| Custodial Technician | Janitor | `job-name-alt-janitor-3` |
| Cybertronic Technician | Roboticist | `job-name-alt-roboticist-3` |
| Deck Chief | Quartermaster | `job-name-alt-qm-2` |
| Deck Worker | Cargo Technician | `job-name-alt-cargotech-4` |
| Delivery Associate | Courier | `job-name-alt-courier-3` |
| Detainee | Transit Prisoner | `job-name-alt-transit-prisoner-1` |
| Dispatch Runner | Courier | `job-name-alt-courier-2` |
| Dispatcher | Warden | `job-name-alt-warden-1` |
| Documentarian | Reporter | `job-name-alt-reporter-2` |
| Drill Instructor | Sergeant | `job-name-alt-security-sergeant-2` |
| Drill Technician | Salvage Specialist | `job-name-alt-salvagespec-3` |
| Electrician | Station Engineer | `job-name-alt-engineer-3` |
| Emergency Damage Control Technician | Station Engineer | `job-name-alt-engineer-5` |
| Emergency Medical Technician | Paramedic | `job-name-alt-paramedic-2` |
| Employment Officer | Head of Personnel | `job-name-alt-hop-1` |
| Engine Operator | Station Engineer | `job-name-alt-engineer-4` |
| Engineering Supervisor | Chief Engineer | `job-name-alt-ce-2` |
| Epidemiologist | Virologist | `job-name-alt-virologist-1` |
| EVA Technician | Atmospheric Technician | `job-name-alt-atmostech-3` |
| Executive Aide | Administrative Assistant | `job-name-alt-admin-assistant-3` |
| Field Geologist | Salvage Specialist | `job-name-alt-salvagespec-2` |
| Field Medic | Corpsman | `job-name-alt-brigmedic-2` |
| Fire Suppression Specialist | Atmospheric Technician | `job-name-alt-atmostech-1` |
| Forensic Investigator | Detective | `job-name-alt-detective-1` |
| Gardener | Botanist | `job-name-alt-botanist-4` |
| General Practitioner | Medical Doctor | `job-name-alt-doctor-4` |
| Guidance Counselor | Psychologist | `job-name-alt-psychologist-2` |
| Hardware Technician | Scientist | `job-name-alt-scientist-3` |
| Head of Command | Captain | `job-name-alt-captain-4` |
| Head of Engineering | Chief Engineer | `job-name-alt-ce-1` |
| Head of Hospitality | Head of Personnel | `job-name-alt-hop-3` |
| Head of Medical | Chief Medical Officer | `job-name-alt-cmo-2` |
| Head of Science | Research Director | `job-name-alt-rd-4` |
| Head Physician | Chief Medical Officer | `job-name-alt-cmo-4` |
| Herbologist | Botanist | `job-name-alt-botanist-2` |
| Hydration Equipment Operator | Bartender | `job-name-alt-bartender-3` |
| Hydroponicist | Botanist | `job-name-alt-botanist-3` |
| Hydroponics Specialist | Botanist | `job-name-alt-botanist-1` |
| Immunologist | Virologist | `job-name-alt-virologist-3` |
| Influencer | Reporter | `job-name-alt-reporter-1` |
| Inmate | Transit Prisoner | `job-name-alt-transit-prisoner-2` |
| Inspector | Detective | `job-name-alt-detective-2` |
| Inventory Associate | Cargo Technician | `job-name-alt-cargotech-5` |
| Jester | Clown | `job-name-alt-clown-1` |
| Joker | Clown | `job-name-alt-clown-3` |
| Journalist | Reporter | `job-name-alt-reporter-4` |
| Junior Cook | Service Worker | `job-name-alt-serviceworker-2` |
| Lab Technician | Chemist | `job-name-alt-chemist-2` |
| Lab Technician | Scientist | `job-name-alt-scientist-4` |
| Lead Investigator | Detective | `job-name-alt-detective-3` |
| Lead Researcher | Research Director | `job-name-alt-rd-1` |
| Legal Clerk | Lawyer | `job-name-alt-lawyer-5` |
| Legal Representative | Lawyer | `job-name-alt-lawyer-2` |
| Life Support Technician | Atmospheric Technician | `job-name-alt-atmostech-2` |
| Line Cook | Chef | `job-name-alt-chef-2` |
| Logistics Clerk | Cargo Technician | `job-name-alt-cargotech-2` |
| Logistics Coordinator | Quartermaster | `job-name-alt-qm-4` |
| Maestro | Musician | `job-name-alt-musician-3` |
| Magister | Chaplain | `job-name-alt-chaplain-8` |
| Maid | Janitor | `job-name-alt-janitor-1` |
| Mail Carrier | Courier | `job-name-alt-courier-1` |
| Maintenance Technician | Station Engineer | `job-name-alt-engineer-1` |
| Maintenance Worker | Janitor | `job-name-alt-janitor-2` |
| Mechanic | Station Engineer | `job-name-alt-engineer-2` |
| Mechatronic Specialist | Roboticist | `job-name-alt-roboticist-2` |
| Media Coordinator | Reporter | `job-name-alt-reporter-3` |
| Medical Director | Chief Medical Officer | `job-name-alt-cmo-1` |
| Medical Resident | Medical Doctor | `job-name-alt-doctor-5` |
| Mining Specialist | Salvage Specialist | `job-name-alt-salvagespec-1` |
| Mixologist | Bartender | `job-name-alt-bartender-1` |
| Monk | Chaplain | `job-name-alt-chaplain-9` |
| Nanotrasen Advisor | Nanotrasen Representative | `job-name-alt-ntr-3` |
| Nanotrasen Compliance Executive | Nanotrasen Representative | `job-name-alt-ntr-2` |
| Nurse | Medical Doctor | `job-name-alt-doctor-2` |
| Nurse Practitioner | Medical Doctor | `job-name-alt-doctor-6` |
| Oracle | Chaplain | `job-name-alt-chaplain-6` |
| Pantomimist | Mime | `job-name-alt-mime-1` |
| Pathologist | Virologist | `job-name-alt-virologist-2` |
| Patrol Leader | Sergeant | `job-name-alt-security-sergeant-1` |
| Performer | Musician | `job-name-alt-musician-2` |
| Pharmacist | Chemist | `job-name-alt-chemist-1` |
| Pharmacologist | Chemist | `job-name-alt-chemist-3` |
| Physician | Medical Doctor | `job-name-alt-doctor-1` |
| Pontifex | Chaplain | `job-name-alt-chaplain-7` |
| Preacher | Chaplain | `job-name-alt-chaplain-1` |
| Priest | Chaplain | `job-name-alt-chaplain-5` |
| Professor | Librarian | `job-name-alt-librarian-3` |
| Prosecutor | Lawyer | `job-name-alt-lawyer-4` |
| Psychiatrist | Psychologist | `job-name-alt-psychologist-3` |
| Public Defender | Lawyer | `job-name-alt-lawyer-6` |
| Radio DJ | Radio Host | `job-name-alt-radiohost-1` |
| Requisitions Officer | Quartermaster | `job-name-alt-qm-1` |
| Research Supervisor | Research Director | `job-name-alt-rd-2` |
| Reverend | Chaplain | `job-name-alt-chaplain-4` |
| Sanitation Specialist | Janitor | `job-name-alt-janitor-4` |
| Search & Rescue Technician | Paramedic | `job-name-alt-paramedic-3` |
| Security Commander | Head of Security | `job-name-alt-hos-1` |
| Shipbreaking Specialist | Salvage Specialist | `job-name-alt-salvagespec-4` |
| Shrine Guardian | Chaplain | `job-name-alt-chaplain-3` |
| Shuttle Pilot | Cargo Technician | `job-name-alt-cargotech-1` |
| Site Administrator | Captain | `job-name-alt-captain-6` |
| Site Director | Captain | `job-name-alt-captain-5` |
| Site Manager | Captain | `job-name-alt-captain-3` |
| Sous-chef | Chef | `job-name-alt-chef-1` |
| Spiritual Advisor | Chaplain | `job-name-alt-chaplain-2` |
| Station Commander | Captain | `job-name-alt-captain-1` |
| Steward | Service Worker | `job-name-alt-serviceworker-5` |
| Surgeon | Medical Doctor | `job-name-alt-doctor-3` |
| Surveillance Operator | Warden | `job-name-alt-warden-2` |
| Systems Administrator | Research Director | `job-name-alt-rd-5` |
| Talk Show Host | Radio Host | `job-name-alt-radiohost-3` |
| Theoretical Physicist | Scientist | `job-name-alt-scientist-5` |
| Therapist | Psychologist | `job-name-alt-psychologist-1` |
| Trauma Specialist | Paramedic | `job-name-alt-paramedic-1` |
| Waiter | Service Worker | `job-name-alt-serviceworker-1` |
| Warehouse Supervisor | Quartermaster | `job-name-alt-qm-3` |
| Warehouse Technician | Cargo Technician | `job-name-alt-cargotech-3` |
| Writer | Librarian | `job-name-alt-librarian-2` |
| Xenoarchaeologist | Scientist | `job-name-alt-scientist-1` |

## Auffälligkeiten

- **Doppelter Titel:** „Lab Technician“ gibt es bei Chemist (`job-name-alt-chemist-2`) und Scientist (`job-name-alt-scientist-4`). Sperren werden pro Job eingetragen, die beiden sind also unabhängig.
- **Brigmedic:** Der Job `Brigmedic` heißt im Spiel „Corpsman“, „Brigmedic“ ist dort ein Alt-Titel (`job-name-alt-brigmedic-3`).
- **Mime** hat nur einen Alt-Titel (Pantomimist), **Chaplain** mit 9 die meisten.
- **Wählbare Jobs ohne Alt-Titel:** Assistant, Blueshield Officer, Cyborg, Medical Intern, Nanotrasen Career Trainer, Research Assistant, Security Cadet, Security Officer, Shaft Miner, Station AI, Technical Assistant.
- **Alt-Titel bei Jobs ohne eigene Voraussetzungen:** Botanist, Cargo Technician, Clown, Janitor, Librarian, Musician, Psychologist, Radio Host, Reporter. Hier greift ein Timelock sofort ab der ersten Runde, z.B. `RoleTimeRequirement` auf den Job selbst.
- **Kandidaten für Timelocks** (Titel, die nach mehr Verantwortung klingen als der Job): Deck Chief, Warehouse Supervisor, Logistics Coordinator (QM); Lead Investigator (Detective); Patrol Leader, Drill Instructor (Sergeant); Surgeon, Medical Resident (Doctor); Chief Physician, Head Physician (CMO); Research Supervisor, Chief Science Officer (RD); Engineering Supervisor (CE); Crew Supervisor (HoP); Prosecutor, Public Defender (Lawyer); Pontifex (Chaplain); Maestro (Musician); Sous-chef (Chef). Nur Vorschlag, nichts davon ist eingetragen.
- `SpecialOperationsOfficer` hat keinen en-US-Locale-Eintrag für den Namen (`job-name-special-operations-officer`), der Name oben ist aus der ID abgeleitet.
