using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Servicio;


namespace Lucky.Services.Contracts.DataContract
{

    public class ReporteCliente_Stock_Validacion_Request
    {
        [JsonProperty("a")]
        public string anio { get; set; }

        [JsonProperty("i")]//cambio b por i
        public string mes { get; set; }

        [JsonProperty("c")]
        public int periodo { get; set; }

        [JsonProperty("d")]
        public string codPdv { get; set; }

        [JsonProperty("e")]
        public int codOficina { get; set; }

        [JsonProperty("f")]
        public string codCategoria { get; set; }

        [JsonProperty("g")]
        public bool validado { get; set; }

        [JsonProperty("h")]
        public string user{ get; set; }
    }
    public class ReporteCliente_Stock_Validacion_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ReporteCliente_Stock_Validacion oE_ReporteCliente_Stock_Validacion { get; set; }
    }

    //Por: Ditmar Estrada Bernuy , 12/11/2012
    #region Obtener las Oficinas por canal,compañia y codigo de Persona
    public class OficinasPorPersona_Request
    {
        [JsonProperty("a")]
        public int CodPersona { get; set; }

        [JsonProperty("b")]
        public string CodCanal { get; set; }

        [JsonProperty("c")]
        public int CodCompania { get; set; }
    }
    public class OficinasPorPersona_Response: BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Oficina> Oficinas{ get; set; }
    }
    #endregion
    //Cliente CocaCola - 13/10/2012 - PSalas
    //public class ObtenerInformesCanje_Request { 
    
    //}
    //public class ObtenerInformesCanje_Response : BaseResponse {
    //    [JsonProperty("a")]
    //    public E_InformesCanje oE_InformesCanje { get; set; }
    //}

    #region Analisis de Implementacion
    public class getDatosTotalImplementadoObjetivos_Request {
        [JsonProperty("a")]//Add 22/10/2012. psa. Envia 1 - Muestra todos los Puntos de Venta, 2 - Para mostrar los Puntos de Venta de Frecuencia 8.
        public string opcion { get; set; }
    }
    public class getDatosTotalImplementadoObjetivos_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosTotalImplementadoObjetivos> getDatosTotalImplementadoObjetivos { get; set; }
    }

    //Add 15/10/2012 psa. Obtener los Puntos de Venta Implementados y No Implementados, la fase(Implementado o no Implementado) y coordenadas.
    public class getDatosDetalleImplementacionObjetivo_Request {
        [JsonProperty("a")]
        public string opcion { get; set; }
    }
    public class getDatosDetalleImplementacionObjetivo_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosDetalleImplementacionObjetivo> GetDatosDetalleImplementacionObjetivo { get; set; } 
    }

    public class getCharColumn3DStacked_Request { }
    public class getCharColumn3DStacked_Response : BaseResponse {
        [JsonProperty("a")]
        public List<CharColumn3DStacked> getCharColumn3DStacked { get; set; }
    }

    public class getDatosPorVisita_Request { }
    public class getDatosPorVisita_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosPorVisita> getDatosPorVisita { get; set; }
    }

    public class getDatosPorAcumulado_Request { }
    public class getDatosPorAcumulado_Response : BaseResponse { 
        [JsonProperty("a")]
        public List<GetDatosPorAcumulado> getDatosPorAcumulado {get;set;}
    }

    public class getDatosPorMerma_Request { }
    public class getDatosPorMerma_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosPorMerma> getDatosPorMerma { get; set; }
    }

    public class getDatosMatImpl_Request { }
    public class getDatosMatImpl_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosMatImpl> getDatosMatImpl { get; set; }
    }

    public class getDatosBodeImplFrec_Request { }
    public class getDatosBodeImplFrec_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosBodeImplFrec> getDatosBodeImplFrec { get; set; }
    }
    //Add 17/10/2012. psa. descripcion: Obtener Datos del Resumen para Implementacion y Razones de No Implementacion.
    public class getDatosPorResumeImp_RazNoImpl_Request { }
    public class getDatosPorResumeImp_RazNoImpl_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosPorResumeImp_RazNoImpl> getDatosPorResumeImp_RazNoImpl { get; set; }
    }
    #endregion
    #region Analisis de Stock
    public class getDatosPorCantStock_Request { }
    public class getDatosPorCantStock_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosPorCantStock> getDatosPorCantStock { get; set; }
    }

    public class getDatosPorCantTotalPlatosVendidos_Request { }
    public class getDatosPorCantTotalPlatosVendidos_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosPorCantTotalPlatosVendidos> getDatosPorCantTotalPlatosVendidos { get; set; }
    }
    //Add 16/10/2012 psa. descripcion:ObtenerDatosPorDetalleStockVendidosVsObjetivo, muestra coordenadas para representarlas en mapa.
    public class getDatosPorDetalleStockVenVsObj_Request { }
    public class getDatosPorDetalleStockVenVsObj_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosPorDetalleStockVenVsObj> getDatosPorDetalleStockVenVsObj { get; set; }
    }
    
    //Add 05/11/2012 psa.
    public class getTotAvaPlaIngAlm_Request { }
    public class getTotAvaPlaIngAlm_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<GetDatosPorCantStock> getDatosPorCantStock { get; set; }
    }
    //Add 05/11/2012 psa.
    public class getTotPlaDistCDV_Request { }
    public class getTotPlaDistCDV_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<GetDatosPorCantStock> getDatosPorCantStock { get; set; }
    }
    //Add 05/11/2012 psa.
    public class getAvaPlaObj_Request { }
    public class getAvaPlaObj_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<GetDatosPorCantStock> getDatosPorCantStock { get; set; }
    }
    #endregion
    #region Analisis de Merma
    public class getDatosPorTipMerma_Request { }
    public class getDatosPorTipMerma_Response : BaseResponse {
        [JsonProperty("a")]
        public List<GetDatosPorTipMerma> getDatosPorTipMerma { get; set; }
    }
    #endregion
}
