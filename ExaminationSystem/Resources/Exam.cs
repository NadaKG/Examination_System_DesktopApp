using Examanation_System.Models;
using Microsoft.Data.SqlClient;
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
    public partial class Exam : Form
    {
        private ExamDbContext ctx;
        int SubId;
        int studentId;
        private List<Questions> questions;
        private List<Answers> answers;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private string connectionString = "Data Source=.;Initial Catalog=ExaminationDb;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True";

        public Exam(int SubId, int studentId)
        {
            InitializeComponent();
            this.SubId = SubId;
            this.studentId = studentId;
            LoadQuestions();
            DisplayQuestion();
        }

        private void LoadQuestions()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            questions = new List<Questions>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 5 q.Id, q.Body, q.RightAnswer, q.SubjectId, a.Id as AnswerId, a.Ans1, a.Ans2, a.Ans3 " +
    "FROM Questions q " +
    "INNER JOIN Answers a ON q.Id = a.QuestionID " +
    "WHERE q.SubjectId = @SubjectId " +
    "ORDER BY NEWID()";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SubjectId", SubId);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Questions question = new Questions
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Body = reader["Body"].ToString(),
                            RightAnswer = reader["RightAnswer"].ToString(),
                            SubjectId = Convert.ToInt32(reader["SubjectId"]),
                            Answers = new List<Answers>()
                        };


                        Answers answer = new Answers
                        {
                            Id = Convert.ToInt32(reader["AnswerId"]),
                            Ans1 = reader["Ans1"].ToString(),
                            Ans2 = reader["Ans2"].ToString(),
                            Ans3 = reader["Ans3"].ToString(),
                            QuestionId = question.Id
                        };

                        question.Answers.Add(answer);
                        questions.Add(question);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayQuestion()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            if (currentQuestionIndex < questions.Count)
            {
                Questions question = questions[currentQuestionIndex];
                label1.Text = question.Body;

                Answers currentAnswers = question.Answers.FirstOrDefault();

                if (currentAnswers != null)
                {
                    radioButton1.Text = currentAnswers.Ans1;
                    radioButton2.Text = currentAnswers.Ans2;
                    radioButton3.Text = currentAnswers.Ans3;
                }
                else
                {
                    MessageBox.Show("Error: No answers found for the current question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FinishExam();
                }
                label3.Text = $"Question {currentQuestionIndex + 1} of {questions.Count}";
                button2.Enabled = currentQuestionIndex > 0;
                button1.Text = currentQuestionIndex == questions.Count - 1 ? "Finish Exam" : "Next";
            }
            else
            {
                FinishExam();
            }
        }

        private void FinishExam()
        {
            YourGrade last = new YourGrade(score);
            this.Hide();
            last.Show();
            SaveScoreToDatabase(studentId, SubId, score);


        }

        private void SaveScoreToDatabase(int studentId, int subjectId, int score)
        {
            try
            {
                using (var ctx = new ExamDbContext())
                {
                    var existingStudent = ctx.Students.Find(studentId);
                    if (existingStudent == null)
                    {
                        MessageBox.Show("Error: StudentId not found in the Students table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var studentSubject = ctx.StudentSubjects
                        .FirstOrDefault(ss => ss.StudentId == studentId && ss.SubjectId == subjectId);

                    if (studentSubject != null)
                    {
                        studentSubject.Grade = score;
                    }
                    else
                    {
                        ctx.StudentSubjects.Add(new StudentSubjects
                        {
                            StudentId = studentId,
                            SubjectId = subjectId,
                            Grade = score
                        });
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            
            ctx = new ExamDbContext();

            var existingStudents = ctx.Students.Select(s => s.Id).ToList();

            if (!existingStudents.Contains(studentId))
            {
                MessageBox.Show("Error: StudentId not found in the Students table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
                return;
            }

            LoadQuestions();
            DisplayQuestion();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Finish Exam")
            {
                FinishExam();
                return;
            }


            Questions currentQuestion = questions[currentQuestionIndex];
            string selectedAnswerText = GetSelectedAnswerText();

            if (selectedAnswerText == currentQuestion.RightAnswer)
            {
                score += 10;
            }

            currentQuestionIndex++;
            DisplayQuestion();
        }

        private string GetSelectedAnswerText()
        {
            if (radioButton1.Checked)
                return radioButton1.Text;
            else if (radioButton2.Checked)
                return radioButton2.Text;
            else if (radioButton3.Checked)
                return radioButton3.Text;
            return string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
