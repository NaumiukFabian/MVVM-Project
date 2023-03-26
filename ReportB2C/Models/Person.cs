using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Person
{
    public int Id { get; set; }

    public string? Sha1 { get; set; }

    public bool? IsReturned { get; set; }

    public int? PastPersonId { get; set; }

    public int? Type { get; set; }

    public DateTime? NextDate { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Case> Cases { get; } = new List<Case>();

    public virtual ContactsDetail? ContactsDetail { get; set; }

    public virtual ContatsOfClient? ContatsOfClient { get; set; }

    public virtual ICollection<Email> Emails { get; } = new List<Email>();

    public virtual ICollection<EmailsAddress> EmailsAddresses { get; } = new List<EmailsAddress>();

    public virtual ICollection<Person> InversePastPerson { get; } = new List<Person>();

    public virtual Person? PastPerson { get; set; }

    public virtual ICollection<PhoneNumber> PhoneNumbers { get; } = new List<PhoneNumber>();
}
