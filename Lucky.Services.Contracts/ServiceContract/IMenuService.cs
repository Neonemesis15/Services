using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceContract
{
     [ServiceContract()]
    public interface IMenuService
    {

        [OperationContract()]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", UriTemplate = "ObtenerMenuDetalle")]
        string ObtenerMenuDetalle(string DatosAcceso);
    }
}
