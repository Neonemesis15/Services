using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucky.Entity.Common.Application.JavaMovil;
using Lucky.Business.Common.JavaMovil;
using Lucky.CFG.JavaMovil;
using Lucky.Services.Contracts.ServiceContract;
using System.ServiceModel.Web;

namespace Lucky.Services.Contracts.ServiceImpl
{
    public class EstadoService : IEstadoService
    {
        public static BL_Visita blVisita = new BL_Visita();
        public static BL_Marcacion blMarcacion = new BL_Marcacion();
        public static BL_Registrar_Motivo blRegistrarMotivo = new BL_Registrar_Motivo();

        public string RegistrarMarcacion(string DatosMarcacion)
        {
            DataContract.RegistrarMarcacionRequest request = HelperJson.Deserialize<DataContract.RegistrarMarcacionRequest>(DatosMarcacion);
            DataContract.RegistrarMarcacionResponse response = new DataContract.RegistrarMarcacionResponse();
            try
            {
                blMarcacion.registrarMarcacion(obtenerMarcacion(request));
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.RegistrarMarcacionResponse>(response);
            return responseJSON;
        }

        public string RegistrarVisita(string DatosVisita)
        {
            DataContract.RegistrarVisitaRequest request = HelperJson.Deserialize<DataContract.RegistrarVisitaRequest>(DatosVisita);
            DataContract.RegistrarVisitaResponse response = new DataContract.RegistrarVisitaResponse();
            try
            {
                blVisita.registrarVisita(obtenerVisita(request));
                response.Estado = BaseResponse.EXITO;
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.RegistrarVisitaResponse>(response);
            return responseJSON;
        }

        private E_Visita obtenerVisita(DataContract.RegistrarVisitaRequest request)
        {
            E_Visita visit = new E_Visita();
            visit.ClienteId = request.ClienteId;
            visit.ClientPDV_Code = request.ClientPDV_Code;
            visit.EquipoId = request.EquipoId;
            visit.FechaFin = request.FechaFin;
            visit.FechaIni = request.FechaIni;
            visit.LatitudFin = request.LatitudFin;
            visit.LatitudInicio = request.LatitudInicio;
            visit.LongitudFin = request.LongitudFin;
            visit.LongitudInicio = request.LongitudInicio;
            visit.NoVisitaId = request.NoVisitaId;
            visit.OrigenFin = request.OrigenFin;
            visit.OrigenInicio = request.OrigenInicio;
            visit.PerfilId = request.PerfilId;
            visit.PersonId = request.PersonId;
            return visit;
        }

        private E_Marcacion obtenerMarcacion(DataContract.RegistrarMarcacionRequest request)
        {
            E_Marcacion marcacion = new E_Marcacion();
            marcacion.ClienteId = request.ClienteId;
            marcacion.EquipoId = request.EquipoId;
            marcacion.EstadoId = request.EstadoId;
            marcacion.FechaFin = request.FechaFin;
            marcacion.FechaIni = request.FechaIni;
            marcacion.LatitudFin = request.LatitudFin;
            marcacion.LatitudInicio = request.LatitudInicio;
            marcacion.LongitudFin = request.LongitudFin;
            marcacion.LongitudInicio = request.LongitudInicio;            
            marcacion.OrigenFin = request.OrigenFin;
            marcacion.OrigenInicio = request.OrigenInicio;
            marcacion.MotivoId = request.MotivoId;
            marcacion.PerfilId = request.PerfilId;
            marcacion.PersonId = request.PersonId;
            return marcacion;
        }



        #region Métodos_Android

        public string RegistrarVisita_Mov(string DatosRegistro)
        {
            DataContract.RegistrarVisita_Mov_Request request = HelperJson.Deserialize<DataContract.RegistrarVisita_Mov_Request>(DatosRegistro);
            DataContract.RegistrarVisitaResponse response = new DataContract.RegistrarVisitaResponse();
            try
            {
                blVisita.registrarVisita_Mov(obtenerVisita_Mov(request));
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "La visita se registro con éxito.";
            }
            catch (Exception)
            {
                response.Descripcion = "Servicio no disponible";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.RegistrarVisitaResponse>(response);
            return responseJSON;
        }

        public string RegistrarMarcacion_Mov(string DatosRegistro)
        {
            DataContract.RegistrarMarcacion_Mov_Request request = HelperJson.Deserialize<DataContract.RegistrarMarcacion_Mov_Request>(DatosRegistro);
            DataContract.RegistrarMarcacionResponse response = new DataContract.RegistrarMarcacionResponse();
            try
            {
                blMarcacion.RegistrarMarcacion_Mov(obtenerMarcacion_Mov(request));
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "El registro de marcación fue correcto.";
            }
            catch (Exception)
            {
                response.Descripcion = "No se pudo registrar su marcación.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
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

        //private E_Visita obtenerVisita_Mov(DataContract.RegistrarVisita_Mov_Request request)
        //{
        //    E_Visita visit = new E_Visita();
        //    visit.ClienteId = request.ClienteId;
        //    visit.ClientPDV_Code = request.ClientPDV_Code;
        //    visit.EquipoId = request.EquipoId;
        //    visit.FechaFin = request.FechaFin;
        //    visit.FechaIni = request.FechaIni;
        //    visit.LatitudFin = request.LatitudFin;
        //    visit.LatitudInicio = request.LatitudInicio;
        //    visit.LongitudFin = request.LongitudFin;
        //    visit.LongitudInicio = request.LongitudInicio;
        //    visit.NoVisitaId = request.NoVisitaId;
        //    visit.OrigenFin = request.OrigenFin;
        //    visit.OrigenInicio = request.OrigenInicio;            
        //    visit.PersonId = request.PersonId;
        //    return visit;
        //}

        private E_Visita_Mov obtenerVisita_Mov(DataContract.RegistrarVisita_Mov_Request request)
        {
            E_Visita_Mov visit_Mov = new E_Visita_Mov();
            visit_Mov.Cod_Compania = int.Parse(request.ClienteId);
            visit_Mov.Cod_PtoVenta = request.ClientPDV_Code;
            visit_Mov.Cod_Equipo = request.EquipoId;
            visit_Mov.Fec_RegistroFin = request.FechaFin.ToString();
            visit_Mov.Fec_RegistroInicio= request.FechaIni.ToString();
            visit_Mov.Latitud_Fin = request.LatitudFin;
            visit_Mov.Latitud_Inicio = request.LatitudInicio;
            visit_Mov.Longitud_Fin = request.LongitudFin;
            visit_Mov.Longitud_Inicio = request.LongitudInicio;
            visit_Mov.Cod_NoVisita = request.NoVisitaId.ToString();
            visit_Mov.Origen_fin = request.OrigenFin;
            visit_Mov.Origen_Inicio = request.OrigenInicio;
            visit_Mov.Cod_Persona = Convert.ToInt32(request.PersonId.ToString());
            visit_Mov.Nombre_Foto = request.NombreFoto ?? null;
            visit_Mov.Comentario_Foto = request.ComentarioFoto ?? null;//Add 09/08/2012 Pablo Salas A.
            return visit_Mov;
        }


        public string RegistrarMotivoColgateBodega_Mov(string DatosRegistro)
        {
            DataContract.RegistrarMotivoColgateBodega_Mov_Request request = HelperJson.Deserialize<DataContract.RegistrarMotivoColgateBodega_Mov_Request>(DatosRegistro);
            DataContract.RegistrarMotivoColgateBodega_Mov_Response response = new DataContract.RegistrarMotivoColgateBodega_Mov_Response();
            try
            {
                blRegistrarMotivo.RegistrarMotivoColgateBodega_Mov(request.registroMotivo);
                response.Estado = BaseResponse.EXITO;
                response.Descripcion = "El registro de motivo fue correcto.";
            }
            catch (Exception)
            {
                response.Descripcion = "No se pudo registrar su motivo.";
                response.Estado = BaseResponse.GENERAL_ERROR;
            }

            WebConfiguration.SetDefaultHeader(WebOperationContext.Current);
            string responseJSON = HelperJson.Serialize<DataContract.RegistrarMotivoColgateBodega_Mov_Response>(response);
            return responseJSON;
        }

        #endregion Métodos_Android

    }
}
