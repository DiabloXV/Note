using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Note.Entities;

namespace Note.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-DHMJ427 ; Database =  ITI(Note) ; Trusted_Connection = True ; Encrypt = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region M2M(Student-Course)
            modelBuilder.Entity<student>()
                .HasMany(S => S.StudentCourses);

            modelBuilder.Entity<course>()
                .HasMany(C => C.CourseStudents);

            modelBuilder.Entity<StudentCourse>()  //Composite Pk in a form of anonymous datatype using fluent Api
                .HasKey(SC => new { SC.studentID, SC.courseID });
            #endregion

            #region M2M(Instructor-Course)
            modelBuilder.Entity <Instructor>()
                 .HasMany(I => I.InstructorCourses);

            modelBuilder.Entity<course>()
                .HasMany(C => C.CourseInstructors);

            modelBuilder.Entity<CourseInstructor>()
                .HasKey(CI => new {CI.InstructorID , CI.CourseID});  //Composite Pk in a form of anonymous datatype using fluent Api
            #endregion

        }

        public DbSet <course> Courses { get; set; }

        public DbSet <student> students { get; set; }
    }
}
