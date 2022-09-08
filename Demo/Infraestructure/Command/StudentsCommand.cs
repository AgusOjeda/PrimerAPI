using Aplication.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Command
{
    public class StudentsCommand : IStudentsCommand
    {
        private readonly AppDbContext _context;
        
        public StudentsCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public Task RemoveStudent(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
