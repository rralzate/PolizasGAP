//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SegurosGAP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    [DataContract(IsReference = true)]
    public partial class PolizasSeguro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PolizasSeguro()
        {
            this.PolizasClientes = new HashSet<PolizasCliente>();
        }
    
        [DataMember]public int IdPolizaSeguro { get; set; }
        [DataMember]public string Nombre { get; set; }
        [DataMember]public string Descripcion { get; set; }
        [DataMember]public int IdTipoCubrimiento { get; set; }
        [DataMember]public Nullable<System.DateTime> InicioVigencia { get; set; }
        [DataMember]public Nullable<int> PeriodoCobertura { get; set; }
        [DataMember]public Nullable<decimal> PrecioPoliza { get; set; }
        [DataMember]public int IdTipoRiesgo { get; set; }
    
        public virtual TiposCubrimiento TiposCubrimiento { get; set; }
        public virtual TiposRiesgo TiposRiesgo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolizasCliente> PolizasClientes { get; set; }
    }
}
