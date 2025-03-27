using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using contagto.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace contagto.Controllers
{
    
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
       private readonly UserManager<IdentityUser> _userManager;// me permite acceder a los usuarios de la base de datos

    public CustomerController(ILogger<CustomerController> logger, UserManager<IdentityUser> userManager)
    {
      _logger = logger;
      _userManager = userManager;
    }
    

        public IActionResult Index()
        {
          var userName = _userManager.GetUserName(User);// obtiene el nombre de usuario del usuario autenticado
          Customer customer= new Customer(); // crea una nueva instancia de la clase Customer
          customer.UserName = userName ?? "Unknown"; // asigna el nombre de usuario o un valor predeterminado a la propiedad UserName de la clase Customer
            return View(customer); // devuelve la vista Index con el modelo customer
        }
        public IActionResult RegistrarInfo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}