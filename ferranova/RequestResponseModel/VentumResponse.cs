using BDFerranova;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class VentumResponse
    {
       // public int IdUsuario { get; set; }
        //public int IdCliente { get; set; }
       // public int IdTipoComprobante { get; set; }
        public int IdVenta { get; set; }
        public DateTime? FechaVenta { get; set; }
        public int IdMetodopago { get; set; }
        public string? NumeroDocumento { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FechaRegistro { get; set; }
        //public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();


    }
}
