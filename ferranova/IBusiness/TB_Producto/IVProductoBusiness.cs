using RequestResponseModel.Request.Productos;
using RequestResponseModel.Response.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.TB_Producto
{
    public interface IVProductoBusiness : ICRUDBusiness<VProductoRequest,VProductoResponse>
    {
    }
}
