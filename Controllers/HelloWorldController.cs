using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Cadastro.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int NumTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = NumTimes;

            return View();
        }
    }
}
