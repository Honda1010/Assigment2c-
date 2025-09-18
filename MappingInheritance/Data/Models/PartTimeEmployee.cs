using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingInhertance.Data.Models
{
	internal class PartTimeEmployee: Employee
	{
		public Decimal HourRate { get; set; }
		public int CountOfHours { get; set; }

	}
}
