using ABE.Assignment2.DomainLogic.Config;
using ABE.Assignment2.DomainLogic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABE.Assignment2.DomainLogic.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly GraphQLContext _context;
        public TeacherRepository(GraphQLContext context)
        {
            _context = context;

        }
        public async Task<List<Teacher>> GetAllTeachers()
        {
            return await _context.Set<Teacher>()
                     .AsNoTracking()
                     .ToListAsync();
        }

        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            _context.Add(teacher);
            await _context.SaveChangesAsync();
            return teacher;
        }
    }
}
