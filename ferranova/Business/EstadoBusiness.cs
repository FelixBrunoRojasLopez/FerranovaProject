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
    public class EstadoBusiness : IEstadoBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IEstadoRepository _EstadoRepository;
        private readonly IMapper _mapper;
        public EstadoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _EstadoRepository = new EstadoRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<EstadoResponse> GetAll()
        {
            //declarando la lista de Estado response como resultado
            List<EstadoResponse> lstResponse = new List<EstadoResponse>();
            List<Estado> Estados = _EstadoRepository.GetAll();
            lstResponse = _mapper.Map<List<EstadoResponse>>(Estados);
            return lstResponse;
        }
        public EstadoResponse GetById(int id)
        {
            Estado Estado = _EstadoRepository.GetById(id);
            EstadoResponse resul = _mapper.Map<EstadoResponse>(Estado);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public EstadoResponse Create(EstadoRequest entity)
        {
            Estado Estado = _mapper.Map<Estado>(entity);
            Estado = _EstadoRepository.Create(Estado);
            EstadoResponse result = _mapper.Map<EstadoResponse>(entity);
            return result;
        }
        public List<EstadoResponse> InsertMultiple(List<EstadoRequest> lista)
        {
            List<Estado> Estados = _mapper.Map<List<Estado>>(lista);
            Estados = _EstadoRepository.InsertMultiple(Estados);
            List<EstadoResponse> result = _mapper.Map<List<EstadoResponse>>(Estados);
            return result;
        }
        public EstadoResponse Update(EstadoRequest entity)
        {
            Estado Estado = _mapper.Map<Estado>(entity);
            Estado = _EstadoRepository.Update(Estado);
            EstadoResponse result = _mapper.Map<EstadoResponse>(entity);
            return result;
        }
        public List<EstadoResponse> UpdateMultiple(List<EstadoRequest> lista)
        {
            List<Estado> Estados = _mapper.Map<List<Estado>>(lista);
            Estados = _EstadoRepository.UpdateMultiple(Estados);
            List<EstadoResponse> result = _mapper.Map<List<EstadoResponse>>(Estados);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _EstadoRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<EstadoRequest> lista)
        {
            List<Estado> Estados = _mapper.Map<List<Estado>>(lista);
            int cantidad = _EstadoRepository.DeleteMultipleItems(Estados);
            return cantidad;
        }
    }
}
   