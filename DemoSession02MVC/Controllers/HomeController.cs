using Microsoft.AspNetCore.Mvc;

namespace DemoSession02MVC.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
