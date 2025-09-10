using EFCoreAss2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.Data.Model
{
	//Conventional Approach
	internal class Student
	{
		public int Id { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string? Address { get; set; }
		public int? Age { get; set; }

		public int? DepartmentId { get; set; }
		public Department Department { get; set; }

		public List<Stud_Course> stud_Courses { get; set; }
	}
}
