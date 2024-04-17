using Examanation_System.Models;
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

    public partial class SubjectStudent : Form
    {
        int SubId;
        int UserId = 0;
        ExamDbContext ctx = new ExamDbContext();
        public SubjectStudent(int userid)
        {
            InitializeComponent();
            this.UserId = userid;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if(comboBox1.SelectedItem is Subjects selectedSubject)
            {
                SubId = selectedSubject.Id;
            }
        }

        private void SubjectStudent_Load(object sender, EventArgs e)
        {
            var subjects = ctx.subjects.ToList();
            comboBox1.DataSource = subjects;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            SubId =(int)comboBox1.SelectedValue;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exam examForm = new Exam(SubId, UserId);

            // Check if the form is not disposed
            if (!examForm.IsDisposed)
            {
                this.Hide();
                examForm.Show();
            }
            else
            {
                MessageBox.Show("Error: The Exam form is disposed or closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
