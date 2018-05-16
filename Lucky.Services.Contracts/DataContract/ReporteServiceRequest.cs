using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;

namespace Lucky.Services.Contracts.DataContract
{
    #region App Movil Lucky
    public class ReporteServiceRequest
    {
        [JsonProperty("p")]
        public List<E_Reporte_Presencia> ListaReportePresencia { get; set; }

        [JsonProperty("f")]
        public List<E_Reporte_Fotografico> ListaReporteFotografico { get; set; }

        [JsonProperty("c")]
        public List<E_Reporte_Codigo_ITT> ListaReporteCodigoITT { get; set; }

        [JsonProperty("v")]
        public E_Visita Visita{ get; set; }
    }
    public class ReporteServiceResponse : BaseResponse
    {
    }

    //Add 15/02/2012 pSalas
    public class ReporteBodegaServiceRequest
    {        
        [JsonProperty("a")]
        public List<E_Reporte_RegistroPDV> ListaE_Reporte_RegistroPDV { get; set; }
        
    }
    public class ReporteBodegaServiceResponse : BaseResponse
    {

    }

    public class ReporteFotograficoAuditoriaServiceRequest
    {
        [JsonProperty("f")]
        public E_Reporte_Fotografico_Auditoria ReporteFotografico { get; set; }

        [JsonProperty("v")]
        public E_Visita Visita { get; set; }

    }
    public class ReporteFotograficoAuditoriaServiceResponse : BaseResponse
    {
    }

    //Add 01/03/2012 Joseph Gonzales
    public class ReportePrecioRequest
    {
        [JsonProperty("z")]
        public E_Reporte_Precio ReportePrecio { get; set; }
    }
    public class ReportePrecioResponse : BaseResponse
    {
    }

    //Add 01/03/2012 Joseph Gonzales
    public class ReporteDisponibilidadRequest
    {
        [JsonProperty("z")]
        public E_Reporte_Disponibilidad ReporteDisponibilidad { get; set; }
    }
    public class ReporteDisponibilidadResponse : BaseResponse
    {
    }

    //Add 01/03/2012 Joseph Gonzales
    public class ReporteFotograficoRequest
    {
        [JsonProperty("z")]
        public E_Reporte_Fotografico_General ReporteFotografico { get; set; }
    }
    public class ReporteFotograficoResponse : BaseResponse
    {
    }

    //Add 06/03/2012 pSalas Reportes Colgate FarmaciaDT
    public class ReporteColgateFarmaciaDTRequest {
        [JsonProperty("p")]
        public List<E_Reporte_Presencia_General> oListReportePresencia { get; set; }
        [JsonProperty("i")]//Actualizacion de "v" por "i", 12/03/2012
        public List<E_Reporte_Visibilidad_Competencia> oListReporteVisibilidadCompetencia { get; set; }
        [JsonProperty("r")]
        public List<E_Reporte_Promocion_General> oListReportePromocion { get; set; }
        [JsonProperty("o")]
        public List<E_Reporte_Pop_General> oListReportePop { get; set; }
        
        //Add 12/03/2012 pSalas
        [JsonProperty("v")]
        public E_Visita oE_Visita { get; set; }

        //Add 23/04/2012 
        //Joseph Gonzales
        [JsonProperty("c")]
        public List<E_Reporte_Codigo_ITT> oListaReporteCodigoITT { get; set; }
        
    }
    public class ReporteColgateFarmaciaDTResponse : BaseResponse { }
    
    //Add 06/03/2012 pSalas Reportes Colgate FarmaciaIT
    public class ReporteColgateFarmaciaITRequest
    {
        [JsonProperty("p")]
        public List<E_Reporte_Presencia_General> oListReportePresencia { get; set; }
        [JsonProperty("f")]
        public List<E_Reporte_Fotografico_General> oListReporteFotografico { get; set; }

        //Add 12/03/2012 pSalas
        [JsonProperty("v")]
        public E_Visita oE_Visita { get; set; }

        //Add 23/04/2012 
        //Joseph Gonzales
        [JsonProperty("c")]
        public List<E_Reporte_Codigo_ITT> oListaReporteCodigoITT { get; set; }
        
    }
    public class ReporteColgateFarmaciaITResponse : BaseResponse { }

    //Add 16/03/2012 pSalas Registrar PDV_AndroidPrueba
    public class ReportePDVAndroidRequest {
        [JsonProperty("p")]
        public List<EPuntoVenta> oListPDV { get; set; }
    }
    public class ReportePDVAndroidResponse : BaseResponse { }

    /// <summary>
    /// Registrar Implementar Bodega 
    /// pSalas 
    /// 28/03/2012
    /// </summary>
    public class ReporteImplementarBodegaServiceRequest
    {
        [JsonProperty("a")]
        public E_Reporte_ImplementarBodega oE_Reporte_ImplementarBodega { get; set; }

    }
    public class ReporteImplementarBodegaServiceResponse : BaseResponse
    {

    }
    
    /// <summary>
    /// Registar Presencia Colgate Bodega
    /// pSalas 28/03/2012
    /// </summary>
    public class ReportePresenciaBodegaRequest {
        [JsonProperty("a")]
        public List<E_Reporte_Presencia_General> oListE_Reporte_Presencia_General { get; set; }

        [JsonProperty("c")]
        public List<E_Reporte_Codigo_ITT> ListaReporteCodigoITT { get; set; }

        [JsonProperty("v")]
        public E_Visita oE_Visita { get; set; }
    }
    public class ReportePresenciaBodegaResponse : BaseResponse { }

    /// <summary>
    /// 
    /// </summary>
    public class ReporteFotoAndroidRequest
    {
        [JsonProperty("Foto")]
        public List<E_FotoAndroid> file;
    }
    public class ReporteFotoAndroidResponse : BaseResponse
    {

    }

    
    //Descripcion: Reporte de Stock para todas las Cuentas
    //Fecha      : 05/05/2012 PSA
    public class ReporteStockRequest
    {
        [JsonProperty("z")]
        public E_Reporte_Stock ReporteStock { get; set; }
    }
    public class ReporteStockResponse : BaseResponse { }
    #endregion

    #region AppMovil Movistar
    
    #region App Movil Colgate

    /// <summary>
    /// Descripcion : Request y Response para Reportes Colgate Mayorista - App Movil Movistar
    /// Fecha       : 18/05/2012 PSA
    /// </summary>
    public class ReportesColgateMayoristasService_Mov_Request
    {
        [JsonProperty("a")]
        public List<E_Reporte_Presencia_Mov> oListaRepPresencia_Mov { get; set; }
        [JsonProperty("b")]
        public List<E_Reporte_Fotografico_Mov> oListaRepFotografico_Mov { get; set; }
        [JsonProperty("c")]
        public List<E_Reporte_Codigo_ITT_Mov> oListaRepCodigoITT_Mov { get; set; }
        [JsonProperty("d")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }
        [JsonProperty("e")]
        public int AppEnvia { get; set; }

    }
    public class ReportesColgateMayoristasService_Mov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Reportes_Colgate_Mayoristas_Mov_Response oE_Reportes_Colgate_Mayoristas_Mov_Response { get; set; }
    }
    
    /// <summary>
    /// Descripcion : Request y Response para Reportes Colgate Minorista - App Movil Movistar
    /// Fecha       : 21/05/2012 PSA
    /// </summary>
    public class ReportesColgateMinoristasServices_Mov_Request {
        [JsonProperty("a")]
        public List<E_Reporte_Presencia_Mov> oListaRepPresencia_Mov { get; set; }
        [JsonProperty("b")]
        public List<E_Reporte_Fotografico_Mov> oListaRepFotografico_Mov { get; set; }
        [JsonProperty("c")]
        public List<E_Reporte_Codigo_ITT_Mov> oListaRepCodigoITT_Mov { get; set; }
        [JsonProperty("d")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }
        [JsonProperty("e")]
        public int AppEnvia { get; set; }
    }
    public class ReportesColgateMinoristasServices_Mov_Response : BaseResponse { 
        [JsonProperty("a")]
        public E_Reportes_Colgate_Minorista_Mov_Response oE_Reportes_Colgate_Minorista_Mov_Response { get; set; }
    }

    /// <summary>
    /// Descripcion : Request y Response para Reportes Colgate Farmacia DT - App Movil Movistar
    /// Fecha       : 21/05/2012 PSA
    /// </summary>
    public class ReportesColgateFarmaciasDT_Mov_Request {
        [JsonProperty("a")]
        public List<E_Reporte_Presencia_Mov> oListaRepPresencia_Mov { get; set; }
        [JsonProperty("b")]
        public List<E_Reporte_Codigo_ITT_Mov> oListaRepCodigoITT_Mov { get; set; }
        [JsonProperty("c")]
        public List<E_Reporte_Promocion_Mov> oListaRepPromocion_Mov { get; set; }
        [JsonProperty("d")]
        public List<E_Reporte_Mat_Apoyo_Mov> oListaRepMatApoyo_Mov { get; set; }
        [JsonProperty("e")]
        public List<E_Reporte_VisCompentencia_Mov> oListaRepVisCompetencia_Mov { get; set; }
        [JsonProperty("f")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }
        [JsonProperty("g")]
        public int AppEnvia { get; set; }
    }
    public class ReportesColgateFarmaciasDT_Mov_Response : BaseResponse {
        [JsonProperty("a")]
        public E_Reportes_Colgate_Farmacia_DT_Mov_Response oE_Reportes_Colgate_Farmacia_DT_Mov_Response { get; set; }
    }

    /// <summary>
    /// Descripcion : Request y Response para Reportes Colgate Farmacia IT - App Movil Movistar
    /// Fecha       : 21/05/2012 PSA
    /// </summary>
    public class ReportescolgateFarmaciasIT_Mov_Request {
        [JsonProperty("a")]
        public List<E_Reporte_Presencia_Mov> oListaRepPresencia_Mov { get; set; }
        [JsonProperty("b")]
        public List<E_Reporte_Fotografico_Mov> oListaRepFotografico_Mov { get; set; }
        [JsonProperty("c")]
        public List<E_Reporte_Codigo_ITT_Mov> oListaRepCodigoITT_Mov { get; set; }
        [JsonProperty("d")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }
        [JsonProperty("e")]
        public int AppEnvia { get; set; }
    }
    public class ReportescolgateFarmaciasIT_Mov_Response : BaseResponse {
        [JsonProperty("a")]
        public E_Reportes_Colgate_Farmacia_IT_Mov_Response oE_Reportes_Colgate_Farmacia_IT_Mov_Response { get; set; }
    }

    /// <summary>
    /// Descripcion : Request y Response para Reportes Colgate Bodega - App Movil Movistar
    /// Fecha       : 01/06/2012
    /// Autor       : Joseph Gonzales
    /// </summary>
    public class ReportesColgateBodegaService_Mov_Request
    {
        [JsonProperty("a")]
        public List<E_Reporte_Presencia_Mov> oListaRepPresencia_Mov { get; set; }

        [JsonProperty("b")]
        public List<E_Reporte_Codigo_ITT_Mov> oListaRepCodigoITT_Mov { get; set; }

        [JsonProperty("c")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }

        [JsonProperty("d")]
        public List<E_Reporte_Fotografico_Mov> oListaRepFotografico_Mov { get; set; }

        [JsonProperty("e")]
        public int AppEnvia { get; set; }
    }

    public class ReportesColgateBodegaService_Mov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Reportes_Colgate_Bodega_Mov_Response oE_Reportes_Colgate_Bodega_Mov { get; set; }

    }

    /// <summary>
    /// Descripcion : Request y Response para Registro de PDV para Colgate Bodega - App Movil Movistar
    /// Fecha       : 04/06/2012
    /// Autor       : PSA.
    /// </summary>
    public class ReportesColgateBodega_RegistrarPDV_Mov_Request {
        [JsonProperty("a")]
        public E_Reporte_RegistroPDV_Mov oE_Reporte_RegistroPDV_Mov { get; set; }
    }
    public class ReportesColgateBodega_RegistrarPDV_Mov_Response : BaseResponse {

        [JsonProperty("a")]
        public E_Reporte_RegistroPDV_Response oE_Reporte_RegistroPDV_Response { get; set; }
    }
    
    #endregion

    #region  App Movil Alicorp

    /// <summary>
    /// Descripcion : Request y Response para Reportes Alicorp Mayoristas - App Movil Movistar
    /// Fecha       : 28/05/2012 PSA
    /// </summary>
    public class ReportesAlicorpMayoristaServices_Request {
        [JsonProperty("a")]
        public List<E_Reporte_Precio_Mov> oLista_Rep_Precio_Mov { get; set; }
        [JsonProperty("b")]
        public List<E_Reporte_SOD_Mov> oLista_Rep_SOD_Mov { get; set; }
        [JsonProperty("c")]
        public List<E_Reporte_Fotografico_Mov> oLista_Rep_Fotografico_Mov { get; set; }
        [JsonProperty("d")]
        public List<E_Reporte_Competencia_Mov> oLista_Rep_Competencia_Mov { get; set; }
        [JsonProperty("e")]
        public List<E_Reporte_Stock_Mov> oLista_Rep_Stock_Mov { get; set; }
        [JsonProperty("f")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }
        [JsonProperty("g")]
        public int AppEnvia { get; set; }
    }
    public class ReportesAlicorpMayoristaServices_Response : BaseResponse{ }
        
    /// <summary>
    /// Descripcion : Request y Response para Reportes Alicorp Autoservicios - App Movil Movistar
    /// Fecha       : 28/05/2012 PSA
    /// </summary>
    public class ReportesAlicorpAutoserviciosServices_Request {
        [JsonProperty("a")]
        public List<E_Reporte_Precio_Mov> oLista_Rep_Precio_Mov { get; set; }
        [JsonProperty("b")]
        public List<E_Reporte_Fotografico_Mov> oLista_Rep_Fotografico_Mov { get; set; }
        [JsonProperty("c")]
        public List<E_Reporte_Competencia_Mov> oLista_Rep_Competencia_Mov { get; set; }
        [JsonProperty("d")]
        public List<E_Reporte_Exhibicion_Mov> oLista_Rep_Exhibicion_Mov { get; set; }
        [JsonProperty("e")]
        public List<E_Reporte_Quiebre_Mov> oLista_Rep_Quiebre_Mov { get; set; }
        [JsonProperty("f")]
        public List<E_Reporte_LayOut_Mov> oLista_Rep_LayOut_Mov { get; set; }
        [JsonProperty("g")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }
        [JsonProperty("h")]
        public int AppEnvia { get; set; }
    }
    public class ReportesAlicorpAutoserviciosServices_Response : BaseResponse { }

    #endregion

    #region App Movil San Fernando

    /// <summary>
    /// Autor: Joseph Gonzales
    /// Fecha: 28 - 05 - 2012
    /// Descripción: Request y Response para Reporte San Fernando Aves Vivas - App Móvil Android
    /// </summary>
    public class ReporteSanFernandoAAVV_Mov_Request
    {
        [JsonProperty("a")]
        public List<E_Reporte_Stock_Mov> oListaRepStock_Mov { get; set; }
        [JsonProperty("b")]
        public List<E_Reporte_Precio_Mov> oListaRepPrecio_Mov { get; set; }
        [JsonProperty("c")]
        public List<E_Reporte_Fotografico_Mov> oListaRepFotografico_Mov { get; set; }
        [JsonProperty("d")]
        public List<E_Reporte_Incidencia_Mov> oListaRepIncidencia_Mov { get; set; }
        [JsonProperty("e")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }
        [JsonProperty("f")]
        public int AppEnvia { get; set; }
    }
    public class ReporteSanFernandoAAVV_Mov_Response : BaseResponse { }

    /// <summary>
    /// Autor: Joseph Gonzales
    /// Fecha: 28 - 05 - 2012
    /// Descripción: Request y Response para Reporte San Fernando Moderno - App Móvil Android
    /// </summary>
    public class ReporteSanFernandoModerno_Mov_Request
    {
        [JsonProperty("a")]
        public List<E_Reporte_Precio_Mov> oListaRepPrecio_Mov { get; set; }

        [JsonProperty("b")]
        public List<E_Reporte_Fotografico_Mov> oListaRepFotografico_Mov { get; set; }

        [JsonProperty("c")]
        public List<E_Reporte_Competencia_Mov> oListaRepCompetencia_Mov { get; set; }
                
        [JsonProperty("d")]
        public List<E_Reporte_Stock_Mov> oListaRepStock_Mov { get; set; }

        [JsonProperty("e")]
        public List<E_Reporte_Impulso_Mov> oListaRepImpulso_Mov { get; set; }

        [JsonProperty("f")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }

        [JsonProperty("g")]
        public int AppEnvia { get; set; }
    }
    public class ReporteSanFernandoModerno_Mov_Response : BaseResponse { }

    /// <summary>
    /// Autor: Joseph Gonzales
    /// Fecha: 28 - 05 - 2012
    /// Descripción: Request y Response para Reporte San Fernando Tradicional - App Móvil Android
    /// Actualizacion : 26/07/2012 Pablo Salas A.
    /// </summary>
    /// 
    public class ReporteSanFernandoTradicional_Mov_Request
    {
        [JsonProperty("a")]
        public List<E_Reporte_Precio_Mov> oListaRepPrecio_Mov { get; set; }

        [JsonProperty("b")]
        public List<E_Reporte_Exhibicion_Mov> oListaRepExhibicion_Mov { get; set; }

        [JsonProperty("c")]
        public List<E_Reporte_Marcaje_Precio_Mov> oListaRepMarcaje_Mov { get; set; }

        [JsonProperty("d")]
        public List<E_Reporte_Mat_Apoyo_Mov> oListaRepMaterialApoyo_Mov { get; set; }

        [JsonProperty("e")]
        public List<E_Reporte_Capacitacion_Mov> oListaRepCapacitacion_Mov { get; set; }
        //propiedad agregada el 13/07/2012 por :DUEB

        [JsonProperty("f")]
        public List<E_Reporte_Incidencia_Mov> oListaRepIncidencia_Mov { get; set; }

        [JsonProperty("g")]
        public List<E_Reporte_Credito_Competencia_Mov> oListaRepCredito_Competencia_Mov { get; set; }
        //propiedad agregada el 16/07/2012 por :DUEB

        [JsonProperty("h")]
        public List<E_Reporte_Presencia_Mov> oListaRepPresencia_Mov { get; set; }

        [JsonProperty("i")]
        public E_Visita_Mov oE_Visita_Mov { get; set; }

        [JsonProperty("j")]
        public int AppEnvia { get; set; }

        #region Propiedades Deshabilitadas
        //[JsonProperty("d")]
        //public List<E_Reporte_Mandil_Mov> oListaRepMandil_Mov { get; set; }

        //[JsonProperty("e")]
        //public List<E_Reporte_MatAdicional_Mov> oListaRepMatAdicional_Mov { get; set; }

        //[JsonProperty("f")]
        //public List<E_Reporte_Observacion_Mov> oListaRepObservacion_Mov { get; set; }
        #endregion

    }
    public class ReporteSanFernandoTradicional_Mov_Response : BaseResponse { }

    #endregion 

    #endregion
}
