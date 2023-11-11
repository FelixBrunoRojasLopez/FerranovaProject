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
    public class DetalleProductoRepository : CRUDRepository<DetalleProducto>, IDetalleProductoRepository
    {
        public GenericFilterResponse<DetalleProducto> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<DetalleProducto> InsertMultiple(List<DetalleProducto> detalleProductos)
        {
            throw new NotImplementedException();
        }
    }
}
