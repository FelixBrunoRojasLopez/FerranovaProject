using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IDetallePedidoRepository : ICRUDRepository<DetallePedido>
    {
        List<DetallePedido> InsertMultiple(List<DetallePedido> detallePedidos);
    }
}
