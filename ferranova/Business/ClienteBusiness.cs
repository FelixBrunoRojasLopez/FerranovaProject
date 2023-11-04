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
    public class ClienteBusiness : IClienteBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IClienteRepository _ClienteRepository;
        private readonly IMapper _mapper;
        public ClienteBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _ClienteRepository = new ClienteRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<ClienteResponse> GetAll()
        {
            //declarando la lista de Cliente response como resultado
            List<ClienteResponse> lstResponse = new List<ClienteResponse>();
            List<Cliente> Clientes = _ClienteRepository.GetAll();
            lstResponse = _mapper.Map<List<ClienteResponse>>(Clientes);
            return lstResponse;
        }
        public ClienteResponse GetById(int id)
        {
            Cliente Cliente = _ClienteRepository.GetById(id);
            ClienteResponse resul = _mapper.Map<ClienteResponse>(Cliente);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public ClienteResponse Create(ClienteRequest entity)
        {
            Cliente Cliente = _mapper.Map<Cliente>(entity);
            Cliente = _ClienteRepository.Create(Cliente);
            ClienteResponse result = _mapper.Map<ClienteResponse>(entity);
            return result;
        }
        public List<ClienteResponse> InsertMultiple(List<ClienteRequest> lista)
        {
            List<Cliente> Clientes = _mapper.Map<List<Cliente>>(lista);
            Clientes = _ClienteRepository.InsertMultiple(Clientes);
            List<ClienteResponse> result = _mapper.Map<List<ClienteResponse>>(Clientes);
            return result;
        }
        public ClienteResponse Update(ClienteRequest entity)
        {
            Cliente Cliente = _mapper.Map<Cliente>(entity);
            Cliente = _ClienteRepository.Update(Cliente);
            ClienteResponse result = _mapper.Map<ClienteResponse>(entity);
            return result;
        }
        public List<ClienteResponse> UpdateMultiple(List<ClienteRequest> lista)
        {
            List<Cliente> Clientes = _mapper.Map<List<Cliente>>(lista);
            Clientes = _ClienteRepository.UpdateMultiple(Clientes);
            List<ClienteResponse> result = _mapper.Map<List<ClienteResponse>>(Clientes);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _ClienteRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<ClienteRequest> lista)
        {
            List<Cliente> Clientes = _mapper.Map<List<Cliente>>(lista);
            int cantidad = _ClienteRepository.DeleteMultipleItems(Clientes);
            return cantidad;
        }

        public GenericFilterResponse<ClienteResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<ClienteResponse> result = _mapper.Map<GenericFilterResponse<ClienteResponse>>(_ClienteRepository.GetByFilter(request));

            return result;

        }
    }
}