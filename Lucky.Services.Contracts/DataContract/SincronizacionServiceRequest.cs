using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Services.Contracts.DataContract
{
    public class SincronizacionServiceRequest
    {
        [JsonProperty("e")]
        public string Id_Equipo { get; set; }

        [JsonProperty("c")]
        public string Cliente_Id { get; set; } 

        [JsonProperty("i")]
        public string Person_Id { get; set; }        
    }

    public class SincronizacionServiceResponse : BaseResponse
    {
        [JsonProperty("s")]
        public ESincronizar Sincronizar { get; set; }
    }

    public class SincronizacionServiceAuditoriaRequest
    {
        [JsonProperty("e")]
        public string Id_Equipo { get; set; }
        
        [JsonProperty("i")]
        public string Person_Id { get; set; }
    }

    public class SincronizacionServiceAuditoriaResponse : BaseResponse
    {
        [JsonProperty("s")]
        public ESincronizarAuditoria Sincronizar { get; set; }
    }

    //Add pSalas 16/02/2012
    public class SincronizacionServiceBodegaRequest
    {
        [JsonProperty("e")]
        public string Id_Equipo { get; set; }

        [JsonProperty("p")]
        public string Id_Perfil { get; set; }

        [JsonProperty("c")]
        public string Id_Cliente { get; set; }

        [JsonProperty("u")] //name_user
        public string Name_User { get; set; }


    }
    //Add pSalas 16/02/2012
    public class SincronizacionServiceBodegaResponse : BaseResponse
    {

        [JsonProperty("r")]
        public E_Sincronizar_Bodega SincronizarBodega { get; set; }
    }

    //Add pSalas 16/03/2012 Sincronizacion Android Prueba.
    public class SincronizacionAndroidRequest { 
    
    }
    public class SincronizacionAndroidResponse : BaseResponse {
        [JsonProperty("r")]
        public ESincronizar SincronizarAndroid { get; set; }
    }

    
    #region Clases_Android

    public class SincronizacionService_Mov_Request
    {
        [JsonProperty("a")]
        public string Id_Equipo { get; set; }

        [JsonProperty("b")]
        public int Cliente_Id { get; set; }

        [JsonProperty("c")]
        public string Person_Id { get; set; }
    }

    public class SincronizacionService_Mov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Sincronizar Sincronizar { get; set; }
    }

    public class SincronizacionPreDatos_Request
    {
        [JsonProperty("a")]
        public string Id_Equipo { get; set; }

        [JsonProperty("b")]
        public int Cliente_Id { get; set; }

        [JsonProperty("c")]
        public string Person_Id { get; set; }
    }

    public class SincronizacionPreDatos_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_SincronizarPreDatos SincronizarPreDatos { get; set; }
    }

    #endregion Clases_Android
}