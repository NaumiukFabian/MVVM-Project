using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class File
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }

    public int? FileTypeId { get; set; }

    public string? Description { get; set; }

    public virtual FileType? FileType { get; set; }

    public virtual ICollection<FilesOfCase> FilesOfCases { get; } = new List<FilesOfCase>();

    public virtual ICollection<FilesOfClient> FilesOfClients { get; } = new List<FilesOfClient>();

    public virtual ICollection<FilesOfEent> FilesOfEents { get; } = new List<FilesOfEent>();

    public virtual ICollection<FilesOfEmail> FilesOfEmails { get; } = new List<FilesOfEmail>();
}
