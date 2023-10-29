using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PedidoRepository : CRUDRepository<Pedido>, IPedidoRepository
    {
        public List<Pedido> InsertMultiple(List<Pedido> pedidos)
        {
            throw new NotImplementedException();
        }
    }
}
