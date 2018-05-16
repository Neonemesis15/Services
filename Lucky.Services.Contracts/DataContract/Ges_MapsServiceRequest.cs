using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Servicio;

namespace Lucky.Services.Contracts.DataContract
{
    public class Ges_MapsServiceRequest
    {
        
    }

    #region Colgate

    #region Xplora - Provincia
    #region Sección Universo >>Warning<<
    //1.-Total de PDV’s por ciudad.(considerar periodo).
    public class ClusterZonaDistritoMap_Prov_Request
    {
        [JsonProperty("a")]
        public string codZona { get; set; }

        [JsonProperty("b")]
        public string codDistrito { get; set; }

        [JsonProperty("c")]
        public string idPlanning { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }

        [JsonProperty("e")]
        public string codOficina { get; set; }
    }
    public class ClusterZonaDistritoMap_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ClusterZonaDistrito_Group clusterZonaDistritoMap { get; set; }
    }
    //2.-Total de PDV’s visitados por ciudad y a su vez éstos por clúster.(considerar periodo).
    public class Representatividad_And_Cluster_Prov_Request
    {
        [JsonProperty("a")]
        public string codZona { get; set; }

        [JsonProperty("b")]
        public string codDistrito { get; set; }

        [JsonProperty("c")]
        public string idPlanning { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }

        [JsonProperty("e")]
        public string codOficina { get; set; }
    }
    public class Representatividad_And_Cluster_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ClusterZonaDistrito_Group clusterZonaDistritoMap { get; set; }

        [JsonProperty("b")]
        public E_Representatividad_Group representatividadZonaDistritoMap { get; set; }
    }
    //3.-Total de PDV's  por Cluster
    //Pendiente
    #endregion

    #region Sección - Presencia SKU Mandatorio
    //1.-Porcentaje de Presencia por Rangos.(considerar periodo).
    public class Obtener_PresenciaZonaDistrito_Prov_Request
    {
        [JsonProperty("a")]
        public int servicio { get; set; }

        [JsonProperty("b")]
        public string canal { get; set; }

        [JsonProperty("c")]
        public int codCliente { get; set; }

        [JsonProperty("d")]
        public string codDepartamento { get; set; }

        [JsonProperty("e")]
        public string codciudad { get; set; }

        [JsonProperty("f")]
        public string codZona { get; set; }

        [JsonProperty("g")]
        public string codDistrito { get; set; }

        [JsonProperty("h")]
        public int reportsPlanning { get; set; }

        [JsonProperty("i")]
        public string codOficina { get; set; }
    }
    public class Obtener_PresenciaZonaDistrito_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaZonaDistrito> listaPresencia { get; set; }

        [JsonProperty("b")]
        public List<E_ElemVisibilidadZonaDistrito> listaElementosVisibilidad { get; set; }
    }

    public class PuntoVentaCluster_Prov_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codPais { get; set; }

        [JsonProperty("c")]
        public string codDepartamento { get; set; }

        [JsonProperty("d")]
        public string codProvincia { get; set; }

        [JsonProperty("e")]
        public string codZona { get; set; }

        [JsonProperty("f")]
        public string codDistrito { get; set; }

        [JsonProperty("g")]
        public string cluster { get; set; }

        [JsonProperty("h")]
        public string codPeriodo { get; set; }

        [JsonProperty("i")]//Add 08/11/2012
        public string codOficina { get; set; }

    }
    public class PuntoVentaCluster_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PuntoVentaCluster> oListPuntoVentaCluster { get; set; }

    }
    //2.-Cantidad PDV’s x SKU Mandatorio.(considerar periodo).
    //Se Reutiliza public List<E_ElemVisibilidadZonaDistrito> Obtener_Presencia_ElemeVisibilidad_ZonaDistrito(int servicio, string canal, int codCliente, string codciudad, string codZona, string codDistrito, int reportsPlanning)
    //UP_WEBXPLORA_PRESENCIA_ELEMVISIB_MAPS
    //1.1.-Pintar Mapa por Rangos
    public class PuntoVentaPresenciaRango_Prov_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codPais { get; set; }

        [JsonProperty("c")]
        public string codDepartamento { get; set; }

        [JsonProperty("d")]
        public string codProvincia { get; set; }

        [JsonProperty("e")]
        public string codZona { get; set; }

        [JsonProperty("f")]
        public string codDistrito { get; set; }

        [JsonProperty("g")]
        public string codRango { get; set; }

        [JsonProperty("h")]
        public string codPeriodo { get; set; }

        [JsonProperty("i")]
        public string codOficina { get; set; }
    }
    public class PuntoVentaPresenciaRango_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaPDV> oListPuntoVenta { get; set; }
    }
    //1.2.-Exportar a Excel por Rangos
    //PuntoVentaPresenciaRango_Prov_Request -- Reutilizado
    //PuntoVentaPresenciaRango_Prov_Response --Reutilizado
    public class PuntoVentaPresenciaRangoToExcel_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel oExportExcel { get; set; }
    }
    //2.1.-Pintar Mapa PDV con SKUMandatorio
    public class PuntoVentaPresenciaSKU_Prov_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codPais { get; set; }

        [JsonProperty("c")]
        public string codDepartamento { get; set; }

        [JsonProperty("d")]
        public string codProvincia { get; set; }

        [JsonProperty("e")]
        public string codZona { get; set; }

        [JsonProperty("f")]
        public string codDistrito { get; set; }

        [JsonProperty("g")]
        public string codProducto { get; set; }

        [JsonProperty("h")]
        public string codPeriodo { get; set; }

        [JsonProperty("i")]
        public string codOficina { get; set; }
    }
    public class PuntoVentaPresenciaSKU_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaPDV> oListPuntoVenta { get; set; }
    }
    //2.2.-Exportar a Excel por SKUMandatorios
    //PuntoVentaPresenciaSKU_Prov_Request  -- Reutilizado
    //PuntoVentaPresenciaSKU_Prov_Response -- Reutilizado
    public class PuntoVentaPresenciaSKUToExcel_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel oExportExcel { get; set; }
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

    public class PuntoVentaPresenciaElemVisibilidad_Prov_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codPais { get; set; }

        [JsonProperty("c")]
        public string codDepartamento { get; set; }

        [JsonProperty("d")]
        public string codProvincia { get; set; }

        [JsonProperty("e")]
        public string codZona { get; set; }

        [JsonProperty("f")]
        public string codDistrito { get; set; }

        [JsonProperty("g")]
        public string codElemento { get; set; }

        [JsonProperty("h")]
        public string codPeriodo { get; set; }

        [JsonProperty("i")]
        public string codOficina { get; set; }
    }
    public class PuntoVentaPresenciaElemVisibilidad_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaPDV> oListPuntoVenta { get; set; }
    }
    public class PuntoVentaPresenciaElemVisibilidadToExcel_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel oExportExcel { get; set; }
    }
    //3.2 Pintar Puntos en Mapa PDV
    #endregion

    #region Sección - Graficos
    //1.- Ventas vs Presencia: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
    //Obtener_Grafico_Tendencia
    public class GraficoTendencia_Prov_Request
    {
        [JsonProperty("a")]
        public string codServicio { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCliente { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDepartamento { get; set; }

        [JsonProperty("f")]
        public string codProvincia { get; set; }

        [JsonProperty("g")]
        public string codZona { get; set; }

        [JsonProperty("h")]
        public string codDistrito { get; set; }

        [JsonProperty("i")]
        public string codCategoria { get; set; }

        [JsonProperty("j")]
        public string codProducto { get; set; }

        [JsonProperty("k")]
        public string codCluster { get; set; }

        [JsonProperty("l")]
        public string anio { get; set; }

        [JsonProperty("m")]
        public string mes { get; set; }

        [JsonProperty("n")]
        public string codPeriodo { get; set; }

        [JsonProperty("o")]
        public string codOpcion { get; set; }

        [JsonProperty("p")]
        public string codOficina { get; set; }
    }
    public class GraficoTendencia_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Grafico_Tendencia> oListGraficoTendencia { get; set; }
    }
    //2.-Variación de Ventas: Semana/Mes, Categoría, SKU, Clúster (8 últimos).
    //Obtener_Grafico_Variacion
    public class GraficoVariacion_Prov_Request
    {
        [JsonProperty("a")]
        public string codServicio { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCliente { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDepartamento { get; set; }

        [JsonProperty("f")]
        public string codProvincia { get; set; }

        [JsonProperty("g")]
        public string codZona { get; set; }

        [JsonProperty("h")]
        public string codDistrito { get; set; }

        [JsonProperty("i")]
        public string codCategoria { get; set; }

        [JsonProperty("j")]
        public string codProducto { get; set; }

        [JsonProperty("k")]
        public string codCluster { get; set; }

        [JsonProperty("l")]
        public string anio { get; set; }

        [JsonProperty("m")]
        public string mes { get; set; }

        [JsonProperty("n")]
        public string codPeriodo { get; set; }

        [JsonProperty("o")]
        public string codOpcion { get; set; }

        [JsonProperty("p")]
        public string codOficina { get; set; }
    }
    public class GraficoVariacion_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Grafico_Variacion> oListGraficoVariacion { get; set; }
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

    #region Xplora - Lima
    #endregion

    public class Obtener_Representatividad_Request
    {
        [JsonProperty("a")]
        public int tipo { get; set; }

        [JsonProperty("b")]
        public string codigo { get; set; }
    }
    public class Obtener_Representatividad_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Representatividad representatividad { get; set; }
    }

    public class Obtener_PresenciaZonaDistrito_Request
    {
        [JsonProperty("a")]
        public int servicio { get; set; }

        [JsonProperty("b")]
        public string canal { get; set; }

        [JsonProperty("c")]
        public int codCliente { get; set; }

        [JsonProperty("d")]
        public string codDepartamento { get; set; }

        [JsonProperty("e")]
        public string codciudad { get; set; }

        [JsonProperty("f")]
        public string codZona { get; set; }

        [JsonProperty("g")]
        public string codDistrito { get; set; }

        [JsonProperty("h")]
        public int reportsPlanning { get; set; }
    }
    public class Obtener_PresenciaZonaDistrito_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaZonaDistrito> listaPresencia { get; set; }

        [JsonProperty("b")]
        public List<E_ElemVisibilidadZonaDistrito> listaElementosVisibilidad { get; set; }
    }

    public class Obtener_VentaZonaDistrito_Request
    {
        [JsonProperty("a")]
        public int tipo { get; set; }

        [JsonProperty("b")]
        public string codigo { get; set; }

        [JsonProperty("c")]
        public int reportsPlanning { get; set; }
    }
    public class Obtener_VentaZonaDistrito_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_VentasZonaDistrito> listaVentas { get; set; }
    }

    public class Obtener_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string codEquipo { get; set; }

        [JsonProperty("b")]
        public string codGenerador { get; set; }

        [JsonProperty("c")]
        public string reportsPlanning { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDepartamento { get; set; }

        [JsonProperty("f")]
        public string codProvincia { get; set; }

        [JsonProperty("g")]
        public string codSector { get; set; }

        [JsonProperty("h")]
        public string codDistrito { get; set; }
    }
    public class Obtener_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PuntoVentaMapa> listaPuntosVenta { get; set; }
    }

    public class Obtener_Provincia_Por_CodDepartamento_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }

        [JsonProperty("b")]
        public string codDepartamento { get; set; }
    }
    public class Obtener_Provincia_Por_CodDepartamento_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Provincia> listaProvincias { get; set; }
    }

    public class Obtener_Sector_Por_PaisDepartamentoProvincia_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }

        [JsonProperty("b")]
        public string codDepartamento { get; set; }

        [JsonProperty("c")]
        public string codProvincia { get; set; }
    }
    public class Obtener_Sector_Por_PaisDepartamentoProvincia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Sector> listaSector { get; set; }
    }

    public class Obtener_DatosPuntosVentaMapa_Request
    {
        [JsonProperty("a")]
        public string codPtoVenta { get; set; }

        [JsonProperty("b")]
        public string reportsPlanning { get; set; }
    }
    public class Obtener_DatosPuntosVentaMapa_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_PuntoVentaDatosMapa ptoVenta { get; set; }
    }

    public class Obtener_Presencia_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string codEquipo { get; set; }

        [JsonProperty("b")]
        public string reportsPlanning { get; set; }

        [JsonProperty("c")]
        public string codPtoVenta { get; set; }
    }
    public class Obtener_Presencia_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Presencia_PDV> listaPresenciaPDV { get; set; }
    }

    public class Obtener_ElemVisibilidad_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string codEquipo { get; set; }

        [JsonProperty("b")]
        public string reportsPlanning { get; set; }

        [JsonProperty("c")]
        public string codPtoVenta { get; set; }
    }
    public class Obtener_ElemVisibilidad_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_ElemVisibilidad_PDV> listaElemVisibilidadPDV { get; set; }
    }

    public class Obtener_Venta_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string codEquipo { get; set; }

        [JsonProperty("b")]
        public string reportsPlanning { get; set; }

        [JsonProperty("c")]
        public string codPtoVenta { get; set; }
    }
    public class Obtener_Venta_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Ventas_PDV> listaVentaPDV { get; set; }
    }

    public class Obtener_Foto_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string reportsPlanning { get; set; }

        [JsonProperty("b")]
        public string codPtoVenta { get; set; }
    }
    public class Obtener_Foto_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Foto_PDV fotoPDV { get; set; }
    }

    public class Obtener_HistorialFoto_PuntoVenta_Request
    {
        [JsonProperty("a")]
        public string reportsPlanning { get; set; }

        [JsonProperty("b")]
        public string codPtoVenta { get; set; }
    }
    public class Obtener_HistorialFoto_PuntoVenta_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_HistorialFoto_PDV> listaHistorialFotoPDV { get; set; }
    }

    public class Obtener_Departamento_Por_CodPais_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }
    }
    public class Obtener_Departamento_Por_CodPais_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Departamento> listaDeparamentos { get; set; }
    }

    public class Obtener_Distrito_Por_CodSector_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }

        [JsonProperty("b")]
        public string codDepartamento { get; set; }

        [JsonProperty("c")]
        public string codProvincia { get; set; }

        [JsonProperty("d")]
        public string codSector { get; set; }
    }
    public class Obtener_Distrito_Por_CodSector_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Distrito> listaDistritos { get; set; }
    }

    public class PresenciaZonaDistritoMap_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codDepartamento { get; set; }

        [JsonProperty("c")]
        public string codProvincia { get; set; }

        [JsonProperty("d")]
        public string codZona { get; set; }

        [JsonProperty("e")]
        public string codDistrito { get; set; }

        [JsonProperty("f")]
        public string codCategoria { get; set; }

        [JsonProperty("g")]
        public string codProducto { get; set; }

        [JsonProperty("h")]
        public string codPeriodo { get; set; }

        [JsonProperty("i")]
        public string opcion { get; set; }
    }
    public class PresenciaZonaDistritoMap_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaZonaDistritoMap> ListPresenciaZonaDistritoMap { get; set; }
    }

    public class ClusterZonaDistritoMap_Request
    {
        [JsonProperty("a")]
        public string codZona { get; set; }

        [JsonProperty("b")]
        public string codDistrito { get; set; }

        [JsonProperty("c")]
        public string idPlanning { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }
    }
    public class ClusterZonaDistritoMap_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ClusterZonaDistrito_Group clusterZonaDistritoMap { get; set; }
    }
    
    public class TipoCluster_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_TipoCluster> ListTipoCluster { get; set; }
    }

    public class PuntoVentaCluster_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codPais { get; set; }

        [JsonProperty("c")]
        public string codDepartamento { get; set; }

        [JsonProperty("d")]
        public string codProvincia { get; set; }

        [JsonProperty("e")]
        public string codZona { get; set; }

        [JsonProperty("f")]
        public string codDistrito { get; set; }

        [JsonProperty("g")]
        public string cluster { get; set; }

        [JsonProperty("h")]
        public string codPeriodo { get; set; }

    }
    public class PuntoVentaCluster_Response:BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PuntoVentaCluster> oListPuntoVentaCluster { get; set; }

    }
    public class PuntoVentaMapaVentas_Request
    {

        [JsonProperty("a")]
        public string codPais { get; set; }

        [JsonProperty("b")]
        public string codDepartamento { get; set; }

        [JsonProperty("c")]
        public string codProvincia { get; set; }

        [JsonProperty("d")]
        public string codZona { get; set; }

        [JsonProperty("e")]
        public string codDistrito { get; set; }

        [JsonProperty("f")]
        public string codCategoria { get; set; }

        [JsonProperty("g")]
        public string codProducto { get; set; }

        [JsonProperty("h")]
        public string codCluster { get; set; }

        [JsonProperty("i")]
        public string codPlanning { get; set; }

        [JsonProperty("j")]
        public string codPeriodo { get; set; }
    }
    public class PuntoVentaMapaVentas_Response:BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PuntoVentaMapaVentas> oListPuntoVentaMapaVentas { get; set; }
    }

    public class PuntoVentaPresenciaSKU_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codPais { get; set; }

        [JsonProperty("c")]
        public string codDepartamento { get; set; }

        [JsonProperty("d")]
        public string codProvincia { get; set; }

        [JsonProperty("e")]
        public string codZona { get; set; }

        [JsonProperty("f")]
        public string codDistrito { get; set; }

        [JsonProperty("g")]
        public string codProducto { get; set; }

        [JsonProperty("h")]
        public string codPeriodo { get; set; }
    }
    public class PuntoVentaPresenciaSKU_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaPDV> oListPuntoVenta { get; set; }
    }

    public class PuntoVentaPresenciaSKUToExcel_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel oExportExcel { get; set; }
    }

    public class GraficoTendencia_Request
    {
        [JsonProperty("a")]
        public string codServicio { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCliente { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDepartamento { get; set; }

        [JsonProperty("f")]
        public string codProvincia { get; set; }

        [JsonProperty("g")]
        public string codZona { get; set; }

        [JsonProperty("h")]
        public string codDistrito { get; set; }

        [JsonProperty("i")]
        public string codCategoria { get; set; }

        [JsonProperty("j")]
        public string codProducto { get; set; }

        [JsonProperty("k")]
        public string codCluster { get; set; }

        [JsonProperty("l")]
        public string anio { get; set; }

        [JsonProperty("m")]
        public string mes { get; set; }

        [JsonProperty("n")]
        public string codPeriodo { get; set; }

        [JsonProperty("o")]
        public string codOpcion { get; set; }
    }
    public class GraficoTendencia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Grafico_Tendencia> oListGraficoTendencia { get; set; }
    }

    public class GraficoVariacion_Request
    {
        [JsonProperty("a")]
        public string codServicio { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCliente { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDepartamento { get; set; }

        [JsonProperty("f")]
        public string codProvincia { get; set; }

        [JsonProperty("g")]
        public string codZona { get; set; }

        [JsonProperty("h")]
        public string codDistrito { get; set; }

        [JsonProperty("i")]
        public string codCategoria { get; set; }

        [JsonProperty("j")]
        public string codProducto { get; set; }

        [JsonProperty("k")]
        public string codCluster { get; set; }

        [JsonProperty("l")]
        public string anio { get; set; }

        [JsonProperty("m")]
        public string mes { get; set; }

        [JsonProperty("n")]
        public string codPeriodo { get; set; }

        [JsonProperty("o")]
        public string codOpcion { get; set; }
    }
    public class GraficoVariacion_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Grafico_Variacion> oListGraficoVariacion { get; set; }
    }

    /// <summary>
    /// Author      :
    /// Fecha       :03/09/2012
    /// Descripcion :Evolucion de Ventas de SKUMandatorio X Periodo o Mes y X Zona o Distrito
    /// </summary>
    public class EvolucionVentaSKUMandatorios_Request
    {
        [JsonProperty("a")]
        public E_Filtros_XplMap_Colgate oE_Filtros_XplMap_Colgate { get; set; }
    }

    /// <summary>
    /// Author      :
    /// Fecha       :03/09/2012
    /// Descripcion :Evolucion de Ventas de SKUMandatorio X Periodo o Mes y X Zona o Distrito
    /// </summary>
    public class EvolucionVentaSKUMandatorios_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_VentasZonaDistrito_Detalle oE_VentasZonaDistrito_Detalle { get; set; }
    }
    public class EvolucionVentaSKUMandatorios_Response_List : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_VentasZonaDistrito_Detalle_List> oE_VentasZonaDistrito_Detalle { get; set; }
    }

    /// <summary>
    /// Fecha: 05/09/2012
    /// Author: Pablo Salas A.
    /// Descripcion: Evolucion de Presencia de SKUMandatorios
    /// </summary>
    public class EvolucionPresenciaSKUMandatorios_Request
    {
        
        [JsonProperty("a")]
        public E_Filtros_XplMap_Colgate oE_Filtros_XplMap_Colgate { get; set; }

    }
    public class EvolucionPresenciaSKUMandatorios_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaZonaDistrito_Detalle_List> oE_PresenciaZonaDistrito_Detalle_List { get; set; }
    }


    public class VariacionDetalladaVentas_Request
    {
    }
    public class VariacionDetalladaVentas_Response : BaseResponse
    {
    }

    public class Representatividad_And_Cluster_Request
    {
        [JsonProperty("a")]
        public string codZona { get; set; }

        [JsonProperty("b")]
        public string codDistrito { get; set; }

        [JsonProperty("c")]
        public string idPlanning { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }
    }
    public class Representatividad_And_Cluster_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ClusterZonaDistrito_Group clusterZonaDistritoMap { get; set; }

        [JsonProperty("b")]
        public E_Representatividad_Group representatividadZonaDistritoMap { get; set; }
    }

    public class PuntoVentaPresenciaElemVisibilidad_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codPais { get; set; }

        [JsonProperty("c")]
        public string codDepartamento { get; set; }

        [JsonProperty("d")]
        public string codProvincia { get; set; }

        [JsonProperty("e")]
        public string codZona { get; set; }

        [JsonProperty("f")]
        public string codDistrito { get; set; }

        [JsonProperty("g")]
        public string codElemento { get; set; }

        [JsonProperty("h")]
        public string codPeriodo { get; set; }
    }
    public class PuntoVentaPresenciaElemVisibilidad_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaPDV> oListPuntoVenta { get; set; }
    }

    public class PuntoVentaPresenciaElemVisibilidadToExcel_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel oExportExcel { get; set; }
    }

    public class PuntoVentaPresenciaRango_Request
    {
        [JsonProperty("a")]
        public string codCanal { get; set; }

        [JsonProperty("b")]
        public string codPais { get; set; }

        [JsonProperty("c")]
        public string codDepartamento { get; set; }

        [JsonProperty("d")]
        public string codProvincia { get; set; }

        [JsonProperty("e")]
        public string codZona { get; set; }

        [JsonProperty("f")]
        public string codDistrito { get; set; }

        [JsonProperty("g")]
        public string codRango { get; set; }

        [JsonProperty("h")]
        public string codPeriodo { get; set; }
    }
    public class PuntoVentaPresenciaRango_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PresenciaPDV> oListPuntoVenta { get; set; }
    }

    public class PuntoVentaPresenciaRangoToExcel_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel oExportExcel { get; set; }
    }

    //XploraMaps - Lima
    public class DatosTendenciaSKUMandatorios_Request
    {
        [JsonProperty("a")]
        public string codServicio { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCliente { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDpto { get; set; }

        [JsonProperty("f")]
        public string codCity { get; set; }

        [JsonProperty("g")]
        public string codDistrito { get; set; }

        [JsonProperty("h")]
        public string codSector { get; set; }

        [JsonProperty("i")]
        public string codCluster { get; set; }

        [JsonProperty("j")]
        public string codYear { get; set; }

        [JsonProperty("k")]
        public string codMes { get; set; }

        [JsonProperty("l")]
        public string codPeriodo { get; set; }

        [JsonProperty("m")]
        public string codOpcion { get; set; }
    }
    public class DatosTendenciaSKUMandatorios_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel datosTendencia { get; set; }
    }

    //XploraMaps - Provincias
    public class DatosTendenciaSKUMandatorios_Prov_Request
    {
        [JsonProperty("a")]
        public string codServicio { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCliente { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDpto { get; set; }

        [JsonProperty("f")]
        public string codCity { get; set; }

        [JsonProperty("g")]
        public string codDistrito { get; set; }

        [JsonProperty("h")]
        public string codSector { get; set; }

        [JsonProperty("i")]
        public string codCluster { get; set; }

        [JsonProperty("j")]
        public string codYear { get; set; }

        [JsonProperty("k")]
        public string codMes { get; set; }

        [JsonProperty("l")]
        public string codPeriodo { get; set; }

        [JsonProperty("m")]
        public string codOpcion { get; set; }

        [JsonProperty("n")]//Add 09/11/2012
        public string codOficina { get; set; }
    }
    public class DatosTendenciaSKUMandatorios_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel datosTendencia { get; set; }
    }

    //XploraMaps - Lima
    public class DatosVariacionSKUMandatorios_Request
    {
        [JsonProperty("a")]
        public string codServicio { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }
        
        [JsonProperty("c")]
        public string codCliente { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDpto { get; set; }

        [JsonProperty("f")]
        public string codCity { get; set; }
        
        [JsonProperty("g")]
        public string codDistrito { get; set; }

        [JsonProperty("h")]
        public string codSector { get; set; }
        
        [JsonProperty("i")]
        public string codCluster { get; set; }
        
        [JsonProperty("j")]
        public string codYear { get; set; }
        
        [JsonProperty("k")]
        public string codMes { get; set; }
        
        [JsonProperty("l")]
        public string codPeriodo { get; set; }
        
        [JsonProperty("m")]
        public string codOpcion { get; set; }
    }
    public class DatosVariacionSKUMandatorios_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel datosVariacion { get; set; }
    }
    //XploraMaps - Provincia
    public class DatosVariacionSKUMandatorios_Prov_Request
    {
        [JsonProperty("a")]
        public string codServicio { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCliente { get; set; }

        [JsonProperty("d")]
        public string codPais { get; set; }

        [JsonProperty("e")]
        public string codDpto { get; set; }

        [JsonProperty("f")]
        public string codCity { get; set; }

        [JsonProperty("g")]
        public string codDistrito { get; set; }

        [JsonProperty("h")]
        public string codSector { get; set; }

        [JsonProperty("i")]
        public string codCluster { get; set; }

        [JsonProperty("j")]
        public string codYear { get; set; }

        [JsonProperty("k")]
        public string codMes { get; set; }

        [JsonProperty("l")]
        public string codPeriodo { get; set; }

        [JsonProperty("m")]
        public string codOpcion { get; set; }

        [JsonProperty("n")]//Add 09/11/2012
        public string codOficina { get; set; }
    }
    public class DatosVariacionSKUMandatorios_Prov_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_ExportExcel datosVariacion { get; set; }
    }


    public class Obtener_Seguimiento_Generador_Request
    {
        [JsonProperty("a")]
        public string codEquipo { get; set; }

        [JsonProperty("b")]
        public string codPais { get; set; }

        [JsonProperty("c")]
        public string codDepartamento { get; set; }

        [JsonProperty("d")]
        public string codProvincia { get; set; }

        [JsonProperty("e")]
        public string codDistrito { get; set; }

        [JsonProperty("f")]
        public string codGestor { get; set; }

        [JsonProperty("g")]
        public string fecha { get; set; }
    }
    public class Obtener_Seguimiento_Generador_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Seguimiento_Ruta seguimientoRuta { get; set; }
    }

    #endregion

    #region Backus

    public class Obtener_Cobertura_PDV_x_Canal_Cadena_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCadena { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_Cobertura_PDV_x_Canal_Cadena_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_Cobertura cobertura { get; set; }
    }

    public class Obtener_Status_EQF_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCadena { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_Status_EQF_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Status_EQF> listStatusEQF { get; set; }
    }

    public class Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCadena { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_Presencia_ElementoVisibilidad_x_Canal_Cadena_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Presencia_ElementoVisibilidad> listElementoVisibilidad { get; set; }
    }

    public class Obtener_Presencia_Producto_x_Canal_Cadena_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCadena { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_Presencia_Producto_x_Canal_Cadena_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Presencia_Producto> listProducto { get; set; }
    }

    public class Obtener_Precio_Producto_x_Canal_Cadena_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCadena { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_Precio_Producto_x_Canal_Cadena_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Presencia_Producto> listProducto { get; set; }
    }

    public class Obtener_PDV_Cluster_x_Canal_Cadena_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCadena { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_PDV_Cluster_x_Canal_Cadena_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PuntoVentaMapa> listPtoVenta { get; set; }
    }

    public class Obtener_Datos_PDV_x_Cliente_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codPtoVenta { get; set; }

        [JsonProperty("c")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_Datos_PDV_x_Cliente_Response : BaseResponse
    {
        [JsonProperty("a")]
        public E_PuntoVentaDatosMapa ptoVenta { get; set; }
    }

    public class Obtener_Presencia_Producto_x_PDV_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codPtoVenta { get; set; }

        [JsonProperty("c")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_Presencia_Producto_x_PDV_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Presencia_Producto> listProducto { get; set; }
    }

    public class Obtener_Precio_Producto_x_PDV_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codPtoVenta { get; set; }

        [JsonProperty("c")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_Precio_Producto_x_PDV_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Presencia_Producto> listProducto { get; set; }
    }

    public class Obtener_MaterialApoyo_x_PDV_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codPtoVenta { get; set; }

        [JsonProperty("c")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_MaterialApoyo_x_PDV_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Presencia_ElementoVisibilidad> listElementoVisibilidad { get; set; }
    }

    public class Obtener_PDV_x_Cliente_Request
    {
        [JsonProperty("a")]
        public string codCliente { get; set; }

        [JsonProperty("b")]
        public string codCanal { get; set; }

        [JsonProperty("c")]
        public string codCadena { get; set; }

        [JsonProperty("d")]
        public string reportsPlanning { get; set; }
    }

    public class Obtener_PDV_x_Cliente_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_PuntoVentaDatosMapa> listPtoVenta { get; set; }
    }
    #endregion

    #region Alicorp 
    //Add 15/11/2012 psa.
    public class Obtener_PDV_x_Cliente_Canal_Request {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCanal { get; set; }
    }
    public class Obtener_PDV_x_Cliente_Canal_Response : BaseResponse {
        [JsonProperty("a")]
        public List<E_PuntoDeVenta> oListE_PuntoDeVenta { get; set; }
    }
    //Add 15/11/2012 psa.
    public class Obtener_PDV_x_Cliente_Canal_PDV_Request {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCanal { get; set; }
        [JsonProperty("c")]
        public string CodPDV { get; set; }
    }
    public class Obtener_PDV_x_Cliente_Canal_PDV_Response : BaseResponse {
        [JsonProperty("a")]
        public List<E_PuntoDeVenta> oListE_PuntoDeVenta { get; set; }
    }

    public class Obtener_DatosFiltro_x_Persona_Request {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
    }
    public class Obtener_DatosFiltro_x_Persona_Response : BaseResponse {
        [JsonProperty("a")]
        public E_DatosFiltros oE_DatosFiltros { get; set; } 
    }

    public class Obtener_Canal_x_Cliente_Persona_Request {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodPersona { get; set; }
    }
    public class Obtener_Canal_x_Cliente_Persona_Response :BaseResponse {
        [JsonProperty("a")]
        public List<E_Canal> oListE_Canal { get; set; }
    }

    public class Obtener_Anios_x_Cliente_Canal_Request {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCanal { get; set; }
    }
    public class Obtener_Anios_x_Cliente_Canal_Response : BaseResponse {
        [JsonProperty("a")]
        public List<E_Anio> oListE_Anio { get; set; }
    }

    public class Obtener_Mes_x_Cliente_Canal_Anio_Request {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCanal { get; set; }
        [JsonProperty("c")]
        public string Anio { get; set; }
    }
    public class Obtener_Mes_x_Cliente_Canal_Anio_Response : BaseResponse {
        [JsonProperty("a")]
        public List<E_Mes> oListE_Mes { get; set; }
    }

    public class Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo_Request {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCanal { get; set;}
        [JsonProperty("c")]
        public string Anio { get; set; }
        [JsonProperty("d")]
        public string Mes { get; set; }
        [JsonProperty("e")]
        public string CodReporte { get; set; }
    }
    public class Obtener_Periodo_x_Cliente_Canal_Anio_Mes_Periodo_Response : BaseResponse {
        [JsonProperty("a")]
        public List<E_Periodo> oListE_Periodo { get; set; }
    }

    public class Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep_Request {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCanal { get; set; }
        [JsonProperty("c")]
        public string Anio { get; set; }
        [JsonProperty("d")]
        public string Mes { get; set; }
        [JsonProperty("e")]
        public string Periodo { get; set; }
        [JsonProperty("f")]
        public string Departamento { get; set; }
        [JsonProperty("g")]
        public string CodReporte { get; set; }
    }
    public class Obtener_Categoria_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Rep_Response :BaseResponse {
        [JsonProperty("a")]
        public List<E_Categoria> oListE_Categoria { get; set; }
    }

    public class Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep_Request {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCanal { get; set; }
        [JsonProperty("c")]
        public string Anio { get; set; }
        [JsonProperty("d")]
        public string Mes { get; set; }
        [JsonProperty("e")]
        public string Periodo { get; set; }
        [JsonProperty("f")]
        public string CodCategoria { get; set; }
        [JsonProperty("g")]
        public string CodDepartamento { get; set; }
        [JsonProperty("h")]
        public string CodReporte { get; set; }
    }
    public class Obtener_Sku_x_Cliente_Canal_Anio_Mes_Periodo_Cat_Dpto_Rep_Response : BaseResponse {
        [JsonProperty("a")]
        public List<E_Producto> oListE_Producto { get; set; }
    }

    public class Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Request {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCanal { get; set; }
        [JsonProperty("c")]
        public string Anio { get; set; }
        [JsonProperty("d")]
        public string Mes { get; set; }
        [JsonProperty("e")]
        public string Periodo { get; set; }
        [JsonProperty("f")]
        public string CodDepartamento { get; set; }
    }
    public class Obtener_Resumen_x_Cliente_Canal_Anio_Mes_Periodo_Dpto_Response :BaseResponse {
        [JsonProperty("a")]
        public List<E_Resumen> oListE_Resumen { get; set; }
    }
    #endregion
}