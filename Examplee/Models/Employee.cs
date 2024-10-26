using System;
using System.Collections.Generic;

namespace Examplee.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public decimal EmpPhoneNumber { get; set; }

    public int EmpSalary { get; set; }

    public int DeptId { get; set; }

    public virtual ICollection<Attendence> Attendences { get; set; } = new List<Attendence>();

    public virtual Department Dept { get; set; } = null!;

    public virtual ICollection<Leaf> Leaves { get; set; } = new List<Leaf>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
