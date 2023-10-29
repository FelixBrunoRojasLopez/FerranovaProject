using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class EmpleadoRequest
    {
        public int IdEmpleado { get; set; }
        public int IdCargo { get; set; }
        public bool IdEstado { get; set; }
        public int IdPersona { get; set; }

    }
}
