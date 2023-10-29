using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IProveedorRepository : ICRUDRepository<Proveedor>
    {
        List<Proveedor> InsertMultiple(List<Proveedor> proveedors);
    }
}
