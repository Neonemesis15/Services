using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
    [ServiceContract()]
    public interface IEAProService
    {
        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Validar_usuario")]
        string Validar_usuario(string DatosAcceso);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Obtener_salas")]
        string Obtener_salas(string DatosParametro);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Obtener_centro_costo")]
        string Obtener_centro_costo(string DatosParametro);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Obtener_usuarios")]
        string Obtener_usuarios(string DatosParametro);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Obtener_separaciones")]
        string Obtener_separaciones(string DatosParametro);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Registrar_separacion")]
        string Registrar_separacion(string DatosParametro);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Actualizar_separacion")]
        string Actualizar_separacion(string DatosParametro);

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Eliminar_separacion")]
        string Eliminar_separacion(string DatosParametro);
        
        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "Actualizar_separacion_Fecha")]
        string Actualizar_separacion_Fecha(string DatosParametro);
    }
}
