using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class InvoiceItem
{
    public int Id { get; set; }

    public int? InoiceId { get; set; }

    public int? Nr { get; set; }

    public string? Title { get; set; }

    public decimal? Ammount { get; set; }

    public int? TaxRate { get; set; }

    public int? Count { get; set; }

    public decimal? Tax { get; set; }

    public decimal? FullAmount { get; set; }

    public virtual Invoice? Inoice { get; set; }
}
