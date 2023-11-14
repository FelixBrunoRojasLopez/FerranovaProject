using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Productos
{
    public class VProductoResponse
    {
        public string Message { get; set; } = "";
        public List<ListProductoResponse> Producto { get; set; } = new();
    }
}
