using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Domain.Entities
{
    public class StudentCourse
    { 
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public required virtual Student Student { get; set; }
        public required virtual Course Course { get; set; }

    }
}
