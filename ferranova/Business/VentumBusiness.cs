using AutoMapper;
using BDFerranova;
using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using DocumentFormat.OpenXml.Spreadsheet;
using IBusiness;
using IRepository;
using Microsoft.EntityFrameworkCore;
using Repository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class VentumBusiness : IVentumBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IVentumRepository _VentumRepository;
        private readonly IMapper _mapper;
        // agrego detalle de venta
        private readonly IDetalleVentumRepository _detVentaRepository;
        public VentumBusiness(IMapper mapper)
        {
            _VentumRepository = new VentumRepository();
            _detVentaRepository = new DetalleVentumRepository();
            _mapper = mapper;
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<VentumResponse> GetAll()
        {
            //declarando la lista de Ventum response como resultado
            List<VentumResponse> lstResponse = new List<VentumResponse>();
            List<Ventum> Ventums = _VentumRepository.GetAll();
            lstResponse = _mapper.Map<List<VentumResponse>>(Ventums);
            return lstResponse;
        }
        public VentumResponse GetById(int id)
        {
            Ventum Ventum = _VentumRepository.GetById(id);
            VentumResponse resul = _mapper.Map<VentumResponse>(Ventum);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public VentumResponse Create(VentumRequest entity)
        {
            Ventum Ventum = _mapper.Map<Ventum>(entity);
            Ventum = _VentumRepository.Create(Ventum);
            VentumResponse result = _mapper.Map<VentumResponse>(entity);
            return result;
        }
        public List<VentumResponse> InsertMultiple(List<VentumRequest> lista)
        {
            List<Ventum> Ventums = _mapper.Map<List<Ventum>>(lista);
            Ventums = _VentumRepository.InsertMultiple(Ventums);
            List<VentumResponse> result = _mapper.Map<List<VentumResponse>>(Ventums);
            return result;
        }
        public VentumResponse Update(VentumRequest entity)
        {
            Ventum Ventum = _mapper.Map<Ventum>(entity);
            Ventum = _VentumRepository.Update(Ventum);
            VentumResponse result = _mapper.Map<VentumResponse>(entity);
            return result;
        }
        public List<VentumResponse> UpdateMultiple(List<VentumRequest> lista)
        {
            List<Ventum> Ventums = _mapper.Map<List<Ventum>>(lista);
            Ventums = _VentumRepository.UpdateMultiple(Ventums);
            List<VentumResponse> result = _mapper.Map<List<VentumResponse>>(Ventums);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _VentumRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<VentumRequest> lista)
        {
            List<Ventum> Ventums = _mapper.Map<List<Ventum>>(lista);
            int cantidad = _VentumRepository.DeleteMultipleItems(Ventums);
            return cantidad;
        }

        public GenericFilterResponse<VentumResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<VentumResponse> result = _mapper.Map<GenericFilterResponse<VentumResponse>>(_VentumRepository.GetByFilter(request));

            return result;

        }

        //public VentumResponse Registrar(VentumRequest request)
        //{
        //    VentumResponse ventaGenerada = _mapper.Map<VentumResponse>(request);
        //    if (ventaGenerada.IdVenta == 0)
        //    {
        //        throw new Exception("No se Puede Crear");
        //    }
        //    return _mapper.Map<VentumResponse>(ventaGenerada);
        //}

        //public List<VentumResponse> Historial(string buscarPor, string numeroVenta, string fechaInicio, string fechaFin)
        //{
        //    IQueryable <VentumResponse> query = (IQueryable<VentumResponse>)_VentumRepository.Consultar();
        //    var ListaResultado = new List<VentumResponse>();
        //    if(buscarPor == "fecha")
        //    {
        //        DateTime fecha_Inicio = Convert.ToDateTime((fechaInicio, "dd/MM/yyyy"));
        //        DateTime fecha_Fin = Convert.ToDateTime((fechaFin, "dd/MM/yyyy"));
        //        ListaResultado = query.Where(v => v.FechaRegistro.Value.Date >= fecha_Inicio.Date &&
        //        v.FechaRegistro.Value.Date<= fecha_Fin.Date).Include(dv => dv.DetalleVenta)
        //        .ThenInclude(p => p.IdProductoNavigation).ToList();
        //    }
        //    else
        //    {
        //        ListaResultado = query.Where(v => v.NumeroDocumento == numeroVenta).
        //            Include(dv => dv.DetalleVenta).
        //            ThenInclude(p => p.IdProductoNavigation) .ToList();
        //    }



        //   return _mapper.Map<List<VentumResponse>>(ListaResultado);
        //}

        //public List<ReporteResponse> Reportes(string fechaInicio, string fechaFin)
        //{
        //    IQueryable<DetalleVentumResponse> query = _detVentaRepository.Consultar();
        //    var ListaResultado = new List<DetalleVentumResponse>();
        //        DateTime fecha_Inicio = Convert.ToDateTime((fechaInicio, "dd/MM/yyyy"));
        //        DateTime fecha_Fin = Convert.ToDateTime((fechaFin, "dd/MM/yyyy"));

        //        ListaResultado = query.Include(p=>p.idProductoNavigation).
        //                               Include(v=>v.IdVentaNavigation).
        //                               Where(dv=>
        //                               dv.IdVentaNavigation.FechaRegistro.Value.Date>=fecha_Inicio.Date &&
        //                               dv.IdVentaNavigation.FechaRegistro.Value.Date>=fecha_Fin.Date
        //                               ).ToList();

        //    return _mapper.Map<List<ReporteResponse>>(ListaResultado);
        //}
    }
}