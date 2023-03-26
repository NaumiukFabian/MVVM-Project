using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class KrdOld
{
    public int Id { get; set; }

    public int? CaseId { get; set; }

    public int? State { get; set; }

    public DateTime? DateAdd { get; set; }

    public DateTime? DateDel { get; set; }

    public int? KrdId { get; set; }

    public string? KrdGuid { get; set; }

    public string? Description { get; set; }

    public DateTime? SendDocumentDate { get; set; }

    public virtual Case? Case { get; set; }
}
