using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IDetalleVentumRepository : ICRUDRepository<DetalleVentum>
    {
        List<DetalleVentum> InsertMultiple(List<DetalleVentum> detalleVentums);
    }
}
