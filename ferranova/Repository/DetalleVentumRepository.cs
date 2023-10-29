using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DetalleVentumRepository : CRUDRepository<DetalleVentum>, IDetalleVentumRepository
    {
        public List<DetalleVentum> InsertMultiple(List<DetalleVentum> detalleVentums)
        {
            throw new NotImplementedException();
        }
    }
}
