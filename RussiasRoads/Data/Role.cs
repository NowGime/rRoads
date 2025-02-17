﻿using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
