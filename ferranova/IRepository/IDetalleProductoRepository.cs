using BDFerranova;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IDetalleProductoRepository : ICRUDRepository<DetalleProducto>
    {
        List<DetalleProducto> InsertMultiple(List<DetalleProducto> detalleProductos);
        DetalleProducto BuscarDetalle(string nameDetalle);
    }
}
