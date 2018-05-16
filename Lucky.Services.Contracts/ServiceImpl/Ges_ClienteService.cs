using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Services.Contracts.ServiceContract;
using Lucky.CFG.JavaMovil;
using Lucky.Business.Common.Servicio;

namespace Lucky.Services.Contracts.ServiceImpl
{
    public class Ges_ClienteService : IGes_ClienteService
    {
        private readonly static BL_Ges_ClienteService oBL_Ges_ClienteService = new BL_Ges_ClienteService();

        public string Obtener_Usuario_Digitacion(string DatosAcceso)
        {
            DataContract.Obtener_Usuario_Digitacion_Request request = HelperJson.Deserialize<DataContract.Obtener_Usuario_Digitacion_Request>(DatosAcceso);
            DataContract.Obtener_Usuario_Digitacion_Response response = new DataContract.Obtener_Usuario_Digitacion_Response();
            try
            {
                response.usuarioDigitacion = oBL_Ges_ClienteService.Obtener_Usuario_Digitacion(request.nombreUsuario);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Usuario invalido";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.Obtener_Usuario_Digitacion_Response>(response);
            return responseJSON;
        }
         
    }
}
