using DemoSession02MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession02MVC.Controllers
{
	public class MoviesController : Controller
	{
		public IActionResult Index(int? id)
		{
			return Content($"id: {id}");
		}
		[HttpGet]
		public IActionResult GetMovie(int? id, string name) {
			//if id =0 => return BadRequest
			//if id <10 => return NotFound
			//else return Content with id and name
			if (id==0)
			{
				return BadRequest();
			}
			else if (id<10)
			{
				return NotFound();
			}
			else
			{
				return Content($"id: {id}, name: {name}");
			}
		}
		[HttpGet]
		public IActionResult TestRedirectToAction() {
			return RedirectToAction("GetMovie", new { id = 20, name = "test" }); // in same controller
			// return RedirectToAction("GetMovie", "Movies", new { id = 20, name = "test" }); // in different controller
			//return Redirect("https://www.amazon.eg/s?k=amazon&language=ar_AE&adgrpid=148220656974&hvadid=672482619551&hvdev=c&hvlocphy=9112515&hvnetw=g&hvqmt=e&hvrand=17841929143986539143&hvtargid=kwd-10573980&hydadcr=1513_2304420");
		}
		[HttpPost]
		public IActionResult TestModelBinding([FromRoute]int? id,[FromQuery] string name) {
			return Content($"id: {id}, name: {name}");
		}
		[HttpGet]
		public IActionResult AddMovie(movie movie,int? id,string name, int[] arr ) {
			if (movie is null)
			{
				return BadRequest();
			}
			else
			{
				return Content($"id: {movie.Id}, title: {movie.Title}");
			}
		}


	}
}
