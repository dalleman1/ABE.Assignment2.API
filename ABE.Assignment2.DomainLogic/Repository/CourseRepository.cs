using ABE.Assignment2.DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Repository
{
    public class CourseRepository
    {
        private readonly List<Course> courses = new List<Course>();
        private readonly List<Student> students = new List<Student>();

        public CourseRepository()
        {
            Student student1 = new Student
            {
                FirstName = "Sebastian",
                LastName = "Brahe",
                Id = 1
            };

            Student student2 = new Student
            {
                FirstName = "Morten",
                LastName = "Dalsgaard",
                Id = 2
            };

            Student student3 = new Student
            {
                FirstName = "Frederik",
                LastName = "Dalager",
                Id = 3
            };

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            Teacher teacher1 = new Teacher
            {
                FirstName = "Henrik",
                LastName = "Dabmanden",
                Id = 1
            };

            Course course1 = new Course
            {
                Id = 1,
                Name = "MAD",
                Students = students,
                Teacher = teacher1

            };

            courses.Add(course1);
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        public Course GetCourseById(int id)
        {
            return courses.Where(Course => Course.Id == id).FirstOrDefault<Course>();
        }

    }
}
