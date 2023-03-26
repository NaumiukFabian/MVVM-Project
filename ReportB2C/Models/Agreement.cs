using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Agreement
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Ammount { get; set; }

    public int? CaseId { get; set; }

    public virtual Case? Case { get; set; }

    public virtual ICollection<EventsOfAgrement> EventsOfAgrements { get; } = new List<EventsOfAgrement>();
}
