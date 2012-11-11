using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolleWord.Controller
{
    [Peanut.Controller]
    public class Root
    {
        public class Default : Peanut.IView
        {
            public string YouName
            {
                get;
                set;
            }

            public string Data
            {
                get;
                set;
            }
            public object Execute(Peanut.RequestType type)
            {
                if (type == Peanut.RequestType.POST)
                {
                    if (!string.IsNullOrEmpty(YouName))
                    {
                        Data = string.Format("holle {0} :) Peanut  is .net mvc framework!",YouName);
                    }
                }
                return this;
            }
        }
    }
}