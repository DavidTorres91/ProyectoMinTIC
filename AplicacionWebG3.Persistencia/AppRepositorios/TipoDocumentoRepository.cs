using System;
using AplicacionWebG3.Dominio;



namespace AplicacionWebG3.Persistencia
{
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        private readonly AppC _appContext;
        public TipoDocumentoRepository(AppC Context){
            _appContext = Context;

        }

    
        int ITipoDocumentoRepository.Add(TipoDocumento tipoDocumento){
            var TipoDoc = _appContext.TipoDocumentos.Add(tipoDocumento);
            var result = _appContext.SaveChanges();
            return result;

            

        }
    }
}