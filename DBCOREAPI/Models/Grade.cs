using System;
using System.Collections.Generic;

#nullable disable

namespace DBCOREAPI.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Student1s = new HashSet<Student1>();
        }

        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public virtual ICollection<Student1> Student1s { get; set; }
    }
}
