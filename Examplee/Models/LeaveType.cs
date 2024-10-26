using System;
using System.Collections.Generic;

namespace Examplee.Models;

public partial class LeaveType
{
    public int LeaveTypeId { get; set; }

    public string LeaveTypeName { get; set; } = null!;
}
