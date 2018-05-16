using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IGes_OperativaService
    {
        #region Gestion Reportes - Registrar
        /// <summary>
        /// Fecha:       11/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Request del Reporte de Precios General
        /// </summary>
        /// <param name="DatosReportePrecio"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_Precio")]
        string Registrar_Reporte_Precio(string DatosReportePrecio);

        /// <summary>
        /// Fecha:       11/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Registra el Reporte de Stock General
        /// </summary>
        /// <param name="DatosReporteStock"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_Stock")]        
        string Registrar_Reporte_Stock(string DatosReporteStock);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_SOD")]
        string Registrar_Reporte_SOD(string DatosReporteSOD);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_Exhibicion")]
        string Registrar_Reporte_Exhibicion(string DatosReporteExhibicion);


        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_Quiebre")]
        string Registrar_Reporte_Quiebre(string DatosReporteQuiebre);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_LayOut")]
        string Registrar_Reporte_LayOut(string DatosReporteLayOut);
        
        /// <summary>
        /// Fecha:       31/05/2012
        /// Creado:      Pablo Salas A.
        /// Descripción: Consulta el Reporte de Reporte Competencia
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_Competencia")]
        string Registrar_Reporte_Competencia(string DatosReporte);

        /// <summary>
        /// Fecha:       31/05/2012
        /// Creado:      Pablo Salas A.
        /// Descripción: Consulta el Reporte de Reporte Competencia
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_Fotografico")]
        string Registrar_Reporte_Fotografico(string DatosReporte);

        /// <summary>
        /// Fecha:       26/09/2012
        /// Creado:      Pablo Salas A.
        /// Descripción: Registrar Reporte Encuesta
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_Encuesta")]
        string Registrar_Reporte_Encuesta(string DatosReporte);

        /// <summary>
        /// Fecha:       15/10/2012
        /// Creado:      Joseph Gonzales.
        /// Descripción: Registrar Reporte Encuesta
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Reporte_Encuesta_EQF")]
        string Registrar_Reporte_Encuesta_EQF(string DatosReporte);
        #endregion

        #region Gestion Reportes - Consultar
        /// <summary>
        /// Fecha:       11/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Consulta el Reporte de Stock General
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_Reporte_Stock_Validado")]
        string Consultar_Reporte_Stock_Validado(string DatosParametro);

        /// ---Warning
        /// 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_Reporte_Stock_General")]
        string Consultar_Reporte_Stock_General(string DatosParametro);

        /// ---Warning
        /// 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_Reporte_Precio_General")]
        string Consultar_Reporte_Precio_General(string DatosParametro);

        /// ---Warning
        /// 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_Reporte_SOD_General")]
        string Consultar_Reporte_SOD_General(string DatosParametro);

        /// ---Warning
        /// 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_Reporte_LayOut_General")]
        string Consultar_Reporte_LayOut_General(string DatosParametro);

        /// ---Warning
        /// 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_Reporte_Quiebre_General")]
        string Consultar_Reporte_Quiebre_General(string DatosParametro);

        /// ---Warning
        /// 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_Reporte_Exhibicion_General")]
        string Consultar_Reporte_Exhibicion_General(string DatosParametro);

        /// ---Warning
        /// 
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_Reporte_Exhibicion")]
        string Consultar_Reporte_Exhibicion(string DatosParametro);

        /// <summary>
        /// Fecha:       15/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Consultar Reporte de Datos Validados por el cliente
        /// </summary>
        /// <param name="DatosReportePrecio"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_Reporte_Data_Validada")]
        string Consultar_Reporte_Data_Validada(string DatosParametro);

        /// <summary>
        /// Fecha:       16/08/2012
        /// Creado:      Ditmar Estrada
        /// Descripción: Consulta Reporte de Presencia
        /// </summary>
        /// <param name="name_user"></param>
        /// <param name="User_Password"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consulta_Reporte_Presencia")]
        string Consulta_Reporte_Presencia(string DatosParametro);

        /// <summary>
        /// Fecha:       03/09/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Consulta Reporte de Relevo Online
        /// </summary>
        /// <param name="name_user"></param>
        /// <param name="User_Password"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consulta_Reporte_Relevo")]
        string Consulta_Reporte_Relevo(string DatosParametro);

        /// <summary>
        /// Fecha:       26/09/2012
        /// Creado:      Ditmar Estrada
        /// Descripción: Consulta Reporte de Presencia Consolidado
        /// </summary>
        /// <param name="name_user"></param>
        /// <param name="User_Password"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Consultar_ReportePresenciaConsolidado")]
        string Consultar_ReportePresenciaConsolidado(string DatosParametro);
        #endregion

        #region Gestion Reportes - Actualizar
        /// <summary>
        /// Fecha:       12/11/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Actualizar el Reporte de Exhibicion - Cantidad
        /// </summary>
        /// <param name="DatosReporteExhibicion"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Actualizar_Reporte_Exhibicion")]
        string Actualizar_Reporte_Exhibicion(string DatosReporte);

        /// <summary>
        /// Fecha:       14/11/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Valida el Reporte de Exhibicion
        /// </summary>
        /// <param name="DatosReporteExhibicion"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Validar_Reporte_Exhibicion")]
        string Validar_Reporte_Exhibicion(string DatosReporte);
        #endregion

        #region Gestion Unicos
        /// <summary>
        /// Fecha:       14/05/2012
        /// Creado:      Joseph Gonzales
        /// Descripción: Validación del Reporte Stock General
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Validar_Reporte_Stock")]
        string Validar_Reporte_Stock(string DatosParametro);

        /// <summary>
        /// Fecha:       05/06/2012
        /// Creado:      Carlos Marin
        /// Descripción: Logueo
        /// </summary>
        /// <param name="name_user"></param>
        /// <param name="User_Password"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Logueo")]
        string Logueo(string DatosParametro);

        /// <summary>
        /// Creado por: Giam Farfan
        /// Fecha:04/10/2012
        /// Descripcion: Lista informes para el menu Consumo Masivo v2 Alicorp y perfil 0999
        /// </summary>
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ListarInformesCMv2")]
        string ListarInformesCMv2(string DatosParametro);

        /// <summary>
        /// Creado por: Giam Farfan
        /// Fecha:04/10/2012</summary>
        /// Descripcion: Lista informes para el menu Marketing v2 Alicorp y perfil 0999
        /// <param name="DatosParametro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "ListarInformesMKTv2")]
        string ListarInformesMKTv2(string DatosParametro);
        #endregion

        #region Gestion Orden de Compras
        /// <summary>
        /// Fecha:       25/10/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Registrar Orden de Compras
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_OrdenCompra")]
        string Registrar_OrdenCompra(string DatosOrdenCompra);
        #endregion

        #region Gestion Tickets
        /// <summary>
        /// Fecha:       15/10/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Registrar Tickets
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "Registrar_Tickets")]
        string Registrar_Tickets(string DatosOrdenCompra);
        #endregion

        #region Gestion de Proveedores
        /// <summary>
        /// Fecha:       22/10/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Registro de Proveedor
        /// </summary>
        /// <param name="DatosReportePrecio"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "registrarProveedor")]
        string registrarProveedor(string DatosProveedor);

        /// <summary>
        /// Fecha:       22/10/2012
        /// Creado:      Peter Ccopa
        /// Descripción: Actualizar de Proveedor
        /// </summary>
        /// <param name="DatosReportePrecio"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "actualizarProveedor")]
        string actualizarProveedor(string DatosProveedor);
        #endregion
    }
}
