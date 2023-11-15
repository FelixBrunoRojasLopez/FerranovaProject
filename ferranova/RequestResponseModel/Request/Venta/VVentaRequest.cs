using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Venta
{
    public class VVentaRequest
    {
        public int IdV { get; set; }
        public string? NroDoc { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NroDocumento { get; set; }
        public string? NombreMetodoPago { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FechaVenta { get; set; }
    }
}
