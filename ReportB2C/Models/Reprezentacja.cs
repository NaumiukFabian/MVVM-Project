using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Reprezentacja
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? SecoundName { get; set; }

    public string? Pesel { get; set; }

    public string? Nip { get; set; }

    public string? Street { get; set; }

    public string? Number { get; set; }

    public string? LocalNumber { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? ZipName { get; set; }

    public string? State { get; set; }

    public string? Umocowanie { get; set; }
}
