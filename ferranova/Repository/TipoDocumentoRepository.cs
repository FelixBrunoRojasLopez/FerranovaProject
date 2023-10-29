using BDFerranova;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TipoDocumentoRepository : CRUDRepository<TipoDocumento>, ITipoDocumentoRepository
    {
        public List<TipoDocumento> InsertMultiple(List<TipoDocumento> tipoDocumentos)
        {
            throw new NotImplementedException();
        }
    }
}
