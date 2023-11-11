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
    public class EstadoRepository : CRUDRepository<Estado>, IEstadoRepository
    {
        public GenericFilterResponse<Estado> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<Estado> InsertMultiple(List<Estado> estados)
        {
            throw new NotImplementedException();
        }
    }
}
