using AutoMapper;
using BDFerranova;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using IBusiness;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilSecuriry;

namespace Business
{
    public class AuthBusiness:IAuthBusiness
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        private readonly IUsuarioBusiness _usuarioBusiness;
        private readonly IMapper _mapper;
        private readonly IRolBusiness _rolBusiness;
        private readonly IEmpleadoBusiness _empleadoBusiness;
        private readonly UtilEncriptarDesencriptar _cripto;
        public AuthBusiness(IMapper mapper)
        {
            _mapper = mapper;
            _usuarioBusiness = new UsuarioBusiness(mapper);
            _rolBusiness = new RolBusiness(mapper);
            _empleadoBusiness = new EmpleadoBusiness(mapper);
            _cripto = new UtilEncriptarDesencriptar();
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        public LoginResponse Login(LoginRequest request)
        {
            LoginResponse result = new LoginResponse();

            
            Vusuario usuario = _usuarioBusiness.ObtenerVistaUsername(request.UserName);

            //01 VALIDAMOS QUE EL USUARIO EXISTA
            if (usuario == null)
            {
                return result;
            }

            //02 VALIDAMOS QUE EL USUARIO EXISTA
            //02.01 ==> proceso de encriptar un texto
            string newPassword = (request.Password);
            
            if (newPassword != usuario.Password)
            {
                return result;
            }

            result.Success = true;
            result.Mensaje = "LOGIN CORRECTO";
            result.Usuario = new UsuarioLoginResponse();
            result.Usuario.IdUsuarioAcceso = usuario.IdUsuarioAcceso;
            result.Usuario.Username = usuario.Username;
            result.Usuario.ChangePassword = usuario.ChangePassword;
            result.Usuario.CelularIdentificador = "";
            //result.Usuario.ChangePassword = usuario.ChangePassword;
            result.Usuario.Correo= usuario.Correo;
            result.Usuario.IdEmpleado = usuario.IdEmpleado;
            result.Rol = new RolResponse();
            result.Usuario.IdEstado = usuario.IdEstado;
            result.Rol.IdRol = usuario.IdRol;
            result.Rol.Codigo = usuario.Codigo;
            result.Rol.Funcion = usuario.Funcion;
            result.Rol.Descripcion = usuario.Descripcion;
            result.Persona = new PersonaResponse();
            result.Persona.IdPersona = usuario.IdPersona;
            result.Persona.Nombre = usuario.Nombre;
            result.Persona.Apellido = usuario.Apellido;
            result.Persona.NombreCompleto = usuario.NombreCompleto="";
            result.Persona.NroDocumento = usuario.NroDocumento;
            result.Cargo = new CargoResponse();
            result.Cargo.DescripcionCargo = usuario.Descripcion;
            //result.Empleado.IdPersona = usuario.IdEmpleado;


            /*ESTE TIPO DE IMPLEMENTACIÓN NO ES LA MAS OPTIMA*/
            /*
             * VAMOS A REALIZAR CONSULTAS INDEPENDIENTES
             * _rolBussnies
             * _personaBussnies
             */

            //result.Usuario = new UsuarioLoginResponse();
            //result.Rol = new RolResponse();
            //busqueda del usuario
            //busqueda del rol
            return result;
        }
    }
}