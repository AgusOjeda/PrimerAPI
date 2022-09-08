using Aplication.Interfaces;
using Aplication.Response;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.UseCase.Students
{
    public class StudentService : IStudentServices
    {
        private readonly IStudentsCommand _command;
        private readonly IStudentQuery _query;

        public StudentService(IStudentsCommand command, IStudentQuery query)
        {
            _command = command;
            _query = query;
        }
        public async Task<StudentResponse> CreateStudent(CreateStudentRequest request)
        {
            var student = new Student {
                Name = request.StudentName,
                Address = new StudentAddress
                {
                    Address = request.Address,
                    City = request.City,
                    State = request.State,
                    Country = request.Country
                }
            };
            await _command.InsertStudent(student);
            return new StudentResponse {
                Address = new CreateStudentAddressResponse {
                    Address = student.Address.Address,
                    City = student.Address.City,
                    Country = student.Address.Country,
                    State = student.Address.State,
                    AddressOfStudentId = student.Address.AddressOfStudentId,
                    StudentAddressId = student.Address.StudentAddressId
                },
                Name = student.Name,
                StudentId = student.StudentId,
            };
        }

        public Task<Student> DeleteStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<StudentResponse> GetById(int studentId)
        {
            var student = _query.GetStudent(studentId);

            return Task.FromResult(new StudentResponse
            {
                Address = new CreateStudentAddressResponse
                {
                    Address = student.Address.Address,
                    City = student.Address.City,
                    Country = student.Address.Country,
                    State = student.Address.State,
                    AddressOfStudentId = student.Address.AddressOfStudentId,
                    StudentAddressId = student.Address.StudentAddressId
                },
                Name = student.Name,
                StudentId = student.StudentId,
            });
        }
    }
}
