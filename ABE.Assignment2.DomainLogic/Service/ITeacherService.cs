using ABE.Assignment2.DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Service
{
    public interface ITeacherService
    {
        List<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int id);
        Course GetCourseByTeacher(int id);
    }
}
