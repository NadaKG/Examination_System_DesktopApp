using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation_System.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public string Ans1 { get; set; }
        public string Ans2 { get; set; }
        public string Ans3 { get; set; }
        public int QuestionId { get; set; }
        public Questions Question { get; set; }
    }
}
