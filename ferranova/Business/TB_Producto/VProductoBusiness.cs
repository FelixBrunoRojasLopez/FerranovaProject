using AutoMapper;
using BDFerranova;
using DocumentFormat.OpenXml.Drawing;
using IBusiness;
using IBusiness.TB_Producto;
using IRepository;
using IRepository.TB_Producto;
using Repository.TB_Producto;
using RequestResponseModel;
using RequestResponseModel.Request.Productos;
using RequestResponseModel.Response.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.TB_Producto
{
    
    public class VProductoBusiness : IVProductoBusiness
    {
        #region Inyeccion de dependencias
        private readonly IVProductoRepository _vProductoRepository;
        private readonly IProductoBusiness _productoBusiness;
        private readonly IDetalleProductoBusiness _detalleProductoBusiness;
        private readonly IMapper _mapper;
        public VProductoBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _vProductoRepository = new VProductoRepository();
            _detalleProductoBusiness = new DetalleProductoBusiness(mapper);
            _productoBusiness = new ProductoBusiness(mapper);
        }
        #endregion Inyeccion de dependencias
        #region Crud
        public VProductoResponse Create(VProductoRequest entity)
        {
            VProductoResponse response = new();
            #pragma warning disable CS8604 // Posible argumento de referencia nulo
            DetalleProductoResponse detalle = _detalleProductoBusiness.BuscarDetalle(entity.Descripcion);
            #pragma warning restore CS8604 // Posible argumento de referencia nulo
            ProductoRequest productoRequest = _mapper.Map<ProductoRequest>(entity);
            productoRequest.IdDetalleProducto = detalle.IdDetalleProducto;
            ProductoResponse productoResponse = _productoBusiness.Create(productoRequest);
            ListProductoResponse data = _mapper.Map<ListProductoResponse>(entity);
            data.IdProducto = productoResponse.IdProducto;
            response.Message = "Se registro";
            response.Producto.Add(data);

            return response;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultipleItems(List<VProductoRequest> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<VProductoResponse> GetAll()
        {
            List<VProductoResponse> response = new();
            VProductoResponse data = new();
            List<Vproducto> produto = _vProductoRepository.GetAll();
            List<ListProductoResponse> list = _mapper.Map<List<ListProductoResponse>>(produto);
            data.Message = "Lista de Producto";
            data.Producto.AddRange(list);
            response.Add(data);
            return response;
        }

        public GenericFilterResponse<VProductoResponse> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public VProductoResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<VProductoResponse> InsertMultiple(List<VProductoRequest> lista)
        {
            throw new NotImplementedException();
        }

        public VProductoResponse Update(VProductoRequest entity)
        {
            VProductoResponse response = new();
            #pragma warning disable CS8604 // Posible argumento de referencia nulo
            DetalleProductoResponse detalle = _detalleProductoBusiness.BuscarDetalle(entity.Descripcion);
            #pragma warning restore CS8604 // Posible argumento de referencia nulo
            ProductoRequest productoRequest = _mapper.Map<ProductoRequest>(entity);
            productoRequest.IdDetalleProducto = detalle.IdDetalleProducto;
            ProductoResponse productoResponse = _productoBusiness.Update(productoRequest);
            ListProductoResponse data = _mapper.Map<ListProductoResponse>(entity);
            response.Message = "Se Actualizar";
            response.Producto.Add(data);

            return response;
        }

        public List<VProductoResponse> UpdateMultiple(List<VProductoRequest> lista)
        {
            throw new NotImplementedException();
        }
        #endregion Crud
    }
}
