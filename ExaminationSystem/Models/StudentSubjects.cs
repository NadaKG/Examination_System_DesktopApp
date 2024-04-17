using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation_System.Models
{
    public class StudentSubjects
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Grade { get; set; }
        public Students Student { get; set; }
        public Subjects Subject { get; set; }
    }
}
