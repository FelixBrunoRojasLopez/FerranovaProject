using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Productos
{
    public class ListProductoResponse
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? Stock { get; set; }
        public decimal? Precio { get; set; }
        public bool? IdEstado { get; set; }
    }
}
