using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Miss
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? Date { get; set; }

    public int? ReasonId { get; set; }

    public int? ReplacementId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Reason? Reason { get; set; }
}
