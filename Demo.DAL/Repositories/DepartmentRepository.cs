using Demo.DAL.Data.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories
{
	// primary Constructor prevent Dependency Injection
	public class DepartmentRepository(ApplicationDBContext context) : IDepartmentRepository
	{
		private readonly ApplicationDBContext _context = context;

		public Department GetById(int? id)
		{
			return _context.Departments.AsNoTracking().FirstOrDefault(d => d.Id == id);
		}

		public IEnumerable<Department> GetAll(bool withtracking = false)
		{
			if (withtracking)
			{
				return _context.Departments.ToList();
			}
			else
			{
				return _context.Departments.AsNoTracking().ToList();
			}
		}
		public int Add(Department department)
		{
			_context.Departments.Add(department);
			return _context.SaveChanges();
		}
		public int Update(Department department)
		{
			_context.Departments.Update(department);
			return _context.SaveChanges();
		}
		public int Remove(Department department)
		{
			_context.Departments.Remove(department);
			return _context.SaveChanges();
		}

	}
}
