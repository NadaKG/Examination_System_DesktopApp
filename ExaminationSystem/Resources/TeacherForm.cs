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

    public partial class TeacherForm : Form
    {
        int UserId;
        ExamDbContext ctx = new ExamDbContext();
        public TeacherForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            var subjects = ctx.subjects.ToList();
            comboBox1.DataSource = subjects;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var SubName = (int)comboBox1.SelectedValue;
            var NewQuestion = new Questions() { Body = richTextBox1.Text, RightAnswer = textBox4.Text, SubjectId = SubName };
            if (richTextBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(" Enter Question in Valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ctx.Questions.Add(NewQuestion);
                ctx.SaveChanges();
            }
            var NewAnswers = new Answers() { Ans1 = textBox1.Text, Ans2 = textBox3.Text, Ans3 = textBox2.Text, QuestionId = NewQuestion.Id };

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show(" Enter Question in Valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ctx.Answers.Add(NewAnswers);
                ctx.SaveChanges();
                richTextBox1.Clear();
                textBox4.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show(" Qestion with Id=" + NewAnswers.QuestionId + " is added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
