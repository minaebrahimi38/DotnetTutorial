using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Domain.Entities;

namespace Tutorial.Application.Interface
{
    public interface IStudentService
    {
      Task<Student> CreateStudent(Student student); 
    }
}
