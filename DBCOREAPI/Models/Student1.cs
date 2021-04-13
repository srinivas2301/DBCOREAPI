using System;
using System.Collections.Generic;

#nullable disable

namespace DBCOREAPI.Models
{
    public partial class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; }
    }
}
