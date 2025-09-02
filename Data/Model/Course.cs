using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.Data.Model
{
	// DataAnnotation Approach
	[Table("Courses",Schema ="dbo")]
	internal class Course
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Column(TypeName ="varchar(50)")]
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
		[Required]
		public int Duration { get; set; }
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public int? TopId { get; set; }
	}
}
