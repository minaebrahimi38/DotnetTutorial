using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Application.Interface;
using Tutorial.Domain.Entities;

namespace Tutorial.Infrastructure.Persistence.Repository
{
    public class StudentRepository : IStudentService
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Student> CreateStudent(Student student)
        {
            await _dbContext.Students.AddAsync(student);
            return student;
        }
    }
}
