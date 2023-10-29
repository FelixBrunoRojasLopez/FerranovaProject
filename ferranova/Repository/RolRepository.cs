using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RolRepository : CRUDRepository<Rol>, IRolRepository
    {
        public Rol GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rol> InsertMultiple(List<Rol> rols)
        {
            throw new NotImplementedException();
        }
    }
}
