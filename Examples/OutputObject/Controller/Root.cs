using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OutputObject.Controller
{
    [Peanut.Controller]
    public class Root
    {
        public class Register:Peanut.IView
        {
            public User User
            {
                get;
                set;
            }

            public string OutpuType
            {
                get;
                set;
            }

            public object Execute(Peanut.RequestType type)
            {
                if (OutpuType == "xml")
                {
                    return new Peanut.OutputObject(User, new Peanut.XMLContractAttribute());
                }
                else
                {
                    return new Peanut.OutputObject(User, new Peanut.JSONContractAttribute());
                }
            }
        }
    }
}