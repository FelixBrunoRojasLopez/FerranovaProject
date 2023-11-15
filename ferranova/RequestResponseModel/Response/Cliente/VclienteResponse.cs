using RequestResponseModel.Response.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Cliente
{
    public class VclienteResponse
    {
        public string Message { get; set; } = "";
        public List<ListClienteResponse> Cliente { get; set; } = new();
    }
}
