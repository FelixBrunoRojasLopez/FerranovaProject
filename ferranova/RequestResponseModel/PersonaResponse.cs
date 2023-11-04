using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class PersonaResponse
    {
        public int IdPersona { get; set; }
        [StringLength(50)]
        public string? Nombre { get; set; }
        [StringLength(50)]
        public string? Apellido { get; set; }
        [StringLength(150)]
        public string? Direccion { get; set; }
        [StringLength(12)]
        public string? Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        [StringLength(50)]
        public string? Correo { get; set; }
        public int IdTipoDocumento { get; set; }
        [StringLength(20)]
        public string? NroDocumento { get; set; }
        public string? NombreCompleto { get; set; }

        public string NroDocNombre
        {
            get
            {
                return string.Concat(NroDocumento, " - ", NombreCompleto);
            }
        }
    }
}
