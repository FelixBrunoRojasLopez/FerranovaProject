using RequestResponseModel.Request.Cliente;
using RequestResponseModel.Response.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.TB_Cliente
{
    public interface IVClienteBusiness : ICRUDBusiness<VclienteRequest,VclienteResponse>
    {
    }
}
