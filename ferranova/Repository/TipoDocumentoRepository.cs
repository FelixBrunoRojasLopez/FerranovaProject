using BDFerranova;
using IRepository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TipoDocumentoRepository : CRUDRepository<TipoDocumento>, ITipoDocumentoRepository
    {
        public TipoDocumento BuscarDetalle(string? descripcion)
        {

#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            TipoDocumento tipoDocumento = db.TipoDocumentos.Where(x => x.Descripcion == descripcion).FirstOrDefault();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return tipoDocumento;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }

        public GenericFilterResponse<TipoDocumento> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<TipoDocumento> InsertMultiple(List<TipoDocumento> tipoDocumentos)
        {
            throw new NotImplementedException();
        }
    }
}
