using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class EpuCase
{
    public int Id { get; set; }

    public int? CaseId { get; set; }

    public int? EsadId { get; set; }

    public int? EpuState { get; set; }

    public virtual Case? Case { get; set; }

    public virtual ICollection<EpuDecision> EpuDecisions { get; } = new List<EpuDecision>();
}
