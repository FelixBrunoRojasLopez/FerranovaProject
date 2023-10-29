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
    public class DetalleProductoBusiness : IDetalleProductoBusiness
    {
        //Inyeccion de Dependecias
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IDetalleProductoRepository _DetalleProductoRepository;
        private readonly IMapper _mapper;
        public DetalleProductoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleProductoRepository = new DetalleProductoRepository();
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        public List<DetalleProductoResponse> GetAll()
        {
            //declarando la lista de DetalleProducto response como resultado
            List<DetalleProductoResponse> lstResponse = new List<DetalleProductoResponse>();
            List<DetalleProducto> DetalleProductos = _DetalleProductoRepository.GetAll();
            lstResponse = _mapper.Map<List<DetalleProductoResponse>>(DetalleProductos);
            return lstResponse;
        }
        public DetalleProductoResponse GetById(int id)
        {
            DetalleProducto DetalleProducto = _DetalleProductoRepository.GetById(id);
            DetalleProductoResponse resul = _mapper.Map<DetalleProductoResponse>(DetalleProducto);
            return resul;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public DetalleProductoResponse Create(DetalleProductoRequest entity)
        {
            DetalleProducto DetalleProducto = _mapper.Map<DetalleProducto>(entity);
            DetalleProducto = _DetalleProductoRepository.Create(DetalleProducto);
            DetalleProductoResponse result = _mapper.Map<DetalleProductoResponse>(entity);
            return result;
        }
        public List<DetalleProductoResponse> InsertMultiple(List<DetalleProductoRequest> lista)
        {
            List<DetalleProducto> DetalleProductos = _mapper.Map<List<DetalleProducto>>(lista);
            DetalleProductos = _DetalleProductoRepository.InsertMultiple(DetalleProductos);
            List<DetalleProductoResponse> result = _mapper.Map<List<DetalleProductoResponse>>(DetalleProductos);
            return result;
        }
        public DetalleProductoResponse Update(DetalleProductoRequest entity)
        {
            DetalleProducto DetalleProducto = _mapper.Map<DetalleProducto>(entity);
            DetalleProducto = _DetalleProductoRepository.Update(DetalleProducto);
            DetalleProductoResponse result = _mapper.Map<DetalleProductoResponse>(entity);
            return result;
        }
        public List<DetalleProductoResponse> UpdateMultiple(List<DetalleProductoRequest> lista)
        {
            List<DetalleProducto> DetalleProductos = _mapper.Map<List<DetalleProducto>>(lista);
            DetalleProductos = _DetalleProductoRepository.UpdateMultiple(DetalleProductos);
            List<DetalleProductoResponse> result = _mapper.Map<List<DetalleProductoResponse>>(DetalleProductos);
            return result;
        }
        public int Delete(int id)
        {
            int cantidad = _DetalleProductoRepository.Delete(id);
            return cantidad;
        }
        public int DeleteMultipleItems(List<DetalleProductoRequest> lista)
        {
            List<DetalleProducto> DetalleProductos = _mapper.Map<List<DetalleProducto>>(lista);
            int cantidad = _DetalleProductoRepository.DeleteMultipleItems(DetalleProductos);
            return cantidad;
        }
    }
}
