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
        public IActionResult Index(string destinatario, string asunto, string mensaje)
        {
            this.helpermail.SendMail(destinatario, asunto, mensaje);
            ViewData["MENSAJE"] = "Mensaje enviado a '" + destinatario + "'";
            return View();
        }
    }
}
