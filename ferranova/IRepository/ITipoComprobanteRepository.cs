using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface ITipoComprobanteRepository : ICRUDRepository<TipoComprobante>
    {
        List<TipoComprobante> InsertMultiple(List<TipoComprobante> tipoComprobantes);
    }
}
