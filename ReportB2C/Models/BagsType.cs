using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class BagsType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? IsSystem { get; set; }

    public string? IconName { get; set; }

    public bool? IsVisible { get; set; }

    public virtual ICollection<CasesInBag> CasesInBags { get; } = new List<CasesInBag>();

    public virtual ICollection<CustomBagsNote> CustomBagsNotes { get; } = new List<CustomBagsNote>();

    public virtual SortVisibleCase? SortVisibleCase { get; set; }
}
