using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.Data.Model
{
	//Fluent API Approach
	internal class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int? InsId { get; set; }
		public DateTime HiringDate { get; set; }
	}
}
