using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface ITipoPersonaRepository : ICRUDRepository<TipoPersona>
    {
        List<TipoPersona> InsertMultiple(List<TipoPersona> tipoPersonas);
    }
}
