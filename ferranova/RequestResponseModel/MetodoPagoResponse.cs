using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class MetodoPagoResponse
    {
        public int IdMetodopago { get; set; }
        [StringLength(50)]
        public string? NombreMetodoPago { get; set; } = "";
    }
}
