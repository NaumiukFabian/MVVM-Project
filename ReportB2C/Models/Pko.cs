using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Pko
{
    public int? IdAkt { get; set; }

    public DateTime? PrzekazanaOd { get; set; }

    public int? IdPodmiotu { get; set; }

    public int? CaseId { get; set; }

    public virtual Case? Case { get; set; }
}
