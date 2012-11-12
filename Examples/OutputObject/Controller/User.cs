using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace OutputObject.Controller
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string UserName
        {
            get;
            set;
        }
        [DataMember]
        public string PassWord
        {
            get;
            set;
        }
        [DataMember]
        public Gender Gender
        {
            get;
            set;
        }
        [DataMember]
        public string Email
        {
            get;
            set;
        }
    }
}