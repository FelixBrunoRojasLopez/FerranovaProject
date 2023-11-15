using RequestResponseModel.Response.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Venta
{
    public class VVentaResponse
    {
        public string Message { get; set; } = "";
        public List<ListVentaResponse> Venta { get; set; } = new();
    }
}
