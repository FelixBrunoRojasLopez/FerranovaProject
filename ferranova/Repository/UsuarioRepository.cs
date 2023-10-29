using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository : CRUDRepository<UsuarioAcceso>, IUsuarioRepository
    {
        public UsuarioAcceso ObtenerPorUsername(string username)
        {
            UsuarioAcceso usuario = dbSet
                .Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();
            return usuario;
        }

        public Vusuario ObtenerVistaUsername(string username)
        {
            Vusuario vUsuario = db.Vusuarios.Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();
            return vUsuario;

        }
    }
}
