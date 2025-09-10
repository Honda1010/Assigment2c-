using EFCore1.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAss2.Data.Model
{
	internal class Stud_Course
	{
		public int StudentId { get; set; }
		public Student Student { get; set; }
		public int CourseId { get; set; }
		public Course Course { get; set; }
		public int Grade { get; set; }
	}
}
