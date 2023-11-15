using AutoMapper;
using BDFerranova;
using RequestResponseModel;
using RequestResponseModel.Request.Cliente;
using RequestResponseModel.Request.Productos;
using RequestResponseModel.Response.Cliente;
using RequestResponseModel.Response.Productos;

namespace UtilAutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            #region Cargo
            CreateMap<Cargo, CargoRequest>().ReverseMap();
            CreateMap<Cargo, CargoResponse>().ReverseMap();
            CreateMap<CargoRequest, CargoResponse>().ReverseMap();
            #endregion Cargo
            #region Usuario
            CreateMap<UsuarioAcceso, UsuarioRequest>().ReverseMap();
            CreateMap<UsuarioAcceso, UsuarioResponse>().ReverseMap();
            CreateMap<UsuarioRequest, UsuarioResponse>().ReverseMap();
            #endregion Usuario
            #region Error
            CreateMap<Error, ErrorRequest>().ReverseMap();
            CreateMap<Error, ErrorResponse>().ReverseMap();
            CreateMap<ErrorRequest, ErrorResponse>().ReverseMap();
            #endregion Error
            #region Cliente
            CreateMap<Cliente, ClienteRequest>().ReverseMap();
            CreateMap<Cliente, ClienteResponse>().ReverseMap();
            CreateMap<ClienteRequest, ClienteResponse>().ReverseMap();

            CreateMap<VclienteRequest, ClienteRequest>().ReverseMap();
            CreateMap<VclienteRequest, ListClienteResponse>().ReverseMap();
            CreateMap<Vcliente, ListClienteResponse>().ReverseMap();
            #endregion Cliente
            #region Empleado
            CreateMap<Empleado, EmpleadoRequest>().ReverseMap();
            CreateMap<Empleado, EmpleadoResponse>().ReverseMap();
            CreateMap<EmpleadoRequest, EmpleadoResponse>().ReverseMap();
            #endregion Empleado
            #region Estado
            CreateMap<Estado, EmpleadoRequest>().ReverseMap();
            CreateMap<Estado, EstadoResponse>().ReverseMap();
            CreateMap<EstadoRequest, EstadoResponse>().ReverseMap();
            #endregion Estado
            #region Persona
            CreateMap<Persona, PersonaRequest>().ReverseMap();
            CreateMap<Persona, PersonaResponse>().ReverseMap();
            CreateMap<PersonaRequest, PersonaResponse>().ReverseMap();
            #endregion Persona
            #region Producto
            CreateMap<Producto, ProductoRequest>().ReverseMap();
            CreateMap<Producto, ProductoResponse>().ReverseMap();
            CreateMap<ProductoRequest, ProductoResponse>().ReverseMap();

            CreateMap<VProductoRequest, ProductoRequest>().ReverseMap();
            CreateMap<VProductoRequest, ListProductoResponse>().ReverseMap();
            CreateMap<Vproducto, ListProductoResponse>().ReverseMap();
            #endregion Producto
            #region Rol
            CreateMap<Rol, RolRequest>().ReverseMap();
            CreateMap<Rol, RolResponse>().ReverseMap();
            CreateMap<RolRequest, RolResponse>().ReverseMap();
            #endregion Rol
            #region Venta
            CreateMap<Ventum, VentumRequest>().ReverseMap();
            CreateMap<Ventum, VentumResponse>().ReverseMap();
            CreateMap<VentumRequest, VentumResponse>().ReverseMap().
                ForMember(destino =>
                destino.Total,
                opt => opt.MapFrom(origen => origen.FechaRegistro.Value.ToString("dd/MM/yyyy")));
            #endregion Venta
            #region DetallePedido
            CreateMap<DetallePedido, DetallePedidoRequest>().ReverseMap();
            CreateMap<DetallePedido, DetallePedidoResponse>().ReverseMap();
            CreateMap<DetallePedidoRequest, DetallePedidoResponse>().ReverseMap();
            #endregion DetallePedido
            #region DetalleProducto
            CreateMap<DetalleProducto, DetalleProductoRequest>().ReverseMap();
            CreateMap<DetalleProducto, DetalleProductoResponse>().ReverseMap();
            CreateMap<DetalleProductoRequest, DetalleProductoResponse>().ReverseMap();
            #endregion DetalleProducto
            #region DetalleVenta
            CreateMap<DetalleVentum, DetalleVentumRequest>().ReverseMap();
            CreateMap<DetalleVentum,DetalleVentumResponse>().ReverseMap();
            CreateMap<DetalleVentumRequest, DetalleVentumResponse>();
            #endregion DetalleVenta
            #region MetodoPago
            CreateMap<MetodoPago, MetodoPagoRequest>().ReverseMap();
            CreateMap<MetodoPago, MetodoPagoResponse>().ReverseMap();
            CreateMap<MetodoPagoRequest, MetodoPagoResponse>().ReverseMap();
            #endregion MetodoPago
            #region Pedido
            CreateMap<Pedido, PedidoRequest>().ReverseMap();
            CreateMap<Pedido, PedidoResponse>().ReverseMap();
            CreateMap<PedidoRequest, PedidoResponse>().ReverseMap();
            #endregion Pedido
            #region TipoComprobante
            CreateMap<TipoComprobante, TipoComprobanteRequest>().ReverseMap();
            CreateMap<TipoComprobante, TipoComprobanteResponse>().ReverseMap();
            CreateMap<TipoClienteRequest, TipoComprobanteResponse>().ReverseMap();
            #endregion TipoComprobante
            #region TipoDocumento
            CreateMap<TipoDocumento, TipoDocumentoRequest>().ReverseMap();
            CreateMap<TipoDocumento, TipoDocumentoResponse>().ReverseMap();
            CreateMap<TipoDocumentoRequest, TipoDocumentoResponse>().ReverseMap();
            #endregion TipoDocumento
            #region SessionUsuario
            CreateMap<SesionUsuario, SesionUsuarioRequest>().ReverseMap();
            CreateMap<SesionUsuario, SesionUsuarioResponse>().ReverseMap();
            CreateMap<SesionUsuarioRequest, SesionUsuarioResponse>().ReverseMap();
            #endregion SessionUsuario
            #region MenuAcceso
            CreateMap<MenuAcceso, MenuAccesoRequest>().ReverseMap();
            CreateMap<MenuAcceso, MenuAccesoResponse>().ReverseMap();
            CreateMap<MenuAccesoRequest, MenuAccesoResponse>().ReverseMap();
            #endregion MenuAcceso
            #region Reporte
            CreateMap<DetalleVentum, ReporteResquest>().
                ForMember(destino =>
                destino.FechaRegistro,
                opt => opt.MapFrom(origen => origen.IdVentaNavigation.FechaRegistro.Value.ToString("dd/MM/yyyy"))).
                ForMember(destino =>
                destino.NumeroDocumento,
                opt => opt.MapFrom(origen => origen.IdVentaNavigation.NumeroDocumento)).
                ForMember(destino =>
                destino.TipoPago,//tipo de pago con tipo de pago pero estamos haciendole con el id 
                opt => opt.MapFrom(origen => Convert.ToString(origen.IdVentaNavigation.IdMetodopagoNavigation.NombreMetodoPago))).
                ForMember(destino =>
                destino.TotalVenta,
                opt => opt.MapFrom(origen => origen.IdVentaNavigation.Total.Value)).
                ForMember(destino =>
                destino.Producto,
                opt => opt.MapFrom(origen => origen.IdProductoNavigation.Nombre)).
                ForMember(destino =>
                destino.Precio,
                opt => opt.MapFrom(origen => origen.IdProductoNavigation.Precio.Value)).
                ForMember(destino =>
                destino.Total,
                opt => opt.MapFrom(origen => origen.Total.Value));
            #endregion Reporte
        }
    }
}