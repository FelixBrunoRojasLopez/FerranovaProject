using RequestResponseModel.Request.Venta;
using RequestResponseModel.Response.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.TB_Venta
{
    public interface IVVentaBusiness : ICRUDBusiness<VVentaRequest,VVentaResponse>
    {
    }
}
