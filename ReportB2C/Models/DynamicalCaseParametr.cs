using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class DynamicalCaseParametr
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public int? CaseId { get; set; }

    public int? FineId { get; set; }

    public virtual Case? Case { get; set; }

    public virtual Fine? Fine { get; set; }
}
