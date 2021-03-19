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

        public async Task<Teacher> GetById(int Id)
        {
            return await _context.FindAsync<Teacher>(Id);
        }

        public async Task<bool> DeleteById(int Id)
        {
            var teacher =  await _context.FindAsync<Teacher>(Id);

            if (teacher != null)
            {
                _context.Remove(teacher);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<Teacher> UpdateAsync(Teacher CurrentTeacher, Teacher NewTeacher)
        {
            CurrentTeacher.FirstName = NewTeacher.FirstName;
            CurrentTeacher.LastName = NewTeacher.LastName;
            await _context.SaveChangesAsync();
            return NewTeacher;
        }

        public bool DeleteTeacher(Teacher teacher)
        {
            _context.Remove(teacher);
            return _context.SaveChanges() > 0;
        }
    }
}
