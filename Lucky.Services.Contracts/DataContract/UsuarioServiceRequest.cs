using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Services.Contracts.DataContract
{
    public class UsuarioServiceRequest
    {
        [JsonProperty("u")]
        public string Usuario { get; set; }

        [JsonProperty("p")]
        public string Password { get; set; }
    }

    public class UsuarioServiceResponse : BaseResponse
    {
        [JsonProperty("u")]
        public EUsuario Usuario { get; set; }
    }

    public class UsuarioAuditoriaServiceResponse : BaseResponse
    {
        [JsonProperty("u")]
        public EUsuarioAuditoria Usuario { get; set; }
    }


    public class UsuarioService_Mov_Response : BaseResponse
    {
        [JsonProperty("u")]
        public E_Usuario Usuario { get; set; }
    }
}
