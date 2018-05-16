using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Services.Contracts.ServiceContract;
using Lucky.CFG.JavaMovil;
using Lucky.Business.Common.Servicio;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceImpl
{
    class Ges_ReporteCliente:IGes_ReporteCliente
    {
        private readonly static BL_GES_ReportesCliente oBL_GES_ReportesCliente = new BL_GES_ReportesCliente();

        public string ObtenerStockDG_Validacion(string DatosEntrada)
        {
            DataContract.ReporteCliente_Stock_Validacion_Request request = HelperJson.Deserialize<DataContract.ReporteCliente_Stock_Validacion_Request>(DatosEntrada);
            DataContract.ReporteCliente_Stock_Validacion_Response response = new DataContract.ReporteCliente_Stock_Validacion_Response();
            try
            {
                response.oE_ReporteCliente_Stock_Validacion = oBL_GES_ReportesCliente.ObtenerStockDG_Validacion(request.anio,request.mes,request.periodo,request.codOficina,request.codCategoria);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteCliente_Stock_Validacion_Response>(response);
            return responseJSON;
        }

        public string ValidarStockDiasGiro(string DatosEntrada)
        {
            DataContract.ReporteCliente_Stock_Validacion_Request request = HelperJson.Deserialize<DataContract.ReporteCliente_Stock_Validacion_Request>(DatosEntrada);
            DataContract.ReporteCliente_Stock_Validacion_Response response = new DataContract.ReporteCliente_Stock_Validacion_Response();
            try
            {
                response.Descripcion=oBL_GES_ReportesCliente.ValidarStockDiasGiro(request.anio,request.mes,request.periodo,request.codPdv,request.codCategoria,request.validado,request.user);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error al actualizar.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteCliente_Stock_Validacion_Response>(response);
            return responseJSON;
        }

        //Por: Ditmar Estrada Bernuy , 12/11/2012
        #region Obtener las Oficinas por canal,compañia y codigo de Persona
        public string Obtener_OficinasPorCodPersonaAndCanalAndCompania(string DatosEntrada)
        {
            DataContract.OficinasPorPersona_Request request = HelperJson.Deserialize<DataContract.OficinasPorPersona_Request>(DatosEntrada);
            DataContract.OficinasPorPersona_Response response = new DataContract.OficinasPorPersona_Response();
            try
            {
                response.Oficinas = oBL_GES_ReportesCliente.Obtener_OficinasPorCodPersonaAndCanalAndCompania(request.CodPersona,request.CodCanal,request.CodCompania);
                response.Estado = BaseResponse.EXITO;
            }
            catch(Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.OficinasPorPersona_Response>(response);
            return responseJSON;
        }
        #endregion

        //13/10/2012 Pablo Salas A. - ObtenerInformesCanjes CocaCola
        //public string ObtenerInformesCanje(string DatosEntrada) {
            
        //        DataContract.ObtenerInformesCanje_Request request = HelperJson.Deserialize<DataContract.ObtenerInformesCanje_Request>(DatosEntrada);
        //        DataContract.ObtenerInformesCanje_Response response = new DataContract.ObtenerInformesCanje_Response();
        //    try
        //    {
        //        response.oE_InformesCanje = oBL_GES_ReportesCliente.ObtenerInformesCanje();
        //        response.Estado = BaseResponse.EXITO;
        //    }
        //    catch (Exception ex) {
        //        response.Descripcion = "Error al actualizar";
        //        response.Estado = BaseResponse.GENERAL_ERROR;
        //    }
        //    string responseJSON = HelperJson.Serialize<DataContract.ObtenerInformesCanje_Response>(response);
        //    return responseJSON;
        //}
        #region Informes de Canje Cocacola

        #region Analisis de Implementacion
        public string getDatosTotalImplementadoObjetivos(string DatosEntrada) {
            DataContract.getDatosTotalImplementadoObjetivos_Request request = HelperJson.Deserialize<DataContract.getDatosTotalImplementadoObjetivos_Request>(DatosEntrada);
            DataContract.getDatosTotalImplementadoObjetivos_Response response = new DataContract.getDatosTotalImplementadoObjetivos_Response();
            try {
                response.getDatosTotalImplementadoObjetivos = oBL_GES_ReportesCliente.getDatosTotalImplementadoObjetivos(request.opcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "Ocurrio un Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosTotalImplementadoObjetivos_Response>(response);
            return responseJSON;
        }
        public string getDatosDetalleImplementacionObjetivo(string DatosEntrada) {
            DataContract.getDatosDetalleImplementacionObjetivo_Request request = HelperJson.Deserialize<DataContract.getDatosDetalleImplementacionObjetivo_Request>(DatosEntrada);
            DataContract.getDatosDetalleImplementacionObjetivo_Response response = new DataContract.getDatosDetalleImplementacionObjetivo_Response();
            try {
                response.GetDatosDetalleImplementacionObjetivo = oBL_GES_ReportesCliente.getDatosDetalleImplementacionObjetivo(request.opcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "Ocurrio un Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosDetalleImplementacionObjetivo_Response>(response);
            return responseJSON;
        }
        public string getCharColumn3DStacked(string DatosEntrada) {
            DataContract.getCharColumn3DStacked_Request request = HelperJson.Deserialize<DataContract.getCharColumn3DStacked_Request>(DatosEntrada);
            DataContract.getCharColumn3DStacked_Response response = new DataContract.getCharColumn3DStacked_Response();
            try {
                response.getCharColumn3DStacked = oBL_GES_ReportesCliente.getCharColumn3DStacked();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Ocurrio un Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getCharColumn3DStacked_Response>(response);
            return responseJSON;
        }
        public string getDatosPorVisita(string DatosEntrada) {
            DataContract.getDatosPorVisita_Request request = HelperJson.Deserialize<DataContract.getDatosPorVisita_Request>(DatosEntrada);
            DataContract.getDatosPorVisita_Response response = new DataContract.getDatosPorVisita_Response();
            try {
                response.getDatosPorVisita = oBL_GES_ReportesCliente.getDatosPorVisita();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error al actualizar";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorVisita_Response>(response);
            return responseJSON;
        }
        public string getDatosPorAcumulado(string DatosEntrada) {
            DataContract.getDatosPorAcumulado_Request request = HelperJson.Deserialize<DataContract.getDatosPorAcumulado_Request>(DatosEntrada);
            DataContract.getDatosPorAcumulado_Response response = new DataContract.getDatosPorAcumulado_Response();
            try {
                response.getDatosPorAcumulado = oBL_GES_ReportesCliente.getDatosPorAcumulado();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error al actualizar";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorAcumulado_Response>(response);
            return responseJSON;
        }
        public string getDatosPorMerma(string DatosEntrada) {
            DataContract.getDatosPorMerma_Request request = HelperJson.Deserialize<DataContract.getDatosPorMerma_Request>(DatosEntrada);
            DataContract.getDatosPorMerma_Response response = new DataContract.getDatosPorMerma_Response();
            
            try {
                response.getDatosPorMerma = oBL_GES_ReportesCliente.getDatosPorMerma();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error al actualizar";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorMerma_Response>(response);
            return responseJSON;
        }
        public string getDatosMatImpl(string DatosEntrada) {
            DataContract.getDatosMatImpl_Request request = HelperJson.Deserialize<DataContract.getDatosMatImpl_Request>(DatosEntrada);
            DataContract.getDatosMatImpl_Response response = new DataContract.getDatosMatImpl_Response();
            
            try {
                response.getDatosMatImpl = oBL_GES_ReportesCliente.getDatosMatImpl();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error al actualizar";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosMatImpl_Response>(response);
            return responseJSON;
        }
        public string getDatosBodeImplFrec(string DatosEntrada) {
            DataContract.getDatosBodeImplFrec_Request request = HelperJson.Deserialize<DataContract.getDatosBodeImplFrec_Request>(DatosEntrada);
            DataContract.getDatosBodeImplFrec_Response response = new DataContract.getDatosBodeImplFrec_Response();
            try {
                response.getDatosBodeImplFrec = oBL_GES_ReportesCliente.getDatosBodeImplFrec();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosBodeImplFrec_Response>(response);
            return responseJSON;
        }
        //Add 17/10/2012. psa. descripcion: Obtener Datos del Resumen para Implementacion y Razones de No Implementacion.
        public string getDatosPorResumeImp_RazNoImpl(string DatosEntrada) {
            DataContract.getDatosPorResumeImp_RazNoImpl_Request request = HelperJson.Deserialize<DataContract.getDatosPorResumeImp_RazNoImpl_Request>(DatosEntrada);
            DataContract.getDatosPorResumeImp_RazNoImpl_Response response = new DataContract.getDatosPorResumeImp_RazNoImpl_Response();
            try {
                response.getDatosPorResumeImp_RazNoImpl = oBL_GES_ReportesCliente.getDatosPorResumeImp_RazNoImpl();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorResumeImp_RazNoImpl_Response>(response);
            return responseJSON;
        }
        #endregion
        #region Analisis de Stock
        public string getDatosPorCantStock(string DatosEntrada) {
            DataContract.getDatosPorCantStock_Request request = HelperJson.Deserialize<DataContract.getDatosPorCantStock_Request>(DatosEntrada);
            DataContract.getDatosPorCantStock_Response response = new DataContract.getDatosPorCantStock_Response();
            try {
                response.getDatosPorCantStock = oBL_GES_ReportesCliente.getDatosPorCantStock();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorCantStock_Response>(response);
            return responseJSON;

        }
        public string getDatosPorCantTotalPlatosVendidos(string DatosEntrada) {
            DataContract.getDatosPorCantTotalPlatosVendidos_Request request = HelperJson.Deserialize<DataContract.getDatosPorCantTotalPlatosVendidos_Request>(DatosEntrada);
            DataContract.getDatosPorCantTotalPlatosVendidos_Response response = new DataContract.getDatosPorCantTotalPlatosVendidos_Response();
            try {
                response.getDatosPorCantTotalPlatosVendidos = oBL_GES_ReportesCliente.getDatosPorCantTotalPlatosVendidos();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorCantTotalPlatosVendidos_Response>(response);
            return responseJSON;
        }
        //Add 16/10/2012 psa. descripcion:ObtenerDatosPorDetalleStockVendidosVsObjetivo, muestra coordenadas para representarlas en mapa.
        public string getDatosPorDetalleStockVenVsObj(string DatosEntrada) {
            DataContract.getDatosPorDetalleStockVenVsObj_Request request = HelperJson.Deserialize<DataContract.getDatosPorDetalleStockVenVsObj_Request>(DatosEntrada);
            DataContract.getDatosPorDetalleStockVenVsObj_Response response = new DataContract.getDatosPorDetalleStockVenVsObj_Response();
            try {
                response.getDatosPorDetalleStockVenVsObj = oBL_GES_ReportesCliente.getDatosPorDetalleStockVenVsObj();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorDetalleStockVenVsObj_Response>(response);
            return responseJSON;
        }
        //Add 05/11/2012 psa.
        public string getTotAvaPlaIngAlm(string DatosEntrada)
        {
            DataContract.getDatosPorCantStock_Request request = HelperJson.Deserialize<DataContract.getDatosPorCantStock_Request>(DatosEntrada);
            DataContract.getDatosPorCantStock_Response response = new DataContract.getDatosPorCantStock_Response();
            try
            {
                response.getDatosPorCantStock = oBL_GES_ReportesCliente.getTotAvaPlaIngAlm();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorCantStock_Response>(response);
            return responseJSON;

        }
        //Add 05/11/2012 psa.
        public string getTotPlaDistCDV(string DatosEntrada)
        {
            DataContract.getDatosPorCantStock_Request request = HelperJson.Deserialize<DataContract.getDatosPorCantStock_Request>(DatosEntrada);
            DataContract.getDatosPorCantStock_Response response = new DataContract.getDatosPorCantStock_Response();
            try
            {
                response.getDatosPorCantStock = oBL_GES_ReportesCliente.getTotPlaDistCDV();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorCantStock_Response>(response);
            return responseJSON;

        }
        //Add 05/11/2012 psa.
        public string getAvaPlaObj(string DatosEntrada)
        {
            DataContract.getDatosPorCantStock_Request request = HelperJson.Deserialize<DataContract.getDatosPorCantStock_Request>(DatosEntrada);
            DataContract.getDatosPorCantStock_Response response = new DataContract.getDatosPorCantStock_Response();
            try
            {
                response.getDatosPorCantStock = oBL_GES_ReportesCliente.getAvaPlaObj();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorCantStock_Response>(response);
            return responseJSON;

        }
        #endregion
        #region Analisis de Merma
        public string getDatosPorTipMerma(string DatosEntrada) {
            DataContract.getDatosPorTipMerma_Request request = HelperJson.Deserialize<DataContract.getDatosPorTipMerma_Request>(DatosEntrada);
            DataContract.getDatosPorTipMerma_Response response = new DataContract.getDatosPorTipMerma_Response();
            try {
                response.getDatosPorTipMerma = oBL_GES_ReportesCliente.getDatosPorTipMerma();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "Error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.getDatosPorTipMerma_Response>(response);
            return responseJSON;
        }
        #endregion
        
        #endregion
    }
}
