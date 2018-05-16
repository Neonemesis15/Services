using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IAppMovil
    {
        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Login_Mov")]
        string Login_Mov(string DatosAcceso);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Sincronizar_Mov")]
        string Sincronizar_Mov(string DatosSincronizacion);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "RegistrarMarcacion_Mov")]
        string RegistrarMarcacion_Mov(string DatosRegistro);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Cobrar_Mov")]
        string Cobrar_Mov(string DatosRegistro);


        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "RegistrarPedido_Mov")]
        string RegistrarPedido_Mov(string DatosRegistro);

    }
}
