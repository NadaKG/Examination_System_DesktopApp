using Examanation_System.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examanation_System.Resources
{
    public partial class UserPassword : Form
    {
        private string userType;
        int UserId = 0;

        public UserPassword(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userType == "teacher")
            {
                TeacherForm teacherForm = new TeacherForm(UserId);
                Instructors user = new Instructors();
                user.UserName = textBox1.Text;
                user.Password = textBox2.Text;
                Instructors.Login(user);
                if (Instructors.IsSuccessful)
                {
                    UserId = user.Id;
                    MessageBox.Show(Instructors.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    teacherForm.Show();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show(Instructors.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (userType == "student")
            {
                Students student = new Students();
                student.UserName = textBox1.Text;
                student.Password = textBox2.Text;
                Students.Login(student);
                if (Students.IsSuccessful)
                {
                    
                    UserId = Students.CurrentUser.Id; 

                    SubjectStudent studentForm = new SubjectStudent(UserId);
                    MessageBox.Show(Students.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    studentForm.Show();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show(Students.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UserPassword_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
