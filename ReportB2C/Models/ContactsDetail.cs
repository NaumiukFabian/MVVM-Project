using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class ContactsDetail
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? PersonId { get; set; }

    public string? Note { get; set; }

    public string? Nip { get; set; }

    public string? Pesel { get; set; }

    public string? SecoundName { get; set; }

    public virtual Person? Person { get; set; }
}
