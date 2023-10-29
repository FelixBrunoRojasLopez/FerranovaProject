using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MetodoPagoRepository : CRUDRepository<MetodoPago>, IMetodoPagoRepository
    {
        public List<MetodoPago> InsertMultiple(List<MetodoPago> metodoPagos)
        {
            throw new NotImplementedException();
        }
    }
}
