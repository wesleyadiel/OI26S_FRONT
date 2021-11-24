using Microsoft.AspNetCore.Mvc;
using NextSerie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextSerie.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin(LoginModel model)
        {
            for (int i = 0; i<1000; i++)
            {
                Console.WriteLine("claaaa");
            }

            return null;
        }
    }
}
