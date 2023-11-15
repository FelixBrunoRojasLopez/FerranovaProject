using AutoMapper;
using BDFerranova;
using IBusiness;
using IBusiness.TB_Cliente;
using IRepository.TB_Cliente;
using Repository.TB_Cliente;
using RequestResponseModel;
using RequestResponseModel.Request.Cliente;
using RequestResponseModel.Response.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.TB_Cliente
{
    public class VClienteBusiness : IVClienteBusiness
    {
        #region Inyeccion de dependencias
        private readonly IVClienteRepository _vClienteRepository;
        private readonly IClienteBusiness _ClienteBusiness;
        private readonly ITipoDocumentoBusiness _tipoDocumentoBusiness;
        private readonly IMapper _mapper;
        public VClienteBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _vClienteRepository = new VClienteRepository();
            _tipoDocumentoBusiness = new TipoDocumentoBusiness(mapper);
            _ClienteBusiness = new ClienteBusiness(mapper);
        }
        #endregion Inyeccion de dependencias
        #region Crud
        public VclienteResponse Create(VclienteRequest entity)
        {
            VclienteResponse response = new();
            #pragma warning disable CS8604 // Posible argumento de referencia nulo
            TipoDocumentoResponse tDoc = _tipoDocumentoBusiness.BuscarDetalle(entity.Descripcion);
            #pragma warning restore CS8604 // Posible argumento de referencia nulo
            ClienteRequest ClienteRequest = _mapper.Map<ClienteRequest>(entity);
            //ClienteRequest. IdTipoPersona = tDoc.IdTipoDocumento;
            ClienteResponse ClienteResponse = _ClienteBusiness.Create(ClienteRequest);
            ListClienteResponse data = _mapper.Map<ListClienteResponse>(entity);
            data.IdCliente = ClienteResponse.IdCliente;
            response.Message = "Se registro";
            response.Cliente.Add(data);

            return response;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultipleItems(List<VclienteRequest> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<VclienteResponse> GetAll()
        {
            List<VclienteResponse> response = new();
            VclienteResponse data = new();
            List<Vcliente> cliente = _vClienteRepository.GetAll();
            List<ListClienteResponse> list = _mapper.Map<List<ListClienteResponse>>(cliente);
            data.Message = "Lista de Cliente";
            data.Cliente.AddRange(list);
            response.Add(data);
            return response;
        }

        public GenericFilterResponse<VclienteResponse> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public VclienteResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<VclienteResponse> InsertMultiple(List<VclienteRequest> lista)
        {
            throw new NotImplementedException();
        }

        public VclienteResponse Update(VclienteRequest entity)
        {
            VclienteResponse response = new();
            #pragma warning disable CS8604 // Posible argumento de referencia nulo
            TipoDocumentoResponse tDoc = _tipoDocumentoBusiness.BuscarDetalle(entity.Descripcion);
            #pragma warning restore CS8604 // Posible argumento de referencia nulo
            ClienteRequest ClienteRequest = _mapper.Map<ClienteRequest>(entity);
            //ClienteRequest.IdTipoPersona = tDoc.IdTipoDocumento;
            ClienteResponse ClienteResponse = _ClienteBusiness.Update(ClienteRequest);
            ListClienteResponse data = _mapper.Map<ListClienteResponse>(entity);
            data.IdCliente = ClienteResponse.IdCliente;
            response.Message = "Se registro";
            response.Cliente.Add(data);

            return response;
        }

        public List<VclienteResponse> UpdateMultiple(List<VclienteRequest> lista)
        {
            throw new NotImplementedException();
        }
        #endregion Crud
    }
}
