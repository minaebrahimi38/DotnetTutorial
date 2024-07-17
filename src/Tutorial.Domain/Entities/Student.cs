using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string FatherName { get; set; } = string.Empty;
        public required string Mobile { get; set; }
        public required string NationalId { get; set; }

        public virtual ICollection<Course> StudentCourses { get;set; } = new List<Course>();
    }
}
