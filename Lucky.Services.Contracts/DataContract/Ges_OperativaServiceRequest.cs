using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Servicio;

namespace Lucky.Services.Contracts.DataContract
{
    #region Gestion de Reportes

    #region Gestion de Reportes - Registrar
    /// <summary>
    /// Fecha:       11/05/2012
    /// Creado:      Joseph Gonzales
    /// Descripción: Request del Reporte de Precios General
    /// </summary>
    public class Reporte_Precio_Request : BaseRequestOperativa
    {
        [JsonProperty("a")]
        public List<E_Reporte_Precio> ReportePrecio { get; set; }
    }
    public class Reporte_Precio_Response : BaseResponse
    {
    }

    /// <summary>
    /// Fecha:       11/05/2012
    /// Creado:      Joseph Gonzales
    /// Descripción: Request del Reporte de Stock General
    /// </summary>
    public class Reporte_Stock_Request : BaseRequestOperativa
    {
        [JsonProperty("a")]
        public List<E_Reporte_Stock> ReporteStock { get; set; }
    }
    public class Reporte_Stock_Response : BaseResponse { }

    public class Reporte_SOD_Request : BaseRequestOperativa
    {
        [JsonProperty("a")]
        public List<E_Reporte_SOD> oLista_ReporteSOD { get; set; }
    }
    public class Reporte_SOD_Response : BaseResponse { }
    
    /// <summary>
    /// Descripcion : Registrar Reporte Fotografico
    /// Fecha       : 31/05/2012 PSA
    /// </summary>
    public class Reporte_Competencia_Request : BaseRequestOperativa
    {
        [JsonProperty("a")]
        public List<E_Reporte_Competencia> olista_ReporteCompetencia { get; set; }
    }
    public class Reporte_Competencia_Response : BaseResponse { }

    public class Reporte_Exhibicion_Request : BaseRequestOperativa
    {
        [JsonProperty("a")]
        public List<E_Reporte_Exhibicion> oLista_ReporteExhibicion { get; set; }
    }
    public class Reporte_Exhibicion_Response : BaseResponse { }

    public class Reporte_Quiebre_Request : BaseRequestOperativa
    {
        [JsonProperty("a")]
        public List<E_Reporte_Quiebre> oLista_ReporteQuiebre { get; set; }
    }
    public class Reporte_Quiebre_Response : BaseResponse { }

    public class Reporte_LayOut_Request : BaseRequestOperativa
    {
        [JsonProperty("a")]
        public List<E_Reporte_LayOut> oLista_ReporteLayOut { get; set; }
    }
    public class Reporte_LayOut_Response : BaseResponse { }

    /// <summary>
    /// Descripcion : Registrar Reporte Fotografico
    /// Fecha       : 31/05/2012 PSA
    /// </summary>
    public class Reporte_Fotografico_Request : BaseRequestOperativa {
        [JsonProperty("a")]
        public List<E_Reporte_Fotografico_General> oLista_ReporteFotografico { get; set; }
    }
    public class Reporte_Forografico_Response : BaseResponse { }

    //Add 14/11/2012. Psa. Registrar Reporte Fotografico CocaCola 
    public class Reporte_Fotografico_Mov_Request {
        [JsonProperty("a")]
        public List<E_Reporte_Fotografico_Mov> oListaE_Reporte_Fotografico_Mov { get; set; }
    }
    public class Reporte_Fotografico_Mov_Response :BaseResponse { }

    /// <summary>
    /// Author:Pablo Salas A.
    /// Fecha: 26/09/2012
    /// Descripcion:
    /// </summary>
    public class Registrar_Reporte_Encuesta_Request
    {
        [JsonProperty("a")]
        public E_Reporte_Encuesta oE_Reporte_Encuesta { get; set; }
    }

    public class Registrar_Reporte_Encuesta_EQF_Request
    {
        [JsonProperty("a")]
        public E_Reporte_Encuesta_EQF oE_Reporte_Encuesta_EQF { get; set; }
    }

    public class Registrar_Reporte_Encuenta_Response : BaseResponse { }
    #endregion

    #region Gestion de Reportes- Consultar
    /// <summary>
    /// Autor: Joseph Gonzales
    /// Fecha: 11/05/2012
    /// </summary>
    public class Consultar_Reporte_Stock_Request
    {
        [JsonProperty("a")]
        public string CodServicio { get; set; }

        [JsonProperty("b")]
        public int CodCompania { get; set; }

        [JsonProperty("c")]
        public string CodCanal { get; set; }

        [JsonProperty("d")]
        public int CodOficina { get; set; }

        [JsonProperty("e")]
        public string CodCategoria { get; set; }

        [JsonProperty("f")]
        public int CodReportsCampaña { get; set; }

        [JsonProperty("g")]
        public string TipoData { get; set; }
    }
    public class Consultar_Reporte_Stock_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Consulta_Reporte_Stock> Consulta_Reporte_Stock { get; set; }

    }
    
    /// <summary>
    /// Autor: Joseph Gonzales
    /// Fecha: 14/05/2012
    /// </summary>    
    public class Validar_Reporte_Stock_Request
    {
        [JsonProperty("a")]
        public string listaValidarReporteStock { get; set; }

        [JsonProperty("b")]
        public string listaInValidarReporteStock { get; set; }
    }
    public class Validar_Reporte_Stock_Response : BaseResponse
    {

    }

    /// =--OK
    /// Fecha: 15/05/2012 PSA
    /// </summary>   
    public class Consultar_Reporte_Stock_General_Request {
         [JsonProperty("a")]
        public string CodPersona{get;set;}
         [JsonProperty("b")]
        public string CodCampania{get;set;}
         [JsonProperty("c")]
        public string CodCanal{get;set;}
         [JsonProperty("d")]
        public string CodOficina{get;set;}
         [JsonProperty("e")]
            public string CodNodoComercial{get;set;}
         [JsonProperty("f")]
        public string CodigoPDV_Compania{get;set;}
         [JsonProperty("g")]
        public string CodCategoria {get;set;}
         [JsonProperty("h")]
        public string CodFamilia {get;set;}
        [JsonProperty("i")]
        public DateTime f_inicio {get;set;}
         [JsonProperty("j")]
        public DateTime f_fin { get; set; }
         
    }
    public class Consultar_Reporte_Stock_General_Response : BaseResponse {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Consulta_Reporte_Stock> Consulta_Reporte_Stock { get; set; }
    }

    public class Consultar_Reporte_Precio_General_Request {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
        [JsonProperty("b")]
        public string CodCampania { get; set; }
        [JsonProperty("c")]
        public string CodCanal { get; set; }
        [JsonProperty("d")]
        public string CodOficina { get; set; }
        [JsonProperty("e")]
        public string CodNodoComercial { get; set; }
        [JsonProperty("f")]
        public string CodigoPDV_Compania { get; set; }
        [JsonProperty("g")]
        public string CodCategoria { get; set; }
        [JsonProperty("h")]
        public string CodSubcategoria { get; set; }
        [JsonProperty("i")]
        public string CodMarca { get; set; }
        [JsonProperty("j")]
        public string codProducto { get; set; }
        [JsonProperty("k")]
        public DateTime f_inicio { get; set; }
        [JsonProperty("l")]
        public DateTime f_fin { get; set; }
    }
    public class Consultar_Reporte_Precio_General_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Consulta_Reporte_Precio> Consulta_Reporte_Precio { get; set; }
    }

    public class Consultar_Reporte_SOD_General_Request {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
        [JsonProperty("b")]
        public string CodCampania { get; set; }
        [JsonProperty("c")]
        public string CodCanal { get; set; }
        [JsonProperty("d")]
        public string CodOficina { get; set; }
        [JsonProperty("e")]
        public string CodNodoComercial { get; set; }
        [JsonProperty("f")]
        public string CodigoPDV_Compania { get; set; }
        [JsonProperty("g")]
        public string CodCategoria { get; set; }
        [JsonProperty("h")]
        public string CodMarca { get; set; }
        [JsonProperty("i")]
        public DateTime f_inicio { get; set; }
        [JsonProperty("j")]
        public DateTime f_fin { get; set; }
    }
    public class Consultar_Reporte_SOD_General_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Consulta_Reporte_SOD> Consulta_Reporte_SOD { get; set; }
    } 

    public class Consultar_Reporte_LayOut_General_Request {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
        [JsonProperty("b")]
        public string CodCampania { get; set; }
        [JsonProperty("c")]
        public string CodCanal { get; set; }
        [JsonProperty("d")]
        public string CodCategoria { get; set; }
        [JsonProperty("e")]
        public string CodMarca { get; set; }
        [JsonProperty("f")]
        public DateTime f_inicio { get; set; }
        [JsonProperty("g")]
        public DateTime f_fin { get; set; }
    }
    public class Consultar_Reporte_LayOut_General_Response : BaseResponse {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Consulta_Reporte_LayOut> Consulta_Reporte_LayOut { get; set; }
    }

    public class Consultar_Reporte_Quiebre_General_Request {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
        [JsonProperty("b")]
        public string CodCampania { get; set; }
        [JsonProperty("c")]
        public string CodCanal { get; set; }
        [JsonProperty("d")]
        public string CodOficina { get; set; }
        [JsonProperty("e")]
        public string CodNodoComercial { get; set; }
        [JsonProperty("f")]
        public string CodigoPDV_Compania { get; set; }
        [JsonProperty("g")]
        public string CodCategoria { get; set; }
        [JsonProperty("h")]
        public string CodMarca { get; set; }
        [JsonProperty("i")]
        public string codProducto { get; set; }
        [JsonProperty("j")]
        public DateTime f_inicio { get; set; }
        [JsonProperty("k")]
        public DateTime f_fin { get; set; }
    }
    public class Consultar_Reporte_Quiebre_General_Response : BaseResponse {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Consulta_Reporte_Quiebre> Consulta_Reporte_Quiebre { get; set; }
    }

    public class Consultar_Reporte_Exhibicion_General_Request {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
        [JsonProperty("b")]
        public string CodCampania { get; set; }
        [JsonProperty("c")]
        public string CodCanal { get; set; }
        [JsonProperty("d")]
        public string CodOficina { get; set; }
        [JsonProperty("e")]
        public string CodNodoComercial { get; set; }
        [JsonProperty("f")]
        public string CodigoPDV_Compania { get; set; }
        [JsonProperty("g")]
        public string CodCategoria { get; set; }
        [JsonProperty("h")]
        public string CodMarca { get; set; }
        [JsonProperty("i")]
        public string f_inicio { get; set; }
        [JsonProperty("j")]
        public string f_fin { get; set; }
    }
    public class Consultar_Reporte_Exhibicion_General_Response : BaseResponse {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Consulta_Reporte_Exhibicion> Consulta_Reporte_Exhibicion { get; set; }
    }

    public class Consulta_Reporte_Presencia_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodCanal { get; set; }

        [JsonProperty("c")]
        public string CodOficina { get; set; }

        [JsonProperty("d")]
        public string CodNodoComercial { get; set; }

        [JsonProperty("e")]
        public string CodigoPDV { get; set; }

        [JsonProperty("f")]
        public string CodCategoria { get; set; }

        [JsonProperty("g")]
        public string CodMarca { get; set; }

        [JsonProperty("h")]
        public string CodSupervisor { get; set; }

        [JsonProperty("i")]
        public string CodPersona { get; set; }

        [JsonProperty("j")]
        public string CodTipoReporte { get; set; }

        [JsonProperty("k")]
        public string f_incio { get; set; }

        [JsonProperty("l")]
        public string f_fin { get; set; }
    }
    public class Consulta_Reporte_Presencia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Consulta_Reporte_Presencia> oListConsulta_Reporte_Presencia { get; set; }
    }

    public class Consulta_Reporte_PresenciaConsolidado_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodEquipo { get; set; }

        [JsonProperty("c")]
        public string CodCanal { get; set; }

        [JsonProperty("d")]
        public string CodMercaderista { get; set; }

        [JsonProperty("e")]
        public string CodOficina { get; set; }

        [JsonProperty("f")]
        public string CodMalla { get; set; }

        [JsonProperty("g")]
        public string CodigoPDV { get; set; }

        [JsonProperty("h")]
        public string CodTipoReporte { get; set; }

        [JsonProperty("i")]
        public string f_incio { get; set; }

        [JsonProperty("j")]
        public string f_fin { get; set; }
    }
    public class Consulta_Reporte_PresenciaConsolidado_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ContentStringDataSet oE_ContentStringDataSet { get; set; }
    }

    /// <summary>
    /// Creado por: Giam Farfán
    /// Fecha:04/10/2012
    /// Descripción: Listar informes para Consumo Masivo y Marketing Xplora v2 para usuarios Alicorp con perfil 0999.
    /// </summary>
    public class ListarInformesCMv2_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }
        [JsonProperty("b")]
        public string codCliente { get; set; }
        [JsonProperty("c")]
        public string idagrupacion { get; set; }
        [JsonProperty("d")]
        public string idPersona { get; set; }
    }
    public class ListarInformesCMv2_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Informesv2> oListaInformes{ get; set; }
    }

    public class InformesMKTv2_Request
    {
        [JsonProperty("a")]
        public int idCanal { get; set; }
        [JsonProperty("b")]
        public int idReporte { get; set; }
        [JsonProperty("c")]
        public int idMarca { get; set; }
        [JsonProperty("d")]
        public int idServicio { get; set; }
        [JsonProperty("e")]
        public string anio { get; set; }
    }
    public class InformesMKTv2_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Informes oE_Informes { get; set; }
    }

    #endregion 

    #endregion

    #region Gestion Login
    /// <summary>
    /// Autor: Carlos Marin
    /// Fecha: 05/06/2012
    /// </summary>   
    public class Logueo_Response : BaseResponse
    {
        [JsonProperty("a")]
        public Lucky.Entity.Common.Servicio.E_Persona Logueo { get; set; }
    }
    public class Logueo_Request : BaseResponse
    {
        [JsonProperty("a")]
        public string name_user { get; set; }
        [JsonProperty("b")]
        public string User_Password { get; set; }

    }
    #endregion

    #region Gestion Unicos
    public class Consultar_Reporte_Data_Validada_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Reporte_Data_Validada DataValidada { get; set; }
    }
    
    public class Consulta_Reporte_Relevo_Request
    {
        [JsonProperty("a")]
        public string fechaConsulta { get; set; }

        [JsonProperty("b")]
        public string codCliente { get; set; }

        [JsonProperty("c")]
        public string codUsuario { get; set; }

        [JsonProperty("d")]
        public string codCanal { get; set; }

        [JsonProperty("e")]
        public string codPais { get; set; }

        [JsonProperty("f")]
        public string codDepartamento { get; set; }

        [JsonProperty("g")]
        public string codProvincia { get; set; }
    }
    public class Consulta_Reporte_Relevo_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Reporte_Relevo> oListConsulta_Reporte_Relevo { get; set; }
    }
    #endregion

    #region GEstion Proveedores
    /// <summary>
    /// Fecha:       22/10/2012
    /// Creado:      Peter Ccopa
    /// Descripción: Registra proveedor
    /// </summary>
    public class registrarProveedor_Request : BaseRequestOperativa
    {
        [JsonProperty("a")]
        public E_Proveedor RegistrarProveedor { get; set; }
    }
    public class registrarProveedor_Response : BaseResponse
    {
    }
    //////////////////////////////
    /// <summary>
    /// Fecha:       22/10/2012
    /// Creado:      Peter Ccopa
    /// Descripción: Registra proveedor
    /// </summary>
    public class actualizarProveedor_Request : BaseRequestOperativa
    {
        [JsonProperty("a")]
        public E_Proveedor ActualizarProveedor { get; set; }
    }
    public class actualizarProveedor_Response : BaseResponse
    {
    }

    #endregion
    #region Gestion Orden de Compra
    /// <summary>
    /// Descripcion : Registrar Orden de Compras
    /// Fecha       : 25/10/2012 Peter Ccopa
    /// </summary>
    public class Registrar_OrdenCompra_Request
    {
        [JsonProperty("a")]
        public E_OrdenCompra oRegistrar_OC { get; set; }
    }
    public class Registrar_OrdenCompra_Response : BaseResponse {
        
    }
    #endregion

    #region Gestion de Tickets
    /// <summary>
    /// Descripcion : Registrar Tickets
    /// Fecha       : 15/11/2012 Peter Ccopa
    /// </summary>
    public class Registrar_Tickets_Request
    {
        [JsonProperty("a")]
        public E_Tickets oRegistrar_Tickets { get; set; }
    }
    public class Registrar_Tickets_Response : BaseResponse
    {

    }
    #endregion

    #region Gestion de Reportes - Actualizacion
    public class Actualizar_Reporte_Exhibicion_Request
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }
        [JsonProperty("b")]
        public int Cantidad { get; set; }
        [JsonProperty("c")]
        public string ModifyBy { get; set; }
        [JsonProperty("d")]
        public string DateModify { get; set; }
        [JsonProperty("e")]
        public string DateRegistro { get; set; }
    }
    public class Actualizar_Reporte_Exhibicion_Response : BaseResponse
    {

    }

    public class Validar_Reporte_Exhibicion_Request
    {
        [JsonProperty("a")]
        public string Cheched { get; set; }
        [JsonProperty("b")]
        public string unChecked { get; set; }
    }
    public class Validar_Reporte_Exhibicion_Response : BaseResponse
    {

    }
    #endregion

    public class Consultar_Reporte_Exhibicion_Request
    {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
        [JsonProperty("b")]
        public string CodCampania { get; set; }
        [JsonProperty("c")]
        public string CodCanal { get; set; }
        [JsonProperty("d")]
        public string CodOficina { get; set; }
        [JsonProperty("e")]
        public string CodNodoComercial { get; set; }
        [JsonProperty("f")]
        public string CodigoPDV_Compania { get; set; }
        [JsonProperty("g")]
        public string CodCategoria { get; set; }
        [JsonProperty("h")]
        public string CodMarca { get; set; }
        [JsonProperty("i")]
        public string f_inicio { get; set; }
        [JsonProperty("j")]
        public string f_fin { get; set; }
    }
    public class Consultar_Reporte_Exhibicion_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Consulta_Reporte_Exhibicion> Consulta_Reporte_Exhibicion { get; set; }
    }
}