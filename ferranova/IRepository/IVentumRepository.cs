using BDFerranova;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IVentumRepository : ICRUDRepository<Ventum>
    {
        List<Ventum> InsertMultiple(List<Ventum> ventums);
        Task<VentumResponse> Registrar(VentumRequest request);
        List<VentumResponse> Historial(string buscarPor, string numeroVenta, string fechaInicio, string fechaFin);
        List<VentumResponse> Reporte(string fechaInicio, string fechaFin);
        IQueryable<Ventum> Consultar(Expression<Func<Ventum, bool>> filtro = null);

    }
}
