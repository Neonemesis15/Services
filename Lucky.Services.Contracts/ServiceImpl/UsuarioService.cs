using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.CFG.JavaMovil;
using Lucky.Business.Common.JavaMovil;
using Lucky.Services.Contracts.ServiceContract;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceImpl
{
    public class UsuarioService : IUsuarioService
    {
        private readonly static UsuarioBLL usuarioBLL = new UsuarioBLL();
        public string Login(string DatosAcceso)
        {
            DataContract.UsuarioServiceRequest request = HelperJson.Deserialize<DataContract.UsuarioServiceRequest>(DatosAcceso);
            DataContract.UsuarioServiceResponse response = new DataContract.UsuarioServiceResponse();
            try
            {
                EUsuario usuario = usuarioBLL.Login(request.Usuario, request.Password);
                response.Usuario = usuario;
                response.Estado = BaseResponse.EXITO;                
            }
            catch (Exception)
            {
                response.Descripcion = "Usuario y/o password inválido.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.UsuarioServiceResponse>(response);
            return responseJSON;
        }

        public string LoginAuditoria(string DatosAcceso)
        {
            DataContract.UsuarioServiceRequest request = HelperJson.Deserialize<DataContract.UsuarioServiceRequest>(DatosAcceso);
            DataContract.UsuarioAuditoriaServiceResponse response = new DataContract.UsuarioAuditoriaServiceResponse();
            try
            {
                EUsuarioAuditoria usuario = usuarioBLL.LoginAuditoria(request.Usuario, request.Password);
                response.Usuario = usuario;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Usuario y/o password inválido.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.UsuarioAuditoriaServiceResponse>(response);
            return responseJSON;
        }


        #region Métodos_Android

        public string Login_Mov(string DatosAcceso)
        {
            BL_Usuario oBL_Usuario = new BL_Usuario();

            DataContract.UsuarioServiceRequest request = HelperJson.Deserialize<DataContract.UsuarioServiceRequest>(DatosAcceso);
            DataContract.UsuarioService_Mov_Response response = new DataContract.UsuarioService_Mov_Response();
            try
            {
                E_Usuario usuario = oBL_Usuario.Login_Mov(request.Usuario, request.Password);
                response.Usuario = usuario;
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "Acceso Correcto";
            }
            catch (Exception)
            {
                response.Descripcion = "Usuario y/o password inválido.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.UsuarioService_Mov_Response>(response);
            return responseJSON;
        }

        #endregion Métodos_Android
    }
}