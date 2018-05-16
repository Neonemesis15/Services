using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IEstadoService
    {
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "RegistrarVisita")]
        string RegistrarVisita(string DatosAcceso);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "RegistrarMarcacion")]
        string RegistrarMarcacion(string DatosAcceso);




        #region Métodos_Android

        /// <summary>
        /// Fecha:       16/05/2012
        /// Autor:       Joseph Gonzales
        /// Descripcion: Método que registra la visita a un punto de venta - Android
        /// </summary>
        /// <param name="DatosRegistro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "RegistrarVisita_Mov")]
        string RegistrarVisita_Mov(string DatosRegistro);

        /// <summary>
        /// Fecha:       16/05/2012
        /// Autor:       Joseph Gonzales
        /// Descripcion: Méotodo que registra las diferentes opciones de marcación - Android
        /// </summary>
        /// <param name="DatosRegistro"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "RegistrarMarcacion_Mov")]
        string RegistrarMarcacion_Mov(string DatosRegistro);
        
        /// <summary>
        /// Autor       : Joseph Gonzales
        /// Fecha       : 06 - 06 - 2012
        /// Descripción : Registra los motivos de no implementación y no mantenimiento.
        /// </summary>
        /// <param name="DatosReporte"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "RegistrarMotivoColgateBodega_Mov")]
        string RegistrarMotivoColgateBodega_Mov(string DatosReporte);

        #endregion Métodos_Android
    }
}