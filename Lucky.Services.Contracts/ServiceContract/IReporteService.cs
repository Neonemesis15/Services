using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IReporteService
    {
        #region AppMovil Lucky
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateMayorista")]
        string ReporteColgateMayorista(string DatosReporte);

        //Add 15/02/2012 pSalas
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateBodega")]
        string ReporteColgateBodega(string DatosReporte);

        //Add 01/03/2012 Joseph Gonzales
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReportePrecio")]
        string ReportePrecio(string DatosReporte);

        //Add 01/03/2012 Joseph Gonzales
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteDisponibilidad")]
        string ReporteDisponibilidad(string DatosReporte);

        //Add 01/03/2012 Joseph Gonzales
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteFotografico")]
        string ReporteFotografico(string DatosReporte);

        //Add 06/03/2012 pSalas ReportesFarmaciaDT
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateFarmaciaDT")]
        string ReporteColgateFarmaciaDT(string DatosReporte);

        //Add 06/03/2012 pSalas ReportesFarmaciaIT
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateFarmaciaIT")]
        string ReporteColgateFarmaciaIT(string DatosReporte);

        //Add 16/03/2012 pSalas RegistraPDV Prueba Android
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReportePDVAndroid")]
        string ReportePDVAndroid(string DatosReporte);


        
        /// <summary>
        /// Registrar Reporte Bodega (Registra Nuevos Ptos de Venta para Colgate Bodega)
        /// pSalas 27/03/2012 
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteImplementarBodega")]
        string ReporteImplementarBodega(string DatosReporte);
        
        /// <summary>
        /// Registar PresenciaBodega
        /// pSalas 28/03/2012
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReportePresenciaBodega")]
        string ReportePresenciaBodega(string DatosReporte);

        /// <summary>
        /// Prueba Android para guardar fotos
        /// Descripcion : Registrar Fotos en el Servidor
        /// Fecha       : 05/06/2012
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "RegistrarFoto_Mov")]
        string RegistrarFoto_Mov(string DatosReporteFotoAndroid);


        //Descripcion   : Registra Reporte de Stock para todos los Clientes.
        //Fecha         : 05/05/2012
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteStock")]
        string ReporteStock(string DatosReporteStock);
        #endregion

        #region AppMovil Movistar
        
        #region Cliente Colgate
            #region Reportes_Validaciones Anteriores Fecha:06092012. PSalas
                /// <summary>
                /// Descripcion : Registra Reportes de Colgate Mayorista Movistar
                /// Fecha       : 18/05/2012 - PSA
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                [OperationContract()]
                [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateMayorista_Mov")]
                string ReporteColgateMayorista_Mov(string DatosReporte);

                /// <summary>
                /// Descripcion : Registra Reportes de Colgate Minorista Movistar
                /// Fecha       : 18/05/2012 - PSA
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                [OperationContract()]
                [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateMinorista_Mov")]
                string ReporteColgateMinorista_Mov(string DatosReporte);

                /// <summary>
                /// Descripcion : Registra Reportes de Colgate Farmacia DT Movistar
                /// Fecha       : 18/05/2012 - PSA
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                [OperationContract()]
                [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateFarmaciaDT_Mov")]
                string ReporteColgateFarmaciaDT_Mov(string DatosReporte);

                /// <summary>
                /// Descripcion : Registra Reportes de Colgate Farmacia IT Movistar
                /// Fecha       : 18/05/2012 - PSA
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                [OperationContract()]
                [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateFarmaciaIT_Mov")]
                string ReporteColgateFarmaciaIT_Mov(string DatosReporte);

                /// <summary>
                /// Autor: Joseph Gonzales
                /// Fecha: 01 - 06 - 2012
                /// Descripción: Registra los reportes de colgate canal bodegas.
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                [OperationContract()]
                [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateBodega_Mov")]
                string ReporteColgateBodega_Mov(string DatosReporte);

                /// <summary>
                /// Autor       : PSA
                /// Fecha       : 04 - 06 - 2012
                /// Descripción : Registra un Nuevo Punto de Venta para Colgate Bodega.
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                [OperationContract()]
                [WebInvoke(Method = "POST", UriTemplate = "ReporteColgateBodega_RegistrarPDV_Mov")]
                string ReporteColgateBodega_RegistrarPDV_Mov(string DatosReporte);
            #endregion

            #region Validaciones Nuevas RQ Colgate V 1.9. Fecha:06092012 PSalas
                /// <summary>
                /// Descripcion : Registra Reportes de Colgate Mayorista Movistar
                /// Fecha       : 18/05/2012 - PSA
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                //[OperationContract()]
                //[WebInvoke(Method = "POST", UriTemplate = "ReporteColgateMayorista_Mov_V_1_1")]
                //string ReporteColgateMayorista_Mov_V_1_1(string DatosReporte);

                /// <summary>
                /// Descripcion : Registra Reportes de Colgate Minorista Movistar
                /// Fecha       : 18/05/2012 - PSA
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                //[OperationContract()]
                //[WebInvoke(Method = "POST", UriTemplate = "ReporteColgateMinorista_Mov_V_1_1")]
                //string ReporteColgateMinorista_Mov_V_1_1(string DatosReporte);

                /// <summary>
                /// Descripcion : Registra Reportes de Colgate Farmacia DT Movistar
                /// Fecha       : 18/05/2012 - PSA
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                //[OperationContract()]
                //[WebInvoke(Method = "POST", UriTemplate = "ReporteColgateFarmaciaDT_Mov_V_1_1")]
                //string ReporteColgateFarmaciaDT_Mov_V_1_1(string DatosReporte);

                /// <summary>
                /// Descripcion : Registra Reportes de Colgate Farmacia IT Movistar
                /// Fecha       : 18/05/2012 - PSA
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                //[OperationContract()]
                //[WebInvoke(Method = "POST", UriTemplate = "ReporteColgateFarmaciaIT_Mov_V_1_1")]
                //string ReporteColgateFarmaciaIT_Mov_V_1_1(string DatosReporte);

                /// <summary>
                /// Autor: Joseph Gonzales
                /// Fecha: 01 - 06 - 2012
                /// Descripción: Registra los reportes de colgate canal bodegas.
                /// </summary>
                /// <param name="DatosReporte"></param>
                /// <returns></returns>
                //[OperationContract()]
                //[WebInvoke(Method = "POST", UriTemplate = "ReporteColgateBodega_Mov_V_1_1")]
                //string ReporteColgateBodega_Mov_V_1_1(string DatosReporte);

            #endregion
        #endregion

        #region Cliente San Fernando
                /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       28 - 05 - 2012
        /// Descripción: Registra los reportes para el cliente San Fernando canal Aves Vivas.    
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteSanFernandoAAVV_Mov")]
        string ReporteSanFernandoAAVV_Mov(string DatosReporte);

        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       28 - 05 - 2012
        /// Descripción: Registra los reportes para el cliente San Fernando canal Moderno Vivas.    
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteSanFernandoModerno_Mov")]
        string ReporteSanFernandoModerno_Mov(string DatosReporte);

        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       28 - 05 - 2012
        /// Descripción: Registra los reportes para el cliente San Fernando canal Tradicional Vivas.    
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteSanFernandoTradicional_Mov")]
        string ReporteSanFernandoTradicional_Mov(string DatosReporte);

        #endregion

        #region Cliente Alicorp
        /// <summary>
        /// Descripcion : Registra Reportes de Alicorp Mayorista Movistar
        /// Fecha       : 28/05/2012 - PSA
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteAlicorpMayorista_Mov")]
        string ReporteAlicorpMayorista_Mov(string DatosReporte);

        /// <summary>
        /// Descripcion : Registra Reportes de Alicorp Autoservicios Movistar
        /// Fecha       : 28/05/2012 - PSA
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ReporteAlicorpAutoservicio_Mov")]
        string ReporteAlicorpAutoservicio_Mov(string DatosReporte);
        #endregion 

        #region Cliente CocaCola
        //Add 14/11/2012 Psa
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "RegRepFoto_Mov_Coca")]
        string RegRepFoto_Mov_Coca(string DatosReporte);
        #endregion

        #endregion

    }
}