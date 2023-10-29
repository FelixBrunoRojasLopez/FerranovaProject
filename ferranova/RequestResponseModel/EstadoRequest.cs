using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class EstadoRequest
    {
        public bool IdEstado { get; set; }
        [StringLength(50)]
        public string? DecripcionEstado { get; set; }
    }
}
