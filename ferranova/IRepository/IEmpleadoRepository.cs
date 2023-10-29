using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IEmpleadoRepository : ICRUDRepository<Empleado>
    {
        List<Empleado> InsertMultiple(List<Empleado> empleados);
    }
}
