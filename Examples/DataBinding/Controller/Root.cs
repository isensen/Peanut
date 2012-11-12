using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBinding.Controller
{
    [Peanut.Controller]
    public class Root
    {
        public class ValueBinding:Peanut.IView
        {
            public string UserName
            {
                get;
                set;
            }
            public string PassWord
            {
                get;
                set;
            }
            public Gender Gender
            {
                get;
                set;
            }
            public string EMail
            {
                get;
                set;
            }
            public object Execute(Peanut.RequestType type)
            {
                return this;
            }
        }

        public class FileBinding:Peanut.IView
        {

            public IList<Peanut.Binding.PostFile> Files
            {
                get;
                set;
            }

            public object Execute(Peanut.RequestType type)
            {
                return this;
            }
        }

        public class ObjectBinding:Peanut.IView
        {
            public User User
            {
                get;
                set;
            }

            public object Execute(Peanut.RequestType type)
            {
                return this;
            }
        }
    }
}