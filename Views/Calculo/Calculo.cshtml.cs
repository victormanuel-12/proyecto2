using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace contagto.Views.Calculo
{
    public class Calculo : PageModel
    {
        private readonly ILogger<Calculo> _logger;

        public Calculo(ILogger<Calculo> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}