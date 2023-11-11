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
    public class SesionUsuarioRepository : CRUDRepository<SesionUsuario>, ISesionUsuarioRepository
    {
        public GenericFilterResponse<SesionUsuario> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<SesionUsuario> InsertMultiple(List<SesionUsuario> sesionUsuarios)
        {
            throw new NotImplementedException();
        }
    }
}
