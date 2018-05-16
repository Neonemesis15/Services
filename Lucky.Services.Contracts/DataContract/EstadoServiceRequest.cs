using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.Application.JavaMovil;

namespace Lucky.Services.Contracts.DataContract
{
    public class EstadoServiceRequest
    {

    }

    public class RegistrarVisitaRequest
    {
        private int personId;

        [JsonProperty("i")]
        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }
        private String perfilId;

        [JsonProperty("p")]
        public String PerfilId
        {
            get { return perfilId; }
            set { perfilId = value; }
        }
        private String equipoId;

        [JsonProperty("e")]
        public String EquipoId
        {
            get { return equipoId; }
            set { equipoId = value; }
        }
        private String clienteId;

        [JsonProperty("c")]
        public String ClienteId
        {
            get { return clienteId; }
            set { clienteId = value; }
        }
        private String clientPDV_Code;

        [JsonProperty("v")]
        public String ClientPDV_Code
        {
            get { return clientPDV_Code; }
            set { clientPDV_Code = value; }
        }
        private String noVisitaId;

        [JsonProperty("n")]
        public String NoVisitaId
        {
            get { return noVisitaId; }
            set { noVisitaId = value; }
        }
        private String fechaIni;

        [JsonProperty("f")]
        public String FechaIni
        {
            get { return fechaIni; }
            set { fechaIni = value; }
        }
        private String latitudInicio;

        [JsonProperty("l")]
        public String LatitudInicio
        {
            get { return latitudInicio; }
            set { latitudInicio = value; }
        }
        private String longitudInicio;

        [JsonProperty("g")]
        public String LongitudInicio
        {
            get { return longitudInicio; }
            set { longitudInicio = value; }
        }
        private String origenInicio;

        [JsonProperty("o")]
        public String OrigenInicio
        {
            get { return origenInicio; }
            set { origenInicio = value; }
        }
        private String fechaFin;

        [JsonProperty("h")]
        public String FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        private String latitudFin;

        [JsonProperty("m")]
        public String LatitudFin
        {
            get { return latitudFin; }
            set { latitudFin = value; }
        }
        private String longitudFin;

        [JsonProperty("q")]
        public String LongitudFin
        {
            get { return longitudFin; }
            set { longitudFin = value; }
        }
        private String origenFin;

        [JsonProperty("r")]
        public String OrigenFin
        {
            get { return origenFin; }
            set { origenFin = value; }
        }

    }

    public class RegistrarVisitaResponse : BaseResponse
    {
    }

    public class RegistrarMarcacionRequest
    {
        private int personId;
        [JsonProperty("i")]
        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }

        private String perfilId;
        [JsonProperty("p")]
        public String PerfilId
        {
            get { return perfilId; }
            set { perfilId = value; }
        }

        private String equipoId;
        [JsonProperty("e")]
        public String EquipoId
        {
            get { return equipoId; }
            set { equipoId = value; }
        }

        private String clienteId;
        [JsonProperty("c")]
        public String ClienteId
        {
            get { return clienteId; }
            set { clienteId = value; }
        }

        private String estadoId;
        [JsonProperty("s")]
        public String EstadoId
        {
            get { return estadoId; }
            set { estadoId = value; }
        }

        private String motivoId;
        [JsonProperty("n")]
        public String MotivoId
        {
            get { return motivoId; }
            set { motivoId = value; }
        }
        private String fechaIni;
        [JsonProperty("f")]
        public String FechaIni
        {
            get { return fechaIni; }
            set { fechaIni = value; }
        }

        private String latitudInicio;
        [JsonProperty("l")]
        public String LatitudInicio
        {
            get { return latitudInicio; }
            set { latitudInicio = value; }
        }

        private String longitudInicio;
        [JsonProperty("g")]
        public String LongitudInicio
        {
            get { return longitudInicio; }
            set { longitudInicio = value; }
        }

        private String origenInicio;
        [JsonProperty("o")]
        public String OrigenInicio
        {
            get { return origenInicio; }
            set { origenInicio = value; }
        }

        private String fechaFin;
        [JsonProperty("h")]
        public String FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        private String latitudFin;
        [JsonProperty("m")]
        public String LatitudFin
        {
            get { return latitudFin; }
            set { latitudFin = value; }
        }

        private String longitudFin;
        [JsonProperty("q")]
        public String LongitudFin
        {
            get { return longitudFin; }
            set { longitudFin = value; }
        }

        private String origenFin;
        [JsonProperty("r")]
        public String OrigenFin
        {
            get { return origenFin; }
            set { origenFin = value; }
        }
    }

    public class RegistrarMarcacionResponse : BaseResponse
    {
    }

    #region Clases_Android

    public class RegistrarMarcacion_Mov_Request
    {
        [JsonProperty("i")]
        public int personId { get; set; }
        
        [JsonProperty("e")]
        public string equipoId { get; set; }

        [JsonProperty("c")]
        public string clienteId { get; set; }

        [JsonProperty("s")]
        public string estadoId { get; set; }

        [JsonProperty("n")]
        public string motivoId { get; set; }

        [JsonProperty("f")]
        public string fechaIni { get; set; }

        [JsonProperty("l")]
        public string latitudInicio { get; set; }

        [JsonProperty("g")]
        public string longitudInicio { get; set; }

        [JsonProperty("o")]
        public string origenInicio { get; set; }
        
        [JsonProperty("h")]
        public string fechaFin { get; set; }

        [JsonProperty("m")]
        public string latitudFin { get; set; }

        [JsonProperty("q")]
        public string longitudFin { get; set; }

        [JsonProperty("r")]
        public string origenFin { get; set; }
    }

    public class RegistrarVisita_Mov_Request
    {
        [JsonProperty("i")]
        public int PersonId { get; set; }
        
        [JsonProperty("e")]
        public string EquipoId { get; set; }

        [JsonProperty("c")]
        public string ClienteId { get; set; }

        [JsonProperty("v")]
        public string ClientPDV_Code { get; set; }

        [JsonProperty("n")]
        public string NoVisitaId { get; set; }

        [JsonProperty("f")]
        public string FechaIni { get; set; }

        [JsonProperty("l")]
        public string LatitudInicio { get; set; }

        [JsonProperty("g")]
        public string LongitudInicio { get; set; }

        [JsonProperty("o")]
        public string OrigenInicio { get; set; }

        [JsonProperty("h")]
        public string FechaFin { get; set; }

        [JsonProperty("m")]
        public string LatitudFin { get; set; }
        
        [JsonProperty("q")]
        public string LongitudFin { get; set; }

        [JsonProperty("r")]
        public string OrigenFin { get; set; }

        /// <summary>
        /// Author:Pablo Salas
        /// Fecha: 30/07/2012
        /// Descripcion: Se agrega un nodo para la Fotografia.
        /// </summary>
        private string nombreFoto;
        [JsonProperty("s")]
        public string NombreFoto
        {
            get { return nombreFoto; }
            set { nombreFoto = value; }
        }

        /// <summary>
        /// Author:Pablo Salas
        /// Fecha: 09/08/2012
        /// Descripcion: Se agrega un nodo "t" para el comentario de la Fotografia.
        /// </summary>
        private string comentarioFoto;
        [JsonProperty("t")]
        public string ComentarioFoto
        {
            get { return comentarioFoto; }
            set { comentarioFoto = value; }
        }

    }


    /// <summary>
    /// Autor       : Joseph Gonzales
    /// Fecha       : 06 - 06 - 2012
    /// Descripción : Registra los motivos de no implementación y no mantenimiento.
    /// </summary>
    public class RegistrarMotivoColgateBodega_Mov_Request
    {
        [JsonProperty("a")]
        public E_Registro_MotivoFase registroMotivo { get; set; }
    }
    
    public class RegistrarMotivoColgateBodega_Mov_Response : BaseResponse
    {
    }

    #endregion Clases_Android
}
