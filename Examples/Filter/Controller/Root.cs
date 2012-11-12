using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filter.Controller
{
    [Peanut.Controller]
    public class Root
    {
        [NumberValidater]
        public class Default:Peanut.IView
        {
            public int Number
            {
                get;
                set;
            }
            public string Result
            {
                get;
                set;
            }
            public object Execute(Peanut.RequestType type)
            {
                if (type == Peanut.RequestType.POST )
                {
                    Result = string.Format("value:{0}", Number);
                }
                
                return this;
            }
        }
    }
}