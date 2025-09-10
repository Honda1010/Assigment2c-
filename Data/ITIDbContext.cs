using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using EFCore1.Data.Model;
using EFCoreAss2.Data.Model;

namespace EFCore1.Data
{
	internal class ITIDbContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=LAPTOP-3P0T45J3;Database=ITI3;Trusted_Connection=True;TrustServerCertificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			modelBuilder.Entity<Stud_Course>().HasKey(sc => new { sc.StudentId, sc.CourseId });
			modelBuilder.Entity<Course_Inst>().HasKey(ci => new { ci.InstructorId, ci.CourseId });
		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Topic> Topics { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Instructor> Instructors { get; set; }
		public DbSet<Stud_Course> Stud_Courses { get; set; }
		public DbSet<Course_Inst> Course_Insts { get; set; }

	}
}
