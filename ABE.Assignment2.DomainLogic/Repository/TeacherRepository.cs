using ABE.Assignment2.DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Repository
{
    public class TeacherRepository
    {
        private readonly List<Teacher> _teachers = new List<Teacher>();
        private readonly List<Course> _courses = new List<Course>();

        public TeacherRepository()
        {
            Teacher teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Poul",
                LastName = "Ejnar"
            };

            Course course1 = new Course
            {
                Id = 1,
                Name = "ABE"
            };
        }

        public
    }
}
