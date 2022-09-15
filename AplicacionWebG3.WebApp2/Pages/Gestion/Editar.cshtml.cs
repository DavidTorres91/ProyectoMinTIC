using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AplicacionWebG3.Dominio;
using AplicacionWebG3.Persistencia;


namespace AplicacionWebG3.WebApp2.Pages.Gestion
{
    public class Editar : PageModel
    
    {
        private static IPersonaRepository _personaRepository = new PersonaRepository( new AplicacionWebG3.Persistencia.AppC() );
        public Persona persona = new Persona();
        public void OnGet(int Id)
        {
         persona = _personaRepository.Buscar(Id);
        }
    }
}