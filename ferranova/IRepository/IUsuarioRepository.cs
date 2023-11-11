using BDFerranova;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IUsuarioRepository :ICRUDRepository<UsuarioAcceso>
    {
        //IQueryable<UsuarioResponse> Consultar(Func<object, bool> value);
        UsuarioAcceso ObtenerPorUsername(string username);
        Vusuario ObtenerVistaUsername(string username);
    }
}
