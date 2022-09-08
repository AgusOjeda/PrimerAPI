using Aplication.Response;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface IStudentServices
    {
        Task<StudentResponse> CreateStudent(CreateStudentRequest request);
        Task<Student> DeleteStudent(int studentId);
        Task<List<Student>> GetAll();
        Task<StudentResponse> GetById(int sutdentId);
    }
}
