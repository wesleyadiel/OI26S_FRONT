using Microsoft.AspNetCore.Mvc;
using NextSerie.Models;
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

        [Route("login/validar")]
        [HttpPost]
        public IActionResult ValidarLogin(LoginViewModel model)
        {
            if (String.IsNullOrEmpty(model.Email))
            {
                model.ErrorMessage = "Email não informado.";
                return View("Login", model);
            }

            if (String.IsNullOrEmpty(model.Senha))
            {
                model.ErrorMessage = "Senha não informada.";
                return View("Login", model);
            }

            if ("admin@nextserie.com".Equals(model.Email) && "admin".Equals(model.Senha))
            {
                return View("Home");
            }

            model.ErrorMessage = "Email ou senha inválido.";
            return View("Login", model);

        }

        [Route("login/index")]
        public IActionResult Index(LoginViewModel model)
        {
            ModelState.Clear();

            return View("Login", model);
        }
    }
}
