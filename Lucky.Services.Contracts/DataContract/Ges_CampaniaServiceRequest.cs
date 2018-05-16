using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Entity.Common.Application;
using Lucky.Entity.Common.Servicio;
using Lucky.CFG.JavaMovil;

namespace Lucky.Services.Contracts.DataContract
{
    public class Ges_CampaniaServiceRequest
    {

    }

    #region Gestion de Canales
    public class Listar_Canales_Por_CodCompania_Request
    {
        [JsonProperty("a")]
        public string CodCompania { get; set; }
    }
    public class Listar_Canales_Por_CodCompania_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Canal> oListaCanal { get; set; }
    }
    /// <summary>
    /// Fecha: 11/05/2012
    /// Autor: Joseph Gonzales
    /// </summary>
    public class Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina_Request
    {
        [JsonProperty("a")]
        public string CodCliente { get; set; }

        [JsonProperty("b")]
        public string CodPersona { get; set; }

        [JsonProperty("c")]
        public string CodOficina { get; set; }
    }
    public class Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Canal> oListaCanal { get; set; }
    }
    #endregion
    #region Gestion de Campania
    public class Listar_Campania_Por_CodCanal_y_CodCompania_Request
    {
        [JsonProperty("a")]
        public string CodCanal { get; set; }
        [JsonProperty("b")]
        public string CodCompania { get; set; }
    }
    public class Listar_Campania_Por_CodCanal_y_CodCompania_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Campania> oListaCampania { get; set; }
    }
    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class Listar_Seguimiento_Campaña_Request
    {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCampania { get; set; }
    }
    public class Listar_Seguimiento_Campaña_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Seguimiento> olistaSeguimiento { get; set; }
    }
    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class registarPlanning_Request
    {
        [JsonProperty("a")]
        public E_Planning oE_Planning { get; set; }
    }
    public class registrarPlanning_Response : BaseResponse
    {

    }

    #endregion
    #region Gestion de Reporte
    public class Listar_Reporte_Por_CodCampania_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
    }
    public class Listar_Reporte_Por_CodCampania_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Reporte> oListaReporte { get; set; }
    }
    /// <summary>
    /// Fecha: 10/10/2012
    /// Autor: Peter Ccopa
    /// </summary>
    public class Listar_Sub_Reporte_Request
    {
        [JsonProperty("a")]
        public string CodReporte { get; set; }

        [JsonProperty("b")]
        public string CodCompania { get; set; }

        [JsonProperty("c")]
        public string CodChanel { get; set; }

    }
    public class Listar_Sub_Reporte_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Sub_Reporte> oListaSubReporte { get; set; }
    }
    #endregion
    #region Gestion de Categoria
    public class Listar_Categoria_Por_CodCampania_y_CodReporte_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
        [JsonProperty("b")]
        public string CodReporte { get; set; }
    }
    public class Listar_Categoria_Por_CodCampania_y_CodReporte_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Categoria> oListaCategoria { get; set; }
    }

    ////////////////////////////
    public class Listar_Categoria_Por_CodCampania_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
    }
    public class Listar_Categoria_Por_CodCampania_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Categoria> oListaCategoria { get; set; }
    }

    /// <summary>
    /// Fecha: 11/05/2012
    /// Autor: Joseph Gonzales
    /// </summary>
    public class Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte_Request
    {
        [JsonProperty("a")]
        public string CodCliente { get; set; }

        [JsonProperty("b")]
        public string CodCanal { get; set; }

        [JsonProperty("c")]
        public string CodReporte { get; set; }
    }
    public class Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Categoria> oListaCategoria { get; set; }
    }
    #endregion
    #region Gestion de Marca
    public class Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodReporte { get; set; }

        [JsonProperty("c")]
        public string CodCategoria { get; set; }
    }
    public class Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Marca> oListaMarca { get; set; }
    }
    /// <summary>
    /// /////////////
    /// </summary>

    public class Listar_Marca_Por_CodCategoria_Request
    {
        [JsonProperty("a")]
        public string CodCategoria { get; set; }
    }
    public class Listar_Marca_Por_CodCategoria_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Marca> oListaMarca { get; set; }
    }
    #endregion
    #region Gestion de Supervisor
    public class Listar_Supervisor_Por_CodCampania_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
    }
    public class Listar_Supervisor_Por_CodCampania_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Persona> oListaSupervisor { get; set; }
    }
    #endregion
    #region Gestion de Generador
    public class Listar_Generadores_Por_CodSupervisor_Request
    {
        [JsonProperty("a")]
        public string CodCompania { get; set; }
        [JsonProperty("b")]
        public string CodSupervisor { get; set; }
    }
    public class Listar_Generadores_Por_CodSupervisor_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Persona> oListaGenerador { get; set; }
    }
    public class Person_Request
    {
        [JsonProperty("a")]
        public string CodServicio { get; set; }
        [JsonProperty("b")]
        public string CodCliente { get; set; }
        [JsonProperty("c")]
        public string CodCanal { get; set; }
        [JsonProperty("d")]
        public string año { get; set; }
        [JsonProperty("e")]
        public string mes { get; set; }
        [JsonProperty("f")]
        public string CodPeriodo { get; set; }
        [JsonProperty("g")]
        public string CodCiudad { get; set; }
        [JsonProperty("h")]
        public string CodZona { get; set; }
    }
    public class Person_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Persona> oListaGenerador { get; set; }
    }
    #endregion

    #region Gestion de Generador por Campaña FechaRelevo
    public class Listar_Generadores_Por_CodCampania_FechaRelevo_Request
    {
        [JsonProperty("a")]
        public string CodCompania { get; set; }
        [JsonProperty("b")]
        public string FechaRelevo { get; set; }
    }
    public class Listar_Generadores_Por_CodCampania_FechaRelevo_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Persona> oListaGenerador { get; set; }
    }
    #endregion

    #region Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel
    public class Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel_Request
    {
        [JsonProperty("a")]
        public string CodCompania { get; set; }
        [JsonProperty("b")]
        public string CodDpto { get; set; }
        [JsonProperty("c")]
        public string CodProvincia { get; set; }
        [JsonProperty("d")]
        public string CodDistrito { get; set; }
        [JsonProperty("e")]
        public string Fecha_Relevo { get; set; }
    }
    public class Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Persona> oListaGenerador { get; set; }
    }
    #endregion

    #region Obtener_Usuario
    /// <summary>
    /// Fecha: 11/10/2012
    /// Autor: Peter Ccopa
    /// </summary>
    public class Obtener_Usuario_Request
    {
        [JsonProperty("a")]
        public string idPerson { get; set; }

    }
    public class Obtener_Usuario_Response : BaseResponse
    {
        [JsonProperty("a")]
        public Lucky.Entity.Common.Application.EUsuario oObtenerUsuario { get; set; }
    }

    #endregion
    #region Gestion de Punto de Venta
    public class Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
        [JsonProperty("b")]
        public string CodOficina { get; set; }
    }
    public class Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_PuntoDeVenta> oListaPDV { get; set; }
    }

    //Add 03/05/2012 PSA
    public class Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
        [JsonProperty("b")]
        public string CodOficina { get; set; }
        [JsonProperty("c")]
        public string CodGenerador { get; set; }
    }
    public class Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_PuntoDeVenta> oListaPDV { get; set; }
    }


    #region Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha
    public class Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
        [JsonProperty("b")]
        public string CodDpto { get; set; }
        [JsonProperty("c")]
        public string CodProv { get; set; }
        [JsonProperty("d")]
        public string CodDist { get; set; }
        [JsonProperty("e")]
        public string CodGenerador { get; set; }
        [JsonProperty("f")]
        public string FechaRelevo { get; set; }
    }
    public class Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_PuntoDeVenta> oListaPDV { get; set; }
    }
    #endregion

    public class Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodOficina { get; set; }

        [JsonProperty("c")]
        public string CodCadena { get; set; }
    }
    public class Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_PuntoDeVenta> oListaPDV { get; set; }
    }
    public class Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodCiudad { get; set; }

        [JsonProperty("c")]
        public string CodCadena { get; set; }
    }
    public class Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_PuntoDeVenta> oListaPDV { get; set; }
    }
    public class Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial_Request
    {
        [JsonProperty("a")]
        public string Cod_Campania { get; set; }
        [JsonProperty("b")]
        public string Cod_Departamento { get; set; }
        [JsonProperty("c")]
        public string Cod_Provincia { get; set; }
        [JsonProperty("d")]
        public string Cod_NodoCommercial { get; set; }
    }
    public class Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_PuntoDeVenta> oListE_PuntoDeVenta { get; set; }
    }
    /// <summary>
    /// Author      : Pablo Salas A.
    /// Fecha       : 26/09/2012
    /// Descripcion : Listar PuntosDeVenta por CodCompania
    /// </summary>
    public class Listar_PuntoDeVenta_Por_CodCompania_Request {
        [JsonProperty("a")]
        public string Cod_Campania { get; set; }
    }
    public class Listar_PuntoDeVenta_Por_CodCompania_Response : BaseResponse {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_PuntoDeVenta> oListE_PuntoDeVenta { get; set; }
    }
    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class listarPuntodeVentaPlanning_Request
    {
        [JsonProperty("a")]
        public string codOficina { get; set; }
        [JsonProperty("b")]
        public string codDpto { get; set; }
        [JsonProperty("c")]
        public string codProvincia { get; set; }
        [JsonProperty("d")]
        public string codDistrito { get; set; }
        [JsonProperty("e")]
        public string codtipoagrupacion { get; set; }
        [JsonProperty("f")]
        public string codagrupacion { get; set; }
        [JsonProperty("g")]
        public string codregion { get; set; }
        [JsonProperty("h")]
        public string codzona { get; set; }
    }
    public class listarPuntodeVentaPlanning_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_PuntodeVentaPlanning> listarPuntodeVentaPlanning { get; set; }
    }
    #endregion
    #region Gestion de Oficina
    /// <summary>
    /// Fecha: 11/05/2012
    /// Autor: Joseph Gonzales
    /// </summary>
    public class Listar_Oficinas_Por_CodPersona_Request
    {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
    }
    public class Listar_Oficinas_Por_CodPersona_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Oficina> oListaOficina { get; set; }
    }
    public class Listar_Oficinas_Por_CodCampania_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
    }
    public class Listar_Oficinas_Por_CodCampania_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Oficina> oListaOficina { get; set; }
    }


    public class Listar_Oficinas_Por_CodCampania_CodSupervisor_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
        [JsonProperty("b")]
        public string CodSupervisor { get; set; }
    }
    public class Listar_Oficinas_Por_CodCampania_CodSupervisor_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Oficina> oListaOficina { get; set; }
    }

    /// <summary>
    /// Fecha: 31/08/2012
    /// Author: Pablo Salas A.
    /// Descripcion: Listar Oficinas por CodCompania
    /// </summary>
    public class Listar_Oficinas_Por_CodCompania_Request
    {
        [JsonProperty("a")]
        public string CodCompania { get; set; }
    }
    public class Listar_Oficinas_Por_CodCompania_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Oficina> oListaE_Oficina { get; set; }
    }

    /// <summary>
    /// Autor:Giam Farfan
    /// Fecha:27/09/2012
    /// 
    /// </summary>
    public class Listar_Oficinas_Por_CodPais_CodCliente_CodCampania_Request
    {
        [JsonProperty("a")]
        public string codPais { get; set; }
        [JsonProperty("b")]
        public string codCliente { get; set; }
        [JsonProperty("c")]
        public string codCampania { get; set; }
    }
    public class Listar_Oficinas_Por_CodPais_CodCliente_CodCampania_Response:BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Oficina> olistaOficinas { get; set; }
    }
    #endregion
    #region Gestion de Periodo
    /// <summary>
    /// Fecha: 11/05/2012
    /// Autor: Joseph Gonzales
    /// </summary>
    public class Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes_Request
    {
        [JsonProperty("a")]
        public string CodServicio { get; set; }

        [JsonProperty("b")]
        public string CodCanal { get; set; }

        [JsonProperty("c")]
        public string CodCliente { get; set; }

        [JsonProperty("d")]
        public string CodReporte { get; set; }

        [JsonProperty("e")]
        public string Anio { get; set; }

        [JsonProperty("f")]
        public string Mes { get; set; }
    }
    public class Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Periodo> oListaPeriodo { get; set; }
    }
    #endregion
    #region Gestion de NodoCommercial
    /// <summary>
    /// Fecha: 14/05/2012
    /// Autor: Joseph Gonzales
    /// </summary>
    public class Listar_Cadena_Por_CodCampania_y_CodOficina_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodOficina { get; set; }
    }
    public class Listar_Cadena_Por_CodCampania_y_CodOficina_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Cadena> oListaCadena { get; set; }
    }
    public class Listar_Cadena_Por_CodCliente_y_CodCanal_Request
    {
        [JsonProperty("a")]
        public string CodCliente { get; set; }

        [JsonProperty("b")]
        public string CodCanal { get; set; }
    }
    public class Listar_Cadena_Por_CodCliente_y_CodCanal_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Cadena> oListaCadena { get; set; }
    }
    public class Listar_NodeComercial_Por_CodCampania_CodCiudad_Request
    {
        [JsonProperty("a")]
        public string id_NodeCommercial { get; set; }
        [JsonProperty("b")]
        public string commercialNodeName { get; set; }
        [JsonProperty("c")]
        public string idNodeComType { get; set; }
        [JsonProperty("d")]
        public string NodeCommercial_Status { get; set; }
        [JsonProperty("e")]
        public string NodeCommercial_CreateBy { get; set; }
        [JsonProperty("f")]
        public string NodeCommercial_DateBy { get; set; }
        [JsonProperty("g")]
        public string NodeCommercial_ModiBy { get; set; }
        [JsonProperty("h")]
        public string NodeCommercial_DatemodiBy { get; set; }
    }
    public class Listar_NodeComercial_Por_CodCampania_CodCiudad_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_NodeComercial> oListaNodeComercial { get; set; }
    }
    public class Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Request
    {
        [JsonProperty("a")]
        public string Cod_Campania { get; set; }
        [JsonProperty("b")]
        public string Cod_Departamento { get; set; }
        [JsonProperty("c")]
        public string Cod_Provincia { get; set; }
    }
    public class Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_NodeComercial> oListE_NodeComercial { get; set; }
    }

    public class Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito_Request
    {
        [JsonProperty("a")]
        public string Cod_Campania { get; set; }
        [JsonProperty("b")]
        public string Cod_Departamento { get; set; }
        [JsonProperty("c")]
        public string Cod_Provincia { get; set; }
        [JsonProperty("d")]
        public string Cod_Distrito { get; set; }
    }
    public class Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_NodeComercial> oListE_NodeComercial { get; set; }
    }

    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia_Request
    {
        [JsonProperty("a")]
        public string codCampania { get; set; }
        [JsonProperty("b")]
        public string codOficina { get; set; }
        [JsonProperty("c")]
        public string codDepartamento { get; set; }
        [JsonProperty("d")]
        public string codProvincia { get; set; }
    }
    public class listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_NodeComercial_Type> listarNodeComercial_Type { get; set; }
    }
    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia_Request
    {
        [JsonProperty("a")]
        public string codCampania { get; set; }
        [JsonProperty("b")]
        public string idNodeComercial_Type { get; set; }
        [JsonProperty("c")]
        public string codOficina { get; set; }
        [JsonProperty("d")]
        public string codDepartamento { get; set; }
        [JsonProperty("e")]
        public string codProvincia { get; set; }

    }
    public class listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_NodeComercial> listarNodeComercial { get; set; }
    }
    #endregion
    #region Gestion de SubCategoria
    /// <summary>
    /// Fecha: 14/05/2012
    /// Autor: Joseph Gonzales
    /// </summary>
    public class ListarSubCategoria_Por_CodCategoria_Request
    {
        [JsonProperty("a")]
        public string CodCategoria { get; set; }
    }
    public class ListarSubCategoria_Por_CodCategoria_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_SubCategoria> oListaSubCategoria { get; set; }
    }
    #endregion
    #region Gestion de Productos
    /// <summary>
    /// Fecha: 14/05/2012
    /// Autor: Joseph Gonzales
    /// </summary>
    public class Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodCategoria { get; set; }

        [JsonProperty("c")]
        public string CodSubCategoria { get; set; }

        [JsonProperty("d")]
        public string CodMarca { get; set; }
    }
    public class Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Producto> oListaProducto { get; set; }
    }
    /// <summary>
    /// Fecha: 09/08/2012
    /// Autor: Joseph Gonzales
    /// </summary>
    public class Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }

        [JsonProperty("b")]
        public string CodCliente { get; set; }

        [JsonProperty("c")]
        public string CodCategoria { get; set; }

        [JsonProperty("d")]
        public string CodSubCategoria { get; set; }

        [JsonProperty("e")]
        public string CodMarca { get; set; }
    }
    public class Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Producto> oListaProducto { get; set; }
    }

    #endregion
    #region Gestion de Ciudad
    public class Listar_Ciudad_Por_CodCampania_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }


    }
    public class Listar_Ciudad_Por_CodCampania_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Ciudad> ListaCiudad { get; set; }
    }
    public class Listar_Ciudad_Por_CodDepartamento_Request
    {
        [JsonProperty("a")]
        public string Cod_Departamento { get; set; }
    }
    public class Listar_Ciudad_Por_CodDepartamento_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_Ciudad> oListE_Ciudad { get; set; }
    }

    public class Listar_Ciudad_Por_CodCampania_CodDepartamento_Request
    {
        [JsonProperty("a")]
        public string Cod_Campania { get; set; }
        [JsonProperty("b")]
        public string Cod_Departamento { get; set; }
    }
    public class Listar_Ciudad_Por_CodCampania_CodDepartamento_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_Ciudad> oListE_Ciudad { get; set; }
    }
    #endregion
    #region Gestion de Budget
    /// <summary>
    /// Autor: Pablo Salas A.
    /// Fecha: 18/07/2012
    /// Descripción: Request y Response para Obtener los Budget por CodCompania y CodOpcion
    /// </summary>
    public class Listar_Budget_Por_CodCompania_CodOpcion_Request
    {
        [JsonProperty("a")]
        public string Cod_Compania { get; set; }
        [JsonProperty("b")]
        public string Cod_Opcion { get; set; }
    }
    public class Listar_Budget_Por_CodCompania_CodOpcion_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Budget> oListE_Budget { get; set; }
    }


    /// Autor: Pablo Salas A.
    /// Fecha: 19/07/2012
    /// Descripción: Devuelve los Budget por CodCompania , CodBudget,  CodOpcion
    public class Listar_Budget_Por_CodCompania_CodBudget_CodOpcion_Request
    {
        [JsonProperty("a")]
        public string Cod_Compania { get; set; }
        [JsonProperty("b")]
        public string Cod_Budget { get; set; }
        [JsonProperty("c")]
        public string Cod_Opcion { get; set; }
    }
    public class Listar_Budget_Por_CodCompania_CodBudget_CodOpcion_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Budget> oListE_Budget { get; set; }
    }
    #endregion
    #region Gestion de Departamento
    public class Listar_Departamento_Por_CodCampania_Request
    {
        [JsonProperty("a")]
        public string Cod_Compania { get; set; }
    }
    public class Listar_Departamento_Por_CodCampania_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_Departamento> oListE_Departamento { get; set; }
    }
    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina_Request
    {
        [JsonProperty("a")]
        public string CodCliente { get; set; }
        [JsonProperty("b")]
        public string CodCampania { get; set; }
        [JsonProperty("c")]
        public string codPais { get; set; }
        [JsonProperty("d")]
        public string codOficina { get; set; }
    }
    public class listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_Departamento> listaDepartamentos { get; set; }
    }
    #endregion
    #region Gestion Unicos

    ///Descripcion  : Listar Menús por CodPersona, dependiendo el Perfil y la Compañia de la Persona, mostrar los Reportes Asociados.
    ///Fecha        : 04/05/2012 PSA
    public class Listar_Menu_Por_CodPersona_Request {
        [JsonProperty("a")]
        public string CodPersona { get; set; }
    }
    public class Listar_Menu_Por_CodPersona_Response :BaseResponse {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Menu> oListaMenu { get; set; }
    }
    
    ///Descripcion  : Llena el Reporte Stock Alicorp para que pueda registrar Cantidad y Observaciones.
    ///Fecha        : 05/05/2012 PSA
    public class Llenar_Reporte_Stock_Alicorp_Request {
        [JsonProperty("a")]
        public string CodCompania { get; set; }
        [JsonProperty("b")]
        public string CodReporte { get; set; }
        [JsonProperty("c")]
        public string CodCategoria { get; set; }
    }
    public class Llenar_Reporte_Stock_Alicorp_Response : BaseResponse {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Reporte_Stock_Alicorp> oListaReporte { get; set; }
    
    }

    /// <summary>
    /// Fecha: 10/05/2012
    /// Descripción: Entidades Request y Response para llenar el reporte general.
    /// Módulos: Digitación,....
    /// Autor: Joseph Gonzales
    /// </summary>
    //public class LLenar_Reporte_General_Filtro
    //{
    //    [JsonProperty("a")]
    //    public string CodCompania { get; set; }

    //    [JsonProperty("b")]
    //    public string CodReporte { get; set; }

    //    [JsonProperty("c")]
    //    public string CodCategoria { get; set; }

    //    [JsonProperty("d")]
    //    public string CodMarca { get; set; }

    //    [JsonProperty("e")]
    //    public string CodFamilia { get; set; }

    //    [JsonProperty("f")]
    //    public string CodSubFamilia { get; set; }

    //    [JsonProperty("g")]
    //    public string CodOficina { get; set; }

    //    [JsonProperty("h")]
    //    public string CodGestor { get; set; }

    //    [JsonProperty("i")]
    //    public string CodPDV { get; set; }
    //}

    //public class Llenar_Reporte_General_Request
    //{
    //    [JsonProperty("a")]
    //    public LLenar_Reporte_General_Filtro ReporteFiltros { get; set; }
    //}


    public class Llenar_Reporte_General_Request
    {
        [JsonProperty("a")]
        public E_Filtros_Llenar_Reporte_General ReporteFiltros { get; set; }
    }
    public class Llenar_Reporte_General_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Reporte_General> oListaReporte { get; set; }

        ///solo para reporte exhibicion alicorp AASS
        [JsonProperty("b")]
        public List<Lucky.Entity.Common.Servicio.E_Reporte_General> oListaCondicionExhibicion { get; set; }
    }

    /// <summary>
    /// Fecha: 19/09/2012
    /// Autor: Peter Ccopa
    /// </summary>
    public class Llenar_Reporte_Bodegas_Request
    {
        [JsonProperty("a")]
        public E_Filtros_Llenar_Reporte_General ReporteFiltros { get; set; }
    }
    public class Llenar_Reporte_Bodegas_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Reporte_Bodegas> oListaReporte { get; set; }

        ///solo para reporte exhibicion alicorp AASS
        [JsonProperty("b")]
        public List<Lucky.Entity.Common.Servicio.E_Reporte_Bodegas> oListaCondicionExhibicion { get; set; }
    }

    #endregion
    #region Gestion Anios
    /// <summary>
    /// Fecha: 14/05/2012
    /// Autor: Joseph Gonzales
    /// </summary>
    public class Listar_Anios_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Anio> oListaAnios { get; set; }
    }
    #endregion
    #region Gestion Meses
    public class Listar_Meses_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Mes> oListaMes { get; set; }
    }
    #endregion
    #region Gestion de Provincia
    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
        [JsonProperty("b")]
        public string codPais { get; set; }
        [JsonProperty("c")]
        public string codOficina { get; set; }
        [JsonProperty("d")]
        public string codDepartamento { get; set; }
    }
    public class listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_Provincia> listaProvincias { get; set; }
    }
    #endregion
    #region Gestion de Distritos
    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
        [JsonProperty("b")]
        public string codPais { get; set; }
        [JsonProperty("c")]
        public string codOficina { get; set; }
        [JsonProperty("d")]
        public string codDepartamento { get; set; }
        [JsonProperty("e")]
        public string codProvincia { get; set; }
    }
    public class listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_Distrito> listaDistritos { get; set; }
    }
    #endregion
    #region Gestion Region
    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia_Request
    {
        [JsonProperty("a")]
        public string codCampania { get; set; }
        [JsonProperty("b")]
        public string codOficina { get; set; }
        [JsonProperty("c")]
        public string codDepartamento { get; set; }
        [JsonProperty("d")]
        public string codProvincia { get; set; }
    }
    public class listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Region> listarRegion { get; set; }
    }
    #endregion
    #region Gestion Sector
    /// <summary>
    /// Author: Giam Farfan
    /// </summary>
    public class listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia_Request
    {
        [JsonProperty("a")]
        public string codCampania { get; set; }
        [JsonProperty("b")]
        public string codRegion { get; set; }
        [JsonProperty("c")]
        public string codOficina { get; set; }
        [JsonProperty("d")]
        public string codDepartamento { get; set; }
        [JsonProperty("e")]
        public string codProvincia { get; set; }
    }
    public class listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Lucky.Entity.Common.Servicio.E_Sector> listarSector { get; set; }
    }
    #endregion
    #region Gestion de Dias
    /// <summary>
    /// Fecha   : 24/09/2012
    /// Author  : Pablo Salas Alvarez.
    /// Descripcion: Obtener los Dias.
    /// </summary>
    public class Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo_Request {
        [JsonProperty("a")]
        public E_Filtros oE_Filtros { get; set; }
    }
    public class Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo_Response : BaseResponse {
        [JsonProperty("a")]
        public List<string> oListDias { get; set; }
    }
    #endregion
    #region Gestion de Rutas
    /// <summary>
    /// Author      : Pablo Salas A.
    /// Fecha       : 26/09/2012
    /// Descripcion : 
    /// </summary>
    public class Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Request {
        [JsonProperty("a")]
        public string Cod_Compania { get; set; }
        [JsonProperty("b")]
        public string Cod_Campania { get; set; }
        [JsonProperty("c")]
        public string Cod_Persona { get; set; }
        [JsonProperty("d")]//Add 08/11/2012
        public string Fecha { get; set; }
        [JsonProperty("e")]//Add GF 14/11/2012
        public string Opcion { get; set; }
    }
    public class Listar_Rutas_Por_CodCompania_CodCampania_CodPersona_Response : BaseResponse {
        [JsonProperty("a")]
        public List<E_PuntodeVentaPlanningRuta> oListE_PuntodeVentaPlanningRuta { get; set; }
    }

    /// <summary>
    /// Author: Giam Farfan
    /// Fecha: 30/10/2012
    /// </summary>
    public class updateRuta_Request
    {
        [JsonProperty("a")]
        public string nroRuta { get; set; }
        [JsonProperty("b")]
        public string fechainicio { get; set; }
        [JsonProperty("c")]
        public string fechafin { get; set; }
    }
    public class updateRuta_Response:BaseResponse 
    {

    }

    /// <summary>
    /// Autor: Giam Farfan
    /// Descripcion: Actualizar el estado de una ruta.
    /// Fecha:13/11/2012
    /// </summary>
    public class actualizarEstadoRuta_Request
    {
        [JsonProperty("a")]
        public string nroRuta { get; set; }

        [JsonProperty("b")]
        public int valor { get; set; }
    }
    public class actualizarEstadoRuta_Response : BaseResponse
    {

    }
    #endregion

    #region Gestion de Cadenas
    /// <summary>
    /// Fecha   : 28/09/2012
    /// Author  : Peter Ccopa
    /// Descripcion: Obtener las Cadenas.
    /// </summary>
    public class Listar_Cadenas_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
        [JsonProperty("b")]
        public string codGenerador { get; set; }
        [JsonProperty("c")]
        public string FechaRelevo { get; set; }
    }
    public class Listar_Cadenas_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_NodeComercial> listaCadenas { get; set; }
    }
    #endregion

    #region Gestion de Parametros
    /// <summary>
    /// Fecha   : 30/10/2012
    /// Author  : Peter Ccopa
    /// Descripcion: Obtener parametros.
    /// </summary>
    public class obtener_Parametro_Request
    {
        [JsonProperty("a")]
        public string Tipo { get; set; }
    }
    public class obtener_Parametro_Response : BaseResponse
    {
        [JsonProperty("a")]
        public Entity.Common.Servicio.E_Parametros listaParametros { get; set; }
    }
    #endregion

    #region Obtener Nro OC
    /// <summary>
    /// Fecha   : 25/10/2012
    /// Author  : Peter Ccopa
    /// Descripcion: Obtener correlativo de OC.
    /// </summary>
    public class obtener_NroOrdenCompra_Request
    {
        [JsonProperty("a")]
        public string Nro_OC { get; set; }
        [JsonProperty("b")]
        public string Tipo_Doc { get; set; }
    }
    public class obtener_NroOrdenCompra_Response : BaseResponse
    {
        [JsonProperty("a")]
        public Entity.Common.Servicio.E_Correlativo obtenerOC { get; set; }
    }
    #endregion

    #region Gestion de Proveedores
    /// <summary>
    /// Fecha   : 23/10/2012
    /// Author  : Peter Ccopa
    /// Descripcion: Obtener los Proveedores.
    /// </summary>
    public class Listar_Proveedores_Request
    {
        [JsonProperty("a")]
        public string CodProv { get; set; }

    }
    public class Listar_Proveedores_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_Proveedor> listaProveedores { get; set; }
    }
    #endregion

    #region Gestion de Menu Datamercaderista
    /// <summary>
    /// Fecha   : 16/10/2012
    /// Author  : Peter Ccopa
    /// Descripcion: Obtener Menu Datamercaderista.
    /// </summary>
    public class Listar_Menu_Datamercaderista_Request
    {
        [JsonProperty("a")]
        public string CodModulo { get; set; }
    }
    public class Listar_Menu_Datamercaderista_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_MenuDatamercaderista> listaMenu_Datamercaderista { get; set; }
    }
    #endregion

    #region Gestion de Ordenes de Compras
    /// <summary>
    /// Author: Peter Ccopa
    /// </summary>
    public class ListarOrdenCompra_Cabecera_Request
    {
        [JsonProperty("a")]
        public string Nro_OC { get; set; }
    }
    public class ListarOrdenCompra_Cabecera_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_OrdenCompra> listaOrdenCompra { get; set; }
    }

    /// <summary>
    /// Author: Peter Ccopa
    /// </summary>
    public class ListarOrdenCompra_Detalle_Request
    {
        [JsonProperty("a")]
        public string Nro_OC { get; set; }
    }
    public class ListarOrdenCompra_Detalle_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_OrdenCompraDetalle> listaOrdenCompraDet { get; set; }
    }
    #endregion

    #region Gestion de PDVCadenas
    /// <summary>
    /// Fecha   : 28/09/2012
    /// Author  : Peter Ccopa
    /// Descripcion: Obtener los PDV por Merc y Cadena.
    /// </summary>
    public class Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena_Request
    {
        [JsonProperty("a")]
        public string CodCampania { get; set; }
        [JsonProperty("b")]
        public string codGenerador { get; set; }
        [JsonProperty("c")]
        public string codCadena { get; set; }
        [JsonProperty("d")]
        public string FechaRelevo { get; set; }
    }
    public class Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<Entity.Common.Servicio.E_PuntoDeVenta> listaCadenas { get; set; }
    }
    #endregion

    #region Gestion de Reportes
    /// <summary>
    /// Fecha: 08/11/2012
    /// Autor: Peter Ccopa
    /// </summary>
    //public class Llenar_Reporte_Exhibicion_Request
    //{
    //    [JsonProperty("a")]
    //    public E_Filtros_Reporte ReporteFiltros { get; set; }
    //}
    //public class Llenar_Reporte_Exhibicion_Response : BaseResponse
    //{
    //    [JsonProperty("a")]
    //    public List<Lucky.Entity.Common.Servicio.E_Reporte_Exhibicion> oListaReporteExhibicion { get; set; }

    //}
    #endregion
}