using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ProveedorResponse
    {
        public int IdProveedor { get; set; }
        [StringLength(15)]
        public string? Ruc { get; set; }
        public int IdPersona { get; set; }
    }
}
