using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Odsetki
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Value { get; set; }
}
