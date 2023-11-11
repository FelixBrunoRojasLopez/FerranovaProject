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
    public class RolRepository : CRUDRepository<Rol>, IRolRepository
    {
        public GenericFilterResponse<Rol> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

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
