using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductoRepository : CRUDRepository<Producto>, IProductoRepository
    {
        public List<Producto> InsertMultiple(List<Producto> productos)
        {
            throw new NotImplementedException();
        }
    }
}
