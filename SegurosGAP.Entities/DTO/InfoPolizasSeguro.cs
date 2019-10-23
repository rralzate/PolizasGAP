using System;
using System.Runtime.Serialization;

namespace SegurosGAP.Entities.DTO
{
    public partial class InfoPolizasSeguro
    {
        [DataMember] public int IdPolizaSeguro { get; set; }
        [DataMember] public string Nombre { get; set; }
        [DataMember] public string Descripcion { get; set; }
        [DataMember] public string TipoCubrimiento { get; set; }
        [DataMember] public string InicioVigencia { get; set; }
        [DataMember] public Nullable<int> PeriodoCobertura { get; set; }
        [DataMember] public Nullable<decimal> PrecioPoliza { get; set; }
        [DataMember] public string TipoRiesgo { get; set; }
        [DataMember] public int IdTipoCubrimiento { get; set; }
        [DataMember] public int IdTipoRiesgo { get; set; }
    }
}
