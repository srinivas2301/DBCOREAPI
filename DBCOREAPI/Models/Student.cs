using System;
using System.Collections.Generic;

#nullable disable

namespace DBCOREAPI.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Marks { get; set; }
    }
}
