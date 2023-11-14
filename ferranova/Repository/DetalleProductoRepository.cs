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
        public DetalleProducto BuscarDetalle(string nameDetalle)
        {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            DetalleProducto producto = db.DetalleProductos.Where(x => x.Descripcion == nameDetalle).FirstOrDefault();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return producto;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }

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
