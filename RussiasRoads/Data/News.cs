using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class News
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? Date { get; set; }

    public int? EmployeeId { get; set; }

    public string? Text { get; set; }

    public virtual Employee? Employee { get; set; }
}
