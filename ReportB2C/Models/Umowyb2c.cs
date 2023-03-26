using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Umowyb2c
{
    public string? Nazwa { get; set; }

    public string? DataZawarciaUmowy { get; set; }

    public string? DataKońcaUmowy { get; set; }

    public string? MaksymalnaZapłata { get; set; }

    public string? Prowizja { get; set; }

    public string? IlośćDniOdDatyPrzedawnienia { get; set; }

    public string? ProwizjaPoPrzedawnieniu { get; set; }

    public string? IiiProwizja { get; set; }

    public string? WindykacjaZaOdsetkiBrutto { get; set; }

    public string? WindykacjaZaOdsetkiNetto { get; set; }

    public string? KosztZakupu { get; set; }
}
