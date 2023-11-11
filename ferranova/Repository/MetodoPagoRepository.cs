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
    public class MetodoPagoRepository : CRUDRepository<MetodoPago>, IMetodoPagoRepository
    {
        public GenericFilterResponse<MetodoPago> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<MetodoPago> InsertMultiple(List<MetodoPago> metodoPagos)
        {
            throw new NotImplementedException();
        }
    }
}
