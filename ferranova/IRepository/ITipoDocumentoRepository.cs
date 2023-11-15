using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface ITipoDocumentoRepository : ICRUDRepository<TipoDocumento>
    {
        TipoDocumento BuscarDetalle(string? descripcion);
        List<TipoDocumento> InsertMultiple(List<TipoDocumento> tipoDocumentos);
    }
}
