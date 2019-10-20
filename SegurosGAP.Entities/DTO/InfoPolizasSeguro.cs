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
        [DataMember] public Nullable<System.DateTime> InicioVigencia { get; set; }
        [DataMember] public Nullable<int> PeriodoCobertura { get; set; }
        [DataMember] public Nullable<decimal> PrecioPoliza { get; set; }
        [DataMember] public string TipoRiesgo { get; set; }
    }
}
