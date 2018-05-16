using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application;
using Lucky.Business.Common.Application;
using Lucky.Services.Contracts.ServiceContract;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceImpl
{
    public class MenuService:IMenuService
    {
        BMenu oBMenu = new BMenu();
        public string ObtenerMenuDetalle(string DatosAcceso)
        {
            DataContract.MenuServiceRequest request = HelperJson.Deserialize<DataContract.MenuServiceRequest>(DatosAcceso);
            DataContract.MenuServiceResponse response = new DataContract.MenuServiceResponse();
            try
            {
                List<EMenuDetalle> oEMenuDetalles = oBMenu.Get_MenuDetalleByMenuId(request.menu_id);
                response.MenuDetalles = oEMenuDetalles;
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Error inesperado";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            //WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.MenuServiceResponse>(response);
            return responseJSON;
        }
    }
}
