using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IUsuarioRepository :ICRUDRepository<UsuarioAcceso>
    {
        UsuarioAcceso ObtenerPorUsername(string username);
        Vusuario ObtenerVistaUsername(string username);
    }
}
