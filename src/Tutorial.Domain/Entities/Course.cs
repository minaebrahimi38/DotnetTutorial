using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Domain.Entities
{
    public class Course

    {
        public int Id { get; set; }
        public required string CourseName { get; set; }
        public string Description { get; set; } = string.Empty;
     
  
    }
    
}
