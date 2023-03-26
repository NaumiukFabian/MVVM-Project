using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class DictCaseState
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Color { get; set; }

    public virtual ICollection<Case> Cases { get; } = new List<Case>();
}
