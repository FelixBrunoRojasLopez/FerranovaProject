using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Venta
{
    public class ListVentaResponse
    {
        public int IdV { get; set; }
        public string? NroDoc { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NroDocumento { get; set; }
        public string? NombreMetodoPago { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FechaVenta { get; set; } = DateTime.MinValue;
    }
}
