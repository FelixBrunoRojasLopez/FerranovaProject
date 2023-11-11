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
    public class DetalleVentumRepository : CRUDRepository<DetalleVentum>, IDetalleVentumRepository
    {
        public IQueryable<DetalleVentumResponse> Consultar()
        {
            throw new NotImplementedException();
        }

        public GenericFilterResponse<DetalleVentum> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<DetalleVentum> InsertMultiple(List<DetalleVentum> detalleVentums)
        {
            throw new NotImplementedException();
        }
    }
}
