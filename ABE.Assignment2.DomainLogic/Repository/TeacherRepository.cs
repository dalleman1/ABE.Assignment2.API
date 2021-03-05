using ABE.Assignment2.DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABE.Assignment2.DomainLogic.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly List<Teacher> _teachers = new List<Teacher>();
        private readonly List<Course> _courses = new List<Course>();

        public TeacherRepository()
        {
            Course course1 = new Course
            {
                Id = 1,
                Name = "ABE"
            };

            Teacher teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Poul",
                LastName = "Ejnar",
                Course = course1
            };

            _teachers.Add(teacher1);
            _courses.Add(course1);
        }
        public List<Teacher> GetAllTeachers()
        {
            return _teachers;
        }

        public Teacher GetTeacherById(int id)
        {
            return _teachers.Where(teacher => teacher.Id == id).FirstOrDefault<Teacher>();
        }

        public Course GetCourseByTeacher(int id)
        {
            return _courses.Where(course => course.Teacher.Id == id).FirstOrDefault<Course>();
        }
    }
}
