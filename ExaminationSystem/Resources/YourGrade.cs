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
    public partial class YourGrade : Form
    {

        int score;
        public YourGrade(int Score)
        {
            InitializeComponent();
            this.score = Score;
            label1.Text = $"Your grade is: {score}/50";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void YourGrade_Load(object sender, EventArgs e)
        {

        }
    }
}
