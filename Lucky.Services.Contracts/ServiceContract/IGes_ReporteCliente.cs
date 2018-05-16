using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IGes_ReporteCliente
    {
        /// <summary>
        /// Fecha:       01/09/2012
        /// Creado:      Ditmar Estrada
        /// Descripción: Retorna los datos de reporte de Stock v2

        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ObtenerStockDG_Validacion")]
        string ObtenerStockDG_Validacion(string DatosEntrada);

        /// <summary>
        /// Fecha:       01/09/2012
        /// Creado:      Ditmar Estrada
        /// Descripción: Valida los Dias Giro a nivel de categoria y punto de venta.

        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ValidarStockDiasGiro")]
        string ValidarStockDiasGiro(string DatosEntrada);


        /// <summary>
        /// Fecha:       12/11/2012
        /// Creado:      Ditmar Estrada
        /// Descripción: Obtener las Oficinas por canal,compañia y codigo de Persona

        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_OficinasPorCodPersonaAndCanalAndCompania")]
        string Obtener_OficinasPorCodPersonaAndCanalAndCompania(string DatosEntrada);

        /// <summary>
        /// Fecha: 13/10/2012 Psa 
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        #region Analisis de Implementacion
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosTotalImplementadoObjetivos")]
        string getDatosTotalImplementadoObjetivos(string DatosEntrada);
        //getDatosDetalleImplementacionObjetivo
        //Add 15/10/2012 psa. Obtener los Puntos de Venta Implementados y No Implementados, la fase(Implementado o no Implementado) y coordenadas.
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosDetalleImplementacionObjetivo")]
        string getDatosDetalleImplementacionObjetivo(string DatosEntrada);
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getCharColumn3DStacked")]
        string getCharColumn3DStacked(string DatosEntrada);
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosPorVisita")]
        string getDatosPorVisita(string DatosEntrada);
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosPorAcumulado")]
        string getDatosPorAcumulado(string DatosEntrada);
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosPorMerma")]
        string getDatosPorMerma(string DatosEntrada);
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosMatImpl")]
        string getDatosMatImpl(string DatosEntrada);
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosBodeImplFrec")]
        string getDatosBodeImplFrec(string DatosEntrada);
        [OperationContract()]//Add 17/10/2012. psa. descripcion: Obtener Datos del Resumen para Implementacion y Razones de No Implementacion.
        [WebInvoke(Method = "POST", UriTemplate = "getDatosPorResumeImp_RazNoImpl")]
        string getDatosPorResumeImp_RazNoImpl(string DatosEntrada);
        #endregion
        
        #region Analisis de Stock
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosPorCantStock")]
        string getDatosPorCantStock(string DatosEntrada);
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosPorCantTotalPlatosVendidos")]
        string getDatosPorCantTotalPlatosVendidos(string DatosEntrada);
        [OperationContract()] //Add 16/10/2012 psa. descripcion:ObtenerDatosPorDetalleStockVendidosVsObjetivo, muestra coordenadas para representarlas en mapa.
        [WebInvoke(Method = "POST", UriTemplate = "getDatosPorDetalleStockVenVsObj")]
        string getDatosPorDetalleStockVenVsObj(string DatosEntrada);
        [OperationContract()]//Add 05/11/2012 psa.
        [WebInvoke(Method = "POST", UriTemplate = "getTotAvaPlaIngAlm")]
        string getTotAvaPlaIngAlm(string DatosEntrada);
        [OperationContract()]//Add 05/11/2012 psa.
        [WebInvoke(Method = "POST", UriTemplate = "getTotPlaDistCDV")]
        string getTotPlaDistCDV(string DatosEntrada);
        [OperationContract()]//Add 05/11/2012 psa.
        [WebInvoke(Method = "POST", UriTemplate = "getAvaPlaObj")]
        string getAvaPlaObj(string DatosEntrada);
        #endregion

        #region Analisis de Merma
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "getDatosPorTipMerma")]
        string getDatosPorTipMerma(string DatosEntrada);
        #endregion
    }
}
