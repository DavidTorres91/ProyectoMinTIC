using System;
using AplicacionWebG3.Dominio;
using AplicacionWebG3.Persistencia;

namespace AplicacionWebG3.Consola
{
    public class Program
    {
        private static ITipoDocumentoRepository _tipoDocumentoRepository = new TipoDocumentoRepository(new AplicacionWebG3.Persistencia.AppC());
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenido:");
            var tipoDocumento = new TipoDocumento{
                Nombre = "Cedula"
            };  
            var result = _tipoDocumentoRepository.Add(tipoDocumento);

            if (result > 0) {
                Console.WriteLine("Se inserto Correctamente");
            }else
            {
               Console.WriteLine("no se inserto Correctamente"); 
            }

        }
    }
}

