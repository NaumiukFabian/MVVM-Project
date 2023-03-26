using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class DictEventType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Color { get; set; }

    public string? IconName { get; set; }

    public bool? IsSystemEvent { get; set; }
}
