using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Lucky.CFG.JavaMovil;
using Lucky.Entity.Common.EAPro;

namespace Lucky.Services.Contracts.DataContract
{
    public class EAPRO_Obtener_salas_Request
    {
    }

    public class EAPRO_Obtener_salas_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_Sala> listaSalas { get; set; }
    }

    public class EAPRO_Obtener_centro_costo_Request
    {
    }

    public class EAPRO_Obtener_centro_costo_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_CentroCosto> listaCentroCosto { get; set; }
    }

    public class EAPRO_Validar_usuario_Request
    {
        [JsonProperty("a")]
        public string usuario { get; set; }

        [JsonProperty("b")]
        public string clave { get; set; }
    }

    public class EAPRO_Validar_usuario_Response : BaseResponse
    {
        [JsonProperty("a")]
        public EAPRO_Usuario eUsuario { get; set; }
    }

    public class EAPRO_Obtener_usuarios_Request
    {
    }

    public class EAPRO_Obtener_usuarios_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<EAPRO_Usuario> listUsuarios { get; set; }
    }

    public class EAPRO_Obtener_separaciones_Request
    {
        [JsonProperty("a")]
        public string codigoSala { get; set; }

        [JsonProperty("b")]
        public string codigoUsuario { get; set; }

        [JsonProperty("c")]
        public string codigoEncargado { get; set; }

        [JsonProperty("d")]
        public string codigoCentroCosto { get; set; }
        
        [JsonProperty("e")]
        public string fechaInicio { get; set; }

        [JsonProperty("f")]
        public string fechaFin { get; set; }
    }

    public class EAPRO_Obtener_separaciones_Response : BaseResponse
    {
        [JsonProperty("a")]
        public List<E_SalasSeparadas> listSeparaciones { get; set; }
    }

    public class EAPRO_Registrar_separacion_Request
    {
        [JsonProperty("a")]
        public string codigoSala { get; set; }

        [JsonProperty("b")]
        public string codigoUsuario { get; set; }

        [JsonProperty("c")]
        public string codigoEncargado { get; set; }

        [JsonProperty("d")]
        public string codigoCargo { get; set; }

        [JsonProperty("e")]
        public string codigoCentroCosto { get; set; }

        [JsonProperty("f")]
        public string descripcion { get; set; }

        [JsonProperty("g")]
        public string adicionales { get; set; }

        [JsonProperty("h")]
        public string cantidad { get; set; }

        [JsonProperty("i")]
        public string fecha { get; set; }

        [JsonProperty("j")]
        public string horaInicio { get; set; }

        [JsonProperty("k")]
        public string horaFin { get; set; }
    }

    public class EAPRO_Registrar_separacion_Response : BaseResponse
    {
    }

    public class EAPRO_Actualizar_separacion_Request
    {
        [JsonProperty("a")]
        public int codigoRegistro { get; set; }

        [JsonProperty("b")]
        public string codigoSala { get; set; }

        [JsonProperty("c")]
        public string codigoUsuario { get; set; }

        [JsonProperty("d")]
        public string codigoEncargado { get; set; }

        [JsonProperty("e")]
        public string codigoCargo { get; set; }

        [JsonProperty("f")]
        public string codigoCentroCosto { get; set; }

        [JsonProperty("g")]
        public string descripcion { get; set; }

        [JsonProperty("h")]
        public string adicionales { get; set; }

        [JsonProperty("i")]
        public string cantidad { get; set; }

        [JsonProperty("j")]
        public string fecha { get; set; }

        [JsonProperty("k")]
        public string horaInicio { get; set; }

        [JsonProperty("l")]
        public string horaFin { get; set; }
    }

    public class EAPRO_Actualizar_separacion_Fecha_Request
    {
        [JsonProperty("a")]
        public int codigoRegistro { get; set; }

        [JsonProperty("b")]
        public string fecha { get; set; }
    }

    public class EAPRO_Actualizar_separacion_Response : BaseResponse
    {
    }

    public class EAPRO_Eliminar_separacion_Request
    {
        [JsonProperty("a")]
        public int codigoRegistro { get; set; }
    }

    public class EAPRO_Eliminar_separacion_Response : BaseResponse
    {
    }
}
