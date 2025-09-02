using EFCore1.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.Data.Configuration
{
	internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
	{
		public void Configure(EntityTypeBuilder<Instructor> builder)
		{
			builder.ToTable("Instructors", "dbo");
			builder.HasKey(e => e.Id);
			builder.Property(e => e.Id).ValueGeneratedOnAdd();
			builder.Property(e => e.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
			builder.Property(e => e.Salary).HasColumnType("decimal(18,2)");
			builder.Property(e=>e.bonus).HasColumnType("decimal(18,2)");
		}
	}
}
