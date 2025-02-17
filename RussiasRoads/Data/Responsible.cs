using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Responsible
{
    public int Id { get; set; }

    public int? EventId { get; set; }

    public int? EmployId { get; set; }

    public virtual Employee? Employ { get; set; }

    public virtual Event? Event { get; set; }
}
