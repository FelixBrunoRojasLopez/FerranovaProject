using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class RolResponse
    {
        public int IdRol { get; set; }
        [StringLength(7)]
        public string? Codigo { get; set; }
        [StringLength(255)]
        public string? Descripcion { get; set; }
        [StringLength(100)]
        public string? Funcion { get; set; }
        public bool IdEstado { get; set; }
    }
}
