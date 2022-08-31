using System;
using AplicacionWebG3.Dominio;

namespace AplicacionWebG3.Persistencia
{
    public interface ITipoDocumentoRepository
    {
        int Add(TipoDocumento tipoDocumento);
    }
}