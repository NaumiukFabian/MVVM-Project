using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class SchemaInfoDss
{
    public int SchemaMajorVersion { get; set; }

    public int SchemaMinorVersion { get; set; }

    public string SchemaExtendedInfo { get; set; } = null!;
}
