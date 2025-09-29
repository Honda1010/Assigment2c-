using Demo.DAL.Data.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL2
{
	internal class DepartmentService
	{
		public DepartmentService()
		{
			ApplicationDBContext context = new ApplicationDBContext();
		}
	}
}
