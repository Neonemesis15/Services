using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.CFG.JavaMovil;

namespace Lucky.Services.Contracts.DataContract
{
    public class AppMovilServiceRequest
    {
    }

    public class SincronizacionAppMovilService_Mov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_AppMovil_Sincronizar Sincronizar { get; set; }
    }


    public class RegistrarPedido_Response : BaseResponse
    {
    }

    public class RegistrarPedido_Request
    {
        [JsonProperty("a")]
        public List<E_Pedido_Cab> listaPedido { get; set; }
    }

    public class RegistrarCobro_Request
    {
        [JsonProperty("a")]
        public int codigo{ get; set; }
    }

    public class RegistrarCobro_Response : BaseResponse
    { }
}
