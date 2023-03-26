using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class EncryptionApplication
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }

    public string? ParametersEnc { get; set; }

    public string? ParametersDec { get; set; }

    public virtual ICollection<Encryption> Encryptions { get; } = new List<Encryption>();
}
