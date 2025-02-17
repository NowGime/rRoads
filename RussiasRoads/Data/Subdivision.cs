using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Subdivision
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? HeadId { get; set; }

    public string? Info { get; set; }

    public int? MainEmployeeId { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Subdivision? Head { get; set; }

    public virtual ICollection<Subdivision> InverseHead { get; set; } = new List<Subdivision>();

    public virtual Employee? MainEmployee { get; set; }
}
