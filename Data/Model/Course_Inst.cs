using EFCore1.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAss2.Data.Model
{
	internal class Course_Inst
	{
		public int CourseId { get; set; }
		public Course Course { get; set; }
		public int InstructorId { get; set; }
		public Instructor Instructor { get; set; }
		public String? Evaluate { get; set; }
	}
}
