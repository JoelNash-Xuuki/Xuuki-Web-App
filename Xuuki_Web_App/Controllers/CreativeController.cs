using System; 
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCreative.Models;

using System.Text.Encodings.Web;

namespace MvcCreative.Controllers
{
    public class CreativeController : Controller
    {
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Welcome(string name, int numTimes = 1)
		{
			ViewData["Message"] = "Hello " + name;
			ViewData["NumTimes"] = numTimes;

			return View();
		} 
	}
}
