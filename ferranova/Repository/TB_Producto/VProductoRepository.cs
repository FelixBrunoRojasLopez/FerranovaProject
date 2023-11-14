using BDFerranova;
using IRepository.TB_Producto;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.TB_Producto
{
    public class VProductoRepository : CRUDRepository<Vproducto>, IVProductoRepository
    {
        public GenericFilterResponse<Vproducto> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
