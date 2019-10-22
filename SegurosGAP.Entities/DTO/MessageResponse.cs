using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SegurosGAP.Entities.DTO
{
    public class MessageResponse
    {
        [DataMember] public int Code { get; set; }
        [DataMember] public string Message { get; set; }
    }
}
