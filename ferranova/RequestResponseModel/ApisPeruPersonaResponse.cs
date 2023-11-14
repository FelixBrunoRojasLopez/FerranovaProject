using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ApisPeruPersonaResponse
    {
        public bool Success { get; set; }
        public string dni { get; set; } = "";
        public string nombre { get; set; } = "";
        public string apellidoPaterno { get; set; } = "";
        public string apellidoMaterno { get; set; } = "";
        public string codVerifica { get; set; } = "";

    }
}
