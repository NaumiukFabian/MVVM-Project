using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class FileType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? IconName { get; set; }

    public bool? IsEncrypted { get; set; }

    public virtual ICollection<File> Files { get; } = new List<File>();
}
