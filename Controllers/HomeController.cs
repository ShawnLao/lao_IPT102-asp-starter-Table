using Lao_IPT102_Starters_Tables_10_10_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lao_IPT102_Starters_Tables_10_10_2023.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly List<lao_CivlianInfoModel> _lao_CivilInfos;
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;

			_lao_CivilInfos = new List<lao_CivlianInfoModel>
			{
				new lao_CivlianInfoModel{civilian_Firstname = "Shawn Angelo", civilian_Lastname = "Lao", civilian_MiddleInitial = "D.", civilian_PhoneNumber = "+63(2)7270944"},
				new lao_CivlianInfoModel{civilian_Firstname = "Roland", civilian_Lastname = "Lao", civilian_MiddleInitial = "D.", civilian_PhoneNumber = "+63(2)7270944"},
				new lao_CivlianInfoModel{civilian_Firstname = "Tyron Clarence", civilian_Lastname = "Lao", civilian_MiddleInitial = "D.", civilian_PhoneNumber = "+63(2)7270944"},
				new lao_CivlianInfoModel{civilian_Firstname = "Samantha Nicole", civilian_Lastname = "Naces", civilian_MiddleInitial = "D.", civilian_PhoneNumber = "+63(2)7270944"},
				new lao_CivlianInfoModel{civilian_Firstname = "Liand Jenaz", civilian_Lastname = "Lao", civilian_MiddleInitial = "D.", civilian_PhoneNumber = "+63(2)7270944"},
				new lao_CivlianInfoModel{civilian_Firstname = "Karl Vincent", civilian_Lastname = "Lao", civilian_MiddleInitial = "D.", civilian_PhoneNumber = "+63(2)7270944"},
			};
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}


		public IActionResult lao_CivilianInfosTable()
		{



			//Displays the table views
			return View(_lao_CivilInfos);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}