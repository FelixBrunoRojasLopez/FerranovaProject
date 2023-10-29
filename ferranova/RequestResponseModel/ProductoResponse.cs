using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ProductoResponse
    {
        public int IdProducto { get; set; }
        public int IdDetalleProducto { get; set; }
        public short? Stock { get; set; }
        public decimal? Precio { get; set; }
        [StringLength(50)]
        public string? Nombre { get; set; }
        public byte[]? Imagen { get; set; }
    }
}
