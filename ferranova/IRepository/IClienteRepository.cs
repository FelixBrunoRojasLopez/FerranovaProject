using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IClienteRepository : ICRUDRepository<Cliente>
    {
        List<Cliente> InsertMultiple(List<Cliente> clientes);
    }
}
