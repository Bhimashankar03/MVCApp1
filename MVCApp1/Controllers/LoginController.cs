using Microsoft.AspNetCore.Mvc;

namespace MVCApp1.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
