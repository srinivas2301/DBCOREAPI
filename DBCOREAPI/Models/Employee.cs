using System;
using System.Collections.Generic;

#nullable disable

namespace DBCOREAPI.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Ename { get; set; }
        public int? Deptid { get; set; }

        public virtual Department Dept { get; set; }
    }
}
