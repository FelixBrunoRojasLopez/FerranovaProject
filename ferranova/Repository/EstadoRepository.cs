using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EstadoRepository : CRUDRepository<Estado>, IEstadoRepository
    {
        public List<Estado> InsertMultiple(List<Estado> estados)
        {
            throw new NotImplementedException();
        }
    }
}
