using MappingInhertance.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingInhertance.Data
{
	internal class InheritanceDBContext: DbContext
	{
		public InheritanceDBContext()
		{
		}
		public InheritanceDBContext(DbContextOptions options) : base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
			optionsBuilder.UseSqlServer("Server=LAPTOP-3P0T45J3;Database=InheritanceCompany;Trusted_Connection=True;TrustServerCertificate=True;");
			}
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// TPH
			//modelBuilder.Entity<Employee>()
			//	.HasDiscriminator<string>("EmployeeType")
			//	.HasValue<FullTimeEmployee>("FullTime")
			//	.HasValue<PartTimeEmployee>("PartTime");
			//modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
			//modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
			// TPT
			modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
			modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
			base.OnModelCreating(modelBuilder);

		}
		#region TPCT
		//public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
		//public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
		#endregion
		#region TPH
			//public DbSet<Employee> Employees { get; set; }
			//public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
			//public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
		#endregion
		#region TPt
		public DbSet<Employee> Employees { get; set; }
		public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
		public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
		#endregion



	}
}
