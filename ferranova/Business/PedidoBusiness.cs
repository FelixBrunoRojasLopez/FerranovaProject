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
    public class PedidoBusiness : IPedidoBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IPedidoRepository _PedidoRepository;
        private readonly IMapper _mapper;
        public PedidoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _PedidoRepository = new PedidoRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<PedidoResponse> GetAll()
        {
            //declarando la lista de Pedido response como resultado
            List<PedidoResponse> lstResponse = new List<PedidoResponse>();
            List<Pedido> Pedidos = _PedidoRepository.GetAll();
            lstResponse = _mapper.Map<List<PedidoResponse>>(Pedidos);
            return lstResponse;
        }
        public PedidoResponse GetById(int id)
        {
            Pedido Pedido = _PedidoRepository.GetById(id);
            PedidoResponse resul = _mapper.Map<PedidoResponse>(Pedido);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public PedidoResponse Create(PedidoRequest entity)
        {
            Pedido Pedido = _mapper.Map<Pedido>(entity);
            Pedido = _PedidoRepository.Create(Pedido);
            PedidoResponse result = _mapper.Map<PedidoResponse>(entity);
            return result;
        }
        public List<PedidoResponse> InsertMultiple(List<PedidoRequest> lista)
        {
            List<Pedido> Pedidos = _mapper.Map<List<Pedido>>(lista);
            Pedidos = _PedidoRepository.InsertMultiple(Pedidos);
            List<PedidoResponse> result = _mapper.Map<List<PedidoResponse>>(Pedidos);
            return result;
        }
        public PedidoResponse Update(PedidoRequest entity)
        {
            Pedido Pedido = _mapper.Map<Pedido>(entity);
            Pedido = _PedidoRepository.Update(Pedido);
            PedidoResponse result = _mapper.Map<PedidoResponse>(entity);
            return result;
        }
        public List<PedidoResponse> UpdateMultiple(List<PedidoRequest> lista)
        {
            List<Pedido> Pedidos = _mapper.Map<List<Pedido>>(lista);
            Pedidos = _PedidoRepository.UpdateMultiple(Pedidos);
            List<PedidoResponse> result = _mapper.Map<List<PedidoResponse>>(Pedidos);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _PedidoRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<PedidoRequest> lista)
        {
            List<Pedido> Pedidos = _mapper.Map<List<Pedido>>(lista);
            int cantidad = _PedidoRepository.DeleteMultipleItems(Pedidos);
            return cantidad;
        }

        public GenericFilterResponse<PedidoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<PedidoResponse> result = _mapper.Map<GenericFilterResponse<PedidoResponse>>(_PedidoRepository.GetByFilter(request));

            return result;

        }
    }
}
