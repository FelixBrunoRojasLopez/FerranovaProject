using BDFerranova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class TipoDocumentoFilterResponse
    {
        public int CantidadTotalRegistros {  get; set; }
        public List<PersonaResponse> Lista {  get; set; }
    }
}
