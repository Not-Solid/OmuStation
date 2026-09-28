// SPDX-License-Identifier: AGPL-3.0-or-later

using System.Collections.Generic;
using Content.Shared._Omu.Roles;
using Content.Shared.CCVar;
using Content.Shared.Preferences;
using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.IntegrationTests.Tests._Omu.Roles;

[TestFixture]
public sealed class JobAlternateTitleRequirementsTest
{
    private const string Job = "TitleRequirementTester";
    private const string Tracker = "PlayTimeTitleRequirementTester";
    private const string UnlockedTitle = "job-name-alt-qm-1";
    private const string LockedTitle = "job-name-alt-qm-2";

    // The dataset reuses existing titles so the localized dataset test stays happy.
    [TestPrototypes]
    private const string Prototypes = $@"
- type: playTimeTracker
  id: {Tracker}

- type: job
  id: {Job}
  playTimeTracker: {Tracker}

- type: localizedDataset
  id: AlternateTitles{Job}
  values:
    prefix: job-name-alt-qm-
    count: 4

- type: jobAlternateTitleRequirements
  id: {Job}
  titles:
    {LockedTitle}:
    - !type:RoleTimeRequirement
      role: {Tracker}
      time: 3600
";

    /// <summary>
    /// Makes sure every title requirement points at a job and a title that actually exist.
    /// </summary>
    [Test]
    public async Task RequirementsMatchTitlesTest()
    {
        await using var pair = await PoolManager.GetServerClient();
        var server = pair.Server;

        var protoMan = server.ResolveDependency<IPrototypeManager>();
        var alternateTitles = server.System<JobAlternateTitleSystem>();

        Assert.Multiple(() =>
        {
            foreach (var proto in protoMan.EnumeratePrototypes<JobAlternateTitleRequirementsPrototype>())
            {
                Assert.That(protoMan.HasIndex<JobPrototype>(proto.ID), $"Alternate title requirements {proto.ID} don't match any job!");

                Assert.That(alternateTitles.TryGetTitles(proto.ID, out var titles), $"Alternate title requirements {proto.ID} are for a job without alternate titles!");
                if (titles == null)
                    continue;

                foreach (var title in proto.Titles.Keys)
                {
                    Assert.That(titles, Does.Contain(title), $"Alternate title requirements {proto.ID} lock {title}, which is not one of the job's alternate titles!");
                }
            }
        });

        await pair.CleanReturnAsync();
    }

    [Test]
    public async Task TitleRequirementsTest()
    {
        await using var pair = await PoolManager.GetServerClient(new PoolSettings { Connected = true });
        var server = pair.Server;

        var alternateTitles = server.System<JobAlternateTitleSystem>();
        var noPlayTime = new Dictionary<string, TimeSpan>();
        var enoughPlayTime = new Dictionary<string, TimeSpan> { [Tracker] = TimeSpan.FromHours(2) };
        var profile = new HumanoidCharacterProfile()
            .WithJobAlternateTitle(Job, LockedTitle)
            .WithJobAlternateTitle("Quartermaster", UnlockedTitle);

        // Role timers are disabled for tests, which skips title requirements just like job requirements.
        await server.WaitAssertion(() =>
        {
            Assert.That(alternateTitles.IsTitleAllowed(null, Job, LockedTitle, noPlayTime, out _));

            var validated = (HumanoidCharacterProfile) profile.Validated(pair.Player!, server.InstanceDependencyCollection);
            Assert.That(validated.JobAlternateTitles[Job], Is.EqualTo(LockedTitle));
        });

        server.CfgMan.SetCVar(CCVars.GameRoleTimers, true);

        await server.WaitAssertion(() =>
        {
            Assert.Multiple(() =>
            {
                Assert.That(alternateTitles.IsTitleAllowed(null, Job, UnlockedTitle, noPlayTime, out _));
                Assert.That(alternateTitles.IsTitleAllowed(null, Job, LockedTitle, noPlayTime, out var reason), Is.False);
                Assert.That(reason, Is.Not.Null);
                Assert.That(alternateTitles.IsTitleAllowed(null, Job, LockedTitle, enoughPlayTime, out _));
            });

            // Saving or loading a profile drops titles the player hasn't unlocked yet.
            var validated = (HumanoidCharacterProfile) profile.Validated(pair.Player!, server.InstanceDependencyCollection);
            Assert.That(validated.JobAlternateTitles.ContainsKey(Job), Is.False);
            Assert.That(validated.JobAlternateTitles["Quartermaster"], Is.EqualTo(UnlockedTitle));
        });

        server.CfgMan.SetCVar(CCVars.GameRoleTimers, false);
        await pair.CleanReturnAsync();
    }
}
