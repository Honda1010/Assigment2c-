using EFCore1.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAss2.Data.Configuration
{
	internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
	{
		public void Configure(EntityTypeBuilder<Department> builder)
		{
			builder.Property(e => e.Id).ValueGeneratedOnAdd();
			builder.Property(e => e.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
			builder.Property(e => e.HiringDate).HasColumnType("date");
			builder.HasMany(d => d.Instructors).WithOne(i => i.Dept).HasForeignKey(i => i.DeptId).OnDelete(DeleteBehavior.Cascade);
			builder.HasOne(d => d.DepartmentHead).WithOne(i => i.DepartmentToMange).HasForeignKey<Department>(d => d.HeadId).OnDelete(DeleteBehavior.NoAction);

		}
	}
}
