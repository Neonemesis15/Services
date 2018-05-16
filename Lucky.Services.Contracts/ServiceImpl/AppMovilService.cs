using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Services.Contracts.ServiceContract;
using Lucky.Business.Common.JavaMovil;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;
using Newtonsoft.Json;

namespace Lucky.Services.Contracts.ServiceImpl
{
    public class AppMovilService : IAppMovil
    {
        public static BL_AppMovil blAppMovil = new BL_AppMovil();

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

            string responseJSON = HelperJson.Serialize<DataContract.UsuarioService_Mov_Response>(response);
            return responseJSON;
        }

        public string Sincronizar_Mov(string DatosSincronizacion)
        {
            DataContract.SincronizacionService_Mov_Request request = HelperJson.Deserialize<DataContract.SincronizacionService_Mov_Request>(DatosSincronizacion);
            DataContract.SincronizacionAppMovilService_Mov_Response response = new DataContract.SincronizacionAppMovilService_Mov_Response();
            try
            {
                response.Sincronizar = blAppMovil.Sincronizar_Mov(request.Person_Id, request.Cliente_Id, request.Id_Equipo);
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "La sincronización se realizó con éxito.";
            }
            catch (Exception)
            {
                response.Descripcion = "";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.SincronizacionAppMovilService_Mov_Response>(response);
            return responseJSON;
        }

        public string RegistrarMarcacion_Mov(string DatosRegistro)
        {
            DataContract.RegistrarMarcacion_Mov_Request request = HelperJson.Deserialize<DataContract.RegistrarMarcacion_Mov_Request>(DatosRegistro);
            DataContract.RegistrarMarcacionResponse response = new DataContract.RegistrarMarcacionResponse();
            try
            {
                blAppMovil.RegistrarMarcacion_Mov(obtenerMarcacion_Mov(request));
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "El registro de marcación fue correcto.";
            }
            catch (Exception)
            {
                response.Descripcion = "No se pudo registrar su marcación.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.RegistrarMarcacionResponse>(response);
            return responseJSON;
        }







        private E_Marcacion obtenerMarcacion_Mov(DataContract.RegistrarMarcacion_Mov_Request request)
        {
            E_Marcacion marcacion = new E_Marcacion();
            marcacion.ClienteId = request.clienteId;
            marcacion.EquipoId = request.equipoId;
            marcacion.EstadoId = request.estadoId;
            marcacion.FechaFin = request.fechaFin;
            marcacion.FechaIni = request.fechaIni;
            marcacion.LatitudFin = request.latitudFin;
            marcacion.LatitudInicio = request.latitudInicio;
            marcacion.LongitudFin = request.longitudFin;
            marcacion.LongitudInicio = request.longitudInicio;
            marcacion.OrigenFin = request.origenFin;
            marcacion.OrigenInicio = request.origenInicio;
            marcacion.MotivoId = request.motivoId;
            marcacion.PersonId = request.personId;
            return marcacion;
        }



        public string RegistrarPedido_Mov(string DatosRegistro)
        {
            DataContract.RegistrarPedido_Request request = HelperJson.Deserialize<DataContract.RegistrarPedido_Request>(DatosRegistro);
            DataContract.RegistrarPedido_Response response = new DataContract.RegistrarPedido_Response();
            try
            {
                blAppMovil.RegistrarPedido_Mov(request.listaPedido);
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "Los pedidos se registraron correctamente";
            }
            catch (Exception)
            {
                response.Descripcion = "No se pudo registrar su pedido.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.RegistrarPedido_Response>(response);
            return responseJSON;
        }


        public string Cobrar_Mov(string DatosRegistro)
        {
            DataContract.RegistrarCobro_Request request = HelperJson.Deserialize<DataContract.RegistrarCobro_Request>(DatosRegistro);
            DataContract.RegistrarCobro_Response response = new DataContract.RegistrarCobro_Response();
            try
            {
                blAppMovil.Cobrar_Mov(request.codigo);
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "El cobre se efectuo correctamente.";
            }
            catch (Exception)
            {
                response.Descripcion = "No se pudo registrar su pedido.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            string responseJSON = HelperJson.Serialize<DataContract.RegistrarCobro_Response>(response);
            return responseJSON;
        }
    }

}
