using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp.Domain.Entities
{
    public class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public HashSet<Student> Students { get; set; }
        public HashSet<Teacher> Teachers { get; set; }
    }
}
