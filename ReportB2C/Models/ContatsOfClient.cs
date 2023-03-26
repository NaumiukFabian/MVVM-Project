using System;
using System.Collections.Generic;

namespace ReportB2C.Models;

public partial class ContatsOfClient
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int PersonId { get; set; }

    public string? Position { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
