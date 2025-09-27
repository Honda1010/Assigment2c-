using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Data.DBContexts
{
	public class ApplicationDBContext: DbContext
	{
		public ApplicationDBContext(): base()
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;Database=DemoDB;Trusted_Connection=True;TrustServerCertificate=True;");
		}
		public DbSet<Department> Departments { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
			base.OnModelCreating(modelBuilder);
		}

	}
}
