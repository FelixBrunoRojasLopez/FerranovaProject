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
    public class MenuRolRepository : CRUDRepository<MenuRol>, IMenuRolRepository
    {
        public IQueryable<MenuRolResponse> Consultar()
        {
            throw new NotImplementedException();
        }

        public GenericFilterResponse<MenuRol> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
