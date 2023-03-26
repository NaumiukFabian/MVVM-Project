using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class City
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
