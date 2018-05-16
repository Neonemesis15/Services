using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface ISincronizacionService
    {
        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Sincronizar")]
        string Sincronizar(string DatosSincronizacion);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "SincronizarAuditoria")]
        string SincronizarAuditoria(string datosSincronizacionRq);

        //Add  pSalas 16/02/2012
        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "SincronizarBodega")]
        string SincronizarBodega(string datosSincronizacionRq_Bodega);

        //Add pSalas 16/03/2012
        //[OperationContract()]
        //[System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "SincronizarAndroid")]
        //string SincronizarAndroid(string datosSincronizacionRq_Android);

        #region Métodos_Android

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Sincronizar_Mov")]
        string Sincronizar_Mov(string DatosSincronizacion);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "SincronizarPreDatos_Mov")]
        string SincronizarPreDatos_Mov(string DatosSincronizacion);

        #endregion Métodos_Android

    }
}
