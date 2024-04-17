using Examanation_System.Resources;

namespace Examanation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPassword teacherLoginForm = new UserPassword("teacher");
            teacherLoginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserPassword studentLoginForm = new UserPassword("student");
            studentLoginForm.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
