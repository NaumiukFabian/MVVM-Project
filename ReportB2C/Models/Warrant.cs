using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Warrant
{
    public int Id { get; set; }

    public int? EpuId { get; set; }

    public string? Number { get; set; }

    public DateTime? RulingDate { get; set; }

    public DateTime? LegitymacyDate { get; set; }

    public DateTime? ClauseDate { get; set; }

    public int? DecisionCode { get; set; }

    public string? WarrantSignature { get; set; }

    public decimal? Kos { get; set; }

    public decimal? Kzp { get; set; }

    public int? InterestFreeDays { get; set; }

    public int? CaseId { get; set; }

    public virtual Case? Case { get; set; }
}
