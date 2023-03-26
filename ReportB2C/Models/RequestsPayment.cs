using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class RequestsPayment
{
    public int Id { get; set; }

    public string? Signature { get; set; }

    public int? Nr { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public string? Title { get; set; }

    public DateTime? Date { get; set; }

    public string? BankAcountNr { get; set; }

    public virtual ICollection<RequestsCase> RequestsCases { get; } = new List<RequestsCase>();
}
