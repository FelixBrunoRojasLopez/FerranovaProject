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
    public class TipoComprobanteRepository : CRUDRepository<TipoComprobante>, ITipoComprobanteRepository
    {
        public GenericFilterResponse<TipoComprobante> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<TipoComprobante> InsertMultiple(List<TipoComprobante> tipoComprobantes)
        {
            throw new NotImplementedException();
        }
    }
}
