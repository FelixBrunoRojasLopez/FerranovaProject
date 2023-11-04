using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness
{
    public interface IPersonaBusiness : ICRUDBusiness<PersonaRequest, PersonaResponse>
    {
    TipoDocumentoFilterResponse ObtenerPorFiltro(TipoDocumentoFilterRequest request);
    }
}
