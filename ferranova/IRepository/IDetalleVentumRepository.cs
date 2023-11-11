using BDFerranova;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IDetalleVentumRepository : ICRUDRepository<DetalleVentum>
    {
        IQueryable<DetalleVentumResponse> Consultar();
        List<DetalleVentum> InsertMultiple(List<DetalleVentum> detalleVentums);
    }
}
