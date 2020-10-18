using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EXAMEN.Models;

namespace EXAMEN.Controllers
{
    public class BonoController : Controller
    {

       private readonly ILogger<BonoController> _logger;

        public BonoController(ILogger<BonoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Bono objContacto){
            if (ModelState.IsValid)
            {
                objContacto.Response = "Fue guardado  con  exito";
            }
            return View("index", objContacto);
        }

    }
}