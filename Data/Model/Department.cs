using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.Data.Model
{
	internal class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime HiringDate { get; set; }
		public List<Student> Students { get; set; }

		public List<Instructor> Instructors { get; set; }

		public int? HeadId { get; set; }

		public Instructor DepartmentHead { get; set; }

	}
}
