using System;

namespace AplicacionWebG3.Dominio
{
    public class Profesional 
    {
      public int Id {get; set;}
      public string Especialidad {get; set;}
      public string Calendario {get; set;}
      public string NumLicencia {get; set;}
      public DateTime expLicencia {get; set;}
      public string Nombre {get; set;}
      public string Apellido {get; set;}
      public DateTime FechaNacimiento {get; set;}
      public string Direccion {get; set;}
      public SisPago SisPago {get; set;}

      public TipoDocumento TipoDocumento {get; set;}
      public Genero Genero {get; set;}

      public Contacto Contacto {get; set;}


    
    }
}

