using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DetalleProductoRequest
    {
        public int IdDetalleProducto { get; set; }
        public string? Descripcion { get; set; }
    }
}
