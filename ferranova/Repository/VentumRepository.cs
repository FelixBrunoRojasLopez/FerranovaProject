using BDFerranova;
using IRepository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Repository
{
    public class VentumRepository : CRUDRepository<Ventum>, IVentumRepository
    {
        public IQueryable<Ventum> Consultar(Expression<Func<Ventum, bool>> filtro = null)
        {
            IQueryable<Ventum> queryVenta = filtro == null ? db.Set<Ventum>():db.Set<Ventum>().Where(filtro);
            return queryVenta;
        }

        public GenericFilterResponse<Ventum> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<VentumResponse> Historial(string buscarPor, string numeroVenta, string fechaInicio, string fechaFin)
        {
            throw new NotImplementedException();
        }

        public List<Ventum> InsertMultiple(List<Ventum> ventums)
        {
            throw new NotImplementedException();
        }

        public  Ventum Registrar(Ventum ventum)
        {
            Ventum ventaGenerada = new Ventum();
            using(var transaction = db.Database.BeginTransaction())
            {
                foreach(DetalleVentum dv in ventum.DetalleVenta)
                {
                    Producto producto_encontrado = db.Productos.Where(p => p.IdProducto == dv.IdProducto).First();
                    producto_encontrado.Stock = producto_encontrado.Stock - dv.Cantidad;
                    db.Productos.Update(producto_encontrado);

                }
                 db.SaveChanges();
                NumeroDoc correlativo = db.NumeroDocs.First();
                
                correlativo.UltimoNumero = correlativo.UltimoNumero + 1;
                correlativo.FechaRegistro = DateTime.Now;

                db.NumeroDocs.Update(correlativo);
                db.SaveChanges();

                int CantidadDigitos = 4;
                string ceros = string.Concat(Enumerable.Repeat("0", CantidadDigitos));
                string numeroVenta = ceros + correlativo.UltimoNumero.ToString();

                numeroVenta = numeroVenta.Substring(numeroVenta.Length - CantidadDigitos, CantidadDigitos);

                ventum.NumeroDocumento = numeroVenta;
                db.Venta.Add(ventum);
                db.SaveChanges();

                ventaGenerada = ventum;

                transaction.Commit();
            }
            return ventaGenerada;
        }

        public Task<VentumResponse> Registrar(VentumRequest request)
        {
            throw new NotImplementedException();
        }

        public List<VentumResponse> Reporte(string fechaInicio, string fechaFin)
        {
            throw new NotImplementedException();
        }
    }
}
