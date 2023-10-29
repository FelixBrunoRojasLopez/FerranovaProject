using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IMetodoPagoRepository : ICRUDRepository<MetodoPago>
    {
        List<MetodoPago> InsertMultiple(List<MetodoPago> metodoPagos);
    }
}
