using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class PowerbiV1WplatyNaZlecenie
{
    public int Id { get; set; }

    public decimal? KwotaWpłaty { get; set; }

    public DateTime? DataWplaty { get; set; }

    public int? IloscDniDoPrzedawnienia { get; set; }

    public DateTime? DataWystawienia { get; set; }

    public decimal? ProwizjaDlaNieprzedawnionych { get; set; }

    public decimal? ProwizjaDlaPrzedawnionych { get; set; }

    public string? NazwaPakietu { get; set; }

    public string? IdKlienta { get; set; }
}
