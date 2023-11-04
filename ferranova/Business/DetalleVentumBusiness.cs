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
    public class DetalleVentumBusiness : IDetalleVentumBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IDetalleVentumRepository _DetalleVentumRepository;
        private readonly IMapper _mapper;
        public DetalleVentumBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleVentumRepository = new DetalleVentumRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<DetalleVentumResponse> GetAll()
        {
            //declarando la lista de DetalleVentum response como resultado
            List<DetalleVentumResponse> lstResponse = new List<DetalleVentumResponse>();
            List<DetalleVentum> DetalleVentums = _DetalleVentumRepository.GetAll();
            lstResponse = _mapper.Map<List<DetalleVentumResponse>>(DetalleVentums);
            return lstResponse;
        }
        public DetalleVentumResponse GetById(int id)
        {
            DetalleVentum DetalleVentum = _DetalleVentumRepository.GetById(id);
            DetalleVentumResponse resul = _mapper.Map<DetalleVentumResponse>(DetalleVentum);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public DetalleVentumResponse Create(DetalleVentumRequest entity)
        {
            DetalleVentum DetalleVentum = _mapper.Map<DetalleVentum>(entity);
            DetalleVentum = _DetalleVentumRepository.Create(DetalleVentum);
            DetalleVentumResponse result = _mapper.Map<DetalleVentumResponse>(entity);
            return result;
        }
        public List<DetalleVentumResponse> InsertMultiple(List<DetalleVentumRequest> lista)
        {
            List<DetalleVentum> DetalleVentums = _mapper.Map<List<DetalleVentum>>(lista);
            DetalleVentums = _DetalleVentumRepository.InsertMultiple(DetalleVentums);
            List<DetalleVentumResponse> result = _mapper.Map<List<DetalleVentumResponse>>(DetalleVentums);
            return result;
        }
        public DetalleVentumResponse Update(DetalleVentumRequest entity)
        {
            DetalleVentum DetalleVentum = _mapper.Map<DetalleVentum>(entity);
            DetalleVentum = _DetalleVentumRepository.Update(DetalleVentum);
            DetalleVentumResponse result = _mapper.Map<DetalleVentumResponse>(entity);
            return result;
        }
        public List<DetalleVentumResponse> UpdateMultiple(List<DetalleVentumRequest> lista)
        {
            List<DetalleVentum> DetalleVentums = _mapper.Map<List<DetalleVentum>>(lista);
            DetalleVentums = _DetalleVentumRepository.UpdateMultiple(DetalleVentums);
            List<DetalleVentumResponse> result = _mapper.Map<List<DetalleVentumResponse>>(DetalleVentums);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _DetalleVentumRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<DetalleVentumRequest> lista)
        {
            List<DetalleVentum> DetalleVentums = _mapper.Map<List<DetalleVentum>>(lista);
            int cantidad = _DetalleVentumRepository.DeleteMultipleItems(DetalleVentums);
            return cantidad;
        }

        public GenericFilterResponse<DetalleVentumResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<DetalleVentumResponse> result = _mapper.Map<GenericFilterResponse<DetalleVentumResponse>>(_DetalleVentumRepository.GetByFilter(request));

            return result;

        }
    }
}
