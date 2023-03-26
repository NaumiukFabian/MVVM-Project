using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class RequestsCase
{
    public int Id { get; set; }

    public decimal? AmmountOfTheFullCost { get; set; }

    public decimal? Interst { get; set; }

    public decimal? Kpp { get; set; }

    public decimal? Kos { get; set; }

    public decimal? Kps { get; set; }

    public decimal? Kzp { get; set; }

    public decimal? Kek { get; set; }

    public decimal? Kpe { get; set; }

    public int? RequestPaymentsId { get; set; }

    public int? EventId { get; set; }

    public int? CaseId { get; set; }

    public decimal? AmountOnRequest { get; set; }

    public virtual Case? Case { get; set; }

    public virtual Event? Event { get; set; }

    public virtual RequestsPayment? RequestPayments { get; set; }
}
