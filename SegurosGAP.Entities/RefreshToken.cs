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
    public partial class RefreshToken
    {
        [DataMember]public int IdRefreshTokens { get; set; }
        [DataMember]public string Id { get; set; }
        [DataMember]public string Subject { get; set; }
        [DataMember]public string ClientId { get; set; }
        [DataMember]public System.DateTime IssuedUtc { get; set; }
        [DataMember]public System.DateTime ExpiresUtc { get; set; }
        [DataMember]public string ProtectedTicket { get; set; }
    }
}