using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TipoPersonaRepository : CRUDRepository<TipoPersona>, ITipoPersonaRepository
    {
        public List<TipoPersona> InsertMultiple(List<TipoPersona> tipoPersonas)
        {
            throw new NotImplementedException();
        }
    }
}
