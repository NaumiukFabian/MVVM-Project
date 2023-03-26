using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Signature
{
    public string? Signature1 { get; set; }

    public string? FineIds { get; set; }

    public decimal? RequestAmmount { get; set; }

    public string? CaseSignature { get; set; }

    public decimal? CaseAmmount { get; set; }

    public string? Mandaty { get; set; }

    public string? Zip { get; set; }

    public int? Stateid { get; set; }

    public string? Sha { get; set; }

    public DateTime? DataPodpUmowy { get; set; }

    public string? Name { get; set; }

    public decimal? PaymAmmount { get; set; }

    public DateTime? PaymDate { get; set; }
}
