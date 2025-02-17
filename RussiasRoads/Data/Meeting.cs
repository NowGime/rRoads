using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Meeting
{
    public int Id { get; set; }

    public int? EmployeId { get; set; }

    public DateTime? Date { get; set; }

    public virtual Employee? Employe { get; set; }
}
