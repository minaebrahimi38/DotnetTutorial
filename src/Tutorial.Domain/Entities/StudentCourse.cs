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
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public required virtual Student Student { get; set; }
        public required virtual Course Course { get; set; }

    }
}
