using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class AssetEvent
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public int? User1Id { get; set; }

    public int? User2Id { get; set; }

    public int? EventsId { get; set; }

    public DateTime? AssetDate { get; set; }

    public DateTime? Date { get; set; }

    public string? Desription { get; set; }

    public virtual Event? Events { get; set; }

    public virtual ICollection<Event> EventsNavigation { get; } = new List<Event>();

    public virtual User? User1 { get; set; }

    public virtual User? User2 { get; set; }
}
