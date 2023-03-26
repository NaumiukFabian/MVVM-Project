using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class ContratsFile
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DateReturned { get; set; }

    public int? ContractId { get; set; }

    public int? CommisionType { get; set; }

    public decimal? CommisionValue { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Case> Cases { get; } = new List<Case>();

    public virtual Contract? Contract { get; set; }

    public virtual SortVisibleCase? SortVisibleCase { get; set; }
}
