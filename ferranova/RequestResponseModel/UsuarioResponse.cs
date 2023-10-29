using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class UsuarioResponse
    {
        public int IdUsuarioAcceso { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int IdEmpleado { get; set; }
        public bool? ChangePassword { get; set; }
        public string? Correo { get; set; }
        public int IdRol { get; set; }
        public string? CelularIdentificador { get; set; }
        public bool IdEstado { get; set; }
        public int CreaUsuario { get; set; }
        public int ActualizaUsuario { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeActulizacion { get; set; }
    }
}
