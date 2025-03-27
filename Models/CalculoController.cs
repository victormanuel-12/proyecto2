using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using contagto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace contagto.Controllers
{
    
    public class CalculoController : Controller
    {
        private readonly ILogger<CalculoController> _logger;

        public CalculoController(ILogger<CalculoController> logger)
        {
            _logger = logger;
        }

    [HttpGet]
    public IActionResult Calculo()
    {

      return View();
    }

    [HttpPost]
   public IActionResult Calculo(Calculo calc)
{
   _logger.LogInformation("Operacion: {0}, Numero1: {1}, Numero2: {2}", 
        calc.Operacion, calc.Numero1, calc.Numero2);
    if (ModelState.IsValid)
      {
        string mensaje = "";
        try
        {
          mensaje = $"resultado es : {calc.Calcular()}";
        }
        catch (DivideByZeroException)
        {
          mensaje = "No se puede dividir por cero";
        }
        catch (Exception)
        {
          mensaje = "Error en la operación";
        }
        ViewData["Resultado"] = mensaje;
      }
    return View();
}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}