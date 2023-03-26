using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public int? Role { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsSystem { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Desription { get; set; }

    public DateTime? PasswordDate { get; set; }

    public string? EmailAddress { get; set; }

    public string? EmmailPassword { get; set; }

    public int? EmailTemplateId { get; set; }

    public int? InDashboard { get; set; }

    public virtual ICollection<AssetEvent> AssetEventUser1s { get; } = new List<AssetEvent>();

    public virtual ICollection<AssetEvent> AssetEventUser2s { get; } = new List<AssetEvent>();

    public virtual ICollection<Case> CaseLeadingUsers { get; } = new List<Case>();

    public virtual ICollection<Case> CaseUsers { get; } = new List<Case>();

    public virtual ICollection<Email> Emails { get; } = new List<Email>();

    public virtual ICollection<SystemLog> SystemLogs { get; } = new List<SystemLog>();

    public virtual UserConfiguration? UserConfiguration { get; set; }
}
