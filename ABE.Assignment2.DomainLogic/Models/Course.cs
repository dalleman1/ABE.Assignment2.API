using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
    }
}
