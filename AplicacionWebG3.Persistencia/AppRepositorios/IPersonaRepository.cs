using System;
using System.Collections.Generic;
using AplicacionWebG3.Dominio;


namespace AplicacionWebG3.Persistencia
{
    public interface IPersonaRepository
    {
        int Add(Persona persona);
        IEnumerable<Persona> GetAllPersonas();
        Persona Update(Persona persona);
        Persona Buscar(int id);

        int Delete(Persona persona);
        
        Persona Getpersona (int idPersona);



    }
}