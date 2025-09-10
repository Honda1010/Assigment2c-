using EFCoreAss2.Data.Model;
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
		public int Id { get; set; }
		public string Name { get; set; }
		public int Duration { get; set; }
		public string? Description { get; set; }
		public decimal Price { get; set; }

		public int TopicId { get; set; }
		public Topic Topic { get; set; }

		public List<Stud_Course> stud_Courses { get; set; }

		public List<Course_Inst> course_Insts { get; set; }


	}
}
