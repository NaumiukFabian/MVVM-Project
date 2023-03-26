using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Case
{
    public int Id { get; set; }

    public string? Signatures { get; set; }

    public decimal? BaseAmount { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TimeToDo { get; set; }

    public string? MandateNumber { get; set; }

    public int? PersonId { get; set; }

    public int? StateId { get; set; }

    public int? ContractFilesId { get; set; }

    public int? CommitmentStateId { get; set; }

    public DateTime? Date { get; set; }

    public int? BankAccountId { get; set; }

    public int? UserId { get; set; }

    public decimal? Payments { get; set; }

    public int? LeadingUserId { get; set; }

    public int? ToDoEventsId { get; set; }

    public virtual ICollection<Agreement> Agreements { get; } = new List<Agreement>();

    public virtual BankAccount? BankAccount { get; set; }

    public virtual ICollection<CasesInBag> CasesInBags { get; } = new List<CasesInBag>();

    public virtual ICollection<CasesOfListOfCase> CasesOfListOfCases { get; } = new List<CasesOfListOfCase>();

    public virtual DictStateOfCommitment? CommitmentState { get; set; }

    public virtual ContratsFile? ContractFiles { get; set; }

    public virtual ICollection<DynamicalCaseParametr> DynamicalCaseParametrs { get; } = new List<DynamicalCaseParametr>();

    public virtual EnforcementBailiff? EnforcementBailiff { get; set; }

    public virtual EpuCase? EpuCase { get; set; }

    public virtual ICollection<Event> Events { get; } = new List<Event>();

    public virtual ICollection<FilesOfCase> FilesOfCases { get; } = new List<FilesOfCase>();

    public virtual ICollection<Fine> Fines { get; } = new List<Fine>();

    public virtual ICollection<Gapowicze> Gapowiczes { get; } = new List<Gapowicze>();

    public virtual ICollection<KrdOld> KrdOlds { get; } = new List<KrdOld>();

    public virtual ICollection<Krd> Krds { get; } = new List<Krd>();

    public virtual User? LeadingUser { get; set; }

    public virtual Person? Person { get; set; }

    public virtual ICollection<Postanowienium> Postanowienia { get; } = new List<Postanowienium>();

    public virtual ICollection<RequestsCase> RequestsCases { get; } = new List<RequestsCase>();

    public virtual DictCaseState? State { get; set; }

    public virtual Event? ToDoEvents { get; set; }

    public virtual User? User { get; set; }

    public virtual Warrant? Warrant { get; set; }
}
