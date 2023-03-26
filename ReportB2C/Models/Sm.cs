using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Sm
{
    public int Id { get; set; }

    public string? Number { get; set; }

    public string? Contents { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DateSended { get; set; }

    public int? Status { get; set; }

    public string? StatusDesc { get; set; }

    public int? EventId { get; set; }

    public virtual Event? Event { get; set; }
}
