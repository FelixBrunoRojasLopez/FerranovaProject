using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness
{
    public interface ITipoDocumentoBusiness : ICRUDBusiness<TipoDocumentoRequest, TipoDocumentoResponse>
    {
        TipoDocumentoResponse BuscarDetalle(string? descripcion);
    }
}
