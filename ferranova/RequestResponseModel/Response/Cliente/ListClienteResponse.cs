using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Cliente
{
    public class ListClienteResponse
    {
        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Descripcion { get; set; }
        public string? NroDocumento { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
    }
}
