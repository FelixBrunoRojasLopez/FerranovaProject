using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class MenuRolResponse
    {
        public int IdMenuRol { get; set; }
        public int IdRol { get; set; }
        public bool IdEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int IdMenu { get; set; }
    }
}
