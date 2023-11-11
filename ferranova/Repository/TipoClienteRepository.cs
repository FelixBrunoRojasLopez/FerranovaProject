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
    public class TipoClienteRepository : CRUDRepository<TipoCliente>, ITipoClienteRepository
    {
        public GenericFilterResponse<TipoCliente> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<TipoCliente> InsertMultiple(List<TipoCliente> tipoClientes)
        {
            throw new NotImplementedException();
        }
    }
}
