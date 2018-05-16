using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Services.Contracts.ServiceContract;
using Lucky.CFG.JavaMovil;
using Lucky.Business.Common.EAPro;

namespace Lucky.Services.Contracts.ServiceImpl
{
    public class EAProService : IEAProService
    {
        
        private readonly static BL_EAPro_Service oBL_EAPro_Service = new BL_EAPro_Service();

        public string Validar_usuario(string DatosAcceso)
        {
            DataContract.EAPRO_Validar_usuario_Request request = HelperJson.Deserialize<DataContract.EAPRO_Validar_usuario_Request>(DatosAcceso);
            DataContract.EAPRO_Validar_usuario_Response response = new DataContract.EAPRO_Validar_usuario_Response();
            try
            {
                response.eUsuario = oBL_EAPro_Service.Validar_usuario(request.usuario, request.clave);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Usuario invalido";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EAPRO_Validar_usuario_Response>(response);
            return responseJSON;
        }

        public string Obtener_salas(string DatosParametro)
        {
            DataContract.EAPRO_Obtener_salas_Request request = HelperJson.Deserialize<DataContract.EAPRO_Obtener_salas_Request>(DatosParametro);
            DataContract.EAPRO_Obtener_salas_Response response = new DataContract.EAPRO_Obtener_salas_Response();
            try
            {
                response.listaSalas = oBL_EAPro_Service.Obtener_salas();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EAPRO_Obtener_salas_Response>(response);
            return responseJSON;
        }

        public string Obtener_centro_costo(string DatosParametro)
        {
            DataContract.EAPRO_Obtener_centro_costo_Request request = HelperJson.Deserialize<DataContract.EAPRO_Obtener_centro_costo_Request>(DatosParametro);
            DataContract.EAPRO_Obtener_centro_costo_Response response = new DataContract.EAPRO_Obtener_centro_costo_Response();
            try
            {
                response.listaCentroCosto = oBL_EAPro_Service.Obtener_centro_costo();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EAPRO_Obtener_centro_costo_Response>(response);
            return responseJSON;
        }

        public string Obtener_usuarios(string DatosParametro)
        {
            DataContract.EAPRO_Obtener_usuarios_Request request = HelperJson.Deserialize<DataContract.EAPRO_Obtener_usuarios_Request>(DatosParametro);
            DataContract.EAPRO_Obtener_usuarios_Response response = new DataContract.EAPRO_Obtener_usuarios_Response();
            try
            {
                response.listUsuarios = oBL_EAPro_Service.Obtener_usuarios();
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EAPRO_Obtener_usuarios_Response>(response);
            return responseJSON;
        }

        public string Obtener_separaciones(string DatosParametro)
        {
            DataContract.EAPRO_Obtener_separaciones_Request request = HelperJson.Deserialize<DataContract.EAPRO_Obtener_separaciones_Request>(DatosParametro);
            DataContract.EAPRO_Obtener_separaciones_Response response = new DataContract.EAPRO_Obtener_separaciones_Response();
            try
            {
                response.listSeparaciones = oBL_EAPro_Service.Obtener_separaciones(request.codigoSala, 
                    request.codigoUsuario, request.codigoEncargado, request.codigoCentroCosto, request.fechaInicio, request.fechaFin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "No Existen datos";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EAPRO_Obtener_separaciones_Response>(response);
            return responseJSON;
        }

        public string Registrar_separacion(string DatosParametro)
        {
            DataContract.EAPRO_Registrar_separacion_Request request = HelperJson.Deserialize<DataContract.EAPRO_Registrar_separacion_Request>(DatosParametro);
            DataContract.EAPRO_Registrar_separacion_Response response = new DataContract.EAPRO_Registrar_separacion_Response();
            try
            {
                oBL_EAPro_Service.Registrar_separacion(request.codigoSala, request.codigoUsuario, 
                    request.codigoEncargado, request.codigoCargo, request.codigoCentroCosto, request.descripcion,
                    request.adicionales, request.cantidad, request.fecha, request.horaInicio, request.horaFin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Se registró de forma satisfactoria.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EAPRO_Registrar_separacion_Response>(response);
            return responseJSON;
        }

        public string Actualizar_separacion(string DatosParametro)
        {
            DataContract.EAPRO_Actualizar_separacion_Request request = HelperJson.Deserialize<DataContract.EAPRO_Actualizar_separacion_Request>(DatosParametro);
            DataContract.EAPRO_Actualizar_separacion_Response response = new DataContract.EAPRO_Actualizar_separacion_Response();
            try
            {
                oBL_EAPro_Service.Actualizar_separacion(request.codigoRegistro, request.codigoSala, request.codigoUsuario,
                    request.codigoEncargado, request.codigoCargo, request.codigoCentroCosto, request.descripcion,
                    request.adicionales, request.cantidad, request.fecha, request.horaInicio, request.horaFin);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Se actualizó de forma satisfactoria.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EAPRO_Actualizar_separacion_Response>(response);
            return responseJSON;
        }

        public string Eliminar_separacion(string DatosParametro)
        {
            DataContract.EAPRO_Eliminar_separacion_Request request = HelperJson.Deserialize<DataContract.EAPRO_Eliminar_separacion_Request>(DatosParametro);
            DataContract.EAPRO_Eliminar_separacion_Response response = new DataContract.EAPRO_Eliminar_separacion_Response();
            try
            {
                oBL_EAPro_Service.Eliminar_separacion(request.codigoRegistro);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Se eliminó de forma satisfactoria.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EAPRO_Eliminar_separacion_Response>(response);
            return responseJSON;
        }

        public string Actualizar_separacion_Fecha(string DatosParametro)
        {
            DataContract.EAPRO_Actualizar_separacion_Fecha_Request request = HelperJson.Deserialize<DataContract.EAPRO_Actualizar_separacion_Fecha_Request>(DatosParametro);
            DataContract.EAPRO_Actualizar_separacion_Response response = new DataContract.EAPRO_Actualizar_separacion_Response();
            try
            {
                oBL_EAPro_Service.Actualizar_separacion_Fecha(request.codigoRegistro, request.fecha);
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Se actualizó de forma satisfactoria.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }
            string responseJSON = HelperJson.Serialize<DataContract.EAPRO_Actualizar_separacion_Response>(response);
            return responseJSON;
        }
        
    }
}
