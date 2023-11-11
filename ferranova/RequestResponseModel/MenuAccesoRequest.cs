using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class MenuAccesoRequest
    {
        public int IdMenu { get; set; }
        public string? Nombre { get; set; }
        //public string? Descripcion { get; set; }
        public string? Icono { get; set; }
        //public string? Datatarget { get; set; }
        public string? Url { get; set; }
        //public int Padre { get; set; }
        public bool IdEstado { get; set; }
        //public DateTime FechaCreacion { get; set; }
       // public DateTime FechaActualizacion { get; set; }
    }
}
