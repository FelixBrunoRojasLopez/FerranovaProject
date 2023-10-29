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
    public class DetalleVentumResponse
    {

        public int IdProducto { get; set; }
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Total { get; set; }
    }
}
