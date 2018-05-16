using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IGes_CampaniaService
    {

        #region Gestion de Canales
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Canales_Por_CodCompania")]
        string Listar_Canales_Por_CodCompania(string DatosLista);

        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 11/05/2012
        /// Descripción: Método que devuelve los canales por código de cliente, código de persona y código de oficina
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina")]
        string Listar_Canal_Por_CodCliente_CodPersona_y_CodOficina(string DatosParametro);

        #endregion
        #region Gestion de Campania
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Campania_Por_CodCanal_y_CodCompania")]
        string Listar_Campania_Por_CodCanal_y_CodCompania(string DatosLista);

        #endregion
        #region Gestion de Reporte
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Reporte_Por_CodCampania")]
        string Listar_Reporte_Por_CodCampania(string DatosLista);

        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       10/09/2012
        /// Descripción: Método que devuelve los subreportes
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Sub_Reportes")]
        string Listar_Sub_Reportes(string DatosParametro);
        #endregion
        #region Gestion de Campania
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Categoria_Por_CodCampania_y_CodReporte")]
        string Listar_Categoria_Por_CodCampania_y_CodReporte(string DatosLista);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Categoria_Por_CodCampania")]
        string Listar_Categoria_Por_CodCampania(string DatosLista);
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Planning")]
        string Registrar_Planning(string DatosReporte);
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Seguimiento_Campania")]
        string Listar_Seguimiento_Campania(string DatosLista);
        #endregion
        #region Gestion de Marca
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria")]
        string Listar_Marca_Por_CodCampania_CodReporte_y_CodCategoria(string DatosLista);
        
        /// <summary>
        /// /
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Marca_Por_CodCategoria")]
        string Listar_Marca_Por_CodCategoria(string DatosLista);
        #endregion
        #region Listar_Generadores_Por_CodCampania_Por_CodSupervisor
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Generadores_Por_CodCampania_Por_CodSupervisor")]
        string Listar_Generadores_Por_CodCampania_Por_CodSupervisor(string DatosLista);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Generadores_Por_CodCanal_Y_CodCliente")]
        string Listar_Generadores_Por_CodCanal_Y_CodCliente(string DatosLista);
        #endregion

        
        #region Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel")]
        string Listar_Generadores_Por_CodCamp_CodDpto_CodProv_CodDist_FechRel(string DatosLista);
        #endregion
        #region Gestion de Usuarios
        /// <summary>
        /// Autor:       Peter Ccopa
        /// Fecha:       11/09/2012
        /// Descripción: Método que devuelve el nombre de usuario
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Obtener_Usuario")]
        string Obtener_Usuario(string DatosParametro);
        #endregion
        #region Listar_Supervisor_Por_CodCampania
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Supervisor_Por_CodCampania")]
        string Listar_Supervisor_Por_CodCampania(string DatosLista);
        #endregion
        #region Gestion de Ofcina
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Oficinas_Por_CodCampania")]
        string Listar_Oficinas_Por_CodCampania(string DatosLista);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Oficinas_Por_CodCampania_Por_CodSupervisor")]
        string Listar_Oficinas_Por_CodCampania_CodSupervisor(string DatosLista);
        #endregion
        #region Gestion de Punto de Venta
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina")]
        string Listar_PuntoDeVenta_Por_CodCampania_y_CodOficina(string DatosLista);
        
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador")]
        string Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodGenerador(string DatosLista);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha")]
        string Listar_PDV_Por_Campania_Dpto_Prov_Dist_Gen_Fecha(string DatosLista);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Generadores_Por_CodCampania_FechaRelevo")]
        string Listar_Generadores_Por_CodCampania_FechaRelevo(string DatosLista);

        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve los puntos de venta por código de cadena, código de campaña, código de oficina
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena")]
        string Listar_PuntoDeVenta_Por_CodCampania_CodOficina_CodCadena(string DatosParametro);
        /// <summary>
        /// Autor:       Carlos Marin
        /// Fecha:       06/06/2012
        /// Descripción: Método que devuelve los Puntos de venta por código de cadena, código de campaña, codigo de ciudad
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena")]
        string Listar_PuntoDeVenta_Por_CodCampania_CodCiudad_CodCadena(string DatosParametro);
        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:02/08/2012
        /// Descripcion: Obtener Los Puntos de Venta por CodCampania_CodDepartamento_CodProvincia_Cod_NodeCommercial 
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodDepartamento"></param>
        /// <param name="CodProvincia"></param>
        /// <param name="CodNodeCommercial"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial")]
        string Listar_PuntoDeVenta_Por_CodCampania_CodDepartamento_CodProvincia_CodNodeCommercial(string DatosParametro);
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "listarPuntodeVentaPlanning")]
        string listarPuntodeVentaPlanning(string DatosReporte);
        /// <summary>
        /// Author      : Pablo Salas A.
        /// Fecha       : 26/09/2012
        /// Descripcion : Listar PuntosDeVenta por CodCompania
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_PuntoDeVenta_Por_CodCompania")]
        string Listar_PuntoDeVenta_Por_CodCompania(string DatosReporte);
        #endregion
        #region Gestion de Oficina
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 11/05/2012
        /// Descripción: Método que devuelve las oficinas por código de persona
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Oficinas_Por_CodPersona")]
        string Listar_Oficinas_Por_CodPersona(string DatosParametro);

        /// <summary>
        /// Version :1.0
        /// Fecha   :31/08/2012
        /// Author  :Pablo Salas A.
        /// Descripcion:Obtener las Oficinas Por CodCompania
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Oficinas_Por_CodCompania")]
        string Listar_Oficinas_Por_CodCompania(string DatosParametro);
        /// <summary>
        /// Autor: Giam Farfan
        /// Fecha:27/09/2012
        /// Descripcion: Obtener oficinas por codpais,codcliente,codcampania.
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method="POST", UriTemplate="Listar_Oficinas_Por_CodPais_CodCliente_CodCampania")]
        string Listar_Oficinas_Por_CodPais_CodCliente_CodCampania(string DatosParametros);
        #endregion
        #region Gestion de Categoria
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 11/05/2012
        /// Descripción: Método que devuelve las categorías por código de canal y código de reporte
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte")]
        string Listar_Categoria_Por_CodCliente_CodCanal_y_CodReporte(string DatosParametro);
        #endregion
        #region Gestion de Periodo
        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 11/05/2012
        /// Descripción: Método que devuelve los periodos por código de servicio, código de canal, código de cliente, código de reporte, año y mes
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes")]
        string Listar_Periodo_Por_CodServicio_CodCanal_CodCliente_CodReporte_Anio_Mes(string DatosParametro);
        #endregion
        #region Gestion de NodoCommercial
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve las cadena por código de campaña y código de oficina
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Cadena_Por_CodCampania_y_CodOficina")]
        string Listar_Cadena_Por_CodCampania_y_CodOficina(string DatosParametro);
        /// <summary>
        /// Autor:       Carlos Marin
        /// Fecha:       06/06/2012
        /// Descripción: Método que devuelve los NodeComerciales por código de cadena, código de campaña
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_NodeComercial_Por_CodCampania_CodCiudad")]
        string Listar_NodeComercial_Por_CodCampania_CodCiudad(string DatosParametro);
        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:02/08/2012
        /// Descripcion: Obtener NodosCommerciales por codCampania_CodDepartamento y Cod_Provincia
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodDepartamento"></param>
        /// <param name="CodProvincia"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia")]
        string Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia(string DatosParametro);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito")]
        string Listar_NodoCommercial_Por_CodCampania_CodDepartamento_CodProvincia_Distrito(string DatosParametro);
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia")]
        string listarNodeComercial_Por_codCampania_idNodeComercialType_CodOficina_CodDepartamento_CodProvincia(string DatosReporte);
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia")]
        string listarNodeComercial_Type_Por_CodCampania_CodOficina_CodDepartamento_CodProvincia(string DatosReporte);
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       25/10/2012
        /// Descripción: Método que devuelve los nodos comerciales(cadena) por cliente y por canal
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Cadena_Por_CodCliente_y_CodCanal")]
        string Listar_Cadena_Por_CodCliente_y_CodCanal(string DatosParametro);
        #endregion
        #region Gestion de SubCategoria
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve las SubCategorías por código de categoría
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ListarSubCategoria_Por_CodCategoria")]
        string ListarSubCategoria_Por_CodCategoria(string DatosParametro);
        #endregion
        #region Gestion de Producto
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve las SubCategorías por código de categoría
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca")]
        string Listar_Producto_Por_CodCampania_CodCategoria_CodSubCategoria_CodMarca(string DatosParametro);
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       09/08/2012
        /// Descripción: Método que devuelve las productos
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca")]
        string Listar_Producto_Por_CodCampania_CodCliente_CodCategoria_CodSubCategoria_CodMarca(string DatosParametro);

        #endregion
        #region Gestion de Ciudad
        /// <summary>
        /// Autor:       Carlos Marin
        /// Fecha:       06/06/2012
        /// Descripción: Método que devuelve las ciudades por código de campaña
        /// </summary>
        /// <param name="DatosLista"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Ciudad_Por_CodCampania")]
        string Listar_Ciudad_Por_CodCampania(string DatosParametro);

        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:02/08/2012
        /// Descripcion: Obtener las Provincias por CodDepartamento 
        /// </summary>
        /// <param name="CodDepartamento"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Ciudad_Por_CodDepartamento")]
        string Listar_Ciudad_Por_CodDepartamento(string DatosParametro);
        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:03/08/2012
        /// Descripcion: Obtener Las  Provincias por CodCampania y  CodDepartamento.
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <param name="CodDepartamento"></param>
        /// <param name="CodProvincia"></param>
        /// <param name="CodNodeCommercial"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Ciudad_Por_CodCampania_CodDepartamento")]
        string Listar_Ciudad_Por_CodCampania_CodDepartamento(string DatosParametro);
        #endregion
        #region Gestion de Budget
        /// Autor: Pablo Salas A.
        /// Fecha: 18/07/2012
        /// Descripción: Devuelve los Budget por CodCompania y CodOpcion
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Budget_Por_CodCompania_CodOpcion")]
        string Listar_Budget_Por_CodCompania_CodOpcion(string DatosParametro);


        /// Autor: Pablo Salas A.
        /// Fecha: 19/07/2012
        /// Descripción: Devuelve los Budget por CodCompania , CodBudget,  CodOpcion
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Budget_Por_CodCompania_CodBudget_CodOpcion")]
        string Listar_Budget_Por_CodCompania_CodBudget_CodOpcion(string DatosParametro);
        #endregion
        #region Gestion de Departamento
        /// <summary>
        /// Author:Pablo Salas Alvarez
        /// Fecha:02/08/2012
        /// Descripcion: Obtener los Departamentos por CodCampaña
        /// </summary>
        /// <param name="CodCampania"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Departamento_Por_CodCampania")]
        string Listar_Departamento_Por_CodCampania(string DatosParametro);
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina")]
        string listarDepartamentos_Por_CodCliente_Por_CodCampania_Por_CodPais_CodOficina(string DatosLista);
        #endregion
        #region Gestion de Provincia
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento")]
        string listarProvincias_Por_Campania_Por_CodPais_Por_CodOficina_Por_codDepartamento(string DatosLista);
        #endregion
        #region Gestion de Distritos
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia")]
        string listarDistritos_Por_Campania_Por_CodPais_Por_codOficina_Por_codDepartamento_Por_Provincia(string DatosLista);
        #endregion
        #region Gestion de Anios
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve los años
        /// </summary>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Anios")]
        string Listar_Anios();
        #endregion
        #region Gestion de Meses
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       14/05/2012
        /// Descripción: Método que devuelve los meses
        /// </summary>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Meses")]
        string Listar_Meses();
        #endregion
        #region Gestion de Días
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo")]
        string Listar_Dias_Por_CodServicioCodCanalCodCompania_CodReporte_Anio_Mes_Periodo(string DatosParametro);
        #endregion
        #region Gestion de Sector
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia")]
        string listarSectores_Por_codCampania_codRegion_codOficina_codDepartamento_codProvincia(string DatosReporte);
        #endregion
        #region Gestion de Mallas
        /// <summary>
        /// Autor:Giam Farfan.
        /// Fecha:14/09/2012
        /// Descripcion: Metodo para hacer seguimiento a Planning.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia")]
        string listarRegion_Por_codCampania_codOficina_codDepartamento_codProvincia(string DatosReporte);
        #endregion
        #region Gestion Unicos
        ///Descripcion  : Listar Menús por CodPersona, dependiendo el Perfil y la Compañia de la Persona, mostrar los Reportes Asociados.
        ///Fecha        : 04/05/2012 PSA
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Menu_Por_CodPersona")]
        string Listar_Menu_Por_CodPersona(string DatosLista);

        ///Descripcion  : Llena el Reporte Stock Alicorp para que pueda registrar Cantidad y Observaciones.
        ///Fecha        : 05/05/2012 PSA
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Llenar_Reporte_Stock_Alicorp")]
        string Llenar_Reporte_Stock_Alicorp(string DatosLista);

        /// <summary>
        /// Autor: Joseph Gonzales
        /// Fecha: 10/05/2012
        /// Descripción: Método que devuelve el reporte a mostrar en el módulo de digitación.
        /// </summary>
        /// <param name="DatosParametros">
        /// Código_Campaña
        /// Código_Reporte
        /// Código_Categoría
        /// Código_Marca
        /// Código_Familia
        /// Código_SubFamilia
        /// Código_Oficina
        /// Código_Mercaderista
        /// Código_Punto_Venta
        /// </param>
        /// <returns>
        /// Código_Punto_Venta
        /// Nombre_Punto_Venta
        /// Codigo_Elemento
        /// Nombre_Elemento
        /// 
        /// ** Elemento: Puede representar un producto, marca, categoria, familia o subfamilia.  **
        /// </returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Llenar_Reporte_General")]
        string Llenar_Reporte_General(string DatosParametros);

        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 19/09/2012
        /// Descripción: Método que devuelve el reporte a mostrar en el módulo de digitación Colgate Bodegas.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Llenar_Reporte_Bodegas")]
        string Llenar_Reporte_Bodegas(string DatosParametros);

        #endregion       

        #region Planning
        #endregion

        #region Gestion de Cadenas
        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:28/09/2012
        /// Descripcion: Metodo que trae las Cadenas.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Cadenas")]
        string Listar_Cadenas(string DatosReporte);
        #endregion

        #region Gestion de Parametros
        /// <summary>
        /// Autor: Peter Ccopa
        /// Fecha: 30/10/2012
        /// Descripcion: Metodo que trae el valor de un parametro.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "obtener_Parametro")]
        string obtener_Parametro(string DatosReporte);
        #endregion

        #region Obtener Nro OC
        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:25/10/2012
        /// Descripcion: Metodo que trae correlativo de OC
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "obtener_NroOrdenCompra")]
        string obtener_NroOrdenCompra(string DatosReporte);
        #endregion

        #region Gestion de Proveedores
        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:23/10/2012
        /// Descripcion: Metodo que trae los Proveedores.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Proveedores")]
        string Listar_Proveedores(string DatosProveedor);
        #endregion

        #region Gestion de MenuDatamercaderista
        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:12/10/2012
        /// Descripcion: Metodo que trae los Menu.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Menu_Datamercaderista")]
        string Listar_Menu_Datamercaderista(string DatosReporte);
        #endregion

        #region Gestion de PDVCadenas
        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:28/09/2012
        /// Descripcion: Metodo que trae los PDV por Campaña, Generador y Cadenas.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena")]
        string Listar_PuntoDeVenta_Por_CodCampania_CodGenerador_CodCadena(string DatosReporte);
        #endregion

        #region Gestion de Orden de Compras
        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:29/10/2012
        /// Descripcion: Metodo para traer cabecera de Orden de Compra.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ListarOrdenCompra_Cabecera")]
        string ListarOrdenCompra_Cabecera(string DatosLista);

        /// <summary>
        /// Autor:Peter Ccopa
        /// Fecha:29/10/2012
        /// Descripcion: Metodo para traer detalle de Orden de Compra.
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ListarOrdenCompra_Detalle")]
        string ListarOrdenCompra_Detalle(string DatosLista);

        #endregion

        #region Gestion de Rutas
        /// <summary>
        /// Author      : Pablo Salas A.
        /// Fecha       : 27/09/2012
        /// Descripcion : Listar Rutas por CodCompaniaCodCampaniaCodPersona
        /// </summary>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Rutas_Por_CodCompania_CodCampania_CodPersona")]
        string Listar_Rutas_Por_CodCompania_CodCampania_CodPersona(string DatosReporte);

        //Add 08/11/2012 Pablo Salas A.
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Listar_Rutas_Por_ComCamPerFec")]
        string Listar_Rutas_Por_ComCamPerFec(string DatosReporte);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "updateRuta")]
        string updateRuta(string DatosReporte);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "actualizarEstadoRuta")]
        string actualizarEstadoRuta(string DatosReporte);
        #endregion
        

        

        #region Gestion de Reportes
        /// <summary>
        //  Autor: Peter Ccopa
        //  Fecha: 08/11/2012
        //  Descripcion: Devuelve datos de Reporte de Exhibicion
        /// </summary>
        /// <param name="DatosParametros"></param>
        /// <returns></returns>
        //[OperationContract()]
        //[WebInvoke(Method = "POST", UriTemplate = "Llenar_Reporte_Exhibicion")]
        //string Llenar_Reporte_Exhibicion(string DatosParametros);
        #endregion
    }
}