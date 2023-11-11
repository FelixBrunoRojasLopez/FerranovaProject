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
    public class ErrorRepository : CRUDRepository<Error>, IErrorRepository
    {
        public GenericFilterResponse<Error> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
