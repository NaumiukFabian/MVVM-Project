using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Email
{
    public int Id { get; set; }

    public string? EmailFrom { get; set; }

    public string? EmailTo { get; set; }

    public string? EmailContent { get; set; }

    public DateTime? SendDate { get; set; }

    public DateTime? ReciveDate { get; set; }

    public int? EventId { get; set; }

    public string? Title { get; set; }

    public int? UserId { get; set; }

    public bool? IsReaded { get; set; }

    public int? PersonId { get; set; }

    public int? EmailId { get; set; }

    public int? Status { get; set; }

    public int? Uid { get; set; }

    public virtual Event? Event { get; set; }

    public virtual ICollection<FilesOfEmail> FilesOfEmails { get; } = new List<FilesOfEmail>();

    public virtual Person? Person { get; set; }

    public virtual User? User { get; set; }
}
