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
    public partial class Cliente
    {
        [DataMember]public int IdCliente { get; set; }
        [DataMember]public string Nombre { get; set; }
        [DataMember]public string Pais { get; set; }
        [DataMember]public string Ocupacion { get; set; }
    }
}
