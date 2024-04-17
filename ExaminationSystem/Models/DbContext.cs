using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation_System.Models
{
    public class ExamDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Subjects> subjects { get; set; }
        public DbSet<StudentSubjects> StudentSubjects { get; set; }
        public DbSet<StudentQuestions> StudentQuestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ExaminationDb;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentQuestions>().HasKey(k => new { k.StudentId, k.QuestionId });
            modelBuilder.Entity<StudentSubjects>().HasKey(k => new { k.StudentId, k.SubjectId });
        }
    }
}
