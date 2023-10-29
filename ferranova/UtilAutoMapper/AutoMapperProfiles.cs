using AutoMapper;
using BDFerranova;
using RequestResponseModel;

namespace UtilAutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Cargo, CargoRequest>().ReverseMap();
            CreateMap<Cargo, CargoResponse>().ReverseMap();
            CreateMap<CargoRequest, CargoResponse>().ReverseMap();

            CreateMap<UsuarioAcceso, UsuarioRequest>().ReverseMap();
            CreateMap<UsuarioAcceso, UsuarioResponse>().ReverseMap();
            CreateMap<UsuarioRequest, UsuarioResponse>().ReverseMap();

            CreateMap<Error, ErrorRequest>().ReverseMap();
            CreateMap<Error, ErrorResponse>().ReverseMap();
            CreateMap<ErrorRequest, ErrorResponse>().ReverseMap();

            CreateMap<Cliente, ClienteRequest>().ReverseMap();
            CreateMap<Cliente, ClienteResponse>().ReverseMap();
            CreateMap<ClienteRequest, ClienteResponse>().ReverseMap();

            CreateMap<Empleado, EmpleadoRequest>().ReverseMap();
            CreateMap<Empleado, EmpleadoResponse>().ReverseMap();
            CreateMap<EmpleadoRequest, EmpleadoResponse>().ReverseMap();

            CreateMap<Estado, EmpleadoRequest>().ReverseMap();
            CreateMap<Estado, EstadoResponse>().ReverseMap();
            CreateMap<EstadoRequest, EstadoResponse>().ReverseMap();

            CreateMap<Persona, PersonaRequest>().ReverseMap();
            CreateMap<Persona, PersonaResponse>().ReverseMap();
            CreateMap<PersonaRequest, PersonaResponse>().ReverseMap();

            CreateMap<Producto, ProductoRequest>().ReverseMap();
            CreateMap<Producto, ProductoResponse>().ReverseMap();
            CreateMap<ProductoRequest, ProductoResponse>().ReverseMap();

            CreateMap<Rol, RolRequest>().ReverseMap();
            CreateMap<Rol, RolResponse>().ReverseMap();
            CreateMap<RolRequest, RolResponse>().ReverseMap();

            CreateMap<Ventum, VentumRequest>().ReverseMap();
            CreateMap<Ventum, VentumResponse>().ReverseMap();
            CreateMap<VentumRequest, VentumResponse>().ReverseMap();

            CreateMap<DetallePedido, DetallePedidoRequest>().ReverseMap();
            CreateMap<DetallePedido, DetallePedidoResponse>().ReverseMap();
            CreateMap<DetallePedidoRequest, DetallePedidoResponse>().ReverseMap();

            CreateMap<DetalleProducto, DetalleProductoRequest>().ReverseMap();
            CreateMap<DetalleProducto, DetalleProductoResponse>().ReverseMap();
            CreateMap<DetalleProductoRequest, DetalleProductoResponse>().ReverseMap();

            CreateMap<DetalleVentum, DetalleVentumRequest>().ReverseMap();
            CreateMap<DetalleVentum,DetalleVentumResponse>().ReverseMap();
            CreateMap<DetalleVentumRequest, DetalleVentumResponse>();

            CreateMap<MetodoPago, MetodoPagoRequest>().ReverseMap();
            CreateMap<MetodoPago, MetodoPagoResponse>().ReverseMap();
            CreateMap<MetodoPagoRequest, MetodoPagoResponse>().ReverseMap();

            CreateMap<Pedido, PedidoRequest>().ReverseMap();
            CreateMap<Pedido, PedidoResponse>().ReverseMap();
            CreateMap<PedidoRequest, PedidoResponse>().ReverseMap();

            CreateMap<TipoComprobante, TipoComprobanteRequest>().ReverseMap();
            CreateMap<TipoComprobante, TipoComprobanteResponse>().ReverseMap();
            CreateMap<TipoClienteRequest, TipoComprobanteResponse>().ReverseMap();

            CreateMap<TipoDocumento, TipoDocumentoRequest>().ReverseMap();
            CreateMap<TipoDocumento, TipoDocumentoResponse>().ReverseMap();
            CreateMap<TipoDocumentoRequest, TipoDocumentoResponse>().ReverseMap();

            CreateMap<SesionUsuario, SesionUsuarioRequest>().ReverseMap();
            CreateMap<SesionUsuario, SesionUsuarioResponse>().ReverseMap();
            CreateMap<SesionUsuarioRequest, SesionUsuarioResponse>().ReverseMap();

        }
    }
}