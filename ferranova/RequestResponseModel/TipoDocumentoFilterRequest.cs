using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class TipoDocumentoFilterRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// nro de pagina a mostrar
        /// </summary>
        public int Pagina{ get; set; }
        /// <summary>
        /// cantidad de registro a mopstrar por pagina
        /// </summary>
        public int Cantidad{ get; set; }
        /// <summary>
        /// si se manda un campo a buscar nrodocumento
        /// </summary>
        public string NroDocumento { get; set; } = "";
        /// <summary>
        /// siu se manda unn valor a buscar un valor en el campo de nombre
        /// </summary>
        public string Nombre { get; set; } = "";

    }
}
