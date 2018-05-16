using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IUsuarioService
    {
        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Login")]
        string Login(string DatosAcceso);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "LoginAuditoria")]
        string LoginAuditoria(string DatosAcceso);
        
        #region Métodos_Android

        /// <summary>
        /// Fecha:       16/05/2012
        /// Autor:       Joseph Gonzales
        /// Descripcion: Méotodo que realiza la validación para los usuarios de la aplicación móvil - Android
        /// </summary>
        /// <param name="DatosAcceso"></param>
        /// <returns></returns>
        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Login_Mov")]
        string Login_Mov(string DatosAcceso);

        #endregion Métodos_Android
    }
}
