using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface ITipoClienteRepository : ICRUDRepository<TipoCliente>
    {
        List<TipoCliente> InsertMultiple(List<TipoCliente> tipoClientes);
    }
}
