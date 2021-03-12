using ABE.Assignment2.DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ABE.Assignment2.DomainLogic.Service
{
    public interface ITeacherService
    {
        Task<List<Teacher>> GetAllTeachers();
        Task<Teacher> AddTeacherAsync(Teacher teacher);
    }
}
