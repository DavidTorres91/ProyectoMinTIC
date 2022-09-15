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

        Persona IPersonaRepository.Getpersona (int idPersona)
        {
            return  _appContext.personas.FirstOrDefault(p => p.Id == idPersona);
        }

        Persona IPersonaRepository.Update(Persona persona)
        {
            var persoEncontrada = _appContext.personas.FirstOrDefault(p => p.Id == persona.Id);
            if(persoEncontrada != null)
            {
                persoEncontrada.Nombre = persona.Nombre;
                persoEncontrada.Apellido = persona.Apellido;
                persoEncontrada.Contacto = persona.Contacto;
                persoEncontrada.Direccion = persona.Direccion;
                persoEncontrada.FechaNacimiento = persona.FechaNacimiento;
                persoEncontrada.Genero = persona.Genero;
                persoEncontrada.SisPago = persona.SisPago;
                persoEncontrada.TipoDocumento = persona.TipoDocumento;
                
                _appContext.SaveChanges();
      
        }
        return persoEncontrada;


    
    }
}
}