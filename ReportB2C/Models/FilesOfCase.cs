using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class FilesOfCase
{
    public int Id { get; set; }

    public int? FileId { get; set; }

    public int? CaseId { get; set; }

    public virtual Case? Case { get; set; }

    public virtual File? File { get; set; }
}
