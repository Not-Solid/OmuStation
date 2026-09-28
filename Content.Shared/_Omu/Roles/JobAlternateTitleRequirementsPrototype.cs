// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.Shared._Omu.Roles;

/// <summary>
/// Locks alternate titles of a job behind requirements, the same way jobs are locked behind their requirements.
/// The prototype ID has to match the ID of the <see cref="JobPrototype"/> whose titles it locks.
/// </summary>
[Prototype]
public sealed partial class JobAlternateTitleRequirementsPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    /// Requirements for each alternate title, keyed by the title's LocId from the job's alternate title dataset.
    /// Titles that are not listed here have no requirements.
    /// </summary>
    [DataField(required: true)]
    public Dictionary<string, HashSet<JobRequirement>> Titles = new();
}
