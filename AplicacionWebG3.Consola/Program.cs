using System;
using AplicacionWebG3.Dominio;
using AplicacionWebG3.Persistencia;
namespace AplicacionWebG3.Consola
{
    public class Program
    {
        private static ITipoDocumentoRepository _tipoDocumentoRepository = new TipoDocumentoRepository(new AplicacionWebG3.Persistencia.AppC());
        private static IPersonaRepository _personaRepository = new PersonaRepository(new AplicacionWebG3.Persistencia.AppC());
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenido:");
            var tipoDocumento = new TipoDocumento{
                Nombre = "tarjeta"
            };  
            var result = _tipoDocumentoRepository.Add(tipoDocumento);

            if (result > 0) {
                Console.WriteLine("Se inserto Correctamente");
            }else
            {
               Console.WriteLine("no se inserto Correctamente"); 
            }
            AddPer();

        }

        public static void AddPer(){
            var persona = new Persona 
            {
                Nombre = "jhoana",
                Apellido = "martinez",
                Direccion = "calle 3 # 24483",
                FechaNacimiento = "10-09-2000",
                Genero = Genero.Femenino


            };
            _personaRepository.Add(persona);
        }
    }
}

