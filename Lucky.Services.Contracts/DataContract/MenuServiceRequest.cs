using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application;

namespace Lucky.Services.Contracts.DataContract
{
    public class MenuServiceRequest
    {
        [JsonProperty("i")]
        public int menu_id { get; set; }
    }

    public class MenuServiceResponse : BaseResponse
    {
        [JsonProperty("m")]
        public List<EMenuDetalle> MenuDetalles { get; set; }

    }
}
