using BDFerranova;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness
{
    public interface IUsuarioBusiness :ICRUDBusiness<UsuarioRequest,UsuarioResponse>
    {
        UsuarioResponse BuscarPorNombreUsuario(string username); 
        Vusuario ObtenerVistaUsername(string username);
    }
}
