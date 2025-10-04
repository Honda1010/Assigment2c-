using Demo.BL2.DTOS;
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
		#region Create
		[HttpGet]
		public IActionResult Create()
		{
				return View();
		}
		[HttpPost]
		public IActionResult Create(CreatedDepartmentDto createdDepartmentDto)
		{
			if (ModelState.IsValid)
			{
				_departmentService.Add(createdDepartmentDto);
				return RedirectToAction("Index");
			}
			else
			{
				return View(createdDepartmentDto);

			}
		}

		#endregion
	}
}
