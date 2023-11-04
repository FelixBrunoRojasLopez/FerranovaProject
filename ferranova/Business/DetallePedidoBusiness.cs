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
    public class DetallePedidoBusiness : IDetallePedidoBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IDetallePedidoRepository _DetallePedidoRepository;
        private readonly IMapper _mapper;
        public DetallePedidoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _DetallePedidoRepository = new DetallePedidoRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<DetallePedidoResponse> GetAll()
        {
            //declarando la lista de DetallePedido response como resultado
            List<DetallePedidoResponse> lstResponse = new List<DetallePedidoResponse>();
            List<DetallePedido> DetallePedidos = _DetallePedidoRepository.GetAll();
            lstResponse = _mapper.Map<List<DetallePedidoResponse>>(DetallePedidos);
            return lstResponse;
        }
        public DetallePedidoResponse GetById(int id)
        {
            DetallePedido DetallePedido = _DetallePedidoRepository.GetById(id);
            DetallePedidoResponse resul = _mapper.Map<DetallePedidoResponse>(DetallePedido);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public DetallePedidoResponse Create(DetallePedidoRequest entity)
        {
            DetallePedido DetallePedido = _mapper.Map<DetallePedido>(entity);
            DetallePedido = _DetallePedidoRepository.Create(DetallePedido);
            DetallePedidoResponse result = _mapper.Map<DetallePedidoResponse>(entity);
            return result;
        }
        public List<DetallePedidoResponse> InsertMultiple(List<DetallePedidoRequest> lista)
        {
            List<DetallePedido> DetallePedidos = _mapper.Map<List<DetallePedido>>(lista);
            DetallePedidos = _DetallePedidoRepository.InsertMultiple(DetallePedidos);
            List<DetallePedidoResponse> result = _mapper.Map<List<DetallePedidoResponse>>(DetallePedidos);
            return result;
        }
        public DetallePedidoResponse Update(DetallePedidoRequest entity)
        {
            DetallePedido DetallePedido = _mapper.Map<DetallePedido>(entity);
            DetallePedido = _DetallePedidoRepository.Update(DetallePedido);
            DetallePedidoResponse result = _mapper.Map<DetallePedidoResponse>(entity);
            return result;
        }
        public List<DetallePedidoResponse> UpdateMultiple(List<DetallePedidoRequest> lista)
        {
            List<DetallePedido> DetallePedidos = _mapper.Map<List<DetallePedido>>(lista);
            DetallePedidos = _DetallePedidoRepository.UpdateMultiple(DetallePedidos);
            List<DetallePedidoResponse> result = _mapper.Map<List<DetallePedidoResponse>>(DetallePedidos);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _DetallePedidoRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<DetallePedidoRequest> lista)
        {
            List<DetallePedido> DetallePedidos = _mapper.Map<List<DetallePedido>>(lista);
            int cantidad = _DetallePedidoRepository.DeleteMultipleItems(DetallePedidos);
            return cantidad;
        }

        public GenericFilterResponse<DetallePedidoResponse> GetByFilter(GenericFilterRequest request)
        {
            GenericFilterResponse<DetallePedidoResponse> result = _mapper.Map<GenericFilterResponse<DetallePedidoResponse>>(_DetallePedidoRepository.GetByFilter(request));

            return result;

        }
    }
}
