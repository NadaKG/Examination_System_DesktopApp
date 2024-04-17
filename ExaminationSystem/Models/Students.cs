using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation_System.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<StudentQuestions> StudentQuestions { get; set; } = new HashSet<StudentQuestions>(); // navigational property => many
        public ICollection<StudentSubjects> StudentSubjects { get; set; } = new HashSet<StudentSubjects>(); // navigational property => many


        static ExamDbContext ctx;
        public static bool IsSuccessful;
        public static string Message;
        public static Students CurrentUser { get; set; }
        static Students()
        {
            ctx = new ExamDbContext();
            IsSuccessful = false;
            Message = "";
            CurrentUser = new Students();
        }



        public static void Login(Students user)
        {

            try
            {
                if (user.UserName != string.Empty && user.Password != string.Empty)
                {
                    var loginUser = ctx.Students.FirstOrDefault(a => a.UserName.Equals(user.UserName));
                    if (loginUser != null)
                    {
                        if (loginUser.Password.Equals(user.Password))
                        {
                            CurrentUser = loginUser;
                            Message = $"Login Success! Welcome {CurrentUser.UserName}";
                            IsSuccessful = true;
                            return;
                        }
                        else
                        {
                            Message = "Password Not Valid!";
                            IsSuccessful = false;
                            return;
                        }

                    }
                    else
                    {
                        Message = "User Name Not Valid!";
                        IsSuccessful = false;
                        return;
                    }
                }
                else
                {
                    Message = "User Name and Password Can't be Empty!";
                    IsSuccessful = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                IsSuccessful = false;
            }
        }

    }
}
