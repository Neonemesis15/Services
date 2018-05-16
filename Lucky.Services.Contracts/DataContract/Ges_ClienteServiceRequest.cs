using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.CFG.JavaMovil;
using Newtonsoft.Json;
using Lucky.Entity.Common.Servicio;

namespace Lucky.Services.Contracts.DataContract
{
    public class Obtener_Usuario_Digitacion_Request
    {
        [JsonProperty("a")]
        public string nombreUsuario { get; set; }
    }

    public class Obtener_Usuario_Digitacion_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Usuario_Digitacion usuarioDigitacion { get; set; }
    }
}
