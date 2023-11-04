using AutoMapper;
using Business;
using IBusiness;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel;
using System.Net;

namespace ApiWeb.Controllers
{
    /// <summary>
    /// CONTROLADOR PARA DetalleVentumS
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]

    public class DetalleVentaController : ControllerBase
    {
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IDetalleVentumBusiness _DetalleVentumBusiness;
        private readonly IMapper _mapper;
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="mapper"></param>
        public DetalleVentaController(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleVentumBusiness = new DetalleVentumBusiness(mapper);
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        #region CRUD METHODS
        /// <summary>
        /// RETORNA TODOS LOS REGISTROS DE LA TABLA DetalleVentum
        /// </summary>
        /// <returns>List-DetalleVentumResponse</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<DetalleVentumResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get()
        {
            //int a = 1 ;
            //int b = 0;
            //int resul = a / b;
            return Ok(_DetalleVentumBusiness.GetAll());
        }
        /// <summary>
        /// RETORNA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>DetalleVentumResponse</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(DetalleVentumResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get(int id)
        {
            return Ok(_DetalleVentumBusiness.GetById(id));
        }
        /// <summary>
        /// INSERTA UN REGISTRO EN LA TABLA DetalleVentum
        /// </summary>
        /// <param name="request">DetalleVentumRequest</param>
        /// <returns>DetalleVentumResponse</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(DetalleVentumResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] DetalleVentumRequest request)
        {
            return Ok(_DetalleVentumBusiness.Create(request));
        }
        /// <summary>
        /// ACTUALIZA UN REGISTRO EN LA TABLA DetalleVentum
        /// </summary>
        /// <param name="request">DetalleVentumRequest</param>
        /// <returns>DetalleVentumResponse</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(DetalleVentumResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Update([FromBody] DetalleVentumRequest request)
        {
            return Ok(_DetalleVentumBusiness.Update(request));
        }
        /// <summary>
        /// ELIMINA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>cantidad de registros eliminados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(DetalleVentumResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Delete(int id)
        {
            return Ok(_DetalleVentumBusiness.Delete(id));
        }
        #endregion CRUD METHODS
    }
}
