using AutoMapper;
using Business;
using Business.TB_Producto;
using IBusiness;
using IBusiness.TB_Producto;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel;
using RequestResponseModel.Request.Productos;
using RequestResponseModel.Response.Productos;
using System.Net;

namespace ApiWeb.Controllers
{
    /// <summary>
    /// CONTROLADOR PARA Producto
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductoController : Controller
    {
        #region DECLARACION DE VARIABLE Y CONSTRUCTOR
        private readonly IVProductoBusiness _ProductoBusiness;
        private readonly IMapper _mapper;
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="mapper"></param>
        public ProductoController(IMapper mapper)
        {
            _mapper = mapper;
            _ProductoBusiness = new VProductoBusiness(mapper);
        }
        #endregion DECLARACION DE VARIABLE Y CONSTRUCTOR
        #region CRUD METHODS
        /// <summary>
        /// RETORNA TODOS LOS REGISTROS DE LA TABLA Producto
        /// </summary>
        /// <returns>List-ProductoResponse</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<VProductoResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get()
        {
            //int a = 1 ;
            //int b = 0;
            //int resul = a / b;
            return Ok(_ProductoBusiness.GetAll());
        }
        /// <summary>
        /// RETORNA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>ProductoResponse</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(VProductoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get(int id)
        {
            return Ok(_ProductoBusiness.GetById(id));
        }
        /// <summary>
        /// INSERTA UN REGISTRO EN LA TABLA Producto
        /// </summary>
        /// <param name="request">ProductoRequest</param>
        /// <returns>ProductoResponse</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(VProductoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] VProductoRequest request)
        {
            return Ok(_ProductoBusiness.Create(request));
        }
        /// <summary>
        /// ACTUALIZA UN REGISTRO EN LA TABLA Producto
        /// </summary>
        /// <param name="request">ProductoRequest</param>
        /// <returns>ProductoResponse</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(VProductoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Update([FromBody] VProductoRequest request)
        {
            return Ok(_ProductoBusiness.Update(request));
        }
        /// <summary>
        /// ELIMINA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>cantidad de registros eliminados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ProductoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Delete(int id)
        {
            return Ok(_ProductoBusiness.Delete(id));
        }
        #endregion CRUD METHODS
    }
}
