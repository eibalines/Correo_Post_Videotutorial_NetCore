using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Correo_Post_Videotutorial_NetCore.Controllers
{
    public class CorreosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string destinatario, string asunto, string mensaje)
        {
            ViewData["MENSAJE"] = "Mensaje enviado a <span style='color:red'>"+ destinatario + "</span>";
            return View();
        }
    }
}
