using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TipoClienteRepository : CRUDRepository<TipoCliente>, ITipoClienteRepository
    {
        public List<TipoCliente> InsertMultiple(List<TipoCliente> tipoClientes)
        {
            throw new NotImplementedException();
        }
    }
}
