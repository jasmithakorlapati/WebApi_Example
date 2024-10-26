using System;
using System.Collections.Generic;

namespace Examplee.Models;

public partial class Leaf
{
    public int LeaveReqId { get; set; }

    public int EmpId { get; set; }

    public DateOnly LeaveStart { get; set; }

    public DateOnly LeaveEnd { get; set; }

    public string LeaveReason { get; set; } = null!;

    public virtual Employee Emp { get; set; } = null!;
}
