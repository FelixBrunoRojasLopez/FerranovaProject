using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class UsuarioLoginResponse
    {
        public int IdUsuarioAcceso { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int IdEmpleado { get; set; }
        public bool? ChangePassword { get; set; }
        public string? Correo { get; set; }
        public string? CelularIdentificador { get; set; }
        public bool IdEstado { get; set; }

    }
}
