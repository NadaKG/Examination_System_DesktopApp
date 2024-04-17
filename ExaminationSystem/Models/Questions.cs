using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation_System.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string RightAnswer { get; set; }
        public ICollection<Answers> Answers { get; set; } = new HashSet<Answers>(); // navigational property => many
        public int SubjectId {  get; set; }
        public Subjects Subject { get; set; } // navigational property => one
        public ICollection<StudentQuestions> StudentQuestions { get; set; } = new HashSet<StudentQuestions>(); // navigational property => many
        
    }
}

