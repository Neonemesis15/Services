using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IGes_MapsService
    {
        #region Colgate

        #region Xplora Maps - Lima
        /// <summary>
        /// Fecha:       18/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna la representatividad por zona o distrito
        ///     0: Zona
        ///     1: Distrito
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Representatividad")]
        string Obtener_Representatividad(string DatosEntrada);

        /// <summary>
        /// Fecha:       18/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna la presencia por zona o distrito
        ///     0: Zona
        ///     1: Distrito
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Presencia_ZonaDistrito")]
        string Obtener_Presencia_ZonaDistrito(string DatosEntrada);

        /// <summary>
        /// Fecha:       18/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna la venta por zona o distrito
        ///     0: Zona
        ///     1: Distrito
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Ventas_ZonaDistrito")]
        string Obtener_Ventas_ZonaDistrito(string DatosEntrada);

        /// <summary>
        /// Fecha:       18/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los puntos de venta
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntosVentaMapa")]
        string Obtener_PuntosVentaMapa(string DatosEntrada);

        /// <summary>
        /// Fecha:       18/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna las provincias por código de departamento
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Provincia_Por_CodDepartamento")]
        string Obtener_Provincia_Por_CodDepartamento(string DatosEntrada);

        /// <summary>
        /// Fecha:       18/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna las provincias por código de departamento
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Sector_Por_PaisDepartamentoProvincia")]
        string Obtener_Sector_Por_PaisDepartamentoProvincia(string DatosEntrada);

        /// <summary>
        /// Fecha:       20/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos del puntos de venta
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_DatosPuntosVentaMapa")]
        string Obtener_DatosPuntosVentaMapa(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna la presencia por punto de venta
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Presencia_PuntoVenta")]
        string Obtener_Presencia_PuntoVenta(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los elementos de visibilidad por punto de venta
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_ElemVisibilida_PuntoVenta")]
        string Obtener_ElemVisibilida_PuntoVenta(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna las ventas por punto de venta
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Venta_PuntoVenta")]
        string Obtener_Venta_PuntoVenta(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna las fotos principales por punto de venta
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Foto_PuntoVenta")]
        string Obtener_Foto_PuntoVenta(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna el historial de fotos por punto de venta
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_HistorialFoto_PuntoVenta")]
        string Obtener_HistorialFoto_PuntoVenta(string DatosEntrada);

        /// <summary>
        /// Fecha:       25/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los departamentos por código de pais
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Departamento_Por_CodPais")]
        string Obtener_Departamento_Por_CodPais(string DatosEntrada);

        /// <summary>
        /// Fecha:       25/07/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los distritos por ubigeo y sector
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Distrito_Por_CodSector")]
        string Obtener_Distrito_Por_CodSector(string DatosEntrada);

        /// <summary>
        /// Fecha:       27/07/2012
        /// Creado:      Ditmar Estrada
        /// Descripción: Retorna la presencia de un elemento por distritos 
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PresenciaZonaDistritoMap")]
        string Obtener_PresenciaZonaDistritoMap(string DatosEntrada);

        /// <summary>
        /// Fecha:       03/08/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos de cluster por zonas o distritos
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_ClusterZonaDistritoMap")]
        string Obtener_ClusterZonaDistritoMap(string DatosEntrada);

        /// <summary>
        /// Fecha:       03/08/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los tipos de cluster
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_TipoCluster")]
        string Obtener_TipoCluster();


        /// <summary>
        /// Fecha:       06/08/2012
        /// Creado:      Ditmar Estrada
        /// Descripción: Retorna la presencia de productos en los puntos de venta 
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaCluster")]
        string Obtener_PuntoVentaCluster(string DatosEntrada);


        /// <summary>
        /// Fecha:       07/08/2012
        /// Creado:      Ditmar Estrada
        /// Descripción: Retorna la presencia de productos en los puntos de venta 
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaMapaVentas")]
        string Obtener_PuntoVentaMapaVentas(string DatosEntrada);

        /// <summary>
        /// Fecha:       10/08/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna la presencia de productos en los puntos de venta, segun la cobertura
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaSKU")]
        string Obtener_PuntoVentaPresenciaSKU(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/08/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos para dibujar el grafico de tendencia (Presencia vs Ventas)
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Grafico_Tendencia")]
        string Obtener_Grafico_Tendencia(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/08/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos para dibujar el grafico de variacion (Ventas)
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Grafico_Variacion")]
        string Obtener_Grafico_Variacion(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/08/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos para dibujar el grafico de evolución de ventas de los SKU Mandatorios
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Evolucion_Venta_SKUMandatorios")]
        string Evolucion_Venta_SKUMandatorios(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/08/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos para dibujar el grafico de evolución de presencia de los SKU Mandatorios
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Evolucion_Presencia_SKUMandatorios")]
        string Evolucion_Presencia_SKUMandatorios(string DatosEntrada);

        /// <summary>
        /// Fecha:       24/08/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos para dibujar el grafico de variación detallada de ventas
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Variacion_Detallada_Ventas")]
        string Variacion_Detallada_Ventas(string DatosEntrada);

        /// <summary>
        /// Fecha:       03/09/2012
        /// Creado:      Pablo Salas A.
        /// Descripción: Retorna la Evolucion de Ventas de SKU Mandatorios por (Zona o Distrito) y (Mensual o Semanal)
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "EvolucionVentaSKUMandatorios")]
        string EvolucionVentaSKUMandatorios(string DatosEntrada);


        /// <summary>
        /// Fecha:       05/09/2012
        /// Creado:      Pablo Salas A.
        /// Descripción: Retorna la Evolucion de Presencia de SKU Mandatorios por (Zona o Distrito) y (Mensual o Semanal)
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "EvolucionPresenciaSKUMandatorios")]
        string EvolucionPresenciaSKUMandatorios(string DatosEntrada);


        /// <summary>
        /// Fecha:       10/09/2012
        /// Creado:      Joseph Gonzales.
        /// Descripción: Retorna la representatividad y cluster
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Representatividad_And_Cluster")]
        string Obtener_Representatividad_And_Cluster(string DatosEntrada);

        /// <summary>
        /// Fecha:       11/09/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna la presencia de elementos de visibilidad en los puntos de venta
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaElemVisibilidad")]
        string Obtener_PuntoVentaPresenciaElemVisibilidad(string DatosEntrada);

        /// <summary>
        /// Fecha:       11/09/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los puntos de venta que conforman un rango
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaRango")]
        string Obtener_PuntoVentaPresenciaRango(string DatosEntrada);

        /// <summary>
        /// Fecha:       12/09/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los puntos de venta que conforman un rango. Para ser exportados a Excel.
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaRangoToExcel")]
        string Obtener_PuntoVentaPresenciaRangoToExcel(string DatosEntrada);

        /// <summary>
        /// Fecha:       12/09/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna la presencia de productos en los puntos de venta, segun la cobertura. Para ser exportados a Excel.
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaSKUToExcel")]
        string Obtener_PuntoVentaPresenciaSKUToExcel(string DatosEntrada);

        /// <summary>
        /// Fecha:       12/09/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna la presencia de elementos de visibilidad en los puntos de venta. Para ser exportados a Excel.
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaElemVisibilidadToExcel")]
        string Obtener_PuntoVentaPresenciaElemVisibilidadToExcel(string DatosEntrada);

        /// <summary>
        /// Fecha:       27/09/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos del gráfico de tendencia
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Datos_Tendencia")]
        string Obtener_Datos_Tendencia(string DatosEntrada);

        /// <summary>
        /// Fecha:       27/09/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos del gráfico de variación
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Datos_Variacion")]
        string Obtener_Datos_Variacion(string DatosEntrada);

        /// <summary>
        /// Fecha:       04/10/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Retorna los datos del seguimiento a la ruta de un mercaderista
        /// </summary>
        /// <param name="DatosEntrada"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Seguimiento_Generador")]
        string Obtener_Seguimiento_Generador(string DatosEntrada);
        #endregion

        #region Xplora Maps - Provincia
        #region Sección Universo >>Warning<<
        //1.-Total de PDV’s por ciudad.(considerar periodo).
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_ClusterZonaDistritoMap_Prov")]
        string Obtener_ClusterZonaDistritoMap_Prov(string DatosEntrada);
        //2.-Total de PDV’s visitados por ciudad y a su vez éstos por clúster.(considerar periodo).
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Representatividad_And_Cluster_Prov")]
        string Obtener_Representatividad_And_Cluster_Prov(string DatosEntrada);
        //3.-Total de PDV's  por Cluster
        //Pendiente

        #endregion

        #region Sección - Presencia SKU Mandatorio
        //1.-Porcentaje de Presencia por Rangos.(considerar periodo).
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Presencia_ZonaDistrito_Prov")]
        string Obtener_Presencia_ZonaDistrito_Prov(string DatosEntrada);
        //08/11/2012 Psa.
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaCluster_Prov")]
        string Obtener_PuntoVentaCluster_Prov(string DatosEntrada);
        //2.-Cantidad PDV’s x SKU Mandatorio.(considerar periodo).
        //Se Reutiliza public List<E_ElemVisibilidadZonaDistrito> Obtener_Presencia_ElemeVisibilidad_ZonaDistrito(int servicio, string canal, int codCliente, string codciudad, string codZona, string codDistrito, int reportsPlanning)
        //UP_WEBXPLORA_PRESENCIA_ELEMVISIB_MAPS
        //1.1.-Pintar Mapa por Rangos
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaRango_Prov")]
        string Obtener_PuntoVentaPresenciaRango_Prov(string DatosEntrada);
        //1.2.-Exportar a Excel por Rangos
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaRangoToExcel_Prov")]
        string Obtener_PuntoVentaPresenciaRangoToExcel_Prov(string DatosEntrada);
        //2.1.-Pintar Mapa PDV con SKUMandatorio
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaSKU_Prov")]
        string Obtener_PuntoVentaPresenciaSKU_Prov(string DatosEntrada);
        //2.2.-Exportar a Excel por SKUMandatorios
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaSKUToExcel_Prov")]
        string Obtener_PuntoVentaPresenciaSKUToExcel_Prov(string DatosEntrada);

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
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaElemVisibilidadToExcel_Prov")]
        string Obtener_PuntoVentaPresenciaElemVisibilidadToExcel_Prov(string DatosEntrada);
        //3.2 Pintar Puntos en Mapa PDV
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_PuntoVentaPresenciaElemVisibilidad_Prov")]
        string Obtener_PuntoVentaPresenciaElemVisibilidad_Prov(string DatosEntrada);
        #endregion

        #region Sección - Graficos
        //1.- Ventas vs Presencia: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
        //Obtener_Grafico_Tendencia
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Grafico_Tendencia_Prov")]
        string Obtener_Grafico_Tendencia_Prov(string DatosEntrada);
        
        [OperationContract()]//Add 09/11/2012
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Datos_Tendencia_Prov")]
        string Obtener_Datos_Tendencia_Prov(string DatosEntrada);
        //2.-Variación de Ventas: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
        //Obtener_Grafico_Variacion
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Grafico_Variacion_Prov")]
        string Obtener_Grafico_Variacion_Prov(string DatosEntrada);
        
        [OperationContract()]//Add 09/11/2012
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Datos_Variacion_Prov")]
        string Obtener_Datos_Variacion_Prov(string DatosEntrada);
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

        /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna la cobertura de pdv x canal
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Cobertura_PDV_x_Canal_Cadena")]
            string Obtener_Cobertura_PDV_x_Canal_Cadena(string DatosEntrada);

            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna el status de los equipos de frio
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Status_EQF_x_Canal_Cadena")]
            string Obtener_Status_EQF_x_Canal_Cadena(string DatosEntrada);
        
            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna la presencia de los elementos de visibilidad
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena")]
            string Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena(string DatosEntrada);

            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna la presencia de los productos
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Presencia_Producto_x_Canal_Cadena")]
            string Obtener_Presencia_Producto_x_Canal_Cadena(string DatosEntrada);

            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna el precio de los productos
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Precio_Producto_x_Canal_Cadena")]
            string Obtener_Precio_Producto_x_Canal_Cadena(string DatosEntrada);

            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna los puntos de venta por canal
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_PDV_Cluster_x_Canal_Cadena")]
            string Obtener_PDV_Cluster_x_Canal_Cadena(string DatosEntrada);

            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna los datos del puntos de venta
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Datos_PDV_x_Cliente")]
            string Obtener_Datos_PDV_x_Cliente(string DatosEntrada);

            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna la presencia de los productos por Punto de Venta
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Presencia_Producto_x_PDV")]
            string Obtener_Presencia_Producto_x_PDV(string DatosEntrada);

            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna el precio de los productos por Punto de Venta
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Precio_Producto_x_PDV")]
            string Obtener_Precio_Producto_x_PDV(string DatosEntrada);

            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna la cantidad de equipos de frio y elementos de visibilidad
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_MaterialApoyo_x_PDV")]
            string Obtener_MaterialApoyo_x_PDV(string DatosEntrada);

            /// <summary>
            /// Fecha:       26/10/2012
            /// Creado:      Joseph Gonzales
            /// Descripción: Retorna la lista de puntos de venta
            /// </summary>
            /// <param name="DatosEntrada"></param>
            /// <returns></returns>
            [OperationContract()]
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_PDV_x_Cliente")]
            string Obtener_PDV_x_Cliente(string DatosEntrada);
        #endregion

        #region Alicorp
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_PDV_x_Cliente_Canal")]
            string Obtener_PDV_x_Cliente_Canal(string DatosEntrada);
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_PDV_x_Cliente_Canal_PDV")]
            string Obtener_PDV_x_Cliente_Canal_PDV(string DatosEntrada);
            /*********************/
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_DatosFiltro_x_Persona")]
            string Obtener_DatosFiltro_x_Persona(string DatosEntrada);
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Canal_x_Cliente_Persona")]
            string Obtener_Canal_x_Cliente_Persona(string DatosEntrada);
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Anios_x_Cliente_Canal")]
            string Obtener_Anios_x_Cliente_Canal(string DatosEntrada);
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Mes_x_Cliente_Canal_Anio")]
            string Obtener_Mes_x_Cliente_Canal_Anio(string DatosEntrada);
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo")]
            string Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo(string DatosEntrada);
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep")]
            string Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep(string DatosEntrada);
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep")]
            string Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep(string DatosEntrada);
            [OperationContract()]//Add 15/11/2012 psa
            [WebInvoke(Method = "POST", UriTemplate = "Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto")]
            string Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto(string DatosEntrada);
            /*********************/
        #endregion
    }
}