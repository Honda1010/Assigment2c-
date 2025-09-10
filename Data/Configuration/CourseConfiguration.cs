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
	internal class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.Property(e => e.Id).ValueGeneratedOnAdd();
			builder.Property(e => e.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
			builder.Property(e => e.Duration).IsRequired();
			builder.Property(e => e.Price).HasColumnType("decimal(18,2)");
			builder.Property(e => e.Description).HasColumnType("nvarchar(max)");
			builder.HasMany(c => c.stud_Courses).WithOne(sc => sc.Course).HasForeignKey(sc => sc.CourseId).OnDelete(DeleteBehavior.Cascade);
		}
	}
}
