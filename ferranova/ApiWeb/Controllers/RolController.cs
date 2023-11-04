using AutoMapper;
using Business;
using IBusiness;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel;
using System.Net;

namespace ApiWeb.Controllers
{
    /// <summary>
    /// CONTROLADOR PARA ROL
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class RolController : Controller
    {
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IRolBusiness _RolBusiness;
        private readonly IMapper _mapper;
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="mapper"></param>
        public RolController(IMapper mapper)
        {
            _mapper = mapper;
            _RolBusiness = new RolBusiness(mapper);
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        #region CRUD METHODS
        /// <summary>
        /// RETORNA TODOS LOS REGISTROS DE LA TABLA Rol
        /// </summary>
        /// <returns>List-RolResponse</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<RolResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get()
        {
            //int a = 1 ;
            //int b = 0;
            //int resul = a / b;
            return Ok(_RolBusiness.GetAll());
        }
        /// <summary>
        /// RETORNA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>RolResponse</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(RolResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get(int id)
        {
            return Ok(_RolBusiness.GetById(id));
        }
        /// <summary>
        /// INSERTA UN REGISTRO EN LA TABLA Rol
        /// </summary>
        /// <param name="request">RolRequest</param>
        /// <returns>RolResponse</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(RolResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] RolRequest request)
        {
            return Ok(_RolBusiness.Create(request));
        }
        /// <summary>
        /// ACTUALIZA UN REGISTRO EN LA TABLA Rol
        /// </summary>
        /// <param name="request">RolRequest</param>
        /// <returns>RolResponse</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(RolResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Update([FromBody] RolRequest request)
        {
            return Ok(_RolBusiness.Update(request));
        }
        /// <summary>
        /// ELIMINA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>cantidad de registros eliminados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(RolResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Delete(int id)
        {
            return Ok(_RolBusiness.Delete(id));
        }
        #endregion CRUD METHODS
    }
}

