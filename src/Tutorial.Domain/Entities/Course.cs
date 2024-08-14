using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Domain.Entities
{
    public class Course

    {
        public int Id { get; set; }
        [StringLength(100)]
        public required string CourseName { get; set; }
        [StringLength(250)]
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<Student> Students { get; } = new HashSet<Student>();
    }

}
