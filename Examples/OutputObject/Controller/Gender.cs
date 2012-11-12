using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace OutputObject.Controller
{
    
    [DataContract]
    public enum Gender
    {
        [EnumMember]
        Female,
        [EnumMember]
        Male
    }
}