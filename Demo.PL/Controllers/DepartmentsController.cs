using Demo.BL2.DTOS;
using Demo.BL2.Services;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
	public class DepartmentsController(IDepartmentService _departmentService , ILogger<DepartmentsController> _logger ,IWebHostEnvironment _environment) : Controller
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
				try
				{
					int res = _departmentService.Add(createdDepartmentDto);
					if (res > 0) return RedirectToAction("Index");
					else
					{
						ModelState.AddModelError(String.Empty, "Faild to Add Department");
						return View(createdDepartmentDto);
					}
				}
				catch (Exception ex)
				{
					if (_environment.IsDevelopment())
					{
						_logger.LogError(ex, "Error occurred while adding a department.");
						ModelState.AddModelError(string.Empty, ex.Message);
						return View(createdDepartmentDto);
					}
					else
					{
						_logger.LogError(ex, "Error occurred while adding a department.");
						ModelState.AddModelError(string.Empty, "An error occurred while processing your request. Please try again later.");
						return View(createdDepartmentDto);

					}
				}
			}
			else
			{
				return View(createdDepartmentDto);

			}
		}
		#endregion
		#region Details
		[HttpGet]
		public IActionResult Details(int? id)
		{
			if (id == null) return BadRequest();
			var department = _departmentService.GetById(id);
			if (department == null) return NotFound();
			return View(department);
		}
		#endregion
		#region Edits
		[HttpGet]
		public IActionResult Edit(int? id)
		{
			if (id == null) return BadRequest();
			var department = _departmentService.GetById(id);
			if (department == null) return NotFound();
			var ViewModel = new DepartmentEditViewModel
			{
				Name = department.Name,
				Code = department.Code,
				Description = department.Description,
				DateOfLastModification = department.DateOfLastModification
			};
			return View(ViewModel);
		}
		[HttpPost]
		public IActionResult Edit([FromRoute] int id, DepartmentEditViewModel departmentEditViewModel)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var updatedDepartmentDto = new UpdatedDepartmentDto
					{
						Id = id,
						Name = departmentEditViewModel.Name,
						Code = departmentEditViewModel.Code,
						Description = departmentEditViewModel.Description,
						DateOfLastModification = departmentEditViewModel.DateOfLastModification  // to be replaced by the current user id
					};
					int res = _departmentService.Update(updatedDepartmentDto);
					if (res > 0) return RedirectToAction("Index");
					else
					{
						ModelState.AddModelError(String.Empty, "Faild to Update Department");
						return View(departmentEditViewModel);
					}
				}
				catch (Exception ex)
				{
					if (_environment.IsDevelopment())
					{
						_logger.LogError(ex, "Error occurred while updating a department.");
						ModelState.AddModelError(string.Empty, ex.Message);
						return View(departmentEditViewModel);
					}
					else
					{
						_logger.LogError(ex, "Error occurred while updating a department.");
						ModelState.AddModelError(string.Empty, "An error occurred while processing your request. Please try again later.");
						return View(departmentEditViewModel);
					}
				}
			}
			else
			{
				return View(departmentEditViewModel);
			}
		}
		#endregion
	}
}
