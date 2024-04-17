using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation_System.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Instructors Instructor { get; set; }
        public ICollection<Questions> Questions { get; set; } = new HashSet<Questions>(); // navigational property => many
        public ICollection<StudentSubjects> StudentSubjects { get; set; } = new HashSet<StudentSubjects>(); // navigational property => many
    }
}

