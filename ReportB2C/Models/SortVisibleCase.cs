using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class SortVisibleCase
{
    public int Id { get; set; }

    public int? BagsTypeId { get; set; }

    public string? ColumnName { get; set; }

    public int? ContractFilesId { get; set; }

    public int? SortNumber { get; set; }

    public virtual BagsType? BagsType { get; set; }

    public virtual ContratsFile? ContractFiles { get; set; }
}
