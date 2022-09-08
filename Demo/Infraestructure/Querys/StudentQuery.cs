using Aplication.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Querys
{
    public class StudentQuery : IStudentQuery
    {
        private readonly AppDbContext _context;

        public StudentQuery(AppDbContext context)
        {
            _context = context;
        }
        public List<Student> GetListStudent()
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int studentId)
        {
            var students = _context.Students
            .Include(s => s.Address)
            .FirstOrDefault(x => x.StudentId == studentId);
            
            return students;
        }
    }
}
