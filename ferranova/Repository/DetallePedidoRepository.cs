using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DetallePedidoRepository : CRUDRepository<DetallePedido>, IDetallePedidoRepository
    {
        public List<DetallePedido> InsertMultiple(List<DetallePedido> detallePedidos)
        {
            throw new NotImplementedException();
        }
    }
}
