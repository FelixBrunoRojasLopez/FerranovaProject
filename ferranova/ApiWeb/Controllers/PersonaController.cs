using AutoMapper;
using Business;
using IBusiness;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel;
using System.Net;

namespace ApiWeb.Controllers
{ /// <summary>
  /// CONTROLADOR PARA PERSONA
  /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]

    public class PersonaController : ControllerBase
    {
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IPersonaBusiness _PersonaBusiness;
        private readonly IMapper _mapper;
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="mapper"></param>
        public PersonaController(IMapper mapper)
        {
            _mapper = mapper;
            _PersonaBusiness = new PersonaBusiness(mapper);
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        #region CRUD METHODS
        /// <summary>
        /// RETORNA TODOS LOS REGISTROS DE LA TABLA Persona
        /// </summary>
        /// <returns>List-PersonaResponse</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<PersonaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get()
        {
            //int a = 1 ;
            //int b = 0;
            //int resul = a / b;
            return Ok(_PersonaBusiness.GetAll());
        }
        /// <summary>
        /// RETORNA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>PersonaResponse</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(PersonaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get(int id)
        {
            return Ok(_PersonaBusiness.GetById(id));
        }
        /// <summary>
        /// INSERTA UN REGISTRO EN LA TABLA Persona
        /// </summary>
        /// <param name="request">PersonaRequest</param>
        /// <returns>PersonaResponse</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(PersonaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] PersonaRequest request)
        {
            return Ok(_PersonaBusiness.Create(request));
        }
        [HttpPost("filtro")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(PersonaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult GetByFilter([FromBody] TipoDocumentoFilterRequest request)
        {
            TipoDocumentoFilterResponse res = _PersonaBusiness.ObtenerPorFiltro(request);
            return Ok(res);
        }

        /// <summary>
        /// ACTUALIZA UN REGISTRO EN LA TABLA Persona
        /// </summary>
        /// <param name="request">PersonaRequest</param>
        /// <returns>PersonaResponse</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(PersonaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Update([FromBody] PersonaRequest request)
        {
            return Ok(_PersonaBusiness.Update(request));
        }
        /// <summary>
        /// ELIMINA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>cantidad de registros eliminados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(PersonaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Delete(int id)
        {
            return Ok(_PersonaBusiness.Delete(id));
        }
        #endregion CRUD METHODS
    }
}
