using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Company
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Nip { get; set; }

    public virtual ICollection<Contract> Contracts { get; } = new List<Contract>();
}
