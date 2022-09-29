
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AplicacionWebG3.Persistencia;
using AplicacionWebG3.Dominio;



namespace AplicacionWebG3.WebApp
{
    public class CrearProModel : PageModel
    {
        private IProfesionalRepository _profesionalRepository = new ProfesionalRepository( new AplicacionWebG3.Persistencia.AppC());

        public void OnGet()
        {
        }

        public void OnPost(){
            var nombre = Request.Form["nombre"];
            var apellido= Request.Form["apellido"];
            var direccion = Request.Form["direccion"];
            var genero = Request.Form["genero"];
            var discriminador = Request.Form["discriminador"];

            var profesional = new Profesional{
                Nombre = nombre,
                Apellido = apellido,
                Direccion = direccion,
                Genero = (genero == 0 ? Genero.Masculino : Genero.Femenino),
                //Discriminator = discriminador
            };

            var result = _profesionalRepository.Add(profesional);
            if(result >0){
                Console.WriteLine("Se inserto correctamente");
            }else{
                Console.WriteLine("no se inserto");

            }
        }


    }
}
