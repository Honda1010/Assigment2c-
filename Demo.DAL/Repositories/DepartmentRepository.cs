using Demo.DAL.Data.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories
{
	// primary Constructor prevent Dependency Injection
	public class DepartmentRepository(ApplicationDBContext context)
	{
		private readonly ApplicationDBContext _context = context;

		public Department GetById(int id)
		{
			return _context.Departments.Find(id);
		}
	}
}
