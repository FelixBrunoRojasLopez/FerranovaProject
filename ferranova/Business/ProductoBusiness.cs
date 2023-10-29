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
    public class ProductoBusiness : IProductoBusiness
    {
            //Inyeccion de Dependecias
            #region DECLARACION DE VARIABLE Y CONSTRUCTOR
            private readonly IProductoRepository _ProductoRepository;
            private readonly IMapper _mapper;
            public ProductoBusiness(IMapper mapper)
            {
                _mapper = mapper;
                _ProductoRepository = new ProductoRepository();
            }
            #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
            public List<ProductoResponse> GetAll()
            {
                //declarando la lista de Producto response como resultado
                List<ProductoResponse> lstResponse = new List<ProductoResponse>();
                List<Producto> Productos = _ProductoRepository.GetAll();
                lstResponse = _mapper.Map<List<ProductoResponse>>(Productos);
                return lstResponse;
            }
            public ProductoResponse GetById(int id)
            {
                Producto Producto = _ProductoRepository.GetById(id);
                ProductoResponse resul = _mapper.Map<ProductoResponse>(Producto);
                return resul;
            }

            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }

            public ProductoResponse Create(ProductoRequest entity)
            {
                Producto Producto = _mapper.Map<Producto>(entity);
                Producto = _ProductoRepository.Create(Producto);
                ProductoResponse result = _mapper.Map<ProductoResponse>(entity);
                return result;
            }
            public List<ProductoResponse> InsertMultiple(List<ProductoRequest> lista)
            {
                List<Producto> Productos = _mapper.Map<List<Producto>>(lista);
                Productos = _ProductoRepository.InsertMultiple(Productos);
                List<ProductoResponse> result = _mapper.Map<List<ProductoResponse>>(Productos);
                return result;
            }
            public ProductoResponse Update(ProductoRequest entity)
            {
                Producto Producto = _mapper.Map<Producto>(entity);
                Producto = _ProductoRepository.Update(Producto);
                ProductoResponse result = _mapper.Map<ProductoResponse>(entity);
                return result;
            }
            public List<ProductoResponse> UpdateMultiple(List<ProductoRequest> lista)
            {
                List<Producto> Productos = _mapper.Map<List<Producto>>(lista);
                Productos = _ProductoRepository.UpdateMultiple(Productos);
                List<ProductoResponse> result = _mapper.Map<List<ProductoResponse>>(Productos);
                return result;
            }
            public int Delete(int id)
            {
                int cantidad = _ProductoRepository.Delete(id);
                return cantidad;
            }
            public int DeleteMultipleItems(List<ProductoRequest> lista)
            {
                List<Producto> Productos = _mapper.Map<List<Producto>>(lista);
                int cantidad = _ProductoRepository.DeleteMultipleItems(Productos);
                return cantidad;
            }
    }
}
