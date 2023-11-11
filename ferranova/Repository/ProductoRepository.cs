using BDFerranova;
using IRepository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductoRepository : CRUDRepository<Producto>, IProductoRepository
    {
        public IQueryable<ProductoResponse> Consultar()
        {
            throw new NotImplementedException();
        }

        public GenericFilterResponse<Producto> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<Producto> InsertMultiple(List<Producto> productos)
        {
            throw new NotImplementedException();
        }
    }
}
