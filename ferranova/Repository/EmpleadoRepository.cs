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
    public class EmpleadoRepository : CRUDRepository<Empleado>, IEmpleadoRepository
    {
        public GenericFilterResponse<Empleado> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> InsertMultiple(List<Empleado> empleados)
        {
            throw new NotImplementedException();
        }
    }
}
