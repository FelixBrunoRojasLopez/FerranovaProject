using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IRolRepository : ICRUDRepository<Rol>
    {
        Rol GetByID(int id);
        List<Rol> InsertMultiple(List<Rol> rols);
    }
}
