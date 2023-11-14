using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDFerranova;

namespace RequestResponseModel
{
    public class DetalleVentumRequest
    {
        public int IdProducto { get; set; }
        public int IdDetalleVenta { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Total { get; set; }
        //public virtual Producto? idProductoNavigation { get; set; }
        //public virtual Ventum? IdVentaNavigation { get; set; }
        //public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
        //public int IdVenta { get; set; }
        //public decimal? Descuento { get; set; }
    }
}
