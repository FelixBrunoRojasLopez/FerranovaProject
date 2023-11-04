using BDFerranova;
using IRepository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Repository
{
    public class VentumRepository : CRUDRepository<Ventum>, IVentumRepository
    {
        //public List<Ventum> Consultar(Expression<Func<Ventum, bool>> filtro = null)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Ventum> InsertMultiple(List<Ventum> ventums)
        {
            throw new NotImplementedException();
        }

        //public Task<Ventum> Registrar(Ventum ventum)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
