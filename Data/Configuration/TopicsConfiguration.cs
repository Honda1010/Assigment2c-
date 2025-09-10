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
	internal class TopicsConfiguration : IEntityTypeConfiguration<Topic>
	{
		public void Configure(EntityTypeBuilder<Topic> builder)
		{
			builder.Property(e => e.Id).ValueGeneratedOnAdd();
			builder.Property(e => e.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
			builder.HasMany(t => t.Courses).WithOne(c => c.Topic).HasForeignKey(c => c.TopicId).OnDelete(DeleteBehavior.Cascade);
		}
	}
}
