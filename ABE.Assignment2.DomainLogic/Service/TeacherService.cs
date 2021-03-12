using ABE.Assignment2.DomainLogic.Models;
using ABE.Assignment2.DomainLogic.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ABE.Assignment2.DomainLogic.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            return await _teacherRepository.AddTeacherAsync(teacher);
        }

        public async Task<List<Teacher>> GetAllTeachers()
        {
            return await _teacherRepository.GetAllTeachers();
        }
    }
}
