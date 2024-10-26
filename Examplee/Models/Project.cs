using System;
using System.Collections.Generic;

namespace Examplee.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public int EmpId { get; set; }

    public DateOnly ProjectStart { get; set; }

    public DateOnly ProjectEnd { get; set; }

    public string ProjectName { get; set; } = null!;

    public virtual Employee Emp { get; set; } = null!;
}
