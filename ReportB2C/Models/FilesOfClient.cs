using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class FilesOfClient
{
    public int Id { get; set; }

    public int? FilesId { get; set; }

    public int? ClientId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual File? Files { get; set; }
}
