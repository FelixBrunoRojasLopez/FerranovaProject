using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IVentumRepository : ICRUDRepository<Ventum>
    {
        List<Ventum> InsertMultiple(List<Ventum> ventums);
        //Task<Ventum> Registrar(Ventum ventum);
    }
}
