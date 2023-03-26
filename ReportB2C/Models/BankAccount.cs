using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class BankAccount
{
    public int Id { get; set; }

    public string? Nr { get; set; }

    public string? Iban { get; set; }

    public string? Swift { get; set; }

    public int? ClientId { get; set; }

    public virtual ICollection<Case> Cases { get; } = new List<Case>();

    public virtual Client? Client { get; set; }
}
