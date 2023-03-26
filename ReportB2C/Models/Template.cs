using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class Template
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Path { get; set; }

    public string? Data { get; set; }
}
