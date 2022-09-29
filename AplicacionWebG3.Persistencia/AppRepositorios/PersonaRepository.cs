using System;
using System.Linq;
using System.Collections.Generic;
using AplicacionWebG3.Dominio;



namespace AplicacionWebG3.Persistencia
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly AppC _appContext;
        public PersonaRepository(AppC Context){
            _appContext = Context;

        }

    
        int IPersonaRepository.Add(Persona persona){
            var Perso = _appContext.personas.Add(persona);
            var result = _appContext.SaveChanges();
            return result;
            }

        Persona IPersonaRepository.Buscar(int id){
            return _appContext.personas.Find(id);
        }

        int IPersonaRepository.Delete(Persona persona){
            _appContext.personas.Remove(persona);
            return _appContext.SaveChanges();

            }
        IEnumerable<Persona> IPersonaRepository.GetAllPersonas()
        {
            return _appContext.personas;

        }
        
        int IPersonaRepository.Update(Persona persona){
            _appContext.personas.Update(persona);
            return _appContext.SaveChanges();
        }


    
    }
}
