using AutoMapper;
using BDFerranova;
using IBusiness;
using IRepository.TB_Producto;
using Repository.TB_Producto;
using RequestResponseModel.Request.Productos;
using RequestResponseModel.Response.Productos;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepository.TB_Venta;
using IBusiness.TB_Venta;
using Repository.TB_Venta;
using RequestResponseModel.Response.Venta;
using RequestResponseModel.Request.Venta;

namespace Business.TB_Venta
{
    public class VVentaBusiness : IVVentaBusiness
    {
        public VVentaResponse Create(VVentaRequest entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultipleItems(List<VVentaRequest> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<VVentaResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public GenericFilterResponse<VVentaResponse> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public VVentaResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<VVentaResponse> InsertMultiple(List<VVentaRequest> lista)
        {
            throw new NotImplementedException();
        }

        public VVentaResponse Update(VVentaRequest entity)
        {
            throw new NotImplementedException();
        }

        public List<VVentaResponse> UpdateMultiple(List<VVentaRequest> lista)
        {
            throw new NotImplementedException();
        }
    }
}