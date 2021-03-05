using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
    }
}
