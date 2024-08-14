using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Application.Dtos
{
    public class StudentDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string FatherName { get; set; } = string.Empty;
        public required string Mobile { get; set; }
        public required string NationalId { get; set; }
    }
}
