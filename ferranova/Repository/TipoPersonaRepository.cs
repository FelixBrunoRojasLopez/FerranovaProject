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
    public class TipoPersonaRepository : CRUDRepository<TipoPersona>, ITipoPersonaRepository
    {
        public GenericFilterResponse<TipoPersona> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<TipoPersona> InsertMultiple(List<TipoPersona> tipoPersonas)
        {
            throw new NotImplementedException();
        }
    }
}
