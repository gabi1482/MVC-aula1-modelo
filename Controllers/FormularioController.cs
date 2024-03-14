using Microsoft.AspNetCore.Mvc;
using MVC_aula1.Models;
using System.Diagnostics;

namespace MVC_aula1.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



    }
}