using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class ScopeConfigDss
{
    public Guid ConfigId { get; set; }

    public string ConfigData { get; set; } = null!;

    public string? ScopeStatus { get; set; }
}
