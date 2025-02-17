using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

public partial class Materioal
{
    public int Id { get; set; }

    public int? EventId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? Date { get; set; }

    public DateTime? ChangeDate { get; set; }

    public int? StatusId { get; set; }

    public int? TypeId { get; set; }

    public int? AreaId { get; set; }

    public string? Author { get; set; }

    public virtual Area? Area { get; set; }

    public virtual Event? Event { get; set; }

    public virtual Status? Status { get; set; }
}
