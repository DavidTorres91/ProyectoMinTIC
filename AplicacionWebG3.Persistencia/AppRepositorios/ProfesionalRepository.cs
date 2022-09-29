using System;
using System.Linq;
using System.Collections.Generic;
using AplicacionWebG3.Dominio;



namespace AplicacionWebG3.Persistencia
{
    public class ProfesionalRepository : IProfesionalRepository
    {
        private readonly AppC _appContext;
        public ProfesionalRepository(AppC Context){
            _appContext = Context;

        }

    
        int IProfesionalRepository.Add(Profesional profesional){
            var Prof = _appContext.Profesionales.Add(profesional);
            var result = _appContext.SaveChanges();
            return result;
            }

        Profesional IProfesionalRepository.Buscar(int id){
            return _appContext.Profesionales.Find(id);
        }

        int IProfesionalRepository.Delete(Profesional profesional){
            _appContext.Profesionales.Remove(profesional);
            return _appContext.SaveChanges();

            }
        IEnumerable<Profesional> IProfesionalRepository.GetAllProfesional()
        {
            return _appContext.Profesionales;

        }
        
        int IProfesionalRepository.Update(Profesional profesional){
            _appContext.Profesionales.Update(profesional);
            return _appContext.SaveChanges();
        }


    
    }
}
