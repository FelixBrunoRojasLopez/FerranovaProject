using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmpleadoRepository : CRUDRepository<Empleado>, IEmpleadoRepository
    {
        public List<Empleado> InsertMultiple(List<Empleado> empleados)
        {
            throw new NotImplementedException();
        }
    }
}
