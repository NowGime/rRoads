using System;
using System.Collections.Generic;

namespace RussiasRoads.Data;

/// <summary>
/// Список дней исключений в производственном календаре
/// </summary>
public partial class Workingcalendar
{
    /// <summary>
    /// Идентификатор строки
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// День-исключение
    /// </summary>
    public DateOnly ExceptionDate { get; set; }

    /// <summary>
    /// 0 - будний день, но законодательно принят выходным; 1 - сб или вс, но является рабочим
    /// </summary>
    public bool IsWorkingDay { get; set; }
}
