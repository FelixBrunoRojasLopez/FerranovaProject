using BDFerranova;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DetallePedidoRequest
    {
        public int IdProducto { get; set; }
        public int IdPedidos { get; set; }
        public int IdDetallePedido { get; set; }
        
    }
}
