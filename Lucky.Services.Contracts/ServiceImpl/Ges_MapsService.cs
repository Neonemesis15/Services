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
    public class Ges_MapsService : IGes_MapsService
    {
        private readonly static BL_GES_MapsService oBL_GES_MapsService = new BL_GES_MapsService();

        
        #region Colgate

        #region Presencia
        public string Obtener_PresenciaZonaDistritoMap(string DatosEntrada)
        {
            DataContract.PresenciaZonaDistritoMap_Request request = HelperJson.Deserialize<DataContract.PresenciaZonaDistritoMap_Request>(DatosEntrada);
            DataContract.PresenciaZonaDistritoMap_Response response = new DataContract.PresenciaZonaDistritoMap_Response();
            try
            {
                response.ListPresenciaZonaDistritoMap = oBL_GES_MapsService.Obtener_PresenciaZonaDistritoMap(request.codCanal, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codCategoria, request.codProducto, request.codPeriodo, request.opcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PresenciaZonaDistritoMap_Response>(response);
            return responseJSON;
        }
        public string Evolucion_Presencia_SKUMandatorios(string DatosEntrada)
        {
            DataContract.EvolucionPresenciaSKUMandatorios_Request request = HelperJson.Deserialize<DataContract.EvolucionPresenciaSKUMandatorios_Request>(DatosEntrada);
            DataContract.EvolucionPresenciaSKUMandatorios_Response response = new DataContract.EvolucionPresenciaSKUMandatorios_Response();
            try
            {
                //response.oListPuntoVenta = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaSKU(request.codCanal, request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codProducto, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.EvolucionPresenciaSKUMandatorios_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Author      :Pablo Salas A.
        /// Fecha       :03/09/2012
        /// Descripcion :Evolucion de Presencia de SKUMandatorio X (Periodo o Mes) y X (Zona o Distrito)
        /// Servicio    :http://localhost:58700/Ges_MapsService.svc/EvolucionPresenciaSKUMandatorios
        /// Trama_Request   :<string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">{"a":{"a":"254","b":"2008","c":"1561","d":"589","e":"07","f":"01","h":"06","g":"0","k":"1","l":"2012","m":"7","n":"1145","o":"2"}}</string> 
        /// Trama_Response  : <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">{"a":[{"a":"Evolucion de Presencia de SKU Mandatorio","b":"Noviembre","c":"Diciembre","d":"Enero","e":"Febrero","f":"Marzo","g":"Abril","h":"Mayo","i":"Junio"},{"a":"C HERBAL X 90 GR","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"28"},{"a":"C MENTA  X 75 ML","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"40"},{"a":"CDC TA + CEPILLO 50 ML","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"16"},{"a":"CEP COLGATE PREMIER CLEAN 14 X 12","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"48"},{"a":"CEPILLO TRIPLE ACCION","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"55"},{"a":"COLGATE TA + JABON PROTEX","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"49"},{"a":"COLGATE TA + SACHET","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"30"},{"a":"COLGATE TRIPLE ACCION X  75 ML","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"55"},{"a":"DSD LADY SPEED STICK SACHET 12 GR.","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"20"},{"a":"DSD SPEED STICK SACHET 12 GR.","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"23"},{"a":"JABÓN PALMOLIVE ALOE 75 GR.","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"34"},{"a":"KOLYNOS HERBAL X 90 GR","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"52"},{"a":"KOLYNOS MASTER PLUS ADULTO 12X14","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"34"},{"a":"KOLYNOS SW X 75 ML","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"49"},{"a":"PROTEX X 75 GR","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"37"},{"a":"SUAVITEL ADIOS AL PLANCHADO 80ML.","b":"0","c":"0","d":"0","e":"0","f":"0","g":"0","h":"0","i":"22"}],"d":null,"e":0}</string>

        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        public string EvolucionPresenciaSKUMandatorios(string DatosEntrada)
        {
            DataContract.EvolucionPresenciaSKUMandatorios_Request request = HelperJson.Deserialize<DataContract.EvolucionPresenciaSKUMandatorios_Request>(DatosEntrada);
            DataContract.EvolucionPresenciaSKUMandatorios_Response response = new DataContract.EvolucionPresenciaSKUMandatorios_Response();
            try
            {
                response.oE_PresenciaZonaDistrito_Detalle_List = oBL_GES_MapsService.Obtener_Evolucion_Presencia_SKUMandatorios(request.oE_Filtros_XplMap_Colgate);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EvolucionPresenciaSKUMandatorios_Response>(response);
            return responseJSON;
        }

        #endregion

        #region Ventas
        public string Obtener_PuntosVentaMapa(string DatosEntrada)
        {
            DataContract.Obtener_PuntoVenta_Request request = HelperJson.Deserialize<DataContract.Obtener_PuntoVenta_Request>(DatosEntrada);
            DataContract.Obtener_PuntoVenta_Response response = new DataContract.Obtener_PuntoVenta_Response();
            try
            {
                response.listaPuntosVenta = oBL_GES_MapsService.Obtener_PuntosVentaMapa(request.codEquipo, request.codGenerador, request.reportsPlanning, request.codPais, request.codDepartamento, request.codProvincia, request.codSector, request.codDistrito);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_PuntoVenta_Response>(response);
            return responseJSON;
        }
        public string Evolucion_Venta_SKUMandatorios(string DatosEntrada)
        {
            DataContract.EvolucionVentaSKUMandatorios_Request request = HelperJson.Deserialize<DataContract.EvolucionVentaSKUMandatorios_Request>(DatosEntrada);
            DataContract.EvolucionVentaSKUMandatorios_Response_List response = new DataContract.EvolucionVentaSKUMandatorios_Response_List();
            try
            {
                response.oE_VentasZonaDistrito_Detalle = oBL_GES_MapsService.Obtener_Evolucion_Venta_SKUMandatorios(request.oE_Filtros_XplMap_Colgate);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EvolucionVentaSKUMandatorios_Response_List>(response);
            return responseJSON;
        }
        public string Variacion_Detallada_Ventas(string DatosEntrada)
        {
            DataContract.VariacionDetalladaVentas_Request request = HelperJson.Deserialize<DataContract.VariacionDetalladaVentas_Request>(DatosEntrada);
            DataContract.VariacionDetalladaVentas_Response response = new DataContract.VariacionDetalladaVentas_Response();
            try
            {
                //response.oListPuntoVenta = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaSKU(request.codCanal, request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codProducto, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.VariacionDetalladaVentas_Response>(response);
            return responseJSON;
        }
        /// <summary>
        /// Author      :Pablo Salas A.
        /// Fecha       :03/09/2012
        /// Descripcion :Evolucion de Ventas de SKUMandatorio X (Periodo o Mes) y X (Zona o Distrito)
        /// Servicio    :http://localhost:58700/Ges_MapsService.svc/EvolucionVentaSKUMandatorios
        /// Trama_Request   :<string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">{"a":{"a":"254","b":"2008","c":"1561","d":"589","e":"07","f":"01","h":"06","g":"0","k":"1","l":"2012","m":"7","n":"1145","o":"2"}}</string> 
        /// Trama_Response  :<string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">{"a":{"a":["Evolucion de Ventas","Diciembre","Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio"],"b":[["C HERBAL X 90 GR","0","0","0","0","0","0","0","756.73"],["C MENTA  X 75 ML","0","0","0","0","0","0","0","0"],["CDC TA + CEPILLO 50 ML","0","0","0","0","0","0","0","673.74"],["CEP COLGATE PREMIER CLEAN 14 X 12","0","0","0","0","0","0","0","315.92"],["CEPILLO TRIPLE ACCION","0","0","0","0","0","0","0","48.28"],["COLGATE TA + JABON PROTEX","0","0","0","0","0","0","0","825.8"],["COLGATE TA + SACHET","0","0","0","0","0","0","0","342.45"],["COLGATE TRIPLE ACCION X  75 ML","0","0","0","0","0","0","0","55.57"],["DSD LADY SPEED STICK SACHET 12 GR.","0","0","0","0","0","0","0","206.37"],["DSD SPEED STICK SACHET 12 GR.","0","0","0","0","0","0","0","191.63"],["JABÓN PALMOLIVE ALOE 75 GR.","0","0","0","0","0","0","0","35.29"],["KOLYNOS HERBAL X 90 GR","0","0","0","0","0","0","0","509.35"],["KOLYNOS MASTER PLUS ADULTO 12X14","0","0","0","0","0","0","0","0"],["KOLYNOS SW X 75 ML","0","0","0","0","0","0","0","0"],["PROTEX X 75 GR","0","0","0","0","0","0","0","0"],["SUAVITEL ADIOS AL PLANCHADO 80ML.","0","0","0","0","0","0","0","495.42"]]},"d":null,"e":0}</string>
        /// </summary>
        public string EvolucionVentaSKUMandatorios(string DatosEntrada)
        {
            DataContract.EvolucionVentaSKUMandatorios_Request request = HelperJson.Deserialize<DataContract.EvolucionVentaSKUMandatorios_Request>(DatosEntrada);
            DataContract.EvolucionVentaSKUMandatorios_Response response = new DataContract.EvolucionVentaSKUMandatorios_Response();
            try
            {
                response.oE_VentasZonaDistrito_Detalle = oBL_GES_MapsService.Obtener_Ventas_ZonaDistrito_Detalle(request.oE_Filtros_XplMap_Colgate);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EvolucionVentaSKUMandatorios_Response>(response);
            return responseJSON;
        }
        public string Obtener_PuntoVentaMapaVentas(string DatosEntrada)
        {
            DataContract.PuntoVentaMapaVentas_Request request = HelperJson.Deserialize<DataContract.PuntoVentaMapaVentas_Request>(DatosEntrada);
            DataContract.PuntoVentaMapaVentas_Response response = new DataContract.PuntoVentaMapaVentas_Response();
            try
            {
                response.oListPuntoVentaMapaVentas = oBL_GES_MapsService.Obtener_PuntoVentaMapaVentas(request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codCategoria, request.codProducto, request.codCluster, request.codPlanning, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaMapaVentas_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Unicos
        public string Obtener_Representatividad(string DatosEntrada)
        {
            DataContract.Obtener_Representatividad_Request request = HelperJson.Deserialize<DataContract.Obtener_Representatividad_Request>(DatosEntrada);
            DataContract.Obtener_Representatividad_Response response = new DataContract.Obtener_Representatividad_Response();
            try
            {
                response.representatividad = oBL_GES_MapsService.Obtener_Representatividad(request.tipo, request.codigo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Representatividad_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Ubigeo
        public string Obtener_Provincia_Por_CodDepartamento(string DatosEntrada)
        {
            DataContract.Obtener_Provincia_Por_CodDepartamento_Request request = HelperJson.Deserialize<DataContract.Obtener_Provincia_Por_CodDepartamento_Request>(DatosEntrada);
            DataContract.Obtener_Provincia_Por_CodDepartamento_Response response = new DataContract.Obtener_Provincia_Por_CodDepartamento_Response();
            try
            {
                response.listaProvincias = oBL_GES_MapsService.Obtener_Provincia_Por_CodDepartamento(request.codPais, request.codDepartamento);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Provincia_Por_CodDepartamento_Response>(response);
            return responseJSON;
        }
        public string Obtener_Sector_Por_PaisDepartamentoProvincia(string DatosEntrada)
        {
            DataContract.Obtener_Sector_Por_PaisDepartamentoProvincia_Request request = HelperJson.Deserialize<DataContract.Obtener_Sector_Por_PaisDepartamentoProvincia_Request>(DatosEntrada);
            DataContract.Obtener_Sector_Por_PaisDepartamentoProvincia_Response response = new DataContract.Obtener_Sector_Por_PaisDepartamentoProvincia_Response();
            try
            {
                response.listaSector = oBL_GES_MapsService.Obtener_Sector_Por_PaisDepartamentoProvincia(request.codPais, request.codDepartamento, request.codProvincia);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Sector_Por_PaisDepartamentoProvincia_Response>(response);
            return responseJSON;
        }
        public string Obtener_Departamento_Por_CodPais(string DatosEntrada)
        {
            DataContract.Obtener_Departamento_Por_CodPais_Request request = HelperJson.Deserialize<DataContract.Obtener_Departamento_Por_CodPais_Request>(DatosEntrada);
            DataContract.Obtener_Departamento_Por_CodPais_Response response = new DataContract.Obtener_Departamento_Por_CodPais_Response();
            try
            {
                response.listaDeparamentos = oBL_GES_MapsService.Obtener_Departamento_Por_CodPais(request.codPais);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Departamento_Por_CodPais_Response>(response);
            return responseJSON;
        }
        public string Obtener_Distrito_Por_CodSector(string DatosEntrada)
        {
            DataContract.Obtener_Distrito_Por_CodSector_Request request = HelperJson.Deserialize<DataContract.Obtener_Distrito_Por_CodSector_Request>(DatosEntrada);
            DataContract.Obtener_Distrito_Por_CodSector_Response response = new DataContract.Obtener_Distrito_Por_CodSector_Response();
            try
            {
                response.listaDistritos = oBL_GES_MapsService.Obtener_Distrito_Por_CodSector(request.codPais, request.codDepartamento, request.codProvincia, request.codSector);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Distrito_Por_CodSector_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Foto
        public string Obtener_HistorialFoto_PuntoVenta(string DatosEntrada)
        {
            DataContract.Obtener_HistorialFoto_PuntoVenta_Request request = HelperJson.Deserialize<DataContract.Obtener_HistorialFoto_PuntoVenta_Request>(DatosEntrada);
            DataContract.Obtener_HistorialFoto_PuntoVenta_Response response = new DataContract.Obtener_HistorialFoto_PuntoVenta_Response();
            try
            {
                response.listaHistorialFotoPDV = oBL_GES_MapsService.Obtener_HistorialFoto_PuntoVenta(request.reportsPlanning, request.codPtoVenta);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_HistorialFoto_PuntoVenta_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Cluster
        public string Obtener_TipoCluster()
        {
            DataContract.TipoCluster_Response response = new DataContract.TipoCluster_Response();
            try
            {
                response.ListTipoCluster = oBL_GES_MapsService.Obtener_TipoCluster();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.TipoCluster_Response>(response);
            return responseJSON;
        }

        #endregion



        #region Variacion
       
        #endregion

        #region Seguimiento
        public string Obtener_Seguimiento_Generador(string DatosEntrada)
        {
            DataContract.Obtener_Seguimiento_Generador_Request request = HelperJson.Deserialize<DataContract.Obtener_Seguimiento_Generador_Request>(DatosEntrada);
            DataContract.Obtener_Seguimiento_Generador_Response response = new DataContract.Obtener_Seguimiento_Generador_Response();
            try
            {
                response.seguimientoRuta = oBL_GES_MapsService.Obtener_Seguimiento_x_Ruta(request.codEquipo, request.codPais, request.codDepartamento,
                    request.codProvincia, request.codDistrito, request.codGestor, request.fecha);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Seguimiento_Generador_Response>(response);
            return responseJSON;
        }
        #endregion

        #region XploraMaps - Lima

        #region Sección Universo >>Warning<<
        //1.-Total de PDV’s por ciudad.(considerar periodo).
        public string Obtener_ClusterZonaDistritoMap(string DatosEntrada)
        {
            DataContract.ClusterZonaDistritoMap_Request request = HelperJson.Deserialize<DataContract.ClusterZonaDistritoMap_Request>(DatosEntrada);
            DataContract.ClusterZonaDistritoMap_Response response = new DataContract.ClusterZonaDistritoMap_Response();
            try
            {
                response.clusterZonaDistritoMap = oBL_GES_MapsService.Obtener_ClusterZonaDistritoMap(request.codZona, request.codDistrito, request.idPlanning, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ClusterZonaDistritoMap_Response>(response);
            return responseJSON;
        }
        //2.-Total de PDV’s visitados por ciudad y a su vez éstos por clúster.(considerar periodo).
        public string Obtener_Representatividad_And_Cluster(string DatosEntrada)
        {
            DataContract.Representatividad_And_Cluster_Request request = HelperJson.Deserialize<DataContract.Representatividad_And_Cluster_Request>(DatosEntrada);
            DataContract.Representatividad_And_Cluster_Response response = new DataContract.Representatividad_And_Cluster_Response();
            try
            {
                response.clusterZonaDistritoMap = oBL_GES_MapsService.Obtener_ClusterZonaDistritoMap(request.codZona, request.codDistrito, request.idPlanning, request.reportsPlanning);
                response.representatividadZonaDistritoMap = oBL_GES_MapsService.Obtener_Representatividad_Group(request.codZona, request.codDistrito, request.idPlanning, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Representatividad_And_Cluster_Response>(response);
            return responseJSON;
        }
        //3.-Total de PDV's  por Cluster
        //Pendiente
        #endregion

        #region Sección - Presencia SKU Mandatorio
        //1.-Porcentaje de Presencia por Rangos.(considerar periodo).
        public string Obtener_Presencia_ZonaDistrito(string DatosEntrada)
        {
            DataContract.Obtener_PresenciaZonaDistrito_Request request = HelperJson.Deserialize<DataContract.Obtener_PresenciaZonaDistrito_Request>(DatosEntrada);
            DataContract.Obtener_PresenciaZonaDistrito_Response response = new DataContract.Obtener_PresenciaZonaDistrito_Response();
            try
            {
                response.listaPresencia = oBL_GES_MapsService.Obtener_Presencia_ZonaDistrito(request.servicio,
                    request.canal, request.codCliente, request.codDepartamento, request.codciudad, request.codZona, request.codDistrito, request.reportsPlanning);
                response.listaElementosVisibilidad = oBL_GES_MapsService.Obtener_Presencia_ElemeVisibilidad_ZonaDistrito(request.servicio,
                    request.canal, request.codCliente, request.codciudad, request.codZona, request.codDistrito, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_PresenciaZonaDistrito_Response>(response);
            return responseJSON;
        }
        public string Obtener_PuntoVentaCluster(string DatosEntrada)
        {
            DataContract.PuntoVentaCluster_Request request = HelperJson.Deserialize<DataContract.PuntoVentaCluster_Request>(DatosEntrada);
            DataContract.PuntoVentaCluster_Response response = new DataContract.PuntoVentaCluster_Response();
            try
            {
                response.oListPuntoVentaCluster = oBL_GES_MapsService.Obtener_PuntoVentaCluster(request.codCanal, request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.cluster, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaCluster_Response>(response);
            return responseJSON;
        }
        //2.-Cantidad PDV’s x SKU Mandatorio.(considerar periodo).
        //Se Reutiliza public List<E_ElemVisibilidadZonaDistrito> Obtener_Presencia_ElemeVisibilidad_ZonaDistrito(int servicio, string canal, int codCliente, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        //UP_WEBXPLORA_PRESENCIA_ELEMVISIB_MAPS
        //1.1.-Pintar Mapa por Rangos
        public string Obtener_PuntoVentaPresenciaRango(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaRango_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaRango_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaRango_Response response = new DataContract.PuntoVentaPresenciaRango_Response();
            try
            {
                response.oListPuntoVenta = oBL_GES_MapsService.Obtener_PuntoVentaRango(request.codCanal, request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codRango, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaRango_Response>(response);
            return responseJSON;
        }
        //1.2.-Exportar a Excel por Rangos
        public string Obtener_PuntoVentaPresenciaRangoToExcel(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaRango_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaRango_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaRangoToExcel_Response response = new DataContract.PuntoVentaPresenciaRangoToExcel_Response();
            try
            {
                response.oExportExcel = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaRangoToExcel(request.codCanal, request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codRango, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaRangoToExcel_Response>(response);
            return responseJSON;
        }
        //2.1.-Pintar Mapa PDV con SKUMandatorio
        public string Obtener_PuntoVentaPresenciaSKU(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaSKU_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaSKU_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaSKU_Response response = new DataContract.PuntoVentaPresenciaSKU_Response();
            try
            {
                response.oListPuntoVenta = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaSKU(request.codCanal, request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codProducto, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaSKU_Response>(response);
            return responseJSON;
        }
        //2.2.-Exportar a Excel por SKUMandatorios
        public string Obtener_PuntoVentaPresenciaSKUToExcel(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaSKU_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaSKU_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaSKUToExcel_Response response = new DataContract.PuntoVentaPresenciaSKUToExcel_Response();
            try
            {
                response.oExportExcel = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaSKUToExcel(request.codCanal, request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codProducto, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaSKUToExcel_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Sección - Ventas x SubCategoria
        //3.-Matriz Ventas X Categoría X Distribuidora.(considerar periodo).
        //Reutilizacion
        //public List<E_VentasZonaDistrito> Obtener_Ventas_ZonaDistrito(int tipo, string codigo, int reportsPlanning)
        //UP_XPLORAMAPS_VENTAS
        public string Obtener_Ventas_ZonaDistrito(string DatosEntrada)
        {
            DataContract.Obtener_VentaZonaDistrito_Request request = HelperJson.Deserialize<DataContract.Obtener_VentaZonaDistrito_Request>(DatosEntrada);
            DataContract.Obtener_VentaZonaDistrito_Response response = new DataContract.Obtener_VentaZonaDistrito_Response();
            try
            {
                response.listaVentas = oBL_GES_MapsService.Obtener_Ventas_ZonaDistrito(request.tipo, request.codigo, request.reportsPlanning);
                if (response.listaVentas == null)
                    throw new Exception();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_VentaZonaDistrito_Response>(response);
            return responseJSON;
        }

        #endregion

        #region Sección - Elementos de Visibilidad
        //3.- Cantidad de PDV’s por Elemento de Visibilidad (COLPAL, P&G) .(considerar periodo).
        //Reutilizacion del Metodo
        // public List<E_ElemVisibilidad_PDV> Obtener_ElemVisibilida_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        //SP_GES_MAPS_OBTENER_ELEMENTO_VISIBILIDAD_PDV
        public string Obtener_ElemVisibilida_PuntoVenta(string DatosEntrada)
        {
            DataContract.Obtener_ElemVisibilidad_PuntoVenta_Request request = HelperJson.Deserialize<DataContract.Obtener_ElemVisibilidad_PuntoVenta_Request>(DatosEntrada);
            DataContract.Obtener_ElemVisibilidad_PuntoVenta_Response response = new DataContract.Obtener_ElemVisibilidad_PuntoVenta_Response();
            try
            {
                response.listaElemVisibilidadPDV = oBL_GES_MapsService.Obtener_ElemVisibilida_PuntoVenta(request.codEquipo, request.reportsPlanning, request.codPtoVenta);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_ElemVisibilidad_PuntoVenta_Response>(response);
            return responseJSON;
        }

        //3.1 Exportar a Excel
        public string Obtener_PuntoVentaPresenciaElemVisibilidadToExcel(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaElemVisibilidad_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaElemVisibilidad_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaElemVisibilidadToExcel_Response response = new DataContract.PuntoVentaPresenciaElemVisibilidadToExcel_Response();
            try
            {
                response.oExportExcel = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaElemVisibilidadToExcel(request.codCanal, request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codElemento, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaElemVisibilidadToExcel_Response>(response);
            return responseJSON;
        }
        //3.2 Pintar Puntos en Mapa PDV
        public string Obtener_PuntoVentaPresenciaElemVisibilidad(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaElemVisibilidad_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaElemVisibilidad_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaElemVisibilidad_Response response = new DataContract.PuntoVentaPresenciaElemVisibilidad_Response();
            try
            {
                response.oListPuntoVenta = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaElemVisibilidad(request.codCanal, request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codElemento, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaElemVisibilidad_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Sección - Graficos
        //1.- Ventas vs Presencia: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
        //Obtener_Grafico_Tendencia
        public string Obtener_Grafico_Tendencia(string DatosEntrada)
        {
            DataContract.GraficoTendencia_Request request = HelperJson.Deserialize<DataContract.GraficoTendencia_Request>(DatosEntrada);
            DataContract.GraficoTendencia_Response response = new DataContract.GraficoTendencia_Response();
            try
            {
                response.oListGraficoTendencia = oBL_GES_MapsService.Obtener_Grafico_Tendencia(request.codServicio, request.codCanal, request.codCliente,
                    request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito,
                    request.codCategoria, request.codProducto, request.codCluster, request.anio, request.mes, request.codPeriodo, request.codOpcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.GraficoTendencia_Response>(response);
            return responseJSON;
        }
        public string Obtener_Datos_Tendencia(string DatosEntrada)
        {
            DataContract.DatosTendenciaSKUMandatorios_Request request = HelperJson.Deserialize<DataContract.DatosTendenciaSKUMandatorios_Request>(DatosEntrada);
            DataContract.DatosTendenciaSKUMandatorios_Response response = new DataContract.DatosTendenciaSKUMandatorios_Response();
            try
            {
                response.datosTendencia = oBL_GES_MapsService.Obtener_Datos_Tendencia(request.codServicio, request.codCanal,
                    request.codCliente, request.codPais, request.codDpto, request.codCity, request.codDistrito, request.codSector,
                    request.codCluster, request.codYear, request.codMes, request.codPeriodo, request.codOpcion);

                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.DatosTendenciaSKUMandatorios_Response>(response);
            return responseJSON;
        }
        //2.-Variación de Ventas: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
        //Obtener_Grafico_Variacion
        public string Obtener_Grafico_Variacion(string DatosEntrada)
        {
            DataContract.GraficoVariacion_Request request = HelperJson.Deserialize<DataContract.GraficoVariacion_Request>(DatosEntrada);
            DataContract.GraficoVariacion_Response response = new DataContract.GraficoVariacion_Response();
            try
            {
                response.oListGraficoVariacion = oBL_GES_MapsService.Obtener_Grafico_Variacion(request.codServicio, request.codCanal, request.codCliente,
                    request.codPais, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito,
                    request.codCategoria, request.codProducto, request.codCluster, request.anio, request.mes, request.codPeriodo, request.codOpcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.GraficoVariacion_Response>(response);
            return responseJSON;
        }
        public string Obtener_Datos_Variacion(string DatosEntrada)
        {
            DataContract.DatosVariacionSKUMandatorios_Request request = HelperJson.Deserialize<DataContract.DatosVariacionSKUMandatorios_Request>(DatosEntrada);
            DataContract.DatosVariacionSKUMandatorios_Response response = new DataContract.DatosVariacionSKUMandatorios_Response();
            try
            {
                response.datosVariacion = oBL_GES_MapsService.Obtener_Datos_Variacion(request.codServicio, request.codCanal,
                    request.codCliente, request.codPais, request.codDpto, request.codCity, request.codDistrito, request.codSector,
                    request.codCluster, request.codYear, request.codMes, request.codPeriodo, request.codOpcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.DatosVariacionSKUMandatorios_Response>(response);
            return responseJSON;
        }
        #endregion

        #region Sección - Visita por PDV >>Reutiliza Por Completo<<
        //1.- 4 Fotos (2 internas ant,des / 2 externas ant,des)
        //Reutilizar el que Existe
        //public E_Foto_PDV Obtener_Foto_PuntoVenta(string reportsPlanning, string codPtoVenta)
        //SP_GES_MAPS_OBTENER_FOTO_PDV
        public string Obtener_Foto_PuntoVenta(string DatosEntrada)
        {
            DataContract.Obtener_Foto_PuntoVenta_Request request = HelperJson.Deserialize<DataContract.Obtener_Foto_PuntoVenta_Request>(DatosEntrada);
            DataContract.Obtener_Foto_PuntoVenta_Response response = new DataContract.Obtener_Foto_PuntoVenta_Response();
            try
            {
                response.fotoPDV = oBL_GES_MapsService.Obtener_Foto_PuntoVenta(request.reportsPlanning, request.codPtoVenta);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Foto_PuntoVenta_Response>(response);
            return responseJSON;
        }

        //2.-Datos del PDV igual que en Xplora Maps Lima.
        //Reutilizar el que Existe
        // public E_PuntoVentaDatosMapa Obtener_DatosPuntosVentaMapa(string codPtoVenta, string reportsPlanning)
        //SP_GES_MAPS_OBTENER_PDV
        public string Obtener_DatosPuntosVentaMapa(string DatosEntrada)
        {
            DataContract.Obtener_DatosPuntosVentaMapa_Request request = HelperJson.Deserialize<DataContract.Obtener_DatosPuntosVentaMapa_Request>(DatosEntrada);
            DataContract.Obtener_DatosPuntosVentaMapa_Response response = new DataContract.Obtener_DatosPuntosVentaMapa_Response();
            try
            {
                response.ptoVenta = oBL_GES_MapsService.Obtener_DatosPuntosVentaMapa(request.codPtoVenta, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_DatosPuntosVentaMapa_Response>(response);
            return responseJSON;
        }

        //3.-Vista de Presencia por SKU igual que en Xplora Maps Lima(check).
        //Reutilizar el que Existe
        //SP_GES_MAPS_OBTENER_PRESENCIA_PDV
        //public List<E_Presencia_PDV> Obtener_Presencia_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        public string Obtener_Presencia_PuntoVenta(string DatosEntrada)
        {
            DataContract.Obtener_Presencia_PuntoVenta_Request request = HelperJson.Deserialize<DataContract.Obtener_Presencia_PuntoVenta_Request>(DatosEntrada);
            DataContract.Obtener_Presencia_PuntoVenta_Response response = new DataContract.Obtener_Presencia_PuntoVenta_Response();
            try
            {
                response.listaPresenciaPDV = oBL_GES_MapsService.Obtener_Presencia_PuntoVenta(request.codEquipo, request.reportsPlanning, request.codPtoVenta);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Presencia_PuntoVenta_Response>(response);
            return responseJSON;
        }

        //4.-Vista de Elementos de Visibilidad por (cant x COLPAL/ COMP(P&G, UNILEVER, J&J etc)).
        //Reutilizar el que Existe
        // public List<E_ElemVisibilidad_PDV> Obtener_ElemVisibilida_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        //SP_GES_MAPS_OBTENER_ELEMENTO_VISIBILIDAD_PDV

        //5.-Vista de Ventas x SKU (importe/cantidad)
        //Reutilizar el que Existe
        //SP_GES_MAPS_OBTENER_VENTA_PDV
        //public List<E_Ventas_PDV> Obtener_Venta_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        public string Obtener_Venta_PuntoVenta(string DatosEntrada)
        {
            DataContract.Obtener_Venta_PuntoVenta_Request request = HelperJson.Deserialize<DataContract.Obtener_Venta_PuntoVenta_Request>(DatosEntrada);
            DataContract.Obtener_Venta_PuntoVenta_Response response = new DataContract.Obtener_Venta_PuntoVenta_Response();
            try
            {
                response.listaVentaPDV = oBL_GES_MapsService.Obtener_Venta_PuntoVenta(request.codEquipo, request.reportsPlanning, request.codPtoVenta);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Venta_PuntoVenta_Response>(response);
            return responseJSON;
        }
        #endregion
        
        #endregion

        #region XploraMaps - Provincias
        #region Sección Universo >>Warning<<
        //1.-Total de PDV’s por ciudad.(considerar periodo).
        public string Obtener_ClusterZonaDistritoMap_Prov(string DatosEntrada)
        {
            DataContract.ClusterZonaDistritoMap_Prov_Request request = HelperJson.Deserialize<DataContract.ClusterZonaDistritoMap_Prov_Request>(DatosEntrada);
            DataContract.ClusterZonaDistritoMap_Prov_Response response = new DataContract.ClusterZonaDistritoMap_Prov_Response();
            try
            {
                response.clusterZonaDistritoMap = oBL_GES_MapsService.Obtener_ClusterZonaDistritoMap_Prov(request.codOficina,request.codZona, request.codDistrito, request.idPlanning, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.ClusterZonaDistritoMap_Prov_Response>(response);
            return responseJSON;
        }
        //2.-Total de PDV’s visitados por ciudad y a su vez éstos por clúster.(considerar periodo).
        public string Obtener_Representatividad_And_Cluster_Prov(string DatosEntrada)
        {
            DataContract.Representatividad_And_Cluster_Prov_Request request = HelperJson.Deserialize<DataContract.Representatividad_And_Cluster_Prov_Request>(DatosEntrada);
            DataContract.Representatividad_And_Cluster_Prov_Response response = new DataContract.Representatividad_And_Cluster_Prov_Response();
            try
            {
                response.clusterZonaDistritoMap = oBL_GES_MapsService.Obtener_ClusterZonaDistritoMap_Prov(request.codOficina,request.codZona, request.codDistrito, request.idPlanning, request.reportsPlanning);
                response.representatividadZonaDistritoMap = oBL_GES_MapsService.Obtener_Representatividad_Group_Prov(request.codOficina,request.codZona, request.codDistrito, request.idPlanning, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Representatividad_And_Cluster_Prov_Response>(response);
            return responseJSON;
        }
        //3.-Total de PDV's  por Cluster
        //Pendiente
        #endregion
        #region Sección - Presencia SKU Mandatorio
        //1.-Porcentaje de Presencia por Rangos.(considerar periodo).
        public string Obtener_Presencia_ZonaDistrito_Prov(string DatosEntrada)
        {
            DataContract.Obtener_PresenciaZonaDistrito_Prov_Request request = HelperJson.Deserialize<DataContract.Obtener_PresenciaZonaDistrito_Prov_Request>(DatosEntrada);
            DataContract.Obtener_PresenciaZonaDistrito_Prov_Response response = new DataContract.Obtener_PresenciaZonaDistrito_Prov_Response();
            try
            {
                response.listaPresencia = oBL_GES_MapsService.Obtener_Presencia_ZonaDistrito_Prov(request.servicio,
                    request.canal, request.codCliente,request.codOficina, request.codDepartamento, request.codciudad, request.codZona, request.codDistrito, request.reportsPlanning);
                response.listaElementosVisibilidad = oBL_GES_MapsService.Obtener_Presencia_ElemeVisibilidad_ZonaDistrito_Prov(request.servicio,
                    request.canal, request.codCliente, request.codOficina,request.codDepartamento, request.codciudad, request.codZona, request.codDistrito, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_PresenciaZonaDistrito_Prov_Response>(response);
            return responseJSON;
        }
        public string Obtener_PuntoVentaCluster_Prov(string DatosEntrada)
        {
            DataContract.PuntoVentaCluster_Prov_Request request = HelperJson.Deserialize<DataContract.PuntoVentaCluster_Prov_Request>(DatosEntrada);
            DataContract.PuntoVentaCluster_Prov_Response response = new DataContract.PuntoVentaCluster_Prov_Response();
            try
            {
                response.oListPuntoVentaCluster = oBL_GES_MapsService.Obtener_PuntoVentaCluster_Prov(request.codCanal, request.codPais,request.codOficina, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.cluster, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaCluster_Prov_Response>(response);
            return responseJSON;
        }
        //2.-Cantidad PDV’s x SKU Mandatorio.(considerar periodo).
        //Se Reutiliza public List<E_ElemVisibilidadZonaDistrito> Obtener_Presencia_ElemeVisibilidad_ZonaDistrito(int servicio, string canal, int codCliente, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        //UP_WEBXPLORA_PRESENCIA_ELEMVISIB_MAPS
        //1.1.-Pintar Mapa por Rangos
        public string Obtener_PuntoVentaPresenciaRango_Prov(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaRango_Prov_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaRango_Prov_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaRango_Prov_Response response = new DataContract.PuntoVentaPresenciaRango_Prov_Response();
            try
            {
                response.oListPuntoVenta = oBL_GES_MapsService.Obtener_PuntoVentaRango_Prov(request.codCanal, request.codPais,request.codOficina, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codRango, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaRango_Prov_Response>(response);
            return responseJSON;
        }
        //1.2.-Exportar a Excel por Rangos
        public string Obtener_PuntoVentaPresenciaRangoToExcel_Prov(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaRango_Prov_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaRango_Prov_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaRangoToExcel_Prov_Response response = new DataContract.PuntoVentaPresenciaRangoToExcel_Prov_Response();
            try
            {
                response.oExportExcel = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaRangoToExcel_Prov(request.codCanal, request.codPais,request.codOficina, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codRango, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaRangoToExcel_Prov_Response>(response);
            return responseJSON;
        }
        //2.1.-Pintar Mapa PDV con SKUMandatorio
        public string Obtener_PuntoVentaPresenciaSKU_Prov(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaSKU_Prov_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaSKU_Prov_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaSKU_Prov_Response response = new DataContract.PuntoVentaPresenciaSKU_Prov_Response();
            try
            {
                response.oListPuntoVenta = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaSKU_Prov(request.codCanal, request.codPais,request.codOficina, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codProducto, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaSKU_Prov_Response>(response);
            return responseJSON;
        }
        //2.2.-Exportar a Excel por SKUMandatorios
        public string Obtener_PuntoVentaPresenciaSKUToExcel_Prov(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaSKU_Prov_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaSKU_Prov_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaSKUToExcel_Prov_Response response = new DataContract.PuntoVentaPresenciaSKUToExcel_Prov_Response();
            try
            {
                response.oExportExcel = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaSKUToExcel_Prov(request.codCanal, request.codPais,request.codOficina, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codProducto, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaSKUToExcel_Prov_Response>(response);
            return responseJSON;
        }
        #endregion
        #region Sección - Ventas x SubCategoria
        //3.-Matriz Ventas X Categoría X Distribuidora.(considerar periodo).
        //Reutilizacion
        //public List<E_VentasZonaDistrito> Obtener_Ventas_ZonaDistrito(int tipo, string codigo, int reportsPlanning)
        //UP_XPLORAMAPS_VENTAS
        #endregion
        #region Sección - Elementos de Visibilidad
        //3.- Cantidad de PDV’s por Elemento de Visibilidad (COLPAL, P&G) .(considerar periodo).
        //Reutilizacion del Metodo
        // public List<E_ElemVisibilidad_PDV> Obtener_ElemVisibilida_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        //SP_GES_MAPS_OBTENER_ELEMENTO_VISIBILIDAD_PDV
        //3.1 Exportar a Excel
        public string Obtener_PuntoVentaPresenciaElemVisibilidadToExcel_Prov(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaElemVisibilidad_Prov_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaElemVisibilidad_Prov_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaElemVisibilidadToExcel_Prov_Response response = new DataContract.PuntoVentaPresenciaElemVisibilidadToExcel_Prov_Response();
            try
            {
                response.oExportExcel = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaElemVisibilidadToExcel_Prov(request.codCanal, request.codPais,request.codOficina, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codElemento, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaElemVisibilidadToExcel_Prov_Response>(response);
            return responseJSON;
        }
        //3.2 Pintar Puntos en Mapa PDV
        public string Obtener_PuntoVentaPresenciaElemVisibilidad_Prov(string DatosEntrada)
        {
            DataContract.PuntoVentaPresenciaElemVisibilidad_Prov_Request request = HelperJson.Deserialize<DataContract.PuntoVentaPresenciaElemVisibilidad_Prov_Request>(DatosEntrada);
            DataContract.PuntoVentaPresenciaElemVisibilidad_Prov_Response response = new DataContract.PuntoVentaPresenciaElemVisibilidad_Prov_Response();
            try
            {
                response.oListPuntoVenta = oBL_GES_MapsService.Obtener_PuntoVentaPresenciaElemVisibilidad_Prov(request.codCanal, request.codPais,request.codOficina, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito, request.codElemento, request.codPeriodo);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.PuntoVentaPresenciaElemVisibilidad_Prov_Response>(response);
            return responseJSON;
        }
        #endregion
        #region Sección - Graficos
        //1.- Ventas vs Presencia: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
        //Obtener_Grafico_Tendencia
        public string Obtener_Grafico_Tendencia_Prov(string DatosEntrada)
        {
            DataContract.GraficoTendencia_Prov_Request request = HelperJson.Deserialize<DataContract.GraficoTendencia_Prov_Request>(DatosEntrada);
            DataContract.GraficoTendencia_Prov_Response response = new DataContract.GraficoTendencia_Prov_Response();
            try
            {
                response.oListGraficoTendencia = oBL_GES_MapsService.Obtener_Grafico_Tendencia_Prov(request.codServicio, request.codCanal, request.codCliente,
                    request.codPais, request.codOficina,request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito,
                    request.codCategoria, request.codProducto, request.codCluster, request.anio, request.mes, request.codPeriodo, request.codOpcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.GraficoTendencia_Prov_Response>(response);
            return responseJSON;
        }
        public string Obtener_Datos_Tendencia_Prov(string DatosEntrada)
        {
            DataContract.DatosTendenciaSKUMandatorios_Prov_Request request = HelperJson.Deserialize<DataContract.DatosTendenciaSKUMandatorios_Prov_Request>(DatosEntrada);
            DataContract.DatosTendenciaSKUMandatorios_Prov_Response response = new DataContract.DatosTendenciaSKUMandatorios_Prov_Response();
            try
            {
                response.datosTendencia = oBL_GES_MapsService.Obtener_Datos_Tendencia_Prov(request.codServicio, request.codCanal,
                    request.codCliente,request.codOficina, request.codPais, request.codDpto, request.codCity, request.codDistrito, request.codSector,
                    request.codCluster, request.codYear, request.codMes, request.codPeriodo, request.codOpcion);

                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.DatosTendenciaSKUMandatorios_Prov_Response>(response);
            return responseJSON;
        }
        //2.-Variación de Ventas: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
        //Obtener_Grafico_Variacion
        public string Obtener_Grafico_Variacion_Prov(string DatosEntrada)
        {
            DataContract.GraficoVariacion_Prov_Request request = HelperJson.Deserialize<DataContract.GraficoVariacion_Prov_Request>(DatosEntrada);
            DataContract.GraficoVariacion_Prov_Response response = new DataContract.GraficoVariacion_Prov_Response();
            try
            {
                response.oListGraficoVariacion = oBL_GES_MapsService.Obtener_Grafico_Variacion_Prov(request.codServicio, request.codCanal, request.codCliente,
                    request.codPais,request.codOficina, request.codDepartamento, request.codProvincia, request.codZona, request.codDistrito,
                    request.codCategoria, request.codProducto, request.codCluster, request.anio, request.mes, request.codPeriodo, request.codOpcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.GraficoVariacion_Prov_Response>(response);
            return responseJSON;
        }
        public string Obtener_Datos_Variacion_Prov(string DatosEntrada)
        {
            DataContract.DatosVariacionSKUMandatorios_Prov_Request request = HelperJson.Deserialize<DataContract.DatosVariacionSKUMandatorios_Prov_Request>(DatosEntrada);
            DataContract.DatosVariacionSKUMandatorios_Prov_Response response = new DataContract.DatosVariacionSKUMandatorios_Prov_Response();
            try
            {
                response.datosVariacion = oBL_GES_MapsService.Obtener_Datos_Variacion_Prov(request.codServicio, request.codCanal,
                    request.codCliente, request.codPais,request.codOficina, request.codDpto, request.codCity, request.codDistrito, request.codSector,
                    request.codCluster, request.codYear, request.codMes, request.codPeriodo, request.codOpcion);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.DatosVariacionSKUMandatorios_Prov_Response>(response);
            return responseJSON;
        }
        #endregion
        #region Sección - Visita por PDV >>Reutiliza Por Completo<<
        //1.- 4 Fotos (2 internas ant,des / 2 externas ant,des)
        //Reutilizar el que Existe
        //public E_Foto_PDV Obtener_Foto_PuntoVenta(string reportsPlanning, string codPtoVenta)
        //SP_GES_MAPS_OBTENER_FOTO_PDV
        //2.-Datos del PDV igual que en Xplora Maps Lima.
        //Reutilizar el que Existe
        // public E_PuntoVentaDatosMapa Obtener_DatosPuntosVentaMapa(string codPtoVenta, string reportsPlanning)
        //SP_GES_MAPS_OBTENER_PDV
        //3.-Vista de Presencia por SKU igual que en Xplora Maps Lima(check).
        //Reutilizar el que Existe
        //SP_GES_MAPS_OBTENER_PRESENCIA_PDV
        //public List<E_Presencia_PDV> Obtener_Presencia_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        //4.-Vista de Elementos de Visibilidad por (cant x COLPAL/ COMP(P&G, UNILEVER, J&J etc)).
        //Reutilizar el que Existe
        // public List<E_ElemVisibilidad_PDV> Obtener_ElemVisibilida_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        //SP_GES_MAPS_OBTENER_ELEMENTO_VISIBILIDAD_PDV

        //5.-Vista de Ventas x SKU (importe/cantidad)
        //Reutilizar el que Existe
        //SP_GES_MAPS_OBTENER_VENTA_PDV
        //public List<E_Ventas_PDV> Obtener_Venta_PuntoVenta(string codEquipo, string reportsPlanning, string codPtoVenta)
        #endregion
        #endregion

        #endregion

        #region Backus

        public string Obtener_Cobertura_PDV_x_Canal_Cadena(string DatosEntrada)
        {
            DataContract.Obtener_Cobertura_PDV_x_Canal_Cadena_Request request = HelperJson.Deserialize<DataContract.Obtener_Cobertura_PDV_x_Canal_Cadena_Request>(DatosEntrada);
            DataContract.Obtener_Cobertura_PDV_x_Canal_Cadena_Response response = new DataContract.Obtener_Cobertura_PDV_x_Canal_Cadena_Response();
            try
            {
                response.cobertura = oBL_GES_MapsService.Obtener_Cobertura_PDV_x_Canal_Cadena(request.codCliente, request.codCanal, request.codCadena, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Cobertura_PDV_x_Canal_Cadena_Response>(response);
            return responseJSON;
        }
        public string Obtener_Status_EQF_x_Canal_Cadena(string DatosEntrada)
        {
            DataContract.Obtener_Status_EQF_Request request = HelperJson.Deserialize<DataContract.Obtener_Status_EQF_Request>(DatosEntrada);
            DataContract.Obtener_Status_EQF_Response response = new DataContract.Obtener_Status_EQF_Response();
            try
            {
                response.listStatusEQF = oBL_GES_MapsService.Obtener_Status_EQF_x_Canal_Cadena(request.codCliente, request.codCanal, request.codCadena, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Status_EQF_Response>(response);
            return responseJSON;
        }
        public string Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena(string DatosEntrada)
        {
            DataContract.Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena_Request request = HelperJson.Deserialize<DataContract.Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena_Request>(DatosEntrada);
            DataContract.Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena_Response response = new DataContract.Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena_Response();
            try
            {
                response.listElementoVisibilidad = oBL_GES_MapsService.Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena(request.codCliente, request.codCanal, request.codCadena, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena_Response>(response);
            return responseJSON;
        }
        public string Obtener_Presencia_Producto_x_Canal_Cadena(string DatosEntrada)
        {
            DataContract.Obtener_Presencia_Producto_x_Canal_Cadena_Request request = HelperJson.Deserialize<DataContract.Obtener_Presencia_Producto_x_Canal_Cadena_Request>(DatosEntrada);
            DataContract.Obtener_Presencia_Producto_x_Canal_Cadena_Response response = new DataContract.Obtener_Presencia_Producto_x_Canal_Cadena_Response();
            try
            {
                response.listProducto = oBL_GES_MapsService.Obtener_Presencia_Producto_x_Canal_Cadena(request.codCliente, request.codCanal, request.codCadena, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Presencia_Producto_x_Canal_Cadena_Response>(response);
            return responseJSON;
        }
        public string Obtener_Precio_Producto_x_Canal_Cadena(string DatosEntrada)
        {
            DataContract.Obtener_Precio_Producto_x_Canal_Cadena_Request request = HelperJson.Deserialize<DataContract.Obtener_Precio_Producto_x_Canal_Cadena_Request>(DatosEntrada);
            DataContract.Obtener_Precio_Producto_x_Canal_Cadena_Response response = new DataContract.Obtener_Precio_Producto_x_Canal_Cadena_Response();
            try
            {
                response.listProducto = oBL_GES_MapsService.Obtener_Precio_Producto_x_Canal_Cadena(request.codCliente, request.codCanal, request.codCadena, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Precio_Producto_x_Canal_Cadena_Response>(response);
            return responseJSON;
        }
        public string Obtener_PDV_Cluster_x_Canal_Cadena(string DatosEntrada)
        {
            DataContract.Obtener_PDV_Cluster_x_Canal_Cadena_Request request = HelperJson.Deserialize<DataContract.Obtener_PDV_Cluster_x_Canal_Cadena_Request>(DatosEntrada);
            DataContract.Obtener_PDV_Cluster_x_Canal_Cadena_Response response = new DataContract.Obtener_PDV_Cluster_x_Canal_Cadena_Response();
            try
            {
                response.listPtoVenta = oBL_GES_MapsService.Obtener_PDV_Cluster_x_Canal_Cadena(request.codCliente, request.codCanal, request.codCadena, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_PDV_Cluster_x_Canal_Cadena_Response>(response);
            return responseJSON;
        }
        public string Obtener_Datos_PDV_x_Cliente(string DatosEntrada)
        {
            DataContract.Obtener_Datos_PDV_x_Cliente_Request request = HelperJson.Deserialize<DataContract.Obtener_Datos_PDV_x_Cliente_Request>(DatosEntrada);
            DataContract.Obtener_Datos_PDV_x_Cliente_Response response = new DataContract.Obtener_Datos_PDV_x_Cliente_Response();
            try
            {
                response.ptoVenta = oBL_GES_MapsService.Obtener_Datos_PDV_x_Cliente(request.codCliente, request.codPtoVenta ,request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Datos_PDV_x_Cliente_Response>(response);
            return responseJSON;
        }
        public string Obtener_Presencia_Producto_x_PDV(string DatosEntrada)
        {
            DataContract.Obtener_Presencia_Producto_x_PDV_Request request = HelperJson.Deserialize<DataContract.Obtener_Presencia_Producto_x_PDV_Request>(DatosEntrada);
            DataContract.Obtener_Presencia_Producto_x_PDV_Response response = new DataContract.Obtener_Presencia_Producto_x_PDV_Response();
            try
            {
                response.listProducto = oBL_GES_MapsService.Obtener_Presencia_Producto_x_PDV(request.codCliente, request.codPtoVenta, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Presencia_Producto_x_PDV_Response>(response);
            return responseJSON;
        }
        public string Obtener_Precio_Producto_x_PDV(string DatosEntrada)
        {
            DataContract.Obtener_Precio_Producto_x_PDV_Request request = HelperJson.Deserialize<DataContract.Obtener_Precio_Producto_x_PDV_Request>(DatosEntrada);
            DataContract.Obtener_Precio_Producto_x_PDV_Response response = new DataContract.Obtener_Precio_Producto_x_PDV_Response();
            try
            {
                response.listProducto = oBL_GES_MapsService.Obtener_Precio_Producto_x_PDV(request.codCliente, request.codPtoVenta, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Precio_Producto_x_PDV_Response>(response);
            return responseJSON;
        }
        public string Obtener_MaterialApoyo_x_PDV(string DatosEntrada)
        {
            DataContract.Obtener_MaterialApoyo_x_PDV_Request request = HelperJson.Deserialize<DataContract.Obtener_MaterialApoyo_x_PDV_Request>(DatosEntrada);
            DataContract.Obtener_MaterialApoyo_x_PDV_Response response = new DataContract.Obtener_MaterialApoyo_x_PDV_Response();
            try
            {
                response.listElementoVisibilidad = oBL_GES_MapsService.Obtener_MaterialApoyo_x_PDV(request.codCliente, request.codPtoVenta, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_MaterialApoyo_x_PDV_Response>(response);
            return responseJSON;
        }
        public string Obtener_PDV_x_Cliente(string DatosEntrada)
        {
            DataContract.Obtener_PDV_x_Cliente_Request request = HelperJson.Deserialize<DataContract.Obtener_PDV_x_Cliente_Request>(DatosEntrada);
            DataContract.Obtener_PDV_x_Cliente_Response response = new DataContract.Obtener_PDV_x_Cliente_Response();
            try
            {
                response.listPtoVenta = oBL_GES_MapsService.Obtener_PDV_x_Cliente(request.codCliente, request.codCanal, request.codCadena, request.reportsPlanning);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.Obtener_PDV_x_Cliente_Response>(response);
            return responseJSON;
        }

        #endregion

        #region Alicorp
        //Add 15/11/2012 psa.
        public string Obtener_PDV_x_Cliente_Canal(string DatosEntrada) {
            DataContract.Obtener_PDV_x_Cliente_Canal_Request request = HelperJson.Deserialize<DataContract.Obtener_PDV_x_Cliente_Canal_Request>(DatosEntrada);
            DataContract.Obtener_PDV_x_Cliente_Canal_Response response = new DataContract.Obtener_PDV_x_Cliente_Canal_Response();
            try {
                response.oListE_PuntoDeVenta = oBL_GES_MapsService.Obtener_PDV_x_Cliente_Canal(request.CodCliente, request.CodCanal);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_PDV_x_Cliente_Canal_Response>(response);
            return responseJSON;

        }
        //Add 15/11/2012 Psa
        public string Obtener_PDV_x_Cliente_Canal_PDV(string DatosEntrada) {
            DataContract.Obtener_PDV_x_Cliente_Canal_PDV_Request request = HelperJson.Deserialize<DataContract.Obtener_PDV_x_Cliente_Canal_PDV_Request>(DatosEntrada);
            DataContract.Obtener_PDV_x_Cliente_Canal_PDV_Response response = new DataContract.Obtener_PDV_x_Cliente_Canal_PDV_Response();
            try {
                response.oListE_PuntoDeVenta = oBL_GES_MapsService.Obtener_PDV_x_Cliente_Canal_PDV(request.CodCliente, request.CodCanal, request.CodPDV);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex) {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_PDV_x_Cliente_Canal_PDV_Response>(response);
            return responseJSON;
        }

        /**********************************************/
        //Add 15/11/2012 Psa ****
        public string Obtener_DatosFiltro_x_Persona(string DatosEntrada)
        {
            DataContract.Obtener_DatosFiltro_x_Persona_Request request = HelperJson.Deserialize<DataContract.Obtener_DatosFiltro_x_Persona_Request>(DatosEntrada);
            DataContract.Obtener_DatosFiltro_x_Persona_Response response = new DataContract.Obtener_DatosFiltro_x_Persona_Response();
            try
            {
                response.oE_DatosFiltros = oBL_GES_MapsService.Obtener_DatosFiltro_x_Persona(request.CodPersona);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_DatosFiltro_x_Persona_Response>(response);
            return responseJSON;
        }
        //Add 15/11/2012 Psa ****
        public string Obtener_Canal_x_Cliente_Persona(string DatosEntrada)
        {
            DataContract.Obtener_Canal_x_Cliente_Persona_Request request = HelperJson.Deserialize<DataContract.Obtener_Canal_x_Cliente_Persona_Request>(DatosEntrada);
            DataContract.Obtener_Canal_x_Cliente_Persona_Response response = new DataContract.Obtener_Canal_x_Cliente_Persona_Response();
            try
            {
                response.oListE_Canal = oBL_GES_MapsService.Obtener_Canal_x_Cliente_Persona(request.CodCliente,request.CodPersona);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Canal_x_Cliente_Persona_Response>(response);
            return responseJSON;
        }
        //Add 15/11/2012 Psa ****
        public string Obtener_Anios_x_Cliente_Canal(string DatosEntrada)
        {
            DataContract.Obtener_Anios_x_Cliente_Canal_Request request = HelperJson.Deserialize<DataContract.Obtener_Anios_x_Cliente_Canal_Request>(DatosEntrada);
            DataContract.Obtener_Anios_x_Cliente_Canal_Response response = new DataContract.Obtener_Anios_x_Cliente_Canal_Response();
            try
            {
                response.oListE_Anio = oBL_GES_MapsService.Obtener_Anios_x_Cliente_Canal(request.CodCliente, request.CodCanal);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Anios_x_Cliente_Canal_Response>(response);
            return responseJSON;
        }
        //Add 15/11/2012 Psa ***
        public string Obtener_Mes_x_Cliente_Canal_Anio(string DatosEntrada)
        {
            DataContract.Obtener_Mes_x_Cliente_Canal_Anio_Request request = HelperJson.Deserialize<DataContract.Obtener_Mes_x_Cliente_Canal_Anio_Request>(DatosEntrada);
            DataContract.Obtener_Mes_x_Cliente_Canal_Anio_Response response = new DataContract.Obtener_Mes_x_Cliente_Canal_Anio_Response();
            try
            {
                response.oListE_Mes = oBL_GES_MapsService.Obtener_Mes_x_Cliente_Canal_Anio(request.CodCliente, request.CodCanal, request.Anio);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Mes_x_Cliente_Canal_Anio_Response>(response);
            return responseJSON;
        }
        //Add 15/11/2012 Psa ***
        public string Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo(string DatosEntrada)
        {
            DataContract.Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo_Request request = HelperJson.Deserialize<DataContract.Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo_Request>(DatosEntrada);
            DataContract.Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo_Response response = new DataContract.Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo_Response();
            try
            {
                response.oListE_Periodo = oBL_GES_MapsService.Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Reporte(request.CodCliente, request.CodCanal,request.Anio,request.Mes, request.CodReporte);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo_Response>(response);
            return responseJSON;
        }
        //Add 15/11/2012 Psa ***
        public string Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep(string DatosEntrada)
        {
            DataContract.Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep_Request request = HelperJson.Deserialize<DataContract.Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep_Request>(DatosEntrada);
            DataContract.Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep_Response response = new DataContract.Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep_Response();
            try
            {
                response.oListE_Categoria = oBL_GES_MapsService.Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep(request.CodCliente, request.CodCanal, request.Anio, request.Mes, request.Periodo, request.Departamento, request.CodReporte);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep_Response>(response);
            return responseJSON;
        }
        //Add 15/11/2012 Psa ***
        public string Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep(string DatosEntrada)
        {
            DataContract.Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep_Request request = HelperJson.Deserialize<DataContract.Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep_Request>(DatosEntrada);
            DataContract.Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep_Response response = new DataContract.Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep_Response();
            try
            {
                response.oListE_Producto = oBL_GES_MapsService.Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep(request.CodCliente, request.CodCanal, request.Anio,request.Mes,request.Periodo,request.CodCategoria,request.CodDepartamento,request.CodReporte);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep_Response>(response);
            return responseJSON;
        }
        //Add 15/11/2012 Psa ***
        public string Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto(string DatosEntrada)
        {
            DataContract.Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Request request = HelperJson.Deserialize<DataContract.Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Request>(DatosEntrada);
            DataContract.Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Response response = new DataContract.Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Response();
            try
            {
                response.oListE_Resumen = oBL_GES_MapsService.Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto(request.CodCliente, request.CodCanal, request.Anio, request.Mes,request.Periodo,request.CodDepartamento);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception ex)
            {
                response.Descripcion = "No existen datos.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Response>(response);
            return responseJSON;
        }
        /**********************************************/
        #endregion

    }
}