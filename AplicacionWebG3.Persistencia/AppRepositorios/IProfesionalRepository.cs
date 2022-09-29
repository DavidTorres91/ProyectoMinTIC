using System;
using System.Collections.Generic;
using AplicacionWebG3.Dominio;


namespace AplicacionWebG3.Persistencia
{
    public interface IProfesionalRepository
    {
        int Add(Profesional profesional);
        IEnumerable<Profesional> GetAllProfesional();
        int Update(Profesional profesional);
        Profesional Buscar(int id);

        int Delete(Profesional profesional);
        
     


    }
}