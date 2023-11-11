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
    public class PedidoRepository : CRUDRepository<Pedido>, IPedidoRepository
    {
        public GenericFilterResponse<Pedido> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> InsertMultiple(List<Pedido> pedidos)
        {
            throw new NotImplementedException();
        }
    }
}
