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
    public class TipoClienteBusiness : ITipoClienteBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly ITipoClienteRepository _TipoClienteRepository;
        private readonly IMapper _mapper;
        public TipoClienteBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _TipoClienteRepository = new TipoClienteRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<TipoClienteResponse> GetAll()
        {
            //declarando la lista de TipoCliente response como resultado
            List<TipoClienteResponse> lstResponse = new List<TipoClienteResponse>();
            List<TipoCliente> TipoClientes = _TipoClienteRepository.GetAll();
            lstResponse = _mapper.Map<List<TipoClienteResponse>>(TipoClientes);
            return lstResponse;
        }
        public TipoClienteResponse GetById(int id)
        {
            TipoCliente TipoCliente = _TipoClienteRepository.GetById(id);
            TipoClienteResponse resul = _mapper.Map<TipoClienteResponse>(TipoCliente);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public TipoClienteResponse Create(TipoClienteRequest entity)
        {
            TipoCliente TipoCliente = _mapper.Map<TipoCliente>(entity);
            TipoCliente = _TipoClienteRepository.Create(TipoCliente);
            TipoClienteResponse result = _mapper.Map<TipoClienteResponse>(entity);
            return result;
        }
        public List<TipoClienteResponse> InsertMultiple(List<TipoClienteRequest> lista)
        {
            List<TipoCliente> TipoClientes = _mapper.Map<List<TipoCliente>>(lista);
            TipoClientes = _TipoClienteRepository.InsertMultiple(TipoClientes);
            List<TipoClienteResponse> result = _mapper.Map<List<TipoClienteResponse>>(TipoClientes);
            return result;
        }
        public TipoClienteResponse Update(TipoClienteRequest entity)
        {
            TipoCliente TipoCliente = _mapper.Map<TipoCliente>(entity);
            TipoCliente = _TipoClienteRepository.Update(TipoCliente);
            TipoClienteResponse result = _mapper.Map<TipoClienteResponse>(entity);
            return result;
        }
        public List<TipoClienteResponse> UpdateMultiple(List<TipoClienteRequest> lista)
        {
            List<TipoCliente> TipoClientes = _mapper.Map<List<TipoCliente>>(lista);
            TipoClientes = _TipoClienteRepository.UpdateMultiple(TipoClientes);
            List<TipoClienteResponse> result = _mapper.Map<List<TipoClienteResponse>>(TipoClientes);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _TipoClienteRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<TipoClienteRequest> lista)
        {
            List<TipoCliente> TipoClientes = _mapper.Map<List<TipoCliente>>(lista);
            int cantidad = _TipoClienteRepository.DeleteMultipleItems(TipoClientes);
            return cantidad;
        }

        public GenericFilterResponse<TipoClienteResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<TipoClienteResponse> result = _mapper.Map<GenericFilterResponse<TipoClienteResponse>>(_TipoClienteRepository.GetByFilter(request));

            return result;

        }
    }
}