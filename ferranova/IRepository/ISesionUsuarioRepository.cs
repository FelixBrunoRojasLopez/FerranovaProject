using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface ISesionUsuarioRepository : ICRUDRepository<SesionUsuario>
    {
        List<SesionUsuario> InsertMultiple(List<SesionUsuario> sesionUsuarios);
    }
}
