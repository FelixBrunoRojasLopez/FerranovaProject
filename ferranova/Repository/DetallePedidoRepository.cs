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
    public class DetallePedidoRepository : CRUDRepository<DetallePedido>, IDetallePedidoRepository
    {
        public GenericFilterResponse<DetallePedido> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<DetallePedido> InsertMultiple(List<DetallePedido> detallePedidos)
        {
            throw new NotImplementedException();
        }
    }
}
