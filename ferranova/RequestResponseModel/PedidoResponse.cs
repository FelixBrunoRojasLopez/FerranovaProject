using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class PedidoResponse
    {
        public int IdPedidos { get; set; }
        public DateTime FechaEntrega { get; set; }
        public TimeSpan? Hora { get; set; }
        [StringLength(100)]
        public string? Descripcion { get; set; }
        public int IdCliente { get; set; }
        public short? Cantidad { get; set; }
    }
}
