using AutoMapper;
using Business;
using IBusiness;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RequestResponseModel;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using UtilSecuriry;

namespace ApiWeb.Controllers
{
    /// <summary>
    /// CONTROLLER PARA LA AUTENTICACIÓN
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        private readonly IAuthBusiness _authBusiness;
        private readonly IMapper _mapper;
        private readonly UtilEncriptarDesencriptar _cripto;
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="mapper">AAAA</param>
        public AuthController(IMapper mapper)
        {
            _mapper = mapper;

            _authBusiness = new AuthBusiness(mapper);
            _cripto = new UtilEncriptarDesencriptar();
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR

        /// <summary>
        /// Valida que el servicio este activo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]

        public IActionResult Get()
        {
            return Ok(true);
        }
        /// <summary>
        /// Metodo para realizar el inicio de sesión
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(LoginResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            LoginResponse loginResponse = _authBusiness.Login(request);
            if (loginResponse.Success)//cambiar o quitar el if
            {
                loginResponse.Token = CreateToken(loginResponse);
                return Ok(loginResponse);
            }
            else
            {
                return Ok(loginResponse);
            }
            //loginResponse.Token = CreateToken(loginResponse);
            //return Ok(loginResponse);
        }
        #region INICIO GENERACIÓN DE TOKEN

        private string CreateToken(LoginResponse oLoginResponse)
        {
            ////obteniendo información de nuestro archivo appsettings.json
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            ////OBTENER EL TIEMPO DE VIDA DEL TOKEN
            int tiempoVida = int.Parse(configurationFile["Jwt:TimeJWTMin"]);
            ////01 VAMOS A DETALLAR LOS CLAIMS
            ////==> INFORMACIÓN QUE SE PUEDE ALMACENAR DENTRO DEL TOKEN GENERADO

            ////string stringClaims = JsonConvert.SerializeObject(oLoginResponse);
            ////stringClaims = _cripto.AES_encriptar(stringClaims);
            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, configurationFile["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),// - UTC-0
                        new Claim(ClaimTypes.Role, oLoginResponse.Rol.IdRol.ToString()),
                        new Claim("UserId", oLoginResponse.Usuario.IdUsuarioAcceso.ToString()),
                        new Claim("DisplayName", oLoginResponse.Persona.Nombre),
                        new Claim("UserName", oLoginResponse.Usuario.Username),
                        new Claim("RoleName", oLoginResponse.Rol.Descripcion),
                    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configurationFile["Jwt:Issuer"],
                configurationFile["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(tiempoVida),
                signingCredentials: signIn

                );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        #endregion FIN GENERACIÓN DE TOKEN




    }
}
