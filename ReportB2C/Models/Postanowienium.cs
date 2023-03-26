using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Postanowienium
{
    public int Id { get; set; }

    public int? EpuId { get; set; }

    public string? Signature { get; set; }

    public string? SiganturePow { get; set; }

    public string? Status { get; set; }

    public DateTime? DataOrzeczenia { get; set; }

    public string? NazwaDecyzji { get; set; }

    public string? Dokument { get; set; }

    public string? DataWplywu { get; set; }

    public string? Sad { get; set; }

    public string? Sedzia { get; set; }

    public string? Powod { get; set; }

    public string? Pozwany { get; set; }

    public string? Tresc { get; set; }

    public int? StatPostanowienia { get; set; }

    public int? CaseId { get; set; }

    public DateTime? ToDoDate { get; set; }

    public string? ToDoComment { get; set; }

    public virtual Case? Case { get; set; }
}
