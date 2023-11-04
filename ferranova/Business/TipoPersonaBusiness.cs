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
    public class TipoPersonaBusiness : ITipoPersonaBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly ITipoPersonaRepository _TipoPersonaRepository;
        private readonly IMapper _mapper;
        public TipoPersonaBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _TipoPersonaRepository = new TipoPersonaRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<TipoPersonaResponse> GetAll()
        {
            //declarando la lista de TipoPersona response como resultado
            List<TipoPersonaResponse> lstResponse = new List<TipoPersonaResponse>();
            List<TipoPersona> TipoPersonas = _TipoPersonaRepository.GetAll();
            lstResponse = _mapper.Map<List<TipoPersonaResponse>>(TipoPersonas);
            return lstResponse;
        }
        public TipoPersonaResponse GetById(int id)
        {
            TipoPersona TipoPersona = _TipoPersonaRepository.GetById(id);
            TipoPersonaResponse resul = _mapper.Map<TipoPersonaResponse>(TipoPersona);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public TipoPersonaResponse Create(TipoPersonaRequest entity)
        {
            TipoPersona TipoPersona = _mapper.Map<TipoPersona>(entity);
            TipoPersona = _TipoPersonaRepository.Create(TipoPersona);
            TipoPersonaResponse result = _mapper.Map<TipoPersonaResponse>(entity);
            return result;
        }
        public List<TipoPersonaResponse> InsertMultiple(List<TipoPersonaRequest> lista)
        {
            List<TipoPersona> TipoPersonas = _mapper.Map<List<TipoPersona>>(lista);
            TipoPersonas = _TipoPersonaRepository.InsertMultiple(TipoPersonas);
            List<TipoPersonaResponse> result = _mapper.Map<List<TipoPersonaResponse>>(TipoPersonas);
            return result;
        }
        public TipoPersonaResponse Update(TipoPersonaRequest entity)
        {
            TipoPersona TipoPersona = _mapper.Map<TipoPersona>(entity);
            TipoPersona = _TipoPersonaRepository.Update(TipoPersona);
            TipoPersonaResponse result = _mapper.Map<TipoPersonaResponse>(entity);
            return result;
        }
        public List<TipoPersonaResponse> UpdateMultiple(List<TipoPersonaRequest> lista)
        {
            List<TipoPersona> TipoPersonas = _mapper.Map<List<TipoPersona>>(lista);
            TipoPersonas = _TipoPersonaRepository.UpdateMultiple(TipoPersonas);
            List<TipoPersonaResponse> result = _mapper.Map<List<TipoPersonaResponse>>(TipoPersonas);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _TipoPersonaRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<TipoPersonaRequest> lista)
        {
            List<TipoPersona> TipoPersonas = _mapper.Map<List<TipoPersona>>(lista);
            int cantidad = _TipoPersonaRepository.DeleteMultipleItems(TipoPersonas);
            return cantidad;
        }

        public GenericFilterResponse<TipoPersonaResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<TipoPersonaResponse> result = _mapper.Map<GenericFilterResponse<TipoPersonaResponse>>(_TipoPersonaRepository.GetByFilter(request));

            return result;

        }
    }
}