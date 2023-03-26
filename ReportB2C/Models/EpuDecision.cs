using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class EpuDecision
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Text { get; set; }

    public DateTime? DateReturned { get; set; }

    public int? EvantId { get; set; }

    public int? EpuCaseId { get; set; }

    public virtual EpuCase? EpuCase { get; set; }

    public virtual Event? Evant { get; set; }
}
