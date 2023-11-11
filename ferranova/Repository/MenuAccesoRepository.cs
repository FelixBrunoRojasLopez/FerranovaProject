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
    public class MenuAccesoRepository : CRUDRepository<MenuAcceso>, IMenuAccesoRepository
    {
        public GenericFilterResponse<MenuAcceso> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
