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
    public class MetodoPagoBusiness : IMetodoPagoBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IMetodoPagoRepository _MetodoPagoRepository;
        private readonly IMapper _mapper;
        public MetodoPagoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _MetodoPagoRepository = new MetodoPagoRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<MetodoPagoResponse> GetAll()
        {
            //declarando la lista de MetodoPago response como resultado
            List<MetodoPagoResponse> lstResponse = new List<MetodoPagoResponse>();
            List<MetodoPago> MetodoPagos = _MetodoPagoRepository.GetAll();
            lstResponse = _mapper.Map<List<MetodoPagoResponse>>(MetodoPagos);
            return lstResponse;
        }
        public MetodoPagoResponse GetById(int id)
        {
            MetodoPago MetodoPago = _MetodoPagoRepository.GetById(id);
            MetodoPagoResponse resul = _mapper.Map<MetodoPagoResponse>(MetodoPago);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public MetodoPagoResponse Create(MetodoPagoRequest entity)
        {
            MetodoPago MetodoPago = _mapper.Map<MetodoPago>(entity);
            MetodoPago = _MetodoPagoRepository.Create(MetodoPago);
            MetodoPagoResponse result = _mapper.Map<MetodoPagoResponse>(entity);
            return result;
        }
        public List<MetodoPagoResponse> InsertMultiple(List<MetodoPagoRequest> lista)
        {
            List<MetodoPago> MetodoPagos = _mapper.Map<List<MetodoPago>>(lista);
            MetodoPagos = _MetodoPagoRepository.InsertMultiple(MetodoPagos);
            List<MetodoPagoResponse> result = _mapper.Map<List<MetodoPagoResponse>>(MetodoPagos);
            return result;
        }
        public MetodoPagoResponse Update(MetodoPagoRequest entity)
        {
            MetodoPago MetodoPago = _mapper.Map<MetodoPago>(entity);
            MetodoPago = _MetodoPagoRepository.Update(MetodoPago);
            MetodoPagoResponse result = _mapper.Map<MetodoPagoResponse>(entity);
            return result;
        }
        public List<MetodoPagoResponse> UpdateMultiple(List<MetodoPagoRequest> lista)
        {
            List<MetodoPago> MetodoPagos = _mapper.Map<List<MetodoPago>>(lista);
            MetodoPagos = _MetodoPagoRepository.UpdateMultiple(MetodoPagos);
            List<MetodoPagoResponse> result = _mapper.Map<List<MetodoPagoResponse>>(MetodoPagos);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _MetodoPagoRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<MetodoPagoRequest> lista)
        {
            List<MetodoPago> MetodoPagos = _mapper.Map<List<MetodoPago>>(lista);
            int cantidad = _MetodoPagoRepository.DeleteMultipleItems(MetodoPagos);
            return cantidad;
        }
    }
}
