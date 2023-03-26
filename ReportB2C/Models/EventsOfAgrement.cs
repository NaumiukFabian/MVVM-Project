using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class EventsOfAgrement
{
    public int Id { get; set; }

    public int? EventId { get; set; }

    public int? AgrrementId { get; set; }

    public virtual Agreement? Agrrement { get; set; }

    public virtual Event? Event { get; set; }
}
