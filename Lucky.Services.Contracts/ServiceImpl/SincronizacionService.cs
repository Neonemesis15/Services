using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Business.Common.JavaMovil;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Services.Contracts.ServiceContract;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceImpl
{
    public class SincronizacionService : ISincronizacionService
    {
        private readonly static SincronizarBLL sincronizarBLL = new SincronizarBLL();

        public string Sincronizar(string DatosSincr)
        {
            DataContract.SincronizacionServiceRequest request = HelperJson.Deserialize<DataContract.SincronizacionServiceRequest>(DatosSincr);
            DataContract.SincronizacionServiceResponse response = new DataContract.SincronizacionServiceResponse();
            try
            {
                ESincronizar eSincronizar = sincronizarBLL.Sincronizar(request.Person_Id, request.Cliente_Id, request.Id_Equipo);
                response.Sincronizar = eSincronizar;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.SincronizacionServiceResponse>(response);
            return responseJSON;
        }

        public string SincronizarAuditoria(string datosSincronizacionRq)
        {
            DataContract.SincronizacionServiceAuditoriaRequest request = HelperJson.Deserialize<DataContract.SincronizacionServiceAuditoriaRequest>(datosSincronizacionRq);
            DataContract.SincronizacionServiceAuditoriaResponse response = new DataContract.SincronizacionServiceAuditoriaResponse();
            try
            {
                ESincronizarAuditoria eSincronizar = sincronizarBLL.SincronizarAudtioria(request.Person_Id, request.Id_Equipo);
                response.Sincronizar = eSincronizar;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.SincronizacionServiceAuditoriaResponse>(response);
            return responseJSON;
        }

        //Add pSalas 16/02/2012
        public string SincronizarBodega(string datosSincronizacionRq_Bodega)
        {
            DataContract.SincronizacionServiceBodegaRequest request = HelperJson.Deserialize<DataContract.SincronizacionServiceBodegaRequest>(datosSincronizacionRq_Bodega);
            DataContract.SincronizacionServiceBodegaResponse response = new DataContract.SincronizacionServiceBodegaResponse();
            try
            {
                E_Sincronizar_Bodega oE_Sincronizar_Bodega = sincronizarBLL.SincronizarBodega(request.Id_Equipo, request.Id_Perfil, request.Id_Cliente, request.Name_User);
                response.SincronizarBodega = oE_Sincronizar_Bodega;
                response.Estado = BaseResponse.EXITO;

            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.SincronizacionServiceBodegaResponse>(response);

            return responseJSON;
        }

        //Add pSalas 16/03/2012
        /*public string SincronizarAndroid(string datosSincronizacion_Android) {
            DataContract.SincronizacionAndroidRequest request = HelperJson.Deserialize<DataContract.SincronizacionAndroidRequest>(datosSincronizacion_Android);
            DataContract.SincronizacionAndroidResponse response = new DataContract.SincronizacionAndroidResponse();

            try {
                ESincronizar oESincronizarAndroid = sincronizarBLL.Sincronizar_Android();
                response.SincronizarAndroid = oESincronizarAndroid;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception) {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.SincronizacionAndroidResponse>(response);
            return responseJSON;

        }*/

        #region Métodos_Android

        private readonly static BL_Sincronizar oBL_Sincronizar = new BL_Sincronizar();

        /// <summary>
        /// Autor:  Joseph Gonzales
        /// </summary>
        /// <param name="DatosSincronizacion">
        /// 
        /// COLGATE MAYORISTA
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"813622482010","b":"1561","c":"10376"}</string>
        /// 
        /// COLGATE MINORISTA
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"0133725102010","b":"1561","c":"10523"}</string>
        /// 
        /// COLGATE FARMACIA DT
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"0134126102010","b":"1561","c":"10497"}</string>
        /// 
        /// COLGATE FARMACIA IT
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"0134226102010","b":"1561","c":"10229"}</string>
        /// 
        /// COLGATE BODEGA 
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"012011092692011","b":"1561","c":"9798"}</string>
        /// 
        /// ALICORP AASS
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"000361782010","b":"1562","c":"8432"}</string>
        /// 
        /// ALICORP MAYORISTA
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"813711382010","b":"1562","c":"9034"}</string>
        /// 
        /// SAN FERNANDO AA VV
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"101131122011","b":"1572","c":"8938"}</string>
        /// 
        /// SAN FERNANDO MODERNO
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"004552352011","b":"1572","c":"9131"}</string>
        /// 
        /// SAN FERNANDO TRADICIONAL
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"102141122011","b":"1572","c":"9022"}</string>
        /// 
        /// CEMENTOS LIMA PROGRESOL
        /// <string xmlns='http://schemas.microsoft.com/2003/10/Serialization/'>{"a":"811241282010","b":"1560","c":"9428"}</string>
        /// 
        /// </param>
        /// <returns></returns>
        public string Sincronizar_Mov(string DatosSincronizacion)
        {            
            DataContract.SincronizacionService_Mov_Request request = HelperJson.Deserialize<DataContract.SincronizacionService_Mov_Request>(DatosSincronizacion);
            DataContract.SincronizacionService_Mov_Response response = new DataContract.SincronizacionService_Mov_Response();
            try
            {                
                response.Sincronizar = oBL_Sincronizar.Sincronizar_Mov(request.Person_Id, request.Cliente_Id, request.Id_Equipo);
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "La sincronización se realizó con éxito.";
            }
            catch (Exception)
            {
                response.Descripcion = "";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.SincronizacionService_Mov_Response>(response);
            return responseJSON;
        }
        
        /// <summary>
        /// Autor:       Joseph Gonzales
        /// Fecha:       29 - 05 - 2012
        /// Descripción: Sincroniza los datos pre cargados para la aplicación.
        /// </summary>
        /// <param name="DatosSincronizacion"></param>
        /// <returns></returns>
        public string SincronizarPreDatos_Mov(string DatosSincronizacion)
        {
            DataContract.SincronizacionPreDatos_Request request = HelperJson.Deserialize<DataContract.SincronizacionPreDatos_Request>(DatosSincronizacion);
            DataContract.SincronizacionPreDatos_Response response = new DataContract.SincronizacionPreDatos_Response();
            try
            {
                response.SincronizarPreDatos = oBL_Sincronizar.SincronizarPreDatos_Mov(request.Person_Id, request.Cliente_Id, request.Id_Equipo);
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "La sincronización se realizó con éxitos.";
            }
            catch (Exception)
            {
                response.Descripcion = "";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.SincronizacionPreDatos_Response>(response);
            return responseJSON;
        }

        #endregion Métodos_Android
    }
}
