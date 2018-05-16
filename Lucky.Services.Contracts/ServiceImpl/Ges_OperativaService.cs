using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Business.Common.JavaMovil;
using Lucky.CFG.JavaMovil;
using System.Configuration;
using System.IO;
using Lucky.Entity;
using Lucky.Entity.Common.Servicio;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Services.Contracts.ServiceContract;
using System.ServiceModel.Web;
using Lucky.Business.Common.Servicio;
using System.Data;



namespace Lucky.Services.Contracts.ServiceImpl
{
    public class Ges_OperativaService : IGes_OperativaService
    {
        #region Gestion de Reportes - Registrar 
        /// <summary>
        /// Fecha:       11/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Request del Reporte de Precios General
        /// </summary>
        /// <param name="DatosReportePrecio"></param>
        /// <returns></returns>
        public string Registrar_Reporte_Precio(string DatosReportePrecio)
        {
            BL_Reporte_Precio oBL_Reporte_Precio = new BL_Reporte_Precio();

            DataContract.Reporte_Precio_Request request = HelperJson.Deserialize<DataContract.Reporte_Precio_Request>(DatosReportePrecio);
            DataContract.Reporte_Precio_Response response = new DataContract.Reporte_Precio_Response();
            try
            {
                response.Descripcion = oBL_Reporte_Precio.RegistrarPrecio(request.ReportePrecio, request.AppEnvia);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Reporte_Precio_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Fecha:       11/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Request del Reporte de Precios General
        /// </summary>
        /// <param name="DatosReporteStock"></param>
        /// <returns></returns>
        public string Registrar_Reporte_Stock(string DatosReporteStock)
        {
            BL_Reporte_Stock oBL_Reporte_Stock = new BL_Reporte_Stock();

            DataContract.Reporte_Stock_Request request = HelperJson.Deserialize<DataContract.Reporte_Stock_Request>(DatosReporteStock);
            DataContract.Reporte_Stock_Response response = new DataContract.Reporte_Stock_Response();
            try
            {
                response.Descripcion = oBL_Reporte_Stock.Registrar_Reporte_Stock(request.ReporteStock, request.AppEnvia);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Reporte_Stock_Response>(response);
            return responseJSON;
        }
        //--OK
        //--Descripcion : Registrar Reporte SOD
        //--Fecha       : 11/05/2012 - PSA
        public string Registrar_Reporte_SOD(string DatosReporteSOD)
        {
            BL_Reporte_SOD oBL_Reporte_SOD = new BL_Reporte_SOD();

            DataContract.Reporte_SOD_Request request = HelperJson.Deserialize<DataContract.Reporte_SOD_Request>(DatosReporteSOD);
            DataContract.Reporte_SOD_Response response = new DataContract.Reporte_SOD_Response();
            try
            {
                response.Descripcion = oBL_Reporte_SOD.Registrar_Reporte_SOD(request.oLista_ReporteSOD,request.AppEnvia);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Reporte_SOD_Response>(response);
            return responseJSON;
        }
        //--OK
        //--Descripcion : Registrar Reporte Exhibicion
        //--Fecha       : 11/05/2012 - PSA
        public string Registrar_Reporte_Exhibicion(string DatosReporteExhibicion)
        {
            BL_Reporte_Exhibicion oBL_Reporte_Exhibicion = new BL_Reporte_Exhibicion();

            DataContract.Reporte_Exhibicion_Request request = HelperJson.Deserialize<DataContract.Reporte_Exhibicion_Request>(DatosReporteExhibicion);
            DataContract.Reporte_Exhibicion_Response response = new DataContract.Reporte_Exhibicion_Response();
            try
            {
                response.Descripcion = oBL_Reporte_Exhibicion.Registrar_Reporte_Exhibicion(request.oLista_ReporteExhibicion, request.AppEnvia);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Reporte_Exhibicion_Response>(response);
            return responseJSON;
        }
        //--OK
        //--Descripcion : Registrar Reporte Quiebre
        //--Fecha       : 11/05/2012 - PSA
        public string Registrar_Reporte_Quiebre(string DatosReporteQuiebre)
        {
            BL_Reporte_Quiebre oBL_Reporte_Quiebre = new BL_Reporte_Quiebre();

            DataContract.Reporte_Quiebre_Request request = HelperJson.Deserialize<DataContract.Reporte_Quiebre_Request>(DatosReporteQuiebre);
            DataContract.Reporte_Quiebre_Response response = new DataContract.Reporte_Quiebre_Response();
            try
            {
                response.Descripcion = oBL_Reporte_Quiebre.Registrar_Reporte_Quiebre(request.oLista_ReporteQuiebre, request.AppEnvia);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Reporte_Quiebre_Response>(response);
            return responseJSON;
        }
        //--OK
        //--Descripcion : Registrar Reporte LayOut
        //--Fecha       : 11/05/2012 - PSA
        public string Registrar_Reporte_LayOut(string DatosReporteLayOut)
        {
            BL_Reporte_LayOut oBL_Reporte_LayOut = new BL_Reporte_LayOut();

            DataContract.Reporte_LayOut_Request request = HelperJson.Deserialize<DataContract.Reporte_LayOut_Request>(DatosReporteLayOut);
            DataContract.Reporte_LayOut_Response response = new DataContract.Reporte_LayOut_Response();
            try
            {
                response.Descripcion = oBL_Reporte_LayOut.Registrar_Reporte_LayOut(request.oLista_ReporteLayOut, request.AppEnvia);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Reporte_LayOut_Response>(response);
            return responseJSON;
        }
        public string Registrar_Reporte_Fotografico(string DatosReporte) {
            BL_Reporte_Fotografico oBL_Reporte_Fotografico = new BL_Reporte_Fotografico();
            DataContract.Reporte_Fotografico_Request request = HelperJson.Deserialize<DataContract.Reporte_Fotografico_Request>(DatosReporte);
            DataContract.Reporte_Forografico_Response response = new DataContract.Reporte_Forografico_Response();

            try {
                response.Descripcion = oBL_Reporte_Fotografico.registrarFotografico(request.oLista_ReporteFotografico, request.AppEnvia);
                if (response.Descripcion.Equals(""))
                    response.Estado = BaseResponse.EXITO;
                else
                    response.Estado = BaseResponse.GENERAL_ERROR;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception) {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Reporte_Forografico_Response>(response);
            return responseJSON;
        }
        public string Registrar_Reporte_Competencia(string DatosReporte) {
            BL_Reporte_Competencia oBL_Reporte_Competencia = new BL_Reporte_Competencia();
            DataContract.Reporte_Competencia_Request request = HelperJson.Deserialize<DataContract.Reporte_Competencia_Request>(DatosReporte);
            DataContract.Reporte_Competencia_Response response = new DataContract.Reporte_Competencia_Response();

            try
            {
                response.Descripcion = oBL_Reporte_Competencia.Registrar_Reporte_Competencia_Web(request.olista_ReporteCompetencia, request.AppEnvia);
                if (response.Descripcion.Equals(""))
                    response.Estado = BaseResponse.EXITO;
                else
                    response.Estado = BaseResponse.GENERAL_ERROR;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Reporte_Competencia_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Estado  : Warning
        /// Author  : Pablo Salas A.
        /// Fecha   : 26/09/2012
        /// Descripcion :
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        public string Registrar_Reporte_Encuesta(string DatosReporte) {
            DataContract.Registrar_Reporte_Encuesta_Request request = HelperJson.Deserialize<DataContract.Registrar_Reporte_Encuesta_Request>(DatosReporte);
            DataContract.Registrar_Reporte_Encuenta_Response response = new DataContract.Registrar_Reporte_Encuenta_Response();
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();
            try {
                //Falta el metodo que invoca.... response.Descripcion=""????
                response.Descripcion  = oBL_GES_Operativa.Registrar_Reporte_Encuesta(request.oE_Reporte_Encuesta);
                if (!response.Descripcion.Equals(""))
                {
                    response.Descripcion = "Registro con Exito";
                    response.Estado = BaseResponse.EXITO;
                }
                else {
                    response.Descripcion = "Ocurrio un error";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }
            }
            catch (Exception) {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Registrar_Reporte_Encuenta_Response>(response);
            return responseJSON;
        }

        /// <summary>
        /// Author  : Joseph Gonzales.
        /// Fecha   : 15/10/2012
        /// Descripcion :
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns
        public string Registrar_Reporte_Encuesta_EQF(string DatosReporte)
        {
            DataContract.Registrar_Reporte_Encuesta_EQF_Request request = HelperJson.Deserialize<DataContract.Registrar_Reporte_Encuesta_EQF_Request>(DatosReporte);
            DataContract.Registrar_Reporte_Encuenta_Response response = new DataContract.Registrar_Reporte_Encuenta_Response();
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();
            try
            {
                response.Descripcion = oBL_GES_Operativa.Registrar_Reporte_Encuesta_EQF(request.oE_Reporte_Encuesta_EQF);
                if (!response.Descripcion.Equals(""))
                {
                    response.Descripcion = "Registro con Exito";
                    response.Estado = BaseResponse.EXITO;
                }
                else
                {
                    response.Descripcion = "Ocurrio un error";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Registrar_Reporte_Encuenta_Response>(response);
            return responseJSON;
        }
        
        #endregion

        #region Gestion de Reportes - Consultar
        /// <summary>
        /// Fecha:       11/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Consulta el Reporte de Stock General
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Consultar_Reporte_Stock_Validado(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consultar_Reporte_Stock_Request request = HelperJson.Deserialize<DataContract.Consultar_Reporte_Stock_Request>(DatosParametro);
            DataContract.Consultar_Reporte_Stock_Response response = new DataContract.Consultar_Reporte_Stock_Response();
            try
            {
                response.Consulta_Reporte_Stock = oBL_GES_Operativa.Consultar_Reporte_Stock_Validado(request.CodServicio, request.CodCompania, request.CodCanal, request.CodOficina, request.CodCategoria, request.CodReportsCampaña, request.TipoData);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Consultar_Reporte_Stock_Response>(response);
            return responseJSON;

        }
        /// ---Ok
        /// Fecha:       15/05/2012 PSA
        /// Descripción: Consulta el Reporte de Stock General
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Consultar_Reporte_Stock_General(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consultar_Reporte_Stock_General_Request request = HelperJson.Deserialize<DataContract.Consultar_Reporte_Stock_General_Request>(DatosParametro);
            DataContract.Consultar_Reporte_Stock_General_Response response = new DataContract.Consultar_Reporte_Stock_General_Response();
            try
            {
                response.Consulta_Reporte_Stock = oBL_GES_Operativa.Consultar_Reporte_Stock_General(request.CodPersona, request.CodCampania, request.CodCanal, request.CodOficina, request.CodNodoComercial, request.CodigoPDV_Compania, request.CodCategoria, request.CodFamilia, request.f_inicio, request.f_fin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Consultar_Reporte_Stock_General_Response>(response);
            return responseJSON;

        }
        /// ---Ok
        /// Fecha:       15/05/2012 PSA
        /// Descripción: Consulta el Reporte de Precio General
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Consultar_Reporte_Precio_General(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consultar_Reporte_Precio_General_Request request = HelperJson.Deserialize<DataContract.Consultar_Reporte_Precio_General_Request>(DatosParametro);
            DataContract.Consultar_Reporte_Precio_General_Response response = new DataContract.Consultar_Reporte_Precio_General_Response();
            try
            {
                response.Consulta_Reporte_Precio = oBL_GES_Operativa.Consultar_Reporte_Precio_General(request.CodPersona, request.CodCampania, request.CodCanal, request.CodOficina, request.CodNodoComercial, request.CodigoPDV_Compania, request.CodCategoria, request.CodSubcategoria, request.CodMarca, request.codProducto, request.f_inicio, request.f_fin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Consultar_Reporte_Precio_General_Response>(response);
            return responseJSON;

        }
        /// ---Warning
        /// Fecha:       15/05/2012 PSA
        /// Descripción: Consulta el Reporte de SOD General
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Consultar_Reporte_SOD_General(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consultar_Reporte_SOD_General_Request request = HelperJson.Deserialize<DataContract.Consultar_Reporte_SOD_General_Request>(DatosParametro);
            DataContract.Consultar_Reporte_SOD_General_Response response = new DataContract.Consultar_Reporte_SOD_General_Response();
            try
            {
                response.Consulta_Reporte_SOD = oBL_GES_Operativa.Consultar_Reporte_SOD_General(request.CodPersona, request.CodCampania, request.CodCanal, request.CodOficina, request.CodNodoComercial, request.CodigoPDV_Compania, request.CodCategoria, request.CodMarca, request.f_inicio, request.f_fin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Consultar_Reporte_SOD_General_Response>(response);
            return responseJSON;

        }
        /// ---Warning
        /// Fecha:       15/05/2012 PSA
        /// Descripción: Consulta el Reporte de LayOut General
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Consultar_Reporte_LayOut_General(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consultar_Reporte_LayOut_General_Request request = HelperJson.Deserialize<DataContract.Consultar_Reporte_LayOut_General_Request>(DatosParametro);
            DataContract.Consultar_Reporte_LayOut_General_Response response = new DataContract.Consultar_Reporte_LayOut_General_Response();
            try
            {
                response.Consulta_Reporte_LayOut = oBL_GES_Operativa.Consultar_Reporte_LayOut_General(request.CodPersona, request.CodCampania, request.CodCanal, request.CodCategoria, request.CodMarca, request.f_inicio, request.f_fin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Consultar_Reporte_LayOut_General_Response>(response);
            return responseJSON;

        }
        /// ---Warning
        /// Fecha:       15/05/2012 PSA
        /// Descripción: Consulta el Reporte de Quiebre General
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Consultar_Reporte_Quiebre_General(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consultar_Reporte_Quiebre_General_Request request = HelperJson.Deserialize<DataContract.Consultar_Reporte_Quiebre_General_Request>(DatosParametro);
            DataContract.Consultar_Reporte_Quiebre_General_Response response = new DataContract.Consultar_Reporte_Quiebre_General_Response();
            try
            {
                response.Consulta_Reporte_Quiebre = oBL_GES_Operativa.Consultar_Reporte_Quiebre_General(request.CodPersona, request.CodCampania, request.CodCanal, request.CodOficina, request.CodNodoComercial, request.CodigoPDV_Compania, request.CodCategoria, request.CodMarca, request.codProducto, request.f_inicio, request.f_fin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Consultar_Reporte_Quiebre_General_Response>(response);
            return responseJSON;

        }
        /// ---Warning
        /// Fecha:       15/05/2012 PSA
        /// Descripción: Consulta el Reporte de SOD General
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Consultar_Reporte_Exhibicion_General(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consultar_Reporte_Exhibicion_General_Request request = HelperJson.Deserialize<DataContract.Consultar_Reporte_Exhibicion_General_Request>(DatosParametro);
            DataContract.Consultar_Reporte_Exhibicion_General_Response response = new DataContract.Consultar_Reporte_Exhibicion_General_Response();
            try
            {
                response.Consulta_Reporte_Exhibicion = oBL_GES_Operativa.Consultar_Reporte_Exhibicion_General(request.CodPersona, request.CodCampania, request.CodCanal, request.CodOficina, request.CodNodoComercial, request.CodigoPDV_Compania, request.CodCategoria, request.CodMarca, request.f_inicio, request.f_fin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Consultar_Reporte_Exhibicion_General_Response>(response);
            return responseJSON;

        }

        /// Fecha:       13/11/2012 PCP
        /// Descripción: Consulta el Reporte de Exhibicion
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Consultar_Reporte_Exhibicion(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consultar_Reporte_Exhibicion_Request request = HelperJson.Deserialize<DataContract.Consultar_Reporte_Exhibicion_Request>(DatosParametro);
            DataContract.Consultar_Reporte_Exhibicion_Response response = new DataContract.Consultar_Reporte_Exhibicion_Response();
            try
            {
                response.Consulta_Reporte_Exhibicion = oBL_GES_Operativa.Consultar_Reporte_Exhibicion(request.CodPersona, request.CodCampania, request.CodCanal, request.CodOficina, request.CodNodoComercial, request.CodigoPDV_Compania, request.CodCategoria, request.CodMarca, request.f_inicio, request.f_fin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Consultar_Reporte_Exhibicion_Response>(response);
            return responseJSON;

        }

        public string Consultar_Reporte_Data_Validada(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consultar_Reporte_Stock_Request request = HelperJson.Deserialize<DataContract.Consultar_Reporte_Stock_Request>(DatosParametro);
            DataContract.Consultar_Reporte_Data_Validada_Response response = new DataContract.Consultar_Reporte_Data_Validada_Response();
            try
            {
                response.DataValidada = oBL_GES_Operativa.Consultar_Reporte_Data_Validada(request.CodServicio, request.CodCompania, request.CodCanal, request.CodOficina, request.CodCategoria, request.CodReportsCampaña);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }


            string responseJSON = HelperJson.Serialize<DataContract.Consultar_Reporte_Data_Validada_Response>(response);
            return responseJSON;
        }
        public string Consulta_Reporte_Presencia(string datosParametros)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consulta_Reporte_Presencia_Request request = new DataContract.Consulta_Reporte_Presencia_Request();
            DataContract.Consulta_Reporte_Presencia_Response response = new DataContract.Consulta_Reporte_Presencia_Response();
            try
            {
                request = HelperJson.Deserialize<DataContract.Consulta_Reporte_Presencia_Request>(datosParametros);

                response.oListConsulta_Reporte_Presencia = oBL_GES_Operativa.Consultar_Reporte_Presencia(request.CodCampania, request.CodCanal, request.CodOficina, request.CodNodoComercial, request.CodigoPDV, request.CodCategoria, request.CodMarca, request.CodSupervisor, request.CodPersona, request.CodTipoReporte, Convert.ToDateTime(request.f_incio), Convert.ToDateTime(request.f_fin));
                response.Estado = BaseResponse.EXITO;

            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            String responseJSON = HelperJson.Serialize<DataContract.Consulta_Reporte_Presencia_Response>(response);
            return responseJSON;
        }
        public string Consultar_ReportePresenciaConsolidado(string datosParametros)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consulta_Reporte_PresenciaConsolidado_Request request = new DataContract.Consulta_Reporte_PresenciaConsolidado_Request();
            DataContract.Consulta_Reporte_PresenciaConsolidado_Response response = new DataContract.Consulta_Reporte_PresenciaConsolidado_Response();
            try
            {
                request = HelperJson.Deserialize<DataContract.Consulta_Reporte_PresenciaConsolidado_Request>(datosParametros);

                response.oE_ContentStringDataSet = oBL_GES_Operativa.Consultar_ReportePresenciaConsolidado(request.CodCampania, request.CodEquipo,request.CodCanal,request.CodMercaderista, request.CodOficina, request.CodMalla, request.CodigoPDV,request.CodTipoReporte, Convert.ToDateTime(request.f_incio), Convert.ToDateTime(request.f_fin));
                response.Estado = BaseResponse.EXITO;

            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            String responseJSON = HelperJson.Serialize<DataContract.Consulta_Reporte_PresenciaConsolidado_Response>(response);
            return responseJSON;
        }
        public string Consulta_Reporte_Relevo(string datosParametros)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Consulta_Reporte_Relevo_Request request = new DataContract.Consulta_Reporte_Relevo_Request();
            DataContract.Consulta_Reporte_Relevo_Response response = new DataContract.Consulta_Reporte_Relevo_Response();
            try
            {
                request = HelperJson.Deserialize<DataContract.Consulta_Reporte_Relevo_Request>(datosParametros);

                response.oListConsulta_Reporte_Relevo = oBL_GES_Operativa.Consulta_Reporte_Relevo(request.fechaConsulta,
                    request.codCliente, request.codUsuario, request.codCanal, request.codPais, request.codDepartamento,
                    request.codProvincia);
                response.Estado = BaseResponse.EXITO;

            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            String responseJSON = HelperJson.Serialize<DataContract.Consulta_Reporte_Relevo_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion Reportes - Actualizar
        /// <summary>
        /// Fecha:       12/11/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Request del Reporte de Exhibicion
        /// </summary>
        /// <param name="DatosReportePrecio"></param>
        /// <returns></returns>
        public string Actualizar_Reporte_Exhibicion(string DatosReporte)
        {
            BL_GES_Operativa oReporte_Exhibicion = new BL_GES_Operativa();

            DataContract.Actualizar_Reporte_Exhibicion_Request request = HelperJson.Deserialize<DataContract.Actualizar_Reporte_Exhibicion_Request>(DatosReporte);
            DataContract.Actualizar_Reporte_Exhibicion_Response response = new DataContract.Actualizar_Reporte_Exhibicion_Response();
            try
            {
                response.Descripcion = oReporte_Exhibicion.Actualizar_Reporte_Exhibicion(request.CodReporte, request.Cantidad, request.ModifyBy, request.DateModify, request.DateRegistro);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //string responseJSON = HelperJson.Serialize<DataContract.Actualizar_Reporte_Exhibicion_Response>(response);
            return response.Descripcion;
        }

        /// <summary>
        /// Fecha:       14/11/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Request de la validacion del Reporte de Exhibicion
        /// </summary>
        /// <param name="DatosReportePrecio"></param>
        /// <returns></returns>
        public string Validar_Reporte_Exhibicion(string DatosReporte)
        {
            BL_GES_Operativa oReporte_Exhibicion = new BL_GES_Operativa();

            DataContract.Validar_Reporte_Exhibicion_Request request = HelperJson.Deserialize<DataContract.Validar_Reporte_Exhibicion_Request>(DatosReporte);
            DataContract.Validar_Reporte_Exhibicion_Response response = new DataContract.Validar_Reporte_Exhibicion_Response();
            try
            {
                response.Descripcion = oReporte_Exhibicion.Validar_Reporte_Exhibicion(request.Cheched, request.unChecked);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "error";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //string responseJSON = HelperJson.Serialize<DataContract.Actualizar_Reporte_Exhibicion_Response>(response);
            return response.Descripcion;
        }
        #endregion

        #region Gestion de Login
        public string Logueo(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Logueo_Request request = HelperJson.Deserialize<DataContract.Logueo_Request>(DatosParametro);
            DataContract.Logueo_Response response = new DataContract.Logueo_Response();
            try
            {

                response.Logueo = oBL_GES_Operativa.Logueo(request.name_user, request.User_Password);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Ocurrio un error, consultar con el equipo de TI.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }


            string responseJSON = HelperJson.Serialize<DataContract.Logueo_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion Unicos
        /// <summary>
        /// Fecha:       14/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Validación de los reportes 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Validar_Reporte_Stock(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.Validar_Reporte_Stock_Request request = HelperJson.Deserialize<DataContract.Validar_Reporte_Stock_Request>(DatosParametro);
            DataContract.Validar_Reporte_Stock_Response response = new DataContract.Validar_Reporte_Stock_Response();
            try
            {
                oBL_GES_Operativa.Validar_Reporte_Stock(request.listaValidarReporteStock, request.listaInValidarReporteStock);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Validar_Reporte_Stock_Response>(response);
            return responseJSON;
        }

        /// <summary>
        /// Creado por: Giam Farfan
        /// Fecha: 04/10/2012
        /// Descripcion: Lista informes para el menu Consumo Masivo Xplora v2 y el perfil 0999
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string ListarInformesCMv2(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.ListarInformesCMv2_Request request = HelperJson.Deserialize<DataContract.ListarInformesCMv2_Request>(DatosParametro);
            DataContract.ListarInformesCMv2_Response response = new DataContract.ListarInformesCMv2_Response();
            try
            {
                response.oListaInformes=oBL_GES_Operativa.Listar_Informes_CM(request.codPais, request.codCliente,request.idagrupacion,request.idPersona);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.ListarInformesCMv2_Response>(response);
            return responseJSON;
        }

        /// <summary>
        /// Creado por: Giam Farfan
        /// Fecha: 04/10/2012</summary>
        /// Descripcion: Lista informes para el menu Marketing Xplora v2 y el perfil 0999
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string ListarInformesMKTv2(string DatosParametro)
        {
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();

            DataContract.InformesMKTv2_Request request = HelperJson.Deserialize<DataContract.InformesMKTv2_Request>(DatosParametro);
            DataContract.InformesMKTv2_Response response = new DataContract.InformesMKTv2_Response();
            try
            {
                response.oE_Informes = oBL_GES_Operativa.Listar_Informes_MKT(request.idCanal, request.idReporte, request.idMarca, request.idServicio,request.anio);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.InformesMKTv2_Response>(response);
            return responseJSON;
        }

        
        #endregion

        #region Gestion Proveedores
        /// <summary>
        /// Fecha:       22/10/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Registrar Proveedores
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public string registrarProveedor(string DatosProveedor)
        {
            BL_GES_Operativa oBL_registrarProveedor = new BL_GES_Operativa();
            DatosProveedor = "{'a':" + DatosProveedor + "}";
            DataContract.registrarProveedor_Request request = HelperJson.Deserialize<DataContract.registrarProveedor_Request>(DatosProveedor);
            DataContract.registrarProveedor_Response response = new DataContract.registrarProveedor_Response();
            try
            {
                response.Descripcion = oBL_registrarProveedor.registrarProveedor(request.RegistrarProveedor);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.registrarProveedor_Response>(response);
            return responseJSON;
        }

        /// <summary>
        /// Fecha:       11/05/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Actualizar Proveedores
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public string actualizarProveedor(string DatosProveedor)
        {
            BL_GES_Operativa oBL_actualizarProveedor = new BL_GES_Operativa();
            DatosProveedor = "{'a':" + DatosProveedor + "}";
            DataContract.actualizarProveedor_Request request = HelperJson.Deserialize<DataContract.actualizarProveedor_Request>(DatosProveedor);
            DataContract.actualizarProveedor_Response response = new DataContract.actualizarProveedor_Response();
            try
            {
                response.Descripcion = oBL_actualizarProveedor.actualizarProveedor(request.ActualizarProveedor);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.actualizarProveedor_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Orden de Compras - Registrar
        /// <summary>
        /// Fecha:       22/10/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Registro de Orden de Compras
        /// </summary>
        /// <param name="DatosReportePrecio"></param>
        /// <returns></returns>
        public string Registrar_OrdenCompra(string DatosOrdenCompra)
        {
            DataContract.Registrar_OrdenCompra_Request request = HelperJson.Deserialize<DataContract.Registrar_OrdenCompra_Request>(DatosOrdenCompra);
            DataContract.Registrar_OrdenCompra_Response response = new DataContract.Registrar_OrdenCompra_Response();
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();
            try
            {
                response.Descripcion = oBL_GES_Operativa.Registrar_OrdenCompra(request.oRegistrar_OC);
                if (!response.Descripcion.Equals(""))
                {
                    response.Descripcion = "Registro con Exito";
                    response.Estado = BaseResponse.EXITO;
                }
                else
                {
                    response.Descripcion = "Ocurrio un error";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Registrar_OrdenCompra_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion Tickets - Registrar
        /// <summary>
        /// Fecha:       15/11/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Registro de Tickets
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public string Registrar_Tickets(string DatosOrdenCompra)
        {
            DataContract.Registrar_Tickets_Request request = HelperJson.Deserialize<DataContract.Registrar_Tickets_Request>(DatosOrdenCompra);
            DataContract.Registrar_Tickets_Response response = new DataContract.Registrar_Tickets_Response();
            BL_GES_Operativa oBL_GES_Operativa = new BL_GES_Operativa();
            try
            {
                response.Descripcion = oBL_GES_Operativa.Registrar_Tickets(request.oRegistrar_Tickets);
                if (!response.Descripcion.Equals(""))
                {
                    response.Descripcion = "Registro con Exito";
                    response.Estado = BaseResponse.EXITO;
                }
                else
                {
                    response.Descripcion = "Ocurrio un error";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Registrar_Tickets_Response>(response);
            return responseJSON;
        }
        #endregion
    }
}