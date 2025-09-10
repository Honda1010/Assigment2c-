using EFCoreAss2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.Data.Model
{
	//Configuration Approach
	internal class Instructor
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal bonus { get; set; }
		public decimal Salary { get; set; }
		public string? Address { get; set; }
		public int? HourRate { get; set; }

		public int DeptId { get; set; }
		public Department Dept { get; set; }

		public Department DepartmentToMange { get; set; }

		public List<Course_Inst> course_Insts { get; set; }


	}
}
