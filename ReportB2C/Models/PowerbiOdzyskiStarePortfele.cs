using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class PowerbiOdzyskiStarePortfele
{
    public decimal? Kwota { get; set; }

    public DateTime? DataWplaty { get; set; }

    public string? NazwaPakietu { get; set; }

    public string NumerSprawyWCrm { get; set; } = null!;
}
