using Demo.BL2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
	public class DepartmentsController(IDepartmentService _departmentService) : Controller
	{
		public IActionResult Index()
		{
			var departments = _departmentService.GetAll();
			return View(departments);
		}
	}
}
