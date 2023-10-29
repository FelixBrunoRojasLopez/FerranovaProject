using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class RolRequest
    {
        public int IdRol { get; set; }
        [StringLength(7)]
        public string? Codigo { get; set; }
        [StringLength(255)]
        public string? Descripcion { get; set; }
        [StringLength(100)]
        public string? Funcion { get; set; }
        [Required]
        public bool IdEstado { get; set; }

        //[ForeignKey("IdEstado")]
        //[InverseProperty("Rols")]
        //public virtual Estado IdEstadoNavigation { get; set; } = null!;

        //[InverseProperty("IdRolNavigation")]
        //public virtual ICollection<UsuarioAcceso> UsuarioAccesos { get; set; } = new List<UsuarioAcceso>();
    }
}
