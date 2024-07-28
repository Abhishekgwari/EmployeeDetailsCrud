using System;
using System.Collections.Generic;

namespace EmployeeDetailsCrud.Models;

public partial class EmpTable
{
    public int Ssn { get; set; }

    public string Name { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int Salary { get; set; }
}
