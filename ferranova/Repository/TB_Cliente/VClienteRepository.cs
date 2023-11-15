using BDFerranova;
using IRepository.TB_Cliente;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.TB_Cliente
{
    public class VClienteRepository : CRUDRepository<Vcliente>, IVClienteRepository
    {
        public GenericFilterResponse<Vcliente> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
