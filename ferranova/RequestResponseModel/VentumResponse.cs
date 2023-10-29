using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class VentumResponse
    {
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public DateTime? FechaVenta { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? CostoVenta { get; set; }
        public int IdTipoComprobante { get; set; }
        public int IdMetodopago { get; set; }
    }
}
