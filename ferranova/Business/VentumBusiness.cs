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
    public class VentumBusiness : IVentumBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IVentumRepository _VentumRepository;
        private readonly IMapper _mapper;
        public VentumBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _VentumRepository = new VentumRepository();
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
    }
}