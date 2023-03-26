using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Event
{
    public int Id { get; set; }

    public string? Header { get; set; }

    public string? Text { get; set; }

    public DateTime? Time { get; set; }

    public int? Direction { get; set; }

    public bool? Planed { get; set; }

    public int? UserId { get; set; }

    public int? PersonId { get; set; }

    public int? CaseId { get; set; }

    public int? TypeId { get; set; }

    public int? ClientId { get; set; }

    public int? LastAsset { get; set; }

    public virtual ICollection<AssetEvent> AssetEvents { get; } = new List<AssetEvent>();

    public virtual Case? Case { get; set; }

    public virtual ICollection<Case> Cases { get; } = new List<Case>();

    public virtual Client? Client { get; set; }

    public virtual ICollection<Client> Clients { get; } = new List<Client>();

    public virtual ICollection<Email> Emails { get; } = new List<Email>();

    public virtual EpuDecision? EpuDecision { get; set; }

    public virtual ICollection<EventsForInvoice> EventsForInvoices { get; } = new List<EventsForInvoice>();

    public virtual ICollection<EventsOfAgrement> EventsOfAgrements { get; } = new List<EventsOfAgrement>();

    public virtual ICollection<FilesOfEent> FilesOfEents { get; } = new List<FilesOfEent>();

    public virtual AssetEvent? LastAssetNavigation { get; set; }

    public virtual Payment? Payment { get; set; }

    public virtual RequestsCase? RequestsCase { get; set; }

    public virtual Sm? Sm { get; set; }
}
