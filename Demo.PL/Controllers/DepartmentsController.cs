using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
	public class DepartmentsController : Controller
	{
		public DepartmentsController()
		{
			// call the service
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
