using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation_System.Models
{
    public class Instructors
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Subjects> Subject { get; set; } = new HashSet<Subjects>(); // navigational property => many

        static ExamDbContext ctx;
        public static bool IsSuccessful;
        public static string Message;
        public static Instructors CurrentUser { get; set; }
        static Instructors()
        {
            ctx = new ExamDbContext();
            IsSuccessful = false;
            Message = "";
            CurrentUser = new Instructors();
        }



        public static void Login(Instructors user)
        {

            try
            {
                if (user.UserName != string.Empty && user.Password != string.Empty)
                {
                    var loginUser = ctx.Instructors.FirstOrDefault(a => a.UserName.Equals(user.UserName));
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

