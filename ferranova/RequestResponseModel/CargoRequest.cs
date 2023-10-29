using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BDFerranova;

namespace RequestResponseModel
{
    public class CargoRequest
    {
        public int IdCargo { get; set; }

        public string? DescripcionCargo { get; set; }
        public string? Codigo { get; set; }
        public bool IdEstado { get; set; }
    }
} 