using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Contract
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? ClientId { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? TerminationDate { get; set; }

    public int? InterstShift { get; set; }

    public int? Type { get; set; }

    public string? Name { get; set; }

    public decimal? MaxPayments { get; set; }

    public decimal? Percentage { get; set; }

    public string? Description { get; set; }

    public string? BankAcount { get; set; }

    public decimal? TerminationPercange { get; set; }

    public int? TerminationDay { get; set; }

    public decimal? Koszt { get; set; }

    public decimal? Percentage3 { get; set; }

    public string? WindykacjOdsetki { get; set; }

    public string? NazwaKontaDoWplaty { get; set; }

    public decimal? KwotaZakupu { get; set; }

    public string? NazwaKodowa { get; set; }

    public decimal? NaleznoscGlowna { get; set; }

    public string? ThumabailId { get; set; }

    public string? PostAuthor { get; set; }

    public string? CarierName { get; set; }

    public int? RaportTemplateId { get; set; }

    public string? Aprefix { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<ContratsFile> ContratsFiles { get; } = new List<ContratsFile>();

    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();
}
