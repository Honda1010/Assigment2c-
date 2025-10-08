using Demo.BL2.DTOS.Department;
using Demo.BL2.DTOS.Employee;
using Demo.BL2.Services.Classes;
using Demo.BL2.Services.Interfaces;
using Demo.DAL.Models.EmployeeModel;
using Demo.DAL.Models.Shared.Enum;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
	public class EmployeesController(IEmployeeService _employeeService,ILogger<EmployeesController> _logger,IWebHostEnvironment _environment) : Controller
	{
		public IActionResult Index()
		{
			var employees = _employeeService.GetAllEmployee();
			return View(employees);
		}
		#region Create
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(CreatedEmployeeDto createdEmployeeDto)
		{
			if (ModelState.IsValid)
			{
				try
				{
					int res = _employeeService.AddEmployee(createdEmployeeDto);
					if (res > 0) return RedirectToAction("Index");
					else
					{
						ModelState.AddModelError(String.Empty, "Faild to Add Employee");
						return View(createdEmployeeDto);
					}
				}
				catch (Exception ex)
				{
					if (_environment.IsDevelopment())
					{
						_logger.LogError(ex, "Error occurred while adding an employee.");
						ModelState.AddModelError(string.Empty, ex.Message);
						return View(createdEmployeeDto);
					}
					else
					{
						_logger.LogError(ex, "Error occurred while adding an employee.");
						ModelState.AddModelError(string.Empty, "An error occurred while processing your request. Please try again later.");
						return View(createdEmployeeDto);
					}
				}
			}
			else
			{
				return View(createdEmployeeDto);
			}
		}
		#endregion
		#region Details

		[HttpGet]
		public IActionResult Details(int? id)
		{
			if (!id.HasValue) return BadRequest();
			var employee = _employeeService.GetEmployeeById(id);
			if (employee == null) return NotFound();
			return View(employee);
		}
		#endregion
		#region Edit
		[HttpGet]
		public IActionResult Edit(int? id)
		{
			if (!id.HasValue) return BadRequest();
			var employee = _employeeService.GetEmployeeById(id);
			if (employee == null) return NotFound();
			var dto = new UpdatedEmployeeDto
			{
				Id = employee.Id,
				Name = employee.Name,
				Address= employee.Address,
				Email= employee.Email,
				PhoneNumber= employee.PhoneNumber,
				Age= employee.Age,
				IsActive= employee.IsActive,
				Salary= employee.Salary,
				HiringDate= employee.HiringDate,
				Gender= Enum.Parse<Gender>(employee.Gender),
				EmployeeType= Enum.Parse<EmployeeType>(employee.EmployeeType)
			};
			return View(dto);
		}
		[HttpPost]
		public IActionResult Edit([FromRoute] int id, UpdatedEmployeeDto dto) {
			if (id != dto.Id)	return BadRequest();
			if (ModelState.IsValid)
			{
				try
				{
					int res = _employeeService.Update(dto);
					if (res > 0) return RedirectToAction("Index");
					else
					{
						ModelState.AddModelError(String.Empty, "Faild to Update Department");
						return View(dto);
					}
				}
				catch (Exception ex)
				{
					if (_environment.IsDevelopment())
					{
						_logger.LogError(ex, "Error occurred while updating a department.");
						ModelState.AddModelError(string.Empty, ex.Message);
						return View(dto);
					}
					else
					{
						_logger.LogError(ex, "Error occurred while updating a department.");
						ModelState.AddModelError(string.Empty, "An error occurred while processing your request. Please try again later.");
						return View(dto);
					}
				}
			}
			else
			{
				return View(dto);
			}

		}

		#endregion
		#region Delete
		[HttpPost]
		public IActionResult Delete(int id) {
			try
			{
				bool res = _employeeService.RemoveEmployee(id);
				if (res) return RedirectToAction("Index");
				else
				{
					ModelState.AddModelError(String.Empty, "Faild to Delete Department");
					var department = _employeeService.GetEmployeeById(id);
					return View(department);
				}
			}
			catch (Exception ex)
			{
				if (_environment.IsDevelopment())
				{
					_logger.LogError(ex, "Error occurred while deleting a department.");
					ModelState.AddModelError(string.Empty, ex.Message);
					var department = _employeeService.GetEmployeeById(id);
					return View(department);
				}
				else
				{
					_logger.LogError(ex, "Error occurred while deleting a department.");
					ModelState.AddModelError(string.Empty, "An error occurred while processing your request. Please try again later.");
					var department = _employeeService.GetEmployeeById(id);
					return View(department);
				}
			}

		}
		#endregion


	}
}
