using ABE.Assignment2.DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int studentId);

        List<Course> GetCoursesById(int studentId);

    }
}
