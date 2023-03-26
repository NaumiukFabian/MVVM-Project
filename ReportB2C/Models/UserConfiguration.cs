using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class UserConfiguration
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Config { get; set; }

    public virtual User? User { get; set; }
}
