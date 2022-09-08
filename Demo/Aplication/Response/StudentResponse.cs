using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Response
{
    public class StudentResponse
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public CreateStudentAddressResponse Address { get; set; }
    }
    
    public class CreateStudentAddressResponse
    {
        public int StudentAddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public int AddressOfStudentId { get; set; }
    }
}
