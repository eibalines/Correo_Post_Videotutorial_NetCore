using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Correo_Post_Videotutorial_NetCore.Models;
using Correo_Post_Videotutorial_NetCore.Helpers;

namespace Correo_Post_Videotutorial_NetCore.Controllers
{
    public class CorreosController : Controller
    {
        private HelperMail helpermail;
        public CorreosController(HelperMail helpermail)
        {
            this.helpermail = helpermail;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string receptor, string asunto, string texto)
        {
            string mensajefinal = "<h1>Proyecto Techclub Tajamar(MVC NetCore Correos)<h1/><h4>" + texto + " <h4/>"
                                    ; 
            this.helpermail.SendMail(receptor, asunto, mensajefinal);
            ViewData["MENSAJE"] = "Mensaje enviado a '" + receptor + "'";
            return View();
        }
    }
}
