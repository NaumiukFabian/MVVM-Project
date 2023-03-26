using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class TmpMojeSprawy
{
    public int Id { get; set; }

    public string? SygnaturaWgPowoda { get; set; }

    public string? SygnaturaSprawy { get; set; }

    public string? StronyWsprawie { get; set; }

    public string? StanSprawy { get; set; }

    public string? RolaWsprawie { get; set; }

    public decimal? KwotaSporu { get; set; }

    public DateTime? DataPrawomocnosci { get; set; }

    public DateTime? DataWplywu { get; set; }

    public DateTime? DataZakreslenia { get; set; }
}
