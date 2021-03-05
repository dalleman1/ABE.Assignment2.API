using ABE.Assignment2.DomainLogic.Models;
using ABE.Assignment2.DomainLogic.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public List<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }

        public Course GetCourseByTeacher(int id)
        {
            return _teacherRepository.GetCourseByTeacher(id);
        }

        public Teacher GetTeacherById(int id)
        {
            return _teacherRepository.GetTeacherById(id);
        }
    }
}
