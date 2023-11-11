using AutoMapper;
using BDFerranova;
using IBusiness;
using IRepository;
using Repository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DashboardBusiness : IDashBoardBusiness
    {//Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IProductoRepository _productoRepository;
        private readonly IVentumRepository _ventumRepository;
        private readonly IDashboardRepository _DashboardRepository;
        private readonly IMapper _mapper;
        public DashboardBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _DashboardRepository = new DashboardRepository();
            _ventumRepository = new VentumRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<DashboardResponse> GetAll()
        {
            //declarando la lista de Dashboard response como resultado
            List<DashboardResponse> lstResponse = new List<DashboardResponse>();
            List<DashboardResponse> Dashboards = _DashboardRepository.GetAll();
            lstResponse = _mapper.Map<List<DashboardResponse>>(Dashboards);
            return lstResponse;
        }
        public DashboardResponse GetById(int id)
        {
            DashboardResponse Dashboard = _DashboardRepository.GetById(id);
            DashboardResponse resul = _mapper.Map<DashboardResponse>(Dashboard);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public DashboardResponse Create(DashboardRequest entity)
        {
            DashboardResponse Dashboard = _mapper.Map<DashboardResponse>(entity);
            Dashboard = _DashboardRepository.Create(Dashboard);
            DashboardResponse result = _mapper.Map<DashboardResponse>(entity);
            return result;
        }
        public List<DashboardResponse> InsertMultiple(List<DashboardRequest> lista)
        {
            List<DashboardResponse> Dashboards = _mapper.Map<List<DashboardResponse>>(lista);
            Dashboards = _DashboardRepository.InsertMultiple(Dashboards);
            List<DashboardResponse> result = _mapper.Map<List<DashboardResponse>>(Dashboards);
            return result;
        }
        public DashboardResponse Update(DashboardRequest entity)
        {
            DashboardResponse Dashboard = _mapper.Map<DashboardResponse>(entity);
            Dashboard = _DashboardRepository.Update(Dashboard);
            DashboardResponse result = _mapper.Map<DashboardResponse>(entity);
            return result;
        }
        public List<DashboardResponse> UpdateMultiple(List<DashboardRequest> lista)
        {
            List<DashboardResponse> Dashboards = _mapper.Map<List<DashboardResponse>>(lista);
            Dashboards = _DashboardRepository.UpdateMultiple(Dashboards);
            List<DashboardResponse> result = _mapper.Map<List<DashboardResponse>>(Dashboards);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _DashboardRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<DashboardRequest> lista)
        {
            List<DashboardResponse> Dashboards = _mapper.Map<List<DashboardResponse>>(lista);
            int cantidad = _DashboardRepository.DeleteMultipleItems(Dashboards);
            return cantidad;
        }

        public GenericFilterResponse<DashboardResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<DashboardResponse> result = _mapper.Map<GenericFilterResponse<DashboardResponse>>(_DashboardRepository.GetByFilter(request));

            return result;

        }

        private IQueryable<VentumResponse> retornarVentas(IQueryable<VentumResponse> tablaVenta, int restarCantidadDias)
        {
            DateTime? ultimaFecha = tablaVenta.OrderByDescending(v => v.FechaRegistro).Select(v=>v.FechaRegistro).First();
            ultimaFecha = ultimaFecha.Value.AddDays(restarCantidadDias);
            return tablaVenta.Where(v => v.FechaRegistro.Value.Date >= ultimaFecha.Value.Date);

        }
        private int TotalVentasUltimaSemana()
        {
            int total = 0;
            IQueryable<VentumResponse> _ventaQuery = (IQueryable<VentumResponse>)_ventumRepository.Consultar();
            if(_ventaQuery.Count() > 0)
            {
                var tablaVenta = retornarVentas(_ventaQuery, -7);
                total = tablaVenta.Count();
            }
            return total;
        }
        private string TotalIngresosUltimaSemana()
        {
            decimal resultado = 0;
            IQueryable<VentumResponse> _ventaQuery = (IQueryable<VentumResponse>)_ventumRepository.Consultar();
            if (_ventaQuery.Count() > 0)
            {
                var tablaVenta = retornarVentas(_ventaQuery, -7);
                resultado = tablaVenta.Select(v => v.Total).Sum(v => v.Value);
            }
            return Convert.ToString(resultado, new CultureInfo("es_PE"));
        }
        private int TotalProductos()
        {
            IQueryable<ProductoResponse> _productoQuery = _productoRepository.Consultar();
            int total = _productoQuery.Count();
            return total;
        }
        private Dictionary<string,int> VentasUltimaSemana()
        {
            Dictionary<string,int> resultado = new Dictionary<string, int>();
            IQueryable<VentumResponse> _ventaQuery = (IQueryable<VentumResponse>)_ventumRepository.Consultar();
            if(_ventaQuery.Count() > 0)
            {
                var tablaVenta = retornarVentas(_ventaQuery, -7);
                resultado = tablaVenta.
                    GroupBy(v=>v.FechaRegistro.Value.Date).
                    OrderBy(g => g.Key).Select(dv => new {fecha = dv.Key.ToString("dd/MM/yyyy"),total =dv.Count()}).
                    ToDictionary(keySelector: r => r.fecha,elementSelector: r => r.total);
            }
            return resultado;
        }

        public DashboardResponse Resumen()
        {
            DashboardResponse vmDashBoard = new DashboardResponse();
            vmDashBoard.TotalVentas = TotalVentasUltimaSemana();
            vmDashBoard.TotalIngresos = TotalIngresosUltimaSemana();
            vmDashBoard.TotalProductos = TotalProductos();

            List<VentasSemanalesResponse> listaVentaSemana = new List<VentasSemanalesResponse>();
            foreach(KeyValuePair<string,int> item in VentasUltimaSemana())
            {
                listaVentaSemana.Add(new VentasSemanalesResponse()
                {
                    Fecha =item.Key,
                    Total =item.Value,
                });
            }
            vmDashBoard.VentasSemanales = listaVentaSemana;
            return vmDashBoard;
        }

        public TipoDocumentoFilterResponse ObtenerPorFiltro(TipoDocumentoFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
