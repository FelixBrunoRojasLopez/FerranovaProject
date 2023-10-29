using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VentumRepository : CRUDRepository<Ventum>, IVentumRepository
    {
        public List<Ventum> InsertMultiple(List<Ventum> ventums)
        {
            throw new NotImplementedException();
        }
    }
}
