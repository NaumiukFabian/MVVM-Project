using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Eventsbac
{
    public int Id { get; set; }

    public string? Header { get; set; }

    public string? Text { get; set; }

    public DateTime? Time { get; set; }

    public int? Direction { get; set; }

    public bool? Planed { get; set; }

    public int? UserId { get; set; }

    public int? PersonId { get; set; }

    public int? CaseId { get; set; }

    public int? TypeId { get; set; }

    public int? ClientId { get; set; }

    public int? LastAsset { get; set; }
}
