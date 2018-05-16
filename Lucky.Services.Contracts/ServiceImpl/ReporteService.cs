using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Business.Common.JavaMovil;
using Lucky.CFG.JavaMovil;
using System.Configuration;
using System.IO;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Services.Contracts.ServiceContract;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceImpl
{
    public class ReporteService : IReporteService
    {
        #region App Movil Lucky
        private readonly static BL_ReportesColgate_May reportesColgateBLL = new BL_ReportesColgate_May();
        public string ReporteColgateMayorista(string ListaReporte)
        {
            DataContract.ReporteServiceRequest request = HelperJson.Deserialize<DataContract.ReporteServiceRequest>(ListaReporte);
            DataContract.ReporteServiceResponse response = new DataContract.ReporteServiceResponse();
            try
            {
                response.Descripcion = reportesColgateBLL.registrarPresencia_May(request.ListaReportePresencia, request.ListaReporteFotografico, request.ListaReporteCodigoITT, request.Visita);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteServiceResponse>(response);
            return responseJSON;
        }
        //Add pSalas 15/02/2012
        private readonly static BL_ReportesColgate_Bodega oBL_ReportesColgate_Bodega = new BL_ReportesColgate_Bodega();
        public string ReporteColgateBodega(string ListaReporte)
        {
            DataContract.ReporteBodegaServiceRequest request = HelperJson.Deserialize<DataContract.ReporteBodegaServiceRequest>(ListaReporte);
            DataContract.ReporteBodegaServiceResponse response = new DataContract.ReporteBodegaServiceResponse();
            try
            {
                oBL_ReportesColgate_Bodega.registrarRegistroPDV_Bodega(request.ListaE_Reporte_RegistroPDV);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteBodegaServiceResponse>(response);
            return responseJSON;

        }

        private readonly static BL_Reporte_Precio oBL_Reporte_Precio = new BL_Reporte_Precio();
        public string ReportePrecio(string DatosReporte)
        {
            DataContract.ReportePrecioRequest request = HelperJson.Deserialize<DataContract.ReportePrecioRequest>(DatosReporte);
            DataContract.ReportePrecioResponse response = new DataContract.ReportePrecioResponse();
            try
            {
                //oBL_Reporte_Precio.RegistrarPrecio(request.ReportePrecio, APP_MOVIL_ENVIA);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReportePrecioResponse>(response);
            return responseJSON;
        }

        private readonly static BL_Reporte_Disponibilidad oBL_Reporte_Disponibilidad = new BL_Reporte_Disponibilidad();
        public string ReporteDisponibilidad(string DatosReporte)
        {
            DataContract.ReporteDisponibilidadRequest request = HelperJson.Deserialize<DataContract.ReporteDisponibilidadRequest>(DatosReporte);
            DataContract.ReporteDisponibilidadResponse response = new DataContract.ReporteDisponibilidadResponse();
            try
            {
                oBL_Reporte_Disponibilidad.RegistrarDisponibilidad(request.ReporteDisponibilidad);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteDisponibilidadResponse>(response);
            return responseJSON;
        }

        private readonly static BL_Reporte_Fotografico oBL_Reporte_Fotografico = new BL_Reporte_Fotografico();
        public string ReporteFotografico(string DatosReporte)
        {
            DataContract.ReporteFotograficoRequest request = HelperJson.Deserialize<DataContract.ReporteFotograficoRequest>(DatosReporte);
            DataContract.ReporteFotograficoResponse response = new DataContract.ReporteFotograficoResponse();
            try
            {
                oBL_Reporte_Fotografico.registrarFotografico(request.ReporteFotografico);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteFotograficoResponse>(response);
            return responseJSON;
        }

        //Add pSalas 06/03/2012 Service_ColgateFarmaciaDT
        private readonly static BL_ReportesColgate_FarmaciaDT oBLReporteColgateFarmaciaDT = new BL_ReportesColgate_FarmaciaDT();
        public string ReporteColgateFarmaciaDT(string ListaReportes) {
            DataContract.ReporteColgateFarmaciaDTRequest request = HelperJson.Deserialize<DataContract.ReporteColgateFarmaciaDTRequest>(ListaReportes);
            DataContract.ReporteColgateFarmaciaDTResponse response = new DataContract.ReporteColgateFarmaciaDTResponse();
            try
            {
                //int aux;
                // aux=
                    response.Descripcion = oBLReporteColgateFarmaciaDT.registrarReportesColgate_FarmaciaDT(
                    request.oListReportePresencia, 
                    request.oListReporteVisibilidadCompetencia, 
                    request.oListReportePromocion, 
                    request.oListReportePop,
                    request.oListaReporteCodigoITT,
                    request.oE_Visita);

                response.Estado = BaseResponse.EXITO;


            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteColgateFarmaciaDTResponse>(response);
            return responseJSON;
        
        }

        //Add pSalas 06/03/2012 Service_ColgateFarmaciaIT
        private readonly static BL_ReportesColgate_FarmaciaIT oBLReporteColgateFarmaciaIT = new BL_ReportesColgate_FarmaciaIT();
        public string ReporteColgateFarmaciaIT(string ListaReportes)
        {
            DataContract.ReporteColgateFarmaciaITRequest request = HelperJson.Deserialize<DataContract.ReporteColgateFarmaciaITRequest>(ListaReportes);
            DataContract.ReporteColgateFarmaciaITResponse response = new DataContract.ReporteColgateFarmaciaITResponse();
            try
            {
                response.Descripcion = oBLReporteColgateFarmaciaIT.registrarReportesColgate_FarmaciaIT(
                    request.oListReportePresencia, 
                    request.oListReporteFotografico,
                    request.oListaReporteCodigoITT,
                    request.oE_Visita);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteColgateFarmaciaITResponse>(response);
            return responseJSON;

        }

        //ReportePDVAndroid
        //Add 16/03/2012 pSalas RegistrarPDV Android Prueba.
        private readonly static BL_Reporte_Android oBL_Reporte_Android = new BL_Reporte_Android();
        public string ReportePDVAndroid(string ListaPDV) {
            DataContract.ReportePDVAndroidRequest request = HelperJson.Deserialize<DataContract.ReportePDVAndroidRequest>(ListaPDV);
            DataContract.ReportePDVAndroidResponse response = new DataContract.ReportePDVAndroidResponse();
            try {
                oBL_Reporte_Android.registraPDV_Android(request.oListPDV);
                response.Estado = BaseResponse.EXITO;
            }
            catch(Exception ) {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReportePDVAndroidResponse>(response);
            return responseJSON;
        }

        /// <summary>
        /// Registra Implementar Bodega  para ColgateBodega.
        /// pSalas 27/03/2012
        /// </summary>
        private readonly static BL_Reporte_ImplementarBodega oBL_Reporte_ImplementarBodega = new BL_Reporte_ImplementarBodega();
        public string ReporteImplementarBodega(string InfoBodega) {
            DataContract.ReporteImplementarBodegaServiceRequest request = HelperJson.Deserialize<DataContract.ReporteImplementarBodegaServiceRequest>(InfoBodega);
            DataContract.ReporteImplementarBodegaServiceResponse response = new DataContract.ReporteImplementarBodegaServiceResponse();
            try
            {
                response.Descripcion = oBL_Reporte_ImplementarBodega.RegistrarImplementarBodega(request.oE_Reporte_ImplementarBodega);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception) {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteImplementarBodegaServiceResponse>(response);
            return responseJSON;
        }

        /// <summary>
        /// Registrar Reporte PresenciaBodega
        /// pSalas 28/03/2012
        /// </summary>
        private readonly static BL_Reporte_Presencia oBL_Reporte_Presencia = new BL_Reporte_Presencia();
        public string ReportePresenciaBodega(string ListaReportesPresencia) {
            DataContract.ReportePresenciaBodegaRequest request = HelperJson.Deserialize<DataContract.ReportePresenciaBodegaRequest>(ListaReportesPresencia);
            DataContract.ReportePresenciaBodegaResponse response = new DataContract.ReportePresenciaBodegaResponse();

            try {
                response.Descripcion = oBL_Reporte_Presencia.Registrar_Presencia_General_Lista_Normal(request.oListE_Reporte_Presencia_General, request.ListaReporteCodigoITT, request.oE_Visita);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception) {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReportePresenciaBodegaResponse>(response);
            return responseJSON;
        }

        public string RegistrarFoto_Mov(string DatosReporteFotoAndroid)
        {
            DataContract.ReporteFotoAndroidRequest request = HelperJson.Deserialize<DataContract.ReporteFotoAndroidRequest>(DatosReporteFotoAndroid);
            DataContract.ReporteFotoAndroidResponse response = new DataContract.ReporteFotoAndroidResponse();

            try
            {
                string carpetaSubir = ConfigurationManager.AppSettings["Downloads"];

                if (!Directory.Exists(carpetaSubir))
                {
                    Directory.CreateDirectory(carpetaSubir);
                }

                foreach (E_FotoAndroid fotoAndroid in request.file)
                {
                    string destinoArchivo = Path.Combine(carpetaSubir, fotoAndroid.nombre+".jpg");

                    using (var destinoFileStream = new FileStream(destinoArchivo, FileMode.Create))
                    {
                        MemoryStream stream = new MemoryStream(DecodeFrom64(fotoAndroid.file));


                        const int capacidadBuffer = 65536;

                        var buffer = new Byte[capacidadBuffer];
                        int bytesPorLectura = stream.Read(buffer, 0, capacidadBuffer);

                        while (bytesPorLectura > 0)
                        {
                            destinoFileStream.Write(buffer, 0, bytesPorLectura);
                            bytesPorLectura = stream.Read(buffer, 0, capacidadBuffer);
                        }
                    }


                }

                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteFotoAndroidResponse>(response);
            return responseJSON;
        }
        public static byte[] DecodeFrom64(String encodedData)
        {

            byte[] encodedDataAsBytes

                = System.Convert.FromBase64String(encodedData);
            
            return encodedDataAsBytes;

        }

        /// <summary>
        /// Descripcion : Reporte de Stock para todos los Clientes.
        /// Fecha       : 05/05/2012 PSA
        /// </summary>
        public readonly static BL_Reporte_Stock oBL_Reporte_Stock = new BL_Reporte_Stock();
        public string ReporteStock(string DatosReporte) {
            DataContract.ReporteStockRequest request = HelperJson.Deserialize<DataContract.ReporteStockRequest>(DatosReporte);
            DataContract.ReporteStockResponse response = new DataContract.ReporteStockResponse();
            try {
                //response.Descripcion = oBL_Reporte_Stock.Registrar_Reporte_Stock(request.ReporteStock, APP_MOVIL_ENVIA);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception) {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteStockResponse>(response);
            return responseJSON;
        }
        #endregion 

        #region App Movil Movistar
        #region Cliente Colgate
            #region Validaciones Anteriores 06/09/2012 PSalas
            ///// <summary>
            ///// Descripcion : Request y Response para Reportes Colgate Mayorista - App Movil Movistar
            ///// Fecha       : 21/05/2012 PSA
            ///// </summary>
            //private readonly static BL_ReportesColgate_May oBL_ReportesColgate_May_Mov = new BL_ReportesColgate_May();
            //public string ReporteColgateMayorista_Mov(string ListaReporte)
            //{
            //    DataContract.ReportesColgateMayoristasService_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateMayoristasService_Mov_Request>(ListaReporte);
            //    DataContract.ReportesColgateMayoristasService_Mov_Response response = new DataContract.ReportesColgateMayoristasService_Mov_Response();
            //    try
            //    {
            //        response.oE_Reportes_Colgate_Mayoristas_Mov_Response = oBL_ReportesColgate_May_Mov.Registrar_ReportesColgateMay_Mov(request.oListaRepPresencia_Mov, request.oListaRepFotografico_Mov, request.oListaRepCodigoITT_Mov, request.oE_Visita_Mov,request.AppEnvia);
            //        response.Descripcion = response.oE_Reportes_Colgate_Mayoristas_Mov_Response.Mensaje_Response;

            //        if (response.Descripcion.Equals(""))
            //        {
            //            response.Descripcion = "Se ha registrado sus reportes con exito";
            //        }
                
            //        response.Estado = BaseResponse.EXITO;
                
            //    }
            //    catch (Exception)
            //    {
            //        response.Descripcion = "Servicio no disponible";
            //        response.Estado = BaseResponse.GENERAL_ERROR;
            //    }

            //    WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            //    string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateMayoristasService_Mov_Response>(response);
            //    return responseJSON;
            //}

            ///// <summary>
            ///// Descripcion : Request y Response para Reportes Colgate Minorista - App Movil Movistar
            ///// Fecha       : 21/05/2012 PSA
            ///// </summary>
            //private readonly static BL_ReportesColgate_Min oBL_ReportesColgate_Min_Mov = new BL_ReportesColgate_Min();
            //public string ReporteColgateMinorista_Mov(string ListaReporte)
            //{
            //    DataContract.ReportesColgateMinoristasServices_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateMinoristasServices_Mov_Request>(ListaReporte);
            //    DataContract.ReportesColgateMinoristasServices_Mov_Response response = new DataContract.ReportesColgateMinoristasServices_Mov_Response();
            //    try
            //    {

            //        response.oE_Reportes_Colgate_Minorista_Mov_Response = oBL_ReportesColgate_Min_Mov.Registrar_Reportes_Colgate_Min_Mov(request.oListaRepPresencia_Mov, request.oListaRepFotografico_Mov, request.oListaRepCodigoITT_Mov, request.oE_Visita_Mov, request.AppEnvia);
            //        response.Descripcion = response.oE_Reportes_Colgate_Minorista_Mov_Response.Mensaje_Response;

            //        if (response.Descripcion.Equals(""))
            //        {
            //            response.Descripcion = "Se ha registrado sus reportes con exito";
            //        }

            //        //if (response.Descripcion.Equals(""))
            //        //    response.Estado = BaseResponse.EXITO;
            //        //else
            //        //    response.Estado = BaseResponse.GENERAL_ERROR;

            //        response.Estado = BaseResponse.EXITO;
            //    }
            //    catch (Exception)
            //    {
            //        response.Descripcion = "Servicio no disponible";
            //        response.Estado = BaseResponse.GENERAL_ERROR;
            //    }

            //    WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            //    string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateMinoristasServices_Mov_Response>(response);
            //    return responseJSON;
            //}

            ///// <summary>
            ///// Descripcion : Request y Response para Reportes Colgate Farmacia IT - App Movil Movistar
            ///// Fecha       : 21/05/2012 PSA
            ///// </summary>
            //private readonly static BL_ReportesColgate_FarmaciaIT oBL_ReportesColgate_FarmaciaIT_Mov = new BL_ReportesColgate_FarmaciaIT();
            //public string ReporteColgateFarmaciaIT_Mov(string ListaReporte)
            //{
            //    DataContract.ReportescolgateFarmaciasIT_Mov_Request request = HelperJson.Deserialize<DataContract.ReportescolgateFarmaciasIT_Mov_Request>(ListaReporte);
            //    DataContract.ReportescolgateFarmaciasIT_Mov_Response response = new DataContract.ReportescolgateFarmaciasIT_Mov_Response();
            //    try
            //    {
            //        response.oE_Reportes_Colgate_Farmacia_IT_Mov_Response = oBL_ReportesColgate_FarmaciaIT_Mov.Registrar_Reportes_Colgate_Farmacia_IT_Mov(request.oListaRepPresencia_Mov, request.oListaRepFotografico_Mov, request.oListaRepCodigoITT_Mov, request.oE_Visita_Mov, request.AppEnvia);
            //        response.Descripcion = response.oE_Reportes_Colgate_Farmacia_IT_Mov_Response.Mensaje_Response;

            //        if (response.Descripcion.Equals(""))
            //        {
            //            response.Descripcion = "Se ha registrado sus reportes con exito";
            //        }
            //        response.Estado = BaseResponse.EXITO;

            //        //if (response.Descripcion.Equals(""))
            //        //response.Estado = BaseResponse.EXITO;
            //        //else
            //        //    response.Estado = BaseResponse.GENERAL_ERROR;
            //        //response.Estado = BaseResponse.EXITO;
            //    }
            //    catch (Exception)
            //    {
            //        response.Descripcion = "Servicio no disponible";
            //        response.Estado = BaseResponse.GENERAL_ERROR;
            //    }

            //    WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            //    string responseJSON = HelperJson.Serialize<DataContract.ReportescolgateFarmaciasIT_Mov_Response>(response);
            //    return responseJSON;
            //}

            ///// <summary>
            ///// Descripcion : Request y Response para Reportes Colgate Farmacia DT - App Movil Movistar
            ///// Fecha       : 21/05/2012 PSA
            ///// </summary>
            //private readonly static BL_ReportesColgate_FarmaciaDT oBL_ReportesColgate_FarmaciaDT_Mov = new BL_ReportesColgate_FarmaciaDT();
            //public string ReporteColgateFarmaciaDT_Mov(string ListaReporte)
            //{
            //    DataContract.ReportesColgateFarmaciasDT_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateFarmaciasDT_Mov_Request>(ListaReporte);
            //    DataContract.ReportesColgateFarmaciasDT_Mov_Response response = new DataContract.ReportesColgateFarmaciasDT_Mov_Response();
            //    try
            //    {
            //        response.oE_Reportes_Colgate_Farmacia_DT_Mov_Response = oBL_ReportesColgate_FarmaciaDT_Mov.Registar_Reporte_Colgate_Farmacia_DT_Mov(                    request.oListaRepPresencia_Mov,request.oListaRepCodigoITT_Mov, request.oListaRepPromocion_Mov,                      request.oListaRepMatApoyo_Mov,request.oListaRepVisCompetencia_Mov,request.oE_Visita_Mov, request.AppEnvia);
            //        response.Descripcion = response.oE_Reportes_Colgate_Farmacia_DT_Mov_Response.Mensaje_Response;

            //        if (response.Descripcion.Equals(""))
            //        {
            //            response.Descripcion = "Se ha registrado sus reportes con exito";
            //        }
                
            //        response.Estado = BaseResponse.EXITO;

            //        //if (response.Descripcion.Equals(""))
            //        //response.Estado = BaseResponse.EXITO;
            //        //else
            //        //    response.Estado = BaseResponse.GENERAL_ERROR;
            //        //response.Estado = BaseResponse.EXITO;
            //    }
            //    catch (Exception)
            //    {
            //        response.Descripcion = "Servicio no disponible";
            //        response.Estado = BaseResponse.GENERAL_ERROR;
            //    }

            //    WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            //    string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateFarmaciasDT_Mov_Response>(response);
            //    return responseJSON;
            //}

            ///// <summary>
            ///// Autor: Joseph Gonzales
            ///// Fecha: 01 - 06 - 2012
            ///// </summary>
            ///// <param name="DatosReporte"></param>
            ///// <returns></returns>
            ////private readonly static BL_ReportesColgate_Bodega oBL_ReportesColgate_Bodega = new BL_ReportesColgate_Bodega();
            //public string ReporteColgateBodega_Mov(string DatosReporte)
            //{
            //    DataContract.ReportesColgateBodegaService_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateBodegaService_Mov_Request>(DatosReporte);
            //    DataContract.ReportesColgateBodegaService_Mov_Response response = new DataContract.ReportesColgateBodegaService_Mov_Response();
            //    try
            //    {
            //        response.oE_Reportes_Colgate_Bodega_Mov = oBL_ReportesColgate_Bodega.Registrar_ReportesColgateBodega_Mov(request.oListaRepPresencia_Mov, request.oListaRepCodigoITT_Mov, request.oListaRepFotografico_Mov, request.oE_Visita_Mov, request.AppEnvia);
            //        response.Descripcion = response.oE_Reportes_Colgate_Bodega_Mov.Mensaje_Response;

            //        if (response.Descripcion.Equals(""))
            //        {
            //            response.Descripcion = "Se ha registrado sus reportes con exito";
            //        }
            //        response.Estado = BaseResponse.EXITO;


            //        //if (response.Descripcion.Equals(""))
            //            //response.Estado = BaseResponse.EXITO;
            //        //else
            //        //    response.Estado = BaseResponse.GENERAL_ERROR;
            //    }
            //    catch (Exception)
            //    {
            //        response.Descripcion = "Servicio no disponible";
            //        response.Estado = BaseResponse.GENERAL_ERROR;
            //    }

            //    WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            //    string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateBodegaService_Mov_Response>(response);
            //    return responseJSON;
            //}
        
            ///// <summary>
            ///// Autor       : PSA
            ///// Fecha       : 04 - 06 - 2012
            ///// Descripcion : Registrar Punto de Venta para ColgateBodega, Devuelve el ClientPDV_Code, generado.
            ///// </summary>
            ///// <param name="DatosReporte"></param>
            ///// <returns></returns>
            //public string ReporteColgateBodega_RegistrarPDV_Mov(string DatosReporte) {
            //    DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Request>(DatosReporte);
            //    DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Response response = new DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Response();
            //    try
            //    {
            //        response.oE_Reporte_RegistroPDV_Response = oBL_ReportesColgate_Bodega.Registrar_PuntoDeVenta_Bodega_Mov(request.oE_Reporte_RegistroPDV_Mov);
            //        response.Estado = BaseResponse.EXITO;
            //        //response.Descripcion = response.oE_Reporte_RegistroPDV_Response.Mensaje;
            //    }
            //    catch (Exception)
            //    {
            //        response.Descripcion = "Servicio no disponible";
            //        response.Estado = BaseResponse.GENERAL_ERROR;
            //    }

            //    WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            //    string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Response>(response);
            //    return responseJSON;
            //}
            #endregion


            #region Nuevas Validaciones RQ Colgate 1.9. 06/09/2012 PSalas
            /// <summary>
            /// Descripcion : Request y Response para Reportes Colgate Mayorista - App Movil Movistar
            /// Fecha       : 21/05/2012 PSA
            /// Descripcion : ReporteColgateMayorista_Mov_V_1_1
            /// </summary>
            private readonly static BL_ReportesColgate_May oBL_ReportesColgate_May_Mov = new BL_ReportesColgate_May();
            public string ReporteColgateMayorista_Mov(string ListaReporte)
            {
                DataContract.ReportesColgateMayoristasService_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateMayoristasService_Mov_Request>(ListaReporte);
                DataContract.ReportesColgateMayoristasService_Mov_Response response = new DataContract.ReportesColgateMayoristasService_Mov_Response();
                try
                {
                    //response.oE_Reportes_Colgate_Mayoristas_Mov_Response = oBL_ReportesColgate_May_Mov.Registrar_ReportesColgateMay_Mov(request.oListaRepPresencia_Mov, request.oListaRepFotografico_Mov, request.oListaRepCodigoITT_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    response.oE_Reportes_Colgate_Mayoristas_Mov_Response = oBL_ReportesColgate_May_Mov.Registrar_ReportesColgateMay_Mov_V_1_1(request.oListaRepPresencia_Mov, request.oListaRepFotografico_Mov, request.oListaRepCodigoITT_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    response.Descripcion = response.oE_Reportes_Colgate_Mayoristas_Mov_Response.Mensaje_Response;

                    if (response.Descripcion.Equals(""))
                    {
                        response.Descripcion = "Se ha registrado sus reportes con exito";
                    }

                    response.Estado = BaseResponse.EXITO;

                }
                catch (Exception)
                {
                    response.Descripcion = "Servicio no disponible";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateMayoristasService_Mov_Response>(response);
                return responseJSON;
            }

            /// <summary>
            /// Descripcion : Request y Response para Reportes Colgate Minorista - App Movil Movistar
            /// Fecha       : 21/05/2012 PSA
            /// Descripcion : ReporteColgateMinorista_Mov_V_1_1
            /// </summary>
            private readonly static BL_ReportesColgate_Min oBL_ReportesColgate_Min_Mov = new BL_ReportesColgate_Min();
            public string ReporteColgateMinorista_Mov(string ListaReporte)
            {
                DataContract.ReportesColgateMinoristasServices_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateMinoristasServices_Mov_Request>(ListaReporte);
                DataContract.ReportesColgateMinoristasServices_Mov_Response response = new DataContract.ReportesColgateMinoristasServices_Mov_Response();
                try
                {
                    //response.oE_Reportes_Colgate_Minorista_Mov_Response = oBL_ReportesColgate_Min_Mov.Registrar_Reportes_Colgate_Min_Mov(request.oListaRepPresencia_Mov, request.oListaRepFotografico_Mov, request.oListaRepCodigoITT_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    response.oE_Reportes_Colgate_Minorista_Mov_Response = oBL_ReportesColgate_Min_Mov.Registrar_Reportes_Colgate_Min_Mov_V_1_1(request.oListaRepPresencia_Mov, request.oListaRepFotografico_Mov, request.oListaRepCodigoITT_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    response.Descripcion = response.oE_Reportes_Colgate_Minorista_Mov_Response.Mensaje_Response;

                    if (response.Descripcion.Equals(""))
                    {
                        response.Descripcion = "Se ha registrado sus reportes con exito";
                    }

                    //if (response.Descripcion.Equals(""))
                    //    response.Estado = BaseResponse.EXITO;
                    //else
                    //    response.Estado = BaseResponse.GENERAL_ERROR;

                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Servicio no disponible";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateMinoristasServices_Mov_Response>(response);
                return responseJSON;
            }

            /// <summary>
            /// Descripcion : Request y Response para Reportes Colgate Farmacia IT - App Movil Movistar
            /// Fecha       : 21/05/2012 PSA
            /// Descripcion :ReporteColgateFarmaciaIT_Mov_V_1_1
            /// </summary>
            private readonly static BL_ReportesColgate_FarmaciaIT oBL_ReportesColgate_FarmaciaIT_Mov = new BL_ReportesColgate_FarmaciaIT();
            public string ReporteColgateFarmaciaIT_Mov(string ListaReporte)
            {
                DataContract.ReportescolgateFarmaciasIT_Mov_Request request = HelperJson.Deserialize<DataContract.ReportescolgateFarmaciasIT_Mov_Request>(ListaReporte);
                DataContract.ReportescolgateFarmaciasIT_Mov_Response response = new DataContract.ReportescolgateFarmaciasIT_Mov_Response();
                try
                {
                    //response.oE_Reportes_Colgate_Farmacia_IT_Mov_Response = oBL_ReportesColgate_FarmaciaIT_Mov.Registrar_Reportes_Colgate_Farmacia_IT_Mov(request.oListaRepPresencia_Mov, request.oListaRepFotografico_Mov, request.oListaRepCodigoITT_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    response.oE_Reportes_Colgate_Farmacia_IT_Mov_Response = oBL_ReportesColgate_FarmaciaIT_Mov.Registrar_Reportes_Colgate_Farmacia_IT_Mov_V_1_1(request.oListaRepPresencia_Mov, request.oListaRepFotografico_Mov, request.oListaRepCodigoITT_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    response.Descripcion = response.oE_Reportes_Colgate_Farmacia_IT_Mov_Response.Mensaje_Response;

                    if (response.Descripcion.Equals(""))
                    {
                        response.Descripcion = "Se ha registrado sus reportes con exito";
                    }
                    response.Estado = BaseResponse.EXITO;

                    //if (response.Descripcion.Equals(""))
                    //response.Estado = BaseResponse.EXITO;
                    //else
                    //    response.Estado = BaseResponse.GENERAL_ERROR;
                    //response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Servicio no disponible";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.ReportescolgateFarmaciasIT_Mov_Response>(response);
                return responseJSON;
            }

            /// <summary>
            /// Descripcion : Request y Response para Reportes Colgate Farmacia DT - App Movil Movistar
            /// Fecha       : 21/05/2012 PSA
            /// Descripcion : ReporteColgateFarmaciaDT_Mov_V_1_1
            /// </summary>
            private readonly static BL_ReportesColgate_FarmaciaDT oBL_ReportesColgate_FarmaciaDT_Mov = new BL_ReportesColgate_FarmaciaDT();
            public string ReporteColgateFarmaciaDT_Mov(string ListaReporte)
            {
                DataContract.ReportesColgateFarmaciasDT_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateFarmaciasDT_Mov_Request>(ListaReporte);
                DataContract.ReportesColgateFarmaciasDT_Mov_Response response = new DataContract.ReportesColgateFarmaciasDT_Mov_Response();
                try
                {
                    //response.oE_Reportes_Colgate_Farmacia_DT_Mov_Response = oBL_ReportesColgate_FarmaciaDT_Mov.Registar_Reporte_Colgate_Farmacia_DT_Mov(request.oListaRepPresencia_Mov, request.oListaRepCodigoITT_Mov, request.oListaRepPromocion_Mov, request.oListaRepMatApoyo_Mov, request.oListaRepVisCompetencia_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    response.oE_Reportes_Colgate_Farmacia_DT_Mov_Response = oBL_ReportesColgate_FarmaciaDT_Mov.Registar_Reporte_Colgate_Farmacia_DT_Mov_V_1_1(request.oListaRepPresencia_Mov, request.oListaRepCodigoITT_Mov, request.oListaRepPromocion_Mov, request.oListaRepMatApoyo_Mov, request.oListaRepVisCompetencia_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    response.Descripcion = response.oE_Reportes_Colgate_Farmacia_DT_Mov_Response.Mensaje_Response;

                    if (response.Descripcion.Equals(""))
                    {
                        response.Descripcion = "Se ha registrado sus reportes con exito";
                    }

                    response.Estado = BaseResponse.EXITO;

                    //if (response.Descripcion.Equals(""))
                    //response.Estado = BaseResponse.EXITO;
                    //else
                    //    response.Estado = BaseResponse.GENERAL_ERROR;
                    //response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Servicio no disponible";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateFarmaciasDT_Mov_Response>(response);
                return responseJSON;
            }

            /// <summary>
            /// Autor: Joseph Gonzales
            /// Fecha: 01 - 06 - 2012
            /// Descripcion:ReporteColgateBodega_Mov_V_1_1
            /// </summary>
            /// <param name="DatosReporte"></param>
            /// <returns></returns>
            //private readonly static BL_ReportesColgate_Bodega oBL_ReportesColgate_Bodega = new BL_ReportesColgate_Bodega();
            public string ReporteColgateBodega_Mov(string DatosReporte)
            {
                DataContract.ReportesColgateBodegaService_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateBodegaService_Mov_Request>(DatosReporte);
                DataContract.ReportesColgateBodegaService_Mov_Response response = new DataContract.ReportesColgateBodegaService_Mov_Response();
                try
                {
                    response.oE_Reportes_Colgate_Bodega_Mov = oBL_ReportesColgate_Bodega.Registrar_ReportesColgateBodega_Mov_V_1_1(request.oListaRepPresencia_Mov, request.oListaRepCodigoITT_Mov, request.oListaRepFotografico_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    //response.oE_Reportes_Colgate_Bodega_Mov = oBL_ReportesColgate_Bodega.Registrar_ReportesColgateBodega_Mov(request.oListaRepPresencia_Mov, request.oListaRepCodigoITT_Mov, request.oListaRepFotografico_Mov, request.oE_Visita_Mov, request.AppEnvia);
                    response.Descripcion = response.oE_Reportes_Colgate_Bodega_Mov.Mensaje_Response;

                    if (response.Descripcion.Equals(""))
                    {
                        response.Descripcion = "Se ha registrado sus reportes con exito";
                    }
                    response.Estado = BaseResponse.EXITO;


                    //if (response.Descripcion.Equals(""))
                    //response.Estado = BaseResponse.EXITO;
                    //else
                    //    response.Estado = BaseResponse.GENERAL_ERROR;
                }
                catch (Exception)
                {
                    response.Descripcion = "Servicio no disponible";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateBodegaService_Mov_Response>(response);
                return responseJSON;
            }

            /// <summary>
            /// Autor       : PSA
            /// Fecha       : 04 - 06 - 2012
            /// Descripcion : Registrar Punto de Venta para ColgateBodega, Devuelve el ClientPDV_Code, generado.
            /// </summary>
            /// <param name="DatosReporte"></param>
            /// <returns></returns>
            public string ReporteColgateBodega_RegistrarPDV_Mov(string DatosReporte)
            {
                DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Request request = HelperJson.Deserialize<DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Request>(DatosReporte);
                DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Response response = new DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Response();
                try
                {
                    response.oE_Reporte_RegistroPDV_Response = oBL_ReportesColgate_Bodega.Registrar_PuntoDeVenta_Bodega_Mov(request.oE_Reporte_RegistroPDV_Mov);
                    response.Estado = BaseResponse.EXITO;
                    //response.Descripcion = response.oE_Reporte_RegistroPDV_Response.Mensaje;
                }
                catch (Exception)
                {
                    response.Descripcion = "Servicio no disponible";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.ReportesColgateBodega_RegistrarPDV_Mov_Response>(response);
                return responseJSON;
            }
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
        private readonly static BL_ReporteSanFernando_AAVV oBL_ReporteSanFernando_AAVV = new BL_ReporteSanFernando_AAVV();
        public string ReporteSanFernandoAAVV_Mov(string DatosReporte)
        {
            DataContract.ReporteSanFernandoAAVV_Mov_Request request = HelperJson.Deserialize<DataContract.ReporteSanFernandoAAVV_Mov_Request>(DatosReporte);
            DataContract.ReporteSanFernandoAAVV_Mov_Response response = new DataContract.ReporteSanFernandoAAVV_Mov_Response();
            try
            {
                response.Descripcion = oBL_ReporteSanFernando_AAVV.Registrar_ReporteSanFernando_AAVV_Mov(request.oListaRepStock_Mov,
                    request.oListaRepPrecio_Mov, request.oListaRepFotografico_Mov, request.oListaRepIncidencia_Mov, request.oE_Visita_Mov, request.AppEnvia);
                if (response.Descripcion.Equals(""))
                {
                    response.Descripcion = "Se ha registrado con exito sus reportes";
                    response.Estado = BaseResponse.EXITO;
                }
                else
                    response.Estado = BaseResponse.GENERAL_ERROR;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteSanFernandoAAVV_Mov_Response>(response);
            return responseJSON;
        }

        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       28 - 05 - 2012
        /// Descripción: Registra los reportes para el cliente San Fernando canal Moderno.    
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        private readonly static BL_ReporteSanFernando_Moderno oBL_ReporteSanFernando_Moderno = new BL_ReporteSanFernando_Moderno();
        public string ReporteSanFernandoModerno_Mov(string DatosReporte)
        {
            DataContract.ReporteSanFernandoModerno_Mov_Request request = HelperJson.Deserialize<DataContract.ReporteSanFernandoModerno_Mov_Request>(DatosReporte);
            DataContract.ReporteSanFernandoModerno_Mov_Response response = new DataContract.ReporteSanFernandoModerno_Mov_Response();
            try
            {
                response.Descripcion = oBL_ReporteSanFernando_Moderno.Registrar_ReporteSanFernando_Moderno_Mov(request.oListaRepPrecio_Mov,  request.oListaRepFotografico_Mov,
                    request.oListaRepCompetencia_Mov, request.oListaRepStock_Mov, request.oListaRepImpulso_Mov, request.oE_Visita_Mov, request.AppEnvia);
                if (response.Descripcion.Equals(""))
                {
                    response.Descripcion = "Se ha registrado con exito sus reportes";
                    response.Estado = BaseResponse.EXITO;
                }
                else
                    response.Estado = BaseResponse.GENERAL_ERROR;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteSanFernandoModerno_Mov_Response>(response);
            return responseJSON;
        }

        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       28 - 05 - 2012
        /// Descripción: Registra los reportes para el cliente San Fernando canal Tradicional.    
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        private readonly static BL_ReporteSanFernando_Tradicional oBL_ReporteSanFernando_Tradicional = new BL_ReporteSanFernando_Tradicional();
        public string ReporteSanFernandoTradicional_Mov(string DatosReporte)
        {
            DataContract.ReporteSanFernandoTradicional_Mov_Request request = HelperJson.Deserialize<DataContract.ReporteSanFernandoTradicional_Mov_Request>(DatosReporte);
            DataContract.ReporteSanFernandoTradicional_Mov_Response response = new DataContract.ReporteSanFernandoTradicional_Mov_Response();
            try
            {
                response.Descripcion = oBL_ReporteSanFernando_Tradicional.Registrar_ReporteSanFernando_Tradicional_Mov(
                      request.oListaRepPrecio_Mov
                    , request.oListaRepExhibicion_Mov
                    , request.oListaRepMarcaje_Mov
                    , request.oListaRepMaterialApoyo_Mov
                    , request.oListaRepCapacitacion_Mov
                    , request.oListaRepIncidencia_Mov
                    , request.oListaRepCredito_Competencia_Mov
                    , request.oListaRepPresencia_Mov
                    , request.oE_Visita_Mov
                    , request.AppEnvia);
                if (response.Descripcion.Equals(""))
                {
                    response.Descripcion = "Se ha registrado con exito sus reportes";
                    response.Estado = BaseResponse.EXITO;
                }
                else
                    response.Estado = BaseResponse.GENERAL_ERROR;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReporteSanFernandoTradicional_Mov_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Cliente Alicorp
        /// <summary>
        /// Descripcion : Request y Response para Reportes Alicorp Mayorista - App Movil Movistar
        /// Fecha       : 28/05/2012 PSA
        /// </summary>
        private readonly static BL_ReportesAlicorp_May oBL_ReportesAlicorp_May = new BL_ReportesAlicorp_May();
        public string ReporteAlicorpMayorista_Mov(string DatosReporte)
        {
            DataContract.ReportesAlicorpMayoristaServices_Request request = HelperJson.Deserialize<DataContract.ReportesAlicorpMayoristaServices_Request>(DatosReporte);
            DataContract.ReportesAlicorpMayoristaServices_Response response = new DataContract.ReportesAlicorpMayoristaServices_Response();
            try {
                response.Descripcion= oBL_ReportesAlicorp_May.Registrar_Reportes_Alicorp_May_Mov(request.oLista_Rep_Precio_Mov,
                    request.oLista_Rep_SOD_Mov,
                    request.oLista_Rep_Fotografico_Mov,
                    request.oLista_Rep_Competencia_Mov,
                    request.oLista_Rep_Stock_Mov,
                    request.oE_Visita_Mov,
                    request.AppEnvia);
                if (response.Descripcion.Equals(""))
                    response.Estado = BaseResponse.EXITO;
                else
                    response.Estado = BaseResponse.GENERAL_ERROR;
                response.Descripcion = "Se ha registrado con exito!";
                response.Estado = BaseResponse.EXITO;
                

            }
            catch (Exception) {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReportesAlicorpMayoristaServices_Response>(response);
            return responseJSON;
        }

        private readonly static BL_ReportesAlicorp_AutoServicio oBL_ReportesAlicorp_AutoServicio = new BL_ReportesAlicorp_AutoServicio();
        public string ReporteAlicorpAutoservicio_Mov(string DatosReporte)
        {
            DataContract.ReportesAlicorpAutoserviciosServices_Request request = HelperJson.Deserialize<DataContract.ReportesAlicorpAutoserviciosServices_Request>(DatosReporte);
            DataContract.ReportesAlicorpAutoserviciosServices_Response response = new DataContract.ReportesAlicorpAutoserviciosServices_Response();

            try {
                //response.Descripcion;
                response.Descripcion = oBL_ReportesAlicorp_AutoServicio.Registrar_Reportes_Alicorp_Autoservicio(request.oLista_Rep_Precio_Mov,
                    request.oLista_Rep_Fotografico_Mov,
                    request.oLista_Rep_Competencia_Mov,
                    request.oLista_Rep_Exhibicion_Mov,
                    request.oLista_Rep_Quiebre_Mov,
                    request.oLista_Rep_LayOut_Mov,
                    request.oE_Visita_Mov,
                    request.AppEnvia);
                if (response.Descripcion.Equals(""))
                {
                    response.Descripcion = "Se ha registrado con exito sus reportes";
                    response.Estado = BaseResponse.EXITO;
                }
                else
                    response.Estado = BaseResponse.GENERAL_ERROR;
                response.Estado = BaseResponse.EXITO;

            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ReportesAlicorpAutoserviciosServices_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Cliente CocaCola
        //private readonly static BL_Reporte_Fotografico oBL_Reporte_Fotografico = new BL_Reporte_Fotografico();
        public string RegRepFoto_Mov_Coca(string DatosReporte)
        {
            //oBL_ReportesAlicorp_May RegistrarReporteFotografico_Mov
            DataContract.Reporte_Fotografico_Mov_Request request = HelperJson.Deserialize<DataContract.Reporte_Fotografico_Mov_Request>(DatosReporte);
            DataContract.Reporte_Fotografico_Mov_Response response = new DataContract.Reporte_Fotografico_Mov_Response();
            try {
                response.Descripcion = oBL_Reporte_Fotografico.RegRepFoto_Mov_Coca(request.oListaE_Reporte_Fotografico_Mov);
            }
            catch (Exception ex) {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Reporte_Fotografico_Mov_Response>(response);
            return responseJSON;
            
        }
        #endregion

        #endregion

        //public string ReporteAlicorpAutoservicio_Mov(string DatosReporte)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
