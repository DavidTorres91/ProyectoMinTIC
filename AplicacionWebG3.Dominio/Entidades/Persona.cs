using System;

namespace AplicacionWebG3.Dominio
{
    public class Persona
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string FechaNacimiento {get; set;}
        public string Direccion {get; set;}
        public SisPago SisPago {get; set;}

        public TipoDocumento TipoDocumento {get; set;}
        public Genero Genero {get; set;}

        public Contacto Contacto {get; set;}
 

    
    }
}