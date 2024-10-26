using System;
using System.Collections.Generic;

namespace Examplee.Models;

public partial class Attendence
{
    public int AttendenceId { get; set; }

    public int EmpId { get; set; }

    public DateOnly Date { get; set; }

    public string Status { get; set; } = null!;

    public DateTime LoginTime { get; set; }

    public DateTime LogoutTime { get; set; }

    public virtual Employee Emp { get; set; } = null!;
}
