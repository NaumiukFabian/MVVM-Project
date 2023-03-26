using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Fine1
{
    public int MandatId { get; set; }

    public decimal? MandatAmmount { get; set; }

    public decimal? MandatOdsetki { get; set; }

    public decimal? MandatKoszty { get; set; }

    public string? CaseSignature { get; set; }

    public decimal? CaseAmmount { get; set; }

    public string? Zip { get; set; }

    public string? Sha1 { get; set; }

    public string? Name { get; set; }

    public decimal? PaymAmmount { get; set; }

    public decimal? PaymOdsetki { get; set; }

    public decimal? PaymKoszty { get; set; }
}
