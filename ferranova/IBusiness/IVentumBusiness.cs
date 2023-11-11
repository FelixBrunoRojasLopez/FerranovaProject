using BDFerranova;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness
{
    public interface IVentumBusiness : ICRUDBusiness<VentumRequest,VentumResponse>
    {
        VentumResponse Registrar (VentumRequest request);
        List<VentumResponse> Historial(string buscarPor, string numeroVenta, string fechaInicio, string fechaFin);
        List<ReporteResponse> Reportes(string fechaInicio, string fechaFin);
        
    }
}
