using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation_System.Models
{
    public class StudentQuestions
    {

        public int StudentId { get; set; }
        public int QuestionId { get; set; }
        public string StudentAnswer { get; set; }

        public Students Student { get; set; }
        public Questions Question { get; set; }

    }
}
