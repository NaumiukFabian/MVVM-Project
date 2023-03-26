using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class PaymentsForFine
{
    public int Id { get; set; }

    public int? FineId { get; set; }

    public int? PaymentsId { get; set; }

    public decimal? Ammount { get; set; }

    public decimal? Interest { get; set; }

    public decimal? Koszty { get; set; }

    public virtual Fine? Fine { get; set; }

    public virtual Payment? Payments { get; set; }
}
