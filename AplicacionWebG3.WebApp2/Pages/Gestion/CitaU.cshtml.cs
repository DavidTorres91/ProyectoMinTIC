using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AplicacionWebG3.WebApp2.Pages.Gestion
{
    public class CitaU : PageModel
    {
        private readonly ILogger<CitaU> _logger;

        public CitaU(ILogger<CitaU> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}