using BDFerranova;
using IRepository;
using IRepository.TB_Venta;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.TB_Venta
{
    public class VVentaRepository : CRUDRepository<Vventum>, IVVentaRepository
    {
        

        GenericFilterResponse<Vventum> ICRUDRepository<Vventum>.GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
