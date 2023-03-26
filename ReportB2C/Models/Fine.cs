using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Fine
{
    public int Id { get; set; }

    public string? Nr { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Ammount { get; set; }

    public decimal? Interst { get; set; }

    public int? CaseId { get; set; }

    public int? State { get; set; }

    public decimal? Koszty { get; set; }

    public decimal? LesAmount { get; set; }

    public decimal? LesInterst { get; set; }

    public decimal? LesKoszty { get; set; }

    public int? InKrd { get; set; }

    public virtual Case? Case { get; set; }

    public virtual ICollection<DynamicalCaseParametr> DynamicalCaseParametrs { get; } = new List<DynamicalCaseParametr>();

    public virtual ICollection<PaymentsForFine> PaymentsForFines { get; } = new List<PaymentsForFine>();
}
