using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Business.Common.JavaMovil;
using Lucky.Business.Common.Servicio;
using Lucky.Business.Common.Application;
using Lucky.CFG.JavaMovil;
using Lucky.Services.Contracts.ServiceContract;
using System.ServiceModel.Web;
//using System.Configuration;

namespace Lucky.Services.Contracts.ServiceImpl
{
    public class Ges_CampaniaService : IGes_CampaniaService
    {

        private readonly static Lucky.Business.Common.Servicio.BL_GES_Campania oBL_GES_Campania = new BL_GES_Campania();

        #region Gestion de Canales
        public string Listar_Canales_Por_CodCompania(string DatosRequest)
        {

            DataContract.Listar_Canales_Por_CodCompania_Request request = HelperJson.Deserialize<DataContract.Listar_Canales_Por_CodCompania_Request>(DatosRequest);
            DataContract.Listar_Canales_Por_CodCompania_Response response = new DataContract.Listar_Canales_Por_CodCompania_Response();
            try
            {
                response.oListaCanal = oBL_GES_Campania.Listar_Canales_Por_CodCompania(request.CodCompania);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Canales_Por_CodCompania_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Fecha:       11/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Método que devuelve los canales por código de cliente, código de persona y código de oficina
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        public string Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina(string DatosParametro)
        {
            DataContract.Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina_Request request = HelperJson.Deserialize<DataContract.Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina_Request>(DatosParametro);
            DataContract.Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina_Response response = new DataContract.Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina_Response();
            try
            {
                response.oListaCanal = oBL_GES_Campania.Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina(request.CodCliente, request.CodPersona, request.CodOficina);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Campanias
        public string Listar_Campania_Por_CodCanal_y_CodCompania(string DatosRequest)
        {
            DataContract.Listar_Campania_Por_CodCanal_y_CodCompania_Request request = HelperJson.Deserialize<DataContract.Listar_Campania_Por_CodCanal_y_CodCompania_Request>(DatosRequest);
            DataContract.Listar_Campania_Por_CodCanal_y_CodCompania_Response response = new DataContract.Listar_Campania_Por_CodCanal_y_CodCompania_Response();
            try
            {
                response.oListaCampania = oBL_GES_Campania.Listar_Campania_Por_CodCanal_y_CodCompania(request.CodCanal, request.CodCompania);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Campania_Por_CodCanal_y_CodCompania_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Autor:Giam Farfán
        /// Descripcion: Metodos utilizados para Módulo Planning MVC
        /// </summary>
        /// <param name="DatosRequest"></param>
        /// <returns></returns>
        public string Listar_Seguimiento_Campania(string DatosRequest)
        {

            DataContract.Listar_Seguimiento_Campaña_Request request = HelperJson.Deserialize<DataContract.Listar_Seguimiento_Campaña_Request>(DatosRequest);
            DataContract.Listar_Seguimiento_Campaña_Response response = new DataContract.Listar_Seguimiento_Campaña_Response();
            try
            {
                response.olistaSeguimiento = oBL_GES_Campania.listarSeguimientoDeCampaña(request.CodCliente, request.CodCampania);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Seguimiento_Campaña_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Autor:Giam Farfán
        /// Descripcion: Metodos utilizados para Módulo Planning MVC
        /// </summary>
        /// <param name="DatosRequest"></param>
        /// <returns></returns>
        public string Registrar_Planning(string DatosRequest)
        {
            BL_GES_Campania oBL_GES_Campania = new BL_GES_Campania();
            DataContract.registarPlanning_Request request = HelperJson.Deserialize<DataContract.registarPlanning_Request>(DatosRequest);
            DataContract.registrarPlanning_Response response = new DataContract.registrarPlanning_Response();

            try
            {
                response.Descripcion = oBL_GES_Campania.registrarPlanning(request.oE_Planning);
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
            string responseJSON = HelperJson.Serialize<DataContract.registrarPlanning_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Reportes
        public string Listar_Reporte_Por_CodCampania(string DatosRequest)
        {
            DataContract.Listar_Reporte_Por_CodCampania_Request request = HelperJson.Deserialize<DataContract.Listar_Reporte_Por_CodCampania_Request>(DatosRequest);
            DataContract.Listar_Reporte_Por_CodCampania_Response response = new DataContract.Listar_Reporte_Por_CodCampania_Response();
            try
            {
                response.oListaReporte = oBL_GES_Campania.Listar_Reporte_Por_CodCampania(request.CodCampania);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Reporte_Por_CodCampania_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       11/09/2012
        /// Descripción: Método que devuelve los ubreportes por código de reporte, código de campaña y código de canal
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Sub_Reportes(string DatosParametro)
        {
            DataContract.Listar_Sub_Reporte_Request request = HelperJson.Deserialize<DataContract.Listar_Sub_Reporte_Request>(DatosParametro);
            DataContract.Listar_Sub_Reporte_Response response = new DataContract.Listar_Sub_Reporte_Response();
            try
            {
                response.oListaSubReporte = oBL_GES_Campania.ListarSubReportes(request.CodReporte, request.CodCompania, request.CodChanel);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Sub_Reporte_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Productos

        #region Gestion de Categorias
        public string Listar_Categoria_Por_CodCampania_y_CodReporte(string DatosRequest)
        {
            DataContract.Listar_Categoria_Por_CodCampania_y_CodReporte_Request request = HelperJson.Deserialize<DataContract.Listar_Categoria_Por_CodCampania_y_CodReporte_Request>(DatosRequest);
            DataContract.Listar_Categoria_Por_CodCampania_y_CodReporte_Response response = new DataContract.Listar_Categoria_Por_CodCampania_y_CodReporte_Response();
            try
            {
                response.oListaCategoria = oBL_GES_Campania.Listar_Categoria_Por_CodCampania_y_CodReporte(request.CodCampania, request.CodReporte);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Categoria_Por_CodCampania_y_CodReporte_Response>(response);
            return responseJSON;
        }

        public string Listar_Categoria_Por_CodCampania(string DatosRequest)
        {
            DataContract.Listar_Categoria_Por_CodCampania_Request request = HelperJson.Deserialize<DataContract.Listar_Categoria_Por_CodCampania_Request>(DatosRequest);
            DataContract.Listar_Categoria_Por_CodCampania_Response response = new DataContract.Listar_Categoria_Por_CodCampania_Response();
            try
            {
                response.oListaCategoria = oBL_GES_Campania.Listar_Categoria_Por_CodCampania(request.CodCampania);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Categoria_Por_CodCampania_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 11/05/2012
        /// Descripción: Método que devuelve las categorías por código de canal y código de reporte
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte(string DatosParametro)
        {
            DataContract.Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte_Request request = HelperJson.Deserialize<DataContract.Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte_Request>(DatosParametro);
            DataContract.Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte_Response response = new DataContract.Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte_Response();
            try
            {
                response.oListaCategoria = oBL_GES_Campania.Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte(request.CodCliente, request.CodCanal, request.CodReporte);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de SubCategorias
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve las SubCategorias por código de categoria
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        public string ListarSubCategoria_Por_CodCategoria(string DatosParametro)
        {
            DataContract.ListarSubCategoria_Por_CodCategoria_Request request = HelperJson.Deserialize<DataContract.ListarSubCategoria_Por_CodCategoria_Request>(DatosParametro);
            DataContract.ListarSubCategoria_Por_CodCategoria_Response response = new DataContract.ListarSubCategoria_Por_CodCategoria_Response();
            try
            {
                response.oListaSubCategoria = oBL_GES_Campania.ListarSubCategoria_Por_CodCategoria(request.CodCategoria);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ListarSubCategoria_Por_CodCategoria_Response>(response);
            return responseJSON;
        }
        #endregion 

        #region Gestion de Marcas
        public string Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria(string DatosRequest)
        {
            DataContract.Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria_Request request = HelperJson.Deserialize<DataContract.Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria_Request>(DatosRequest);
            DataContract.Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria_Response response = new DataContract.Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria_Response();

            try
            {
                response.oListaMarca = oBL_GES_Campania.Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria(request.CodCampania, request.CodReporte, request.CodCategoria);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria_Response>(response);
            return responseJSON;
        }
        ///////////////////////////////////////////
        public string Listar_Marca_Por_CodCategoria(string DatosRequest)
        {
            DataContract.Listar_Marca_Por_CodCategoria_Request request = HelperJson.Deserialize<DataContract.Listar_Marca_Por_CodCategoria_Request>(DatosRequest);
            DataContract.Listar_Marca_Por_CodCategoria_Response response = new DataContract.Listar_Marca_Por_CodCategoria_Response();

            try
            {
                response.oListaMarca = oBL_GES_Campania.Listar_Marca_Por_CodCategoria(request.CodCategoria);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Marca_Por_CodCategoria_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Productos
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve los Productos por código de campaña, código de categoría, código de subcategoría y código de marca
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca(string DatosParametro)
        {
            DataContract.Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca_Request request = HelperJson.Deserialize<DataContract.Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca_Request>(DatosParametro);
            DataContract.Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca_Response response = new DataContract.Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca_Response();
            try
            {
                response.oListaProducto = oBL_GES_Campania.ListarProducto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca(request.CodCampania, request.CodCategoria, request.CodSubCategoria, request.CodMarca);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       09/08/2012
        /// Descripción: Método que devuelve los Productos por código de campaña, código de categoría, código de subcategoría y código de marca
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca(string DatosParametro)
        {
            DataContract.Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca_Request request = HelperJson.Deserialize<DataContract.Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca_Request>(DatosParametro);
            DataContract.Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca_Response response = new DataContract.Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca_Response();
            try
            {
                response.oListaProducto = oBL_GES_Campania.ListarProducto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca(request.CodCampania, request.CodCliente, request.CodCategoria, request.CodSubCategoria, request.CodMarca);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca_Response>(response);
            return responseJSON;
        }
        #endregion

        #endregion

        #region Gestion de Personal

        #region SubGestion Supervisores
        public string Listar_Supervisor_Por_CodCampania(string DatosRequest)
        {
            DataContract.Listar_Supervisor_Por_CodCampania_Request request = 
                HelperJson.Deserialize<DataContract.Listar_Supervisor_Por_CodCampania_Request>(DatosRequest);
            DataContract.Listar_Supervisor_Por_CodCampania_Response response = 
                new DataContract.Listar_Supervisor_Por_CodCampania_Response();
            try
            {
                response.oListaSupervisor = 
                    oBL_GES_Campania.Listar_Supervisor_Por_CodCampania(request.CodCampania);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = 
                HelperJson.Serialize<DataContract.Listar_Supervisor_Por_CodCampania_Response>(response);
            return responseJSON;
        }
        #endregion

        #region SubGestion Generadores
        public string Listar_Generadores_Por_CodCampania_Por_CodSupervisor(string DatosRequest)
        {
            DataContract.Listar_Generadores_Por_CodSupervisor_Request request = HelperJson.Deserialize<DataContract.Listar_Generadores_Por_CodSupervisor_Request>(DatosRequest);
            DataContract.Listar_Generadores_Por_CodSupervisor_Response response = new DataContract.Listar_Generadores_Por_CodSupervisor_Response();
            try
            {
                response.oListaGenerador = oBL_GES_Campania.Listar_Generadores_Por_CodCampania_CodSupervisor(request.CodCompania, request.CodSupervisor);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Generadores_Por_CodSupervisor_Response>(response);
            return responseJSON;
        }


        #endregion

        #region SubGestion Generadores
        public string Listar_Generadores_Por_CodCampania_FechaRelevo(string DatosRequest)
        {
            DataContract.Listar_Generadores_Por_CodCampania_FechaRelevo_Request request = HelperJson.Deserialize<DataContract.Listar_Generadores_Por_CodCampania_FechaRelevo_Request>(DatosRequest);
            DataContract.Listar_Generadores_Por_CodCampania_FechaRelevo_Response response = new DataContract.Listar_Generadores_Por_CodCampania_FechaRelevo_Response();
            try
            {
                response.oListaGenerador = oBL_GES_Campania.Listar_Generadores_Por_CodCampania_FechaRelevo(request.CodCompania, request.FechaRelevo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Generadores_Por_CodCampania_FechaRelevo_Response>(response);
            return responseJSON;
        }
        public string Listar_Generadores_Por_CodCanal_Y_CodCliente(string DatosRequest)
        {
            DataContract.Person_Request request = HelperJson.Deserialize<DataContract.Person_Request>(DatosRequest);
            DataContract.Person_Response response = new DataContract.Person_Response();
            try
            {
                response.oListaGenerador = oBL_GES_Campania.Listar_Generadores_Por_CodCanal_Y_CodCliente(request.CodServicio,request.CodCliente,request.CodCanal,request.año,request.mes,request.CodPeriodo,request.CodCiudad,request.CodZona);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Person_Response>(response);
            return responseJSON;
        }

        #endregion

        #region Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel
        public string Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel(string DatosRequest)
        {
            DataContract.Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel_Request request = HelperJson.Deserialize<DataContract.Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel_Request>(DatosRequest);
            DataContract.Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel_Response response = new DataContract.Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel_Response();
            try
            {
                response.oListaGenerador = oBL_GES_Campania.Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel(request.CodCompania, request.CodDpto, request.CodProvincia, request.CodDistrito, request.Fecha_Relevo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel_Response>(response);
            return responseJSON;
        }


        #endregion

        #endregion

        #region Gestion de Budget
        /// <summary>
        /// Autor: Pablo Salas A.
        /// Fecha: 18/07/2012
        /// Descripción: Devuelve los Budget por CodCompania y CodOpcion
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        public string Listar_Budget_Por_CodCompania_CodOpcion(string DatosParametros)
        {
            DataContract.Listar_Budget_Por_CodCompania_CodOpcion_Request request = HelperJson.Deserialize<DataContract.Listar_Budget_Por_CodCompania_CodOpcion_Request>(DatosParametros);
            DataContract.Listar_Budget_Por_CodCompania_CodOpcion_Response response = new DataContract.Listar_Budget_Por_CodCompania_CodOpcion_Response();
            try
            {
                response.oListE_Budget = oBL_GES_Campania.Listar_Budget_Por_CodCompania_CodOpcion(request.Cod_Compania, request.Cod_Opcion);
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "Descarga de Presupuestos con exito!";
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;



                //Exception mensaje = ex;
                //Lucky.CFG.Exceptions.Exceptions mesjerror = new Lucky.CFG.Exceptions.Exceptions(ex);
                //mesjerror.errorWebsite(ConfigurationManager.AppSettings["COUNTRY"]);

            }
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Budget_Por_CodCompania_CodOpcion_Response>(response);
            return responseJSON;

        }

        /// <summary>
        /// Autor: Pablo Salas A.
        /// Fecha: 19/07/2012
        /// Descripción: Devuelve los Budget por CodCompania , CodBudget,  CodOpcion
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        public string Listar_Budget_Por_CodCompania_CodBudget_CodOpcion(string DatosParametros)
        {

            DataContract.Listar_Budget_Por_CodCompania_CodBudget_CodOpcion_Request request = HelperJson.Deserialize<DataContract.Listar_Budget_Por_CodCompania_CodBudget_CodOpcion_Request>(DatosParametros);
            DataContract.Listar_Budget_Por_CodCompania_CodBudget_CodOpcion_Response response = new DataContract.Listar_Budget_Por_CodCompania_CodBudget_CodOpcion_Response();
            try
            {
                response.oListE_Budget = oBL_GES_Campania.Listar_Budget_Por_CodCompania_CodBudget_CodOpcion(request.Cod_Compania, request.Cod_Budget, request.Cod_Opcion);
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "Descarga de Presupuestos con exito!";
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Budget_Por_CodCompania_CodBudget_CodOpcion_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Ubigeo

        #region Gestion de Ciudades
        public string Listar_Ciudad_Por_CodCampania(string DatosParametro)
            {
                DataContract.Listar_Ciudad_Por_CodCampania_Request request = HelperJson.Deserialize<DataContract.Listar_Ciudad_Por_CodCampania_Request>(DatosParametro);
                DataContract.Listar_Ciudad_Por_CodCampania_Response response = new DataContract.Listar_Ciudad_Por_CodCampania_Response();
                try
                {
                    response.ListaCiudad = oBL_GES_Campania.Listar_Ciudad_Por_CodCampania(request.CodCampania);
                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Error Inesperado";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.Listar_Ciudad_Por_CodCampania_Response>(response);
                return responseJSON;
            }
            /// <summary>
            /// Author:Pablo Salas Alvarez
            /// Fecha:02/08/2012
            /// Descripcion: Obtener las Provincias por CodDepartamento 
            /// </summary>
            /// http://localhost:58700/Ges_CampaniaService.svc/Listar_Ciudad_Por_CodDepartamento
            /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{a : "15"}</string>
            /// <param name="CodDepartamento"></param>
            /// <returns></returns>
            public string Listar_Ciudad_Por_CodDepartamento(string DatosParametros)
            {
                DataContract.Listar_Ciudad_Por_CodDepartamento_Request request = HelperJson.Deserialize<DataContract.Listar_Ciudad_Por_CodDepartamento_Request>(DatosParametros);
                DataContract.Listar_Ciudad_Por_CodDepartamento_Response response = new DataContract.Listar_Ciudad_Por_CodDepartamento_Response();
                try
                {
                    response.oListE_Ciudad = oBL_GES_Campania.Listar_Ciudad_Por_CodDepartamento(request.Cod_Departamento);
                    response.Descripcion = "Descarga con Exito";
                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Error Inesperado";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }
                string responseJSON = HelperJson.Serialize<DataContract.Listar_Ciudad_Por_CodDepartamento_Response>(response);
                return responseJSON;
            }
            /// <summary>
            /// Author:Pablo Salas Alvarez
            /// Fecha:03/08/2012
            /// Descripcion: Obtener Las  Provincias por CodCampania y  CodDepartamento.
            /// </summary>
            /// <param name="CodCampania"></param>
            /// <param name="CodDepartamento"></param>
            /// <param name="CodProvincia"></param>
            /// <param name="CodNodeCommercial"></param>
            /// http://localhost:58700/Ges_CampaniaService.svc/Listar_Ciudad_Por_CodCampania_CodDepartamento
            /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{a : "813622482010",b:"15"}</string>
            /// <returns></returns>
            public string Listar_Ciudad_Por_CodCampania_CodDepartamento(string DatosParametro)
            {
                DataContract.Listar_Ciudad_Por_CodCampania_CodDepartamento_Request request = HelperJson.Deserialize<DataContract.Listar_Ciudad_Por_CodCampania_CodDepartamento_Request>(DatosParametro);
                DataContract.Listar_Ciudad_Por_CodCampania_CodDepartamento_Response response = new DataContract.Listar_Ciudad_Por_CodCampania_CodDepartamento_Response();
                try
                {
                    response.oListE_Ciudad = oBL_GES_Campania.Listar_Ciudad_Por_CodCampania_CodDepartamento(request.Cod_Campania, request.Cod_Departamento);
                    response.Descripcion = "Descarga con Éxito";
                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Error Inesperado";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }
                string responseJSON = HelperJson.Serialize<DataContract.Listar_Ciudad_Por_CodCampania_CodDepartamento_Response>(response);
                return responseJSON;
            }
            #endregion

        #region Gestion Departamento
            /// <summary>
            /// Author:Pablo Salas Alvarez
            /// Fecha:02/08/2012
            /// Descripcion: Obtener los Departamentos por CodCampaña
            /// </summary>
            /// <param name="CodCampania"></param>
            /// http://localhost:58700/Ges_CampaniaService.svc/Listar_Departamento_Por_CodCampania
            /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{a : "813622482010"}</string>
            /// <returns></returns>
            public string Listar_Departamento_Por_CodCampania(string DatosParametros)
            {
                DataContract.Listar_Departamento_Por_CodCampania_Request request = HelperJson.Deserialize<DataContract.Listar_Departamento_Por_CodCampania_Request>(DatosParametros);
                DataContract.Listar_Departamento_Por_CodCampania_Response response = new DataContract.Listar_Departamento_Por_CodCampania_Response();
                try
                {
                    response.oListE_Departamento = oBL_GES_Campania.Listar_Departamento_Por_CodCampania(request.Cod_Compania);
                    response.Descripcion = "";
                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Error Inesperado";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }
                string responseJSON = HelperJson.Serialize<DataContract.Listar_Departamento_Por_CodCampania_Response>(response);
                return responseJSON;
            }
            /// <summary>
            /// Autor:Giam Farfán
            /// Descripcion: Metodos utilizados para Módulo Planning MVC
            /// </summary>
            /// <param name="DatosRequest"></param>
            /// <returns></returns>
            public string listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina(string DatosRequest)
            {

                DataContract.listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina_Request request = HelperJson.Deserialize<DataContract.listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina_Request>(DatosRequest);
                DataContract.listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina_Response response = new DataContract.listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina_Response();
                try
                {
                    response.listaDepartamentos = oBL_GES_Campania.listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina(request.CodCliente, request.CodCampania, request.codPais,request.codOficina);
                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Error inesperado";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina_Response>(response);
                return responseJSON;
            }
            #endregion

        #region Gestion de Provincias
            /// <summary>
            /// Autor:Giam Farfán
            /// Descripcion: Metodos utilizados para Módulo Planning MVC
            /// </summary>
            /// <param name="DatosRequest"></param>
            /// <returns></returns>
            public string listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento(string DatosRequest)
            {

                DataContract.listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento_Request request = HelperJson.Deserialize<DataContract.listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento_Request>(DatosRequest);
                DataContract.listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento_Response response = new DataContract.listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento_Response();
                try
                {
                    response.listaProvincias = oBL_GES_Campania.listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento(request.CodCampania, request.codPais,request.codOficina ,request.codDepartamento);
                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Error inesperado";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento_Response>(response);
                return responseJSON;
            }
            #endregion

        #region Gestion de Distritos
            /// <summary>
            /// Autor:Giam Farfán
            /// Descripcion: Metodos utilizados para Módulo Planning MVC
            /// </summary>
            /// <param name="DatosRequest"></param>
            /// <returns></returns>
            public string listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia(string DatosRequest)
            {

                DataContract.listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia_Request request = HelperJson.Deserialize<DataContract.listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia_Request>(DatosRequest);
                DataContract.listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia_Response response = new DataContract.listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia_Response();
                try
                {
                    response.listaDistritos = oBL_GES_Campania.listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia(request.CodCampania, request.codPais, request.codOficina,request.codDepartamento, request.codProvincia);
                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Error inesperado";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia_Response>(response);
                return responseJSON;
            }
            #endregion

        #region Gestion de Region
            /// <summary>
            /// Autor:Giam Farfán
            /// Descripcion: Metodos utilizados para Módulo Planning MVC
            /// </summary>
            /// <param name="DatosRequest"></param>
            /// <returns></returns>
            public string listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia(string DatosRequest)
            {
                DataContract.listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia_Request request = HelperJson.Deserialize<DataContract.listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia_Request>(DatosRequest);
                DataContract.listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia_Response response = new DataContract.listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia_Response();
                try
                {
                    response.listarRegion = oBL_GES_Campania.listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia(request.codCampania,request.codOficina,request.codDepartamento,request.codProvincia);
                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Error inesperado";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia_Response>(response);
                return responseJSON;
            }
            #endregion

        #region Gestion de Sector
            /// <summary>
            /// Autor:Giam Farfán
            /// Descripcion: Metodos utilizados para Módulo Planning MVC
            /// </summary>
            /// <param name="DatosRequest"></param>
            /// <returns></returns>
            public string listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia(string DatosRequest)
            {
                DataContract.listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia_Request request = HelperJson.Deserialize<DataContract.listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia_Request>(DatosRequest);
                DataContract.listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia_Response response = new DataContract.listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia_Response();
                try
                {
                    response.listarSector = oBL_GES_Campania.listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia(request.codCampania, request.codRegion,request.codOficina,request.codDepartamento,request.codProvincia);
                    response.Estado = BaseResponse.EXITO;
                }
                catch (Exception)
                {
                    response.Descripcion = "Error inesperado";
                    response.Estado = BaseResponse.GENERAL_ERROR;
                }

                //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                string responseJSON = HelperJson.Serialize<DataContract.listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia_Response>(response);
                return responseJSON;
            }
            #endregion

        #endregion

        #region Gestion de Puntos de Venta
            #region Gestion de Oficinas
                public string Listar_Oficinas_Por_CodCampania(string DatosRequest)
                {
                    DataContract.Listar_Oficinas_Por_CodCampania_Request request = HelperJson.Deserialize<DataContract.Listar_Oficinas_Por_CodCampania_Request>(DatosRequest);
                    DataContract.Listar_Oficinas_Por_CodCampania_Response response = new DataContract.Listar_Oficinas_Por_CodCampania_Response();
                    try
                    {
                        response.oListaOficina = oBL_GES_Campania.Listar_Oficinas_Por_CodCampania(request.CodCampania);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_Oficinas_Por_CodCampania_Response>(response);
                    return responseJSON;
                }
                public string Listar_Oficinas_Por_CodCampania_CodSupervisor(string DatosRequest)
                {
                    DataContract.Listar_Oficinas_Por_CodCampania_CodSupervisor_Request request = HelperJson.Deserialize<DataContract.Listar_Oficinas_Por_CodCampania_CodSupervisor_Request>(DatosRequest);
                    DataContract.Listar_Oficinas_Por_CodCampania_CodSupervisor_Response response = new DataContract.Listar_Oficinas_Por_CodCampania_CodSupervisor_Response();
                    try
                    {
                        response.oListaOficina = oBL_GES_Campania.Listar_Oficinas_Por_CodCampania_Por_CodSupervisor(request.CodCampania, request.CodSupervisor);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_Oficinas_Por_CodCampania_CodSupervisor_Response>(response);
                    return responseJSON;
                }
                /// <summary>
                /// Version :1.0
                /// Fecha   :31/08/2012
                /// Author  :Pablo Salas A.
                /// Descripcion:Obtener las Oficinas Por CodCompania
                /// </summary>
                /// http://localhost:58700/Ges_CampaniaService.svc/Listar_Oficinas_Por_CodCompania
                /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"1562"}</string>
                /// <param name="DatosRequest"></param>
                /// <returns></returns>
                public string Listar_Oficinas_Por_CodCompania(string DatosRequest)
                {
                    DataContract.Listar_Oficinas_Por_CodCompania_Request request = HelperJson.Deserialize<DataContract.Listar_Oficinas_Por_CodCompania_Request>(DatosRequest);
                    DataContract.Listar_Oficinas_Por_CodCompania_Response response = new DataContract.Listar_Oficinas_Por_CodCompania_Response();
                    try
                    {
                        response.oListaE_Oficina = oBL_GES_Campania.Listar_Oficinas_Por_CodCompania(request.CodCompania);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_Oficinas_Por_CodCompania_Response>(response);
                    return responseJSON;
                }
                /// <summary>
                /// Fecha:       11/05/2012
                /// Creado:      Joseph Gonzales
                /// Descripción: Lista las oficinas por persona.
                /// </summary>
                /// <param name="DatosLista"></param>
                /// <returns></returns>
                public string Listar_Oficinas_Por_CodPersona(string DatosParametro)
                {
                    DataContract.Listar_Oficinas_Por_CodPersona_Request request = HelperJson.Deserialize<DataContract.Listar_Oficinas_Por_CodPersona_Request>(DatosParametro);
                    DataContract.Listar_Oficinas_Por_CodPersona_Response response = new DataContract.Listar_Oficinas_Por_CodPersona_Response();
                    try
                    {
                        response.oListaOficina = oBL_GES_Campania.Listar_Oficinas_Por_CodPersona(request.CodPersona);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_Oficinas_Por_CodPersona_Response>(response);
                    return responseJSON;
                }
                /// <summary>
                /// Autor: Giam Farfan
                /// Fecha:27/09/2012
                /// Descripcion:Obtener oficinas por codPais,codCliente,codCampania
                /// </summary>
                /// <param name="DatosParametro"></param>
                /// <returns></returns>
                public string Listar_Oficinas_Por_CodPais_CodCliente_CodCampania(string DatosParametro)
                {
                    DataContract.Listar_Oficinas_Por_CodPais_CodCliente_CodCampania_Request request = HelperJson.Deserialize<DataContract.Listar_Oficinas_Por_CodPais_CodCliente_CodCampania_Request>(DatosParametro);
                    DataContract.Listar_Oficinas_Por_CodPais_CodCliente_CodCampania_Response response = new DataContract.Listar_Oficinas_Por_CodPais_CodCliente_CodCampania_Response();
                    try
                    {
                        response.olistaOficinas = oBL_GES_Campania.Listar_Oficinas_Por_CodPais_CodCliente_CodCampania(request.codPais,request.codCliente,request.codCampania);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_Oficinas_Por_CodPais_CodCliente_CodCampania_Response>(response);
                    return responseJSON;
                }
            #endregion

            #region Gestion de PtoVenta
                public string Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina(string DatosRequest)
                {
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina_Request request = HelperJson.Deserialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina_Request>(DatosRequest);
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina_Response response = new DataContract.Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina_Response();
                    try
                    {
                        response.oListaPDV = oBL_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina(request.CodCampania, request.CodOficina);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina_Response>(response);
                    return responseJSON;
                }
                public string Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador(string DatosRequest)
                {
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador_Request request = HelperJson.Deserialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador_Request>(DatosRequest);
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador_Response response = new DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador_Response();
                    try
                    {
                        response.oListaPDV = oBL_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador(request.CodCampania, request.CodOficina, request.CodGenerador);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador_Response>(response);
                    return responseJSON;
                }

                public string Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha(string DatosRequest)
                {
                    DataContract.Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha_Request request = HelperJson.Deserialize<DataContract.Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha_Request>(DatosRequest);
                    DataContract.Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha_Response response = new DataContract.Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha_Response();
                    try
                    {
                        response.oListaPDV = oBL_GES_Campania.Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha(request.CodCampania, request.CodDpto, request.CodProv,request.CodDist,request.CodGenerador,request.FechaRelevo);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha_Response>(response);
                    return responseJSON;
                }
                /// <summary>
                /// Autor:       Joseph Gonzales
                /// Fecha:       14/05/2012
                /// Descripción: Método que devuelve los puntos de venta por código de campaña código de oficina y código de cadena
                /// </summary>
                /// <param name="DatosLista"></param>
                /// <returns></returns>
                public string Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena(string DatosParametro)
                {
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena_Request request = HelperJson.Deserialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena_Request>(DatosParametro);
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena_Response response = new DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena_Response();
                    try
                    {
                        response.oListaPDV = oBL_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena(request.CodCampania, request.CodOficina, request.CodCadena);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena_Response>(response);
                    return responseJSON;
                }
                public string Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena(string DatosParametro)
                {
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena_Request request = HelperJson.Deserialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena_Request>(DatosParametro);
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena_Response response = new DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena_Response();
                    try
                    {
                        response.oListaPDV = oBL_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena(request.CodCampania, request.CodCiudad, request.CodCadena);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena_Response>(response);
                    return responseJSON;
                }
                /// <summary>
                /// Author:Pablo Salas Alvarez
                /// Fecha:02/08/2012
                /// Descripcion: Obtener Los Puntos de Venta por CodCampania_CodDepartamento_CodProvincia_Cod_NodeCommercial 
                /// </summary>
                /// http://localhost:58700/Ges_CampaniaService.svc/Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial
                /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{a : "0134226102010",b:"15",c:"01",d:"8010" }</string>
                /// <param name="CodCampania"></param>
                /// <param name="CodDepartamento"></param>
                /// <param name="CodProvincia"></param>
                /// <param name="CodNodeCommercial"></param>
                /// <returns></returns>
                public string Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial(string DatosParametros)
                {
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial_Request request = HelperJson.Deserialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial_Request>(DatosParametros);
                    DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial_Response response = new DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial_Response();
                    try
                    {
                        response.oListE_PuntoDeVenta = oBL_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial(request.Cod_Campania, request.Cod_Departamento, request.Cod_Provincia, request.Cod_NodoCommercial);
                        response.Descripcion = "Descarga con Éxito";
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial_Response>(response);
                    return responseJSON;
                }
                public string listarPuntodeVentaPlanning(string DatosParametros)
                {
                    DataContract.listarPuntodeVentaPlanning_Request request = HelperJson.Deserialize<DataContract.listarPuntodeVentaPlanning_Request>(DatosParametros);
                    DataContract.listarPuntodeVentaPlanning_Response response = new DataContract.listarPuntodeVentaPlanning_Response();
                    try
                    {
                        response.listarPuntodeVentaPlanning = oBL_GES_Campania.listarPuntosdeVentaPlanning(request.codOficina,request.codDpto, request.codProvincia, request.codDistrito, request.codtipoagrupacion,request.codagrupacion,request.codregion,request.codzona);
                        response.Descripcion = "Descarga con Éxito";
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }
                    string responseJSON = HelperJson.Serialize<DataContract.listarPuntodeVentaPlanning_Response>(response);
                    return responseJSON;
        
                }
                /// <summary>
                /// Author  : Pablo Salas A.
                /// Fecha   : 26/09/2012
                /// Descripcion:
                /// </summary>
                /// <param name="DatosParametro"></param>
                /// <returns></returns>
                public string Listar_PuntoDeVenta_Por_CodCompania(string DatosParametro)
                {
                    DataContract.Listar_PuntoDeVenta_Por_CodCompania_Request request = HelperJson.Deserialize<DataContract.Listar_PuntoDeVenta_Por_CodCompania_Request>(DatosParametro);
                    DataContract.Listar_PuntoDeVenta_Por_CodCompania_Response response = new DataContract.Listar_PuntoDeVenta_Por_CodCompania_Response();
                    try {
                        response.oListE_PuntoDeVenta = oBL_GES_Campania.Listar_PuntosDeVenta_Por_CodCompania(request.Cod_Campania);
                        response.Descripcion = "Descarga con Éxito";
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception ex) {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_PuntoDeVenta_Por_CodCompania_Response>(response);
                    return responseJSON;
                }
            #endregion

            #region Gestion de Nodos Commerciales
                /// <summary>
                /// Autor:       Joseph Gonzales
                /// Fecha:       14/05/2012
                /// Descripción: Método que devuelve las cadena por código de campaña y código de oficina
                /// </summary>
                /// <param name="DatosLista"></param>
                /// <returns></returns>
                public string Listar_Cadena_Por_CodCampania_y_CodOficina(string DatosParametro)
                {
                    DataContract.Listar_Cadena_Por_CodCampania_y_CodOficina_Request request = HelperJson.Deserialize<DataContract.Listar_Cadena_Por_CodCampania_y_CodOficina_Request>(DatosParametro);
                    DataContract.Listar_Cadena_Por_CodCampania_y_CodOficina_Response response = new DataContract.Listar_Cadena_Por_CodCampania_y_CodOficina_Response();
                    try
                    {
                        response.oListaCadena = oBL_GES_Campania.Listar_Cadena_Por_CodCampania_y_CodOficina(request.CodCampania, request.CodOficina);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_Cadena_Por_CodCampania_y_CodOficina_Response>(response);
                    return responseJSON;
                }

                /// <summary>
                /// Autor:       Joseph Gonzales
                /// Fecha:       25/10/2012
                /// Descripción: Método que devuelve los nodos comerciales(cadena) por cliente y por canal
                /// </summary>
                /// <param name="DatosLista"></param>
                /// <returns></returns>
                public string Listar_Cadena_Por_CodCliente_y_CodCanal(string DatosParametro)
                {
                    DataContract.Listar_Cadena_Por_CodCliente_y_CodCanal_Request request = HelperJson.Deserialize<DataContract.Listar_Cadena_Por_CodCliente_y_CodCanal_Request>(DatosParametro);
                    DataContract.Listar_Cadena_Por_CodCliente_y_CodCanal_Response response = new DataContract.Listar_Cadena_Por_CodCliente_y_CodCanal_Response();
                    try
                    {
                        response.oListaCadena = oBL_GES_Campania.Listar_Cadena_Por_CodCliente_y_CodCanal(request.CodCliente, request.CodCanal);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_Cadena_Por_CodCliente_y_CodCanal_Response>(response);
                    return responseJSON;
                }

                /// <summary>
                /// Autor: Carlos Marin
                /// Fecha: 06/06/2012
                /// Descripción: Método que devuelve las cadenas por código de campaña y codigo de la oficina
                /// </summary>
                /// <param name="CodCampania"></param>
                /// <param name="CodOficina"></param>
                /// <returns></returns>
                public string Listar_NodeComercial_Por_CodCampania_CodCiudad(string DatosParametro)
                {
                    DataContract.Listar_NodeComercial_Por_CodCampania_CodCiudad_Request request = HelperJson.Deserialize<DataContract.Listar_NodeComercial_Por_CodCampania_CodCiudad_Request>(DatosParametro);
                    DataContract.Listar_NodeComercial_Por_CodCampania_CodCiudad_Response response = new DataContract.Listar_NodeComercial_Por_CodCampania_CodCiudad_Response();
                    try
                    {
                        response.oListaNodeComercial = oBL_GES_Campania.Listar_NodeComercial_Por_CodCampania_CodCiudad(request.id_NodeCommercial, request.commercialNodeName);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_NodeComercial_Por_CodCampania_CodCiudad_Response>(response);
                    return responseJSON;
                }
                /// <summary>
                /// Author:Pablo Salas Alvarez
                /// Fecha:02/08/2012
                /// Descripcion: Obtener NodosCommerciales por codCampania_CodDepartamento y Cod_Provincia
                /// http://localhost:58700/Ges_CampaniaService.svc/Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia
                /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{a : "0134226102010", b:"15", c:"01"}</string>
                /// </summary>
                /// <param name="CodCampania"></param>
                /// <param name="CodDepartamento"></param>
                /// <param name="CodProvincia"></param>
                /// <returns></returns>
                public string Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia(string DatosParametros)
                {
                    DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Request request = HelperJson.Deserialize<DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Request>(DatosParametros);
                    DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Response response = new DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Response();
                    try
                    {
                        response.oListE_NodeComercial = oBL_GES_Campania.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia(request.Cod_Campania, request.Cod_Departamento, request.Cod_Provincia);
                        response.Descripcion = "Descarga con Exito";
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Response>(response);
                    return responseJSON;
                }

                /// <summary>
                /// Author:Pablo Salas Alvarez
                /// Fecha:02/08/2012
                /// Descripcion: Obtener NodosCommerciales por codCampania_CodDepartamento y Cod_Provincia Cod_Distrito
                /// </summary>
                /// <param name="CodCampania"></param>
                /// <param name="CodDepartamento"></param>
                /// <param name="CodProvincia"></param>
                /// <returns></returns>
                public string Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito(string DatosParametros)
                {
                    DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito_Request request = HelperJson.Deserialize<DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito_Request>(DatosParametros);
                    DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito_Response response = new DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito_Response();
                    try
                    {
                        response.oListE_NodeComercial = oBL_GES_Campania.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito(request.Cod_Campania, request.Cod_Departamento, request.Cod_Provincia, request.Cod_Distrito);
                        response.Descripcion = "Descarga con Exito";
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error Inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }
                    string responseJSON = HelperJson.Serialize<DataContract.Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito_Response>(response);
                    return responseJSON;
                }
                /// <summary>
                /// Autor:Giam Farfán
                /// Descripcion: Metodos utilizados para Módulo Planning MVC
                /// </summary>
                /// <param name="DatosRequest"></param>
                /// <returns></returns>
                public string listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia(string DatosRequest)
                {
                    DataContract.listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia_Request request = HelperJson.Deserialize<DataContract.listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia_Request>(DatosRequest);
                    DataContract.listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia_Response response = new DataContract.listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia_Response();
                    try
                    {
                        response.listarNodeComercial_Type = oBL_GES_Campania.listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia(request.codCampania,request.codOficina,request.codDepartamento,request.codProvincia);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia_Response>(response);
                    return responseJSON;
                }
                /// <summary>
                /// Autor:Giam Farfán
                /// Descripcion: Metodos utilizados para Módulo Planning MVC
                /// </summary>
                /// <param name="DatosRequest"></param>
                /// <returns></returns>
                public string listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia(string DatosRequest)
                {
                    DataContract.listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia_Request request = HelperJson.Deserialize<DataContract.listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia_Request>(DatosRequest);
                    DataContract.listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia_Response response = new DataContract.listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia_Response();
                    try
                    {
                        response.listarNodeComercial = oBL_GES_Campania.listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia(request.codCampania, request.idNodeComercial_Type,request.codOficina,request.codDepartamento,request.codProvincia);
                        response.Estado = BaseResponse.EXITO;
                    }
                    catch (Exception)
                    {
                        response.Descripcion = "Error inesperado";
                        response.Estado = BaseResponse.GENERAL_ERROR;
                    }

                    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
                    string responseJSON = HelperJson.Serialize<DataContract.listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia_Response>(response);
                    return responseJSON;
                }
            #endregion
        #endregion

        #region Gestion de Años
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve los años
        /// </summary>
        /// <returns></returns>
        public string Listar_Anios()
        {
            DataContract.Listar_Anios_Response response = new DataContract.Listar_Anios_Response();
            try
            {
                response.oListaAnios = oBL_GES_Campania.Listar_Anios();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Anios_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Meses
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve los meses
        /// </summary>
        /// <returns></returns>
        public string Listar_Meses()
        {
            DataContract.Listar_Meses_Response response = new DataContract.Listar_Meses_Response();
            try
            {
                response.oListaMes = oBL_GES_Campania.Listar_Meses();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Meses_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Periodos
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 11/05/2012
        /// Descripción: Método que devuelve los periodos por código de canal, código de reporte, año y mes
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes(string DatosParametro)
        {
            DataContract.Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes_Request request = HelperJson.Deserialize<DataContract.Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes_Request>(DatosParametro);
            DataContract.Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes_Response response = new DataContract.Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes_Response();
            try
            {
                response.oListaPeriodo = oBL_GES_Campania.Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes(request.CodServicio, request.CodCanal, request.CodCliente, request.CodReporte, request.Anio, request.Mes);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes_Response>(response);
            return responseJSON;
        }

        #endregion

        #region Gestion de Dias

        /// <summary>
        /// Author  : Pablo Salas A.
        /// Fecha   : 24/09/2012
        /// Descripcion : Listar Dias
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo(string DatosParametro) {
            
            BL_ReportsPlanning oBL_ReportsPlanning = new BL_ReportsPlanning();
            DataContract.Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo_Request request = HelperJson.Deserialize<DataContract.Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo_Request>(DatosParametro);
            DataContract.Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo_Response response = new DataContract.Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo_Response();
            
            try {
                response.oListDias= oBL_ReportsPlanning.Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo(request.oE_Filtros);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo_Response>(response);
            return responseJSON;
        }

        #endregion

        #region Otras Gestiones
        /// <summary>
        /// Autor:       PSA
        /// Fecha:       04/05/2012 PSA
        /// Descripción: Listar Menús por CodPersona, dependiendo el Perfil y la Compañia de la Persona, mostrar los Reportes Asociados.
        /// </summary>
        public string Listar_Menu_Por_CodPersona(string DatosRequest)
        {
            DataContract.Listar_Menu_Por_CodPersona_Request request = HelperJson.Deserialize<DataContract.Listar_Menu_Por_CodPersona_Request>(DatosRequest);
            DataContract.Listar_Menu_Por_CodPersona_Response response = new DataContract.Listar_Menu_Por_CodPersona_Response();
            try
            {
                response.oListaMenu = oBL_GES_Campania.Listar_Menu_Por_CodPersona(request.CodPersona);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Menu_Por_CodPersona_Response>(response);
            return responseJSON;

        }
        /// <summary>
        /// Autor:       PSA
        /// Fecha:       05/05/2012 PSA
        /// Descripción: Llena el Reporte Stock Alicorp para que pueda registrar Cantidad y Observaciones.
        /// </summary>
        public string Llenar_Reporte_Stock_Alicorp(string DatosRequest)
        {
            DataContract.Llenar_Reporte_Stock_Alicorp_Request request = HelperJson.Deserialize<DataContract.Llenar_Reporte_Stock_Alicorp_Request>(DatosRequest);
            DataContract.Llenar_Reporte_Stock_Alicorp_Response response = new DataContract.Llenar_Reporte_Stock_Alicorp_Response();
            try
            {
                response.oListaReporte = oBL_GES_Campania.Llenar_Reporte_Stock_Alicorp(request.CodCompania, request.CodReporte, request.CodCategoria);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Llenar_Reporte_Stock_Alicorp_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Devuelte los datos del reporte para mostrar en la grilla.
        /// Modulos: Digitación, ...
        /// Autor: Joseph Gonzales
        /// Fecha: 10/05/2012
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        //public string Llenar_Reporte_General(string DatosParametros)
        //{
        //    DataContract.Llenar_Reporte_General_Request request = HelperJson.Deserialize<DataContract.Llenar_Reporte_General_Request>(DatosParametros);
        //    DataContract.Llenar_Reporte_General_Response response = new DataContract.Llenar_Reporte_General_Response();

        //    try
        //    {
        //        response.oListaReporte = oBL_GES_Campania.Llenar_Reporte_General(request.ReporteFiltros.CodCompania, request.ReporteFiltros.CodReporte, request.ReporteFiltros.CodCategoria, request.ReporteFiltros.CodMarca,
        //            request.ReporteFiltros.CodFamilia, request.ReporteFiltros.CodSubFamilia, request.ReporteFiltros.CodOficina, request.ReporteFiltros.CodGestor, request.ReporteFiltros.CodPDV);
        //        response.Estado = BaseResponse.EXITO;
        //    }
        //    catch (Exception)
        //    {
        //        response.Descripcion = "No existen datos.";
        //        response.Estado = BaseResponse.GENERAL_ERROR;
        //    }

        //    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
        //    string responseJSON = HelperJson.Serialize<DataContract.Llenar_Reporte_General_Response>(response);
        //    return responseJSON;
        //}
        /// <summary>
        /// Actualizacion
        /// Author: Pablo Salas A.
        /// Fecha: 03/08/2012
        /// Descripcion: Actualizacion del Reporte de General, se agrega el parametro Cod_Departamento
        /// http://localhost:58700/Ges_CampaniaService.svc/Llenar_Reporte_General
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":{"a":"813622482010","b":"58","c":"0","d":"0","e":"0","f":"0","g":null,"h":"0","i":"LIM-000308","j":"8145","k":null,"l":null,"m":null,"n":"01","o":"15"}}</string>
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        public string Llenar_Reporte_General(string DatosParametros)
        {
            DataContract.Llenar_Reporte_General_Request request = HelperJson.Deserialize<DataContract.Llenar_Reporte_General_Request>(DatosParametros);
            DataContract.Llenar_Reporte_General_Response response = new DataContract.Llenar_Reporte_General_Response();

            try
            {
                response.oListaReporte = oBL_GES_Campania.Llenar_Reporte_General(request.ReporteFiltros);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Llenar_Reporte_General_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Fecha:       19/09/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Devuelte los datos del reporte para mostrar en la grilla Colgate Bodegas
        /// </summary>
        public string Llenar_Reporte_Bodegas(string DatosParametros)
        {
            DataContract.Llenar_Reporte_Bodegas_Request request = HelperJson.Deserialize<DataContract.Llenar_Reporte_Bodegas_Request>(DatosParametros);
            DataContract.Llenar_Reporte_Bodegas_Response response = new DataContract.Llenar_Reporte_Bodegas_Response();

            try
            {
                response.oListaReporte = oBL_GES_Campania.Llenar_Reporte_Bodegas(request.ReporteFiltros);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Llenar_Reporte_Bodegas_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       11/09/2012
        /// Descripción: Método que devuelve los ubreportes por código de reporte, código de campaña y código de canal
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Obtener_Usuario(string DatosParametro)
        {
            DataContract.Obtener_Usuario_Request request = HelperJson.Deserialize<DataContract.Obtener_Usuario_Request>(DatosParametro);
            DataContract.Obtener_Usuario_Response response = new DataContract.Obtener_Usuario_Response();
            try
            {
                response.oObtenerUsuario = oBL_GES_Campania.obtenerNombreUsuario(request.idPerson);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Usuario_Response>(response);
            return responseJSON;
        }
        #endregion
        //#region Planning

        //#endregion

        #region Gestion de Rutas
        /// <summary>
        /// Author      : Pablo Salas A.
        /// Fecha       : 27/09/2012
        /// Descripcion : Listar Rutas por CodCompaniaCodCampaniaCodPersona
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Rutas_Por_CodCompania_CodCampania_CodPersona(string DatosParametro) {
            DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Request request = HelperJson.Deserialize<DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Request>(DatosParametro);
            DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Response response = new DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Response();
            
            try {
                response.oListE_PuntodeVentaPlanningRuta = oBL_GES_Campania.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona(request.Cod_Compania, request.Cod_Campania, request.Cod_Persona);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Response>(response);
            return responseJSON;
        }
        //Add 08/11/2012 Psa.
        public string Listar_Rutas_Por_ComCamPerFec(string DatosParametro)
        {
            DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Request request = HelperJson.Deserialize<DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Request>(DatosParametro);
            DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Response response = new DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Response();

            try
            {
                response.oListE_PuntodeVentaPlanningRuta = oBL_GES_Campania.Listar_Rutas_Por_ComCamPerFec(request.Cod_Compania, request.Cod_Campania, request.Cod_Persona, request.Fecha,request.Opcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Response>(response);
            return responseJSON;
        }


        public string updateRuta(string datos)
        {
            BL_GES_Campania oBL_GES_Campania = new BL_GES_Campania();

            DataContract.updateRuta_Request request = HelperJson.Deserialize<DataContract.updateRuta_Request>(datos);
            DataContract.updateRuta_Response response = new DataContract.updateRuta_Response();
            try
            {
                response.Descripcion = oBL_GES_Campania.updateRuta(request.nroRuta,request.fechainicio,request.fechafin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.updateRuta_Response>(response);
            return responseJSON;
        }

        public string actualizarEstadoRuta(string datos)
        {
            BL_GES_Campania oBL_GES_Campania = new BL_GES_Campania();

            DataContract.actualizarEstadoRuta_Request request = HelperJson.Deserialize<DataContract.actualizarEstadoRuta_Request>(datos);
            DataContract.actualizarEstadoRuta_Response response = new DataContract.actualizarEstadoRuta_Response();
            try
            {
                response.Descripcion = oBL_GES_Campania.actualizarEstadoRuta(request.nroRuta,request.valor);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no Disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.actualizarEstadoRuta_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Cadenas
        /// <summary>
        /// Author      : Peter Ccopa
        /// Fecha       : 28/09/2012
        /// Descripcion : Listar Cadenas
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Cadenas(string DatosParametro)
        {
            DataContract.Listar_Cadenas_Request request = HelperJson.Deserialize<DataContract.Listar_Cadenas_Request>(DatosParametro);
            DataContract.Listar_Cadenas_Response response = new DataContract.Listar_Cadenas_Response();

            try
            {
                response.listaCadenas = oBL_GES_Campania.Listar_Cadenas(request.CodCampania, request.codGenerador,request.FechaRelevo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Cadenas_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Orden de Compra
        /// <summary>
        /// Author      : Peter Ccopa
        /// Fecha       : 25/10/2012
        /// Descripcion : Obtener Nro OC
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string obtener_NroOrdenCompra(string DatosParametro)
        {
            DataContract.obtener_NroOrdenCompra_Request request = HelperJson.Deserialize<DataContract.obtener_NroOrdenCompra_Request>(DatosParametro);
            DataContract.obtener_NroOrdenCompra_Response response = new DataContract.obtener_NroOrdenCompra_Response();

            try
            {
                response.obtenerOC = oBL_GES_Campania.obtener_NroOrdenCompra(request.Tipo_Doc);
                //oBL_GES_Campania.obtener_NroOrdenCompra(request.Tipo_Doc);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.obtener_NroOrdenCompra_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Menu Datamercaderista
        /// <summary>
        /// Author      : Peter Ccopa
        /// Fecha       : 12/10/2012
        /// Descripcion : Listar Menu Datamercaderista
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Menu_Datamercaderista(string DatosParametro)
        {
            DataContract.Listar_Menu_Datamercaderista_Request request = HelperJson.Deserialize<DataContract.Listar_Menu_Datamercaderista_Request>(DatosParametro);
            DataContract.Listar_Menu_Datamercaderista_Response response = new DataContract.Listar_Menu_Datamercaderista_Response();

            try
            {
                response.listaMenu_Datamercaderista = oBL_GES_Campania.Listar_Menu_Datamercaderista(request.CodModulo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Menu_Datamercaderista_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Proveedores
        /// <summary>
        /// Author      : Peter Ccopa
        /// Fecha       : 23/10/2012
        /// Descripcion : Listar Proveedores
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_Proveedores(string DatosParametro)
        {
            DataContract.Listar_Proveedores_Request request = HelperJson.Deserialize<DataContract.Listar_Proveedores_Request>(DatosParametro);
            DataContract.Listar_Proveedores_Response response = new DataContract.Listar_Proveedores_Response();

            try
            {
                response.listaProveedores = oBL_GES_Campania.Listar_Proveedores(request.CodProv);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Listar_Proveedores_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de PDVCadenas
        /// <summary>
        /// Author      : Peter Ccopa
        /// Fecha       : 28/09/2012
        /// Descripcion : Listar los PDV por Campaña, Generador y Cadenas
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena(string DatosParametro)
        {
            DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena_Request request = HelperJson.Deserialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena_Request>(DatosParametro);
            DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena_Response response = new DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena_Response();

            try
            {
                response.listaCadenas = oBL_GES_Campania.Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena(request.CodCampania, request.codGenerador, request.codCadena, request.FechaRelevo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Parametros
        /// <summary>
        /// Author      : Peter Ccopa
        /// Fecha       : 30/10/2012
        /// Descripcion : obtener parametros
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string obtener_Parametro(string DatosParametro)
        {
            DataContract.obtener_Parametro_Request request = HelperJson.Deserialize<DataContract.obtener_Parametro_Request>(DatosParametro);
            DataContract.obtener_Parametro_Response response = new DataContract.obtener_Parametro_Response();

            try
            {
                response.listaParametros = oBL_GES_Campania.obtener_Parametro(request.Tipo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.obtener_Parametro_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Orden de Compras
        /// <summary>
        /// Author      : Peter Ccopa
        /// Fecha       : 92/10/2012
        /// Descripcion : Listar Orden de Compras por NroOC
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string ListarOrdenCompra_Cabecera(string DatosParametro)
        {
            DataContract.ListarOrdenCompra_Cabecera_Request request = HelperJson.Deserialize<DataContract.ListarOrdenCompra_Cabecera_Request>(DatosParametro);
            DataContract.ListarOrdenCompra_Cabecera_Response response = new DataContract.ListarOrdenCompra_Cabecera_Response();

            try
            {
                response.listaOrdenCompra = oBL_GES_Campania.ListarOrdenCompra_Cabecera(request.Nro_OC);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.ListarOrdenCompra_Cabecera_Response>(response);
            return responseJSON;
        }

        /// <summary>
        /// Author      : Peter Ccopa
        /// Fecha       : 92/10/2012
        /// Descripcion : Listar Orden de Compras por NroOC
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        public string ListarOrdenCompra_Detalle(string DatosParametro)
        {
            DataContract.ListarOrdenCompra_Detalle_Request request = HelperJson.Deserialize<DataContract.ListarOrdenCompra_Detalle_Request>(DatosParametro);
            DataContract.ListarOrdenCompra_Detalle_Response response = new DataContract.ListarOrdenCompra_Detalle_Response();

            try
            {
                response.listaOrdenCompraDet = oBL_GES_Campania.ListarOrdenCompra_Detalle(request.Nro_OC);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "Error Inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.ListarOrdenCompra_Detalle_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Gestion de Reportes
        /// <summary>
        /// Fecha:       08/11/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Devuelve los datos del reporte para mostrar en la grilla Exhibicion
        /// </summary>
        //public string Llenar_Reporte_Exhibicion(string DatosParametros)
        //{
        //    DataContract.Llenar_Reporte_Exhibicion_Request request = HelperJson.Deserialize<DataContract.Llenar_Reporte_Exhibicion_Request>(DatosParametros);
        //    DataContract.Llenar_Reporte_Exhibicion_Response response = new DataContract.Llenar_Reporte_Exhibicion_Response();

        //    try
        //    {
        //        response.oListaReporteExhibicion = oBL_GES_Campania.Llenar_Reporte_Exhibicion(request.ReporteFiltros);
        //        response.Estado = BaseResponse.EXITO;
        //    }
        //    catch (Exception)
        //    {
        //        response.Descripcion = "No existen datos.";
        //        response.Estado = BaseResponse.GENERAL_ERROR;
        //    }

        //    //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
        //    string responseJSON = HelperJson.Serialize<DataContract.Llenar_Reporte_Exhibicion_Response>(response);
        //    return responseJSON;
        //}
        #endregion
    }
}
