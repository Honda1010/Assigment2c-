using EFCore1.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAss2.Data.Configuration
{
	internal class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.Property(e => e.Id).ValueGeneratedOnAdd();
			builder.Property(e => e.FName).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
			builder.Property(e => e.LName).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
			builder.HasOne(e => e.Department).WithMany(d => d.Students).HasForeignKey(e => e.DepartmentId).OnDelete(DeleteBehavior.Cascade);
			builder.HasMany(s => s.stud_Courses).WithOne(sc => sc.Student).HasForeignKey(sc => sc.StudentId).OnDelete(DeleteBehavior.Cascade);

		}
	}
}
