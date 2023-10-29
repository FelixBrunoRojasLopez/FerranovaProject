using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IEstadoRepository : ICRUDRepository<Estado>
    {
        List<Estado> InsertMultiple(List<Estado> estados);
    }
}
