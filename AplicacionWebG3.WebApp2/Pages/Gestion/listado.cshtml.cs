using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AplicacionWebG3.Persistencia;
using AplicacionWebG3.Dominio;

namespace AplicacionWebG3.WebApp2.Pages.Gestion
{
    public class listado : PageModel
 
    {
        private static IPersonaRepository _personaRepository = new PersonaRepository( new AplicacionWebG3.Persistencia.AppC() );
        public IEnumerable<Persona> listaPersonas;

        public void OnGet()
        {
            listaPersonas = _personaRepository.GetAllPersonas();
        }
    }

}