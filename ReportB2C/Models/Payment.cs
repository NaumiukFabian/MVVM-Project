using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Payment
{
    public int Id { get; set; }

    public decimal? Amount { get; set; }

    public string? AccountIn { get; set; }

    public string? AccountOut { get; set; }

    public string? Sender { get; set; }

    public string? Recipient { get; set; }

    public string? Title { get; set; }

    public int? EventId { get; set; }

    public DateTime? Date { get; set; }

    public bool? IsPlaned { get; set; }

    public virtual Event? Event { get; set; }

    public virtual ICollection<PaymentsForFine> PaymentsForFines { get; } = new List<PaymentsForFine>();
}
