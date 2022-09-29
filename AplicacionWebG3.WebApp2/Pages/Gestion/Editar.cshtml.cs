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
        public Persona persona;

       public IActionResult OnGet(int Id)
        {
            persona = _personaRepository.Buscar(Id);

            if(persona == null){
                return RedirectToPage("listado");
            }else{
                return Page();
            }
        }

        public IActionResult OnPost(){

           
            var id = Request.Form["Id"];
            var nombre = Request.Form["nombre"];
            var apellido = Request.Form["apellido"];
            var direccion = Request.Form["direccion"];
            var genero = Request.Form["genero"];
            
            
            var personaResult = _personaRepository.Buscar(Int32.Parse(id));

            if( personaResult != null){

                personaResult.Nombre = nombre;
                personaResult.Apellido = apellido;
                personaResult.Direccion = direccion;
                personaResult.Genero = (genero == "0") ? Genero.Masculino : Genero.Femenino;
            
                var result = _personaRepository.Update(personaResult);

                if( result > 0){

                    
                    ViewData["mensaje"] = "Se actualizo correctamente";
                }else{

                    
                    ViewData["mensaje"] = "No se pudo actualizar";
                }

            }else{
                ViewData["mensaje"] = "La persona a actualizar no existe";
            }

            return RedirectToPage("listado");
            
        }
    }
}
