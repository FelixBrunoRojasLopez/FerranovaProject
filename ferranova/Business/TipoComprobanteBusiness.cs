using AutoMapper;
using BDFerranova;
using IBusiness;
using IRepository;
using Repository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TipoComprobanteBusiness : ITipoComprobanteBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly ITipoComprobanteRepository _TipoComprobanteRepository;
        private readonly IMapper _mapper;
        public TipoComprobanteBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _TipoComprobanteRepository = new TipoComprobanteRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<TipoComprobanteResponse> GetAll()
        {
            //declarando la lista de TipoComprobante response como resultado
            List<TipoComprobanteResponse> lstResponse = new List<TipoComprobanteResponse>();
            List<TipoComprobante> TipoComprobantes = _TipoComprobanteRepository.GetAll();
            lstResponse = _mapper.Map<List<TipoComprobanteResponse>>(TipoComprobantes);
            return lstResponse;
        }
        public TipoComprobanteResponse GetById(int id)
        {
            TipoComprobante TipoComprobante = _TipoComprobanteRepository.GetById(id);
            TipoComprobanteResponse resul = _mapper.Map<TipoComprobanteResponse>(TipoComprobante);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public TipoComprobanteResponse Create(TipoComprobanteRequest entity)
        {
            TipoComprobante TipoComprobante = _mapper.Map<TipoComprobante>(entity);
            TipoComprobante = _TipoComprobanteRepository.Create(TipoComprobante);
            TipoComprobanteResponse result = _mapper.Map<TipoComprobanteResponse>(entity);
            return result;
        }
        public List<TipoComprobanteResponse> InsertMultiple(List<TipoComprobanteRequest> lista)
        {
            List<TipoComprobante> TipoComprobantes = _mapper.Map<List<TipoComprobante>>(lista);
            TipoComprobantes = _TipoComprobanteRepository.InsertMultiple(TipoComprobantes);
            List<TipoComprobanteResponse> result = _mapper.Map<List<TipoComprobanteResponse>>(TipoComprobantes);
            return result;
        }
        public TipoComprobanteResponse Update(TipoComprobanteRequest entity)
        {
            TipoComprobante TipoComprobante = _mapper.Map<TipoComprobante>(entity);
            TipoComprobante = _TipoComprobanteRepository.Update(TipoComprobante);
            TipoComprobanteResponse result = _mapper.Map<TipoComprobanteResponse>(entity);
            return result;
        }
        public List<TipoComprobanteResponse> UpdateMultiple(List<TipoComprobanteRequest> lista)
        {
            List<TipoComprobante> TipoComprobantes = _mapper.Map<List<TipoComprobante>>(lista);
            TipoComprobantes = _TipoComprobanteRepository.UpdateMultiple(TipoComprobantes);
            List<TipoComprobanteResponse> result = _mapper.Map<List<TipoComprobanteResponse>>(TipoComprobantes);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _TipoComprobanteRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<TipoComprobanteRequest> lista)
        {
            List<TipoComprobante> TipoComprobantes = _mapper.Map<List<TipoComprobante>>(lista);
            int cantidad = _TipoComprobanteRepository.DeleteMultipleItems(TipoComprobantes);
            return cantidad;
        }
    }
}
