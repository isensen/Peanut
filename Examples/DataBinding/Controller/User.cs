using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBinding.Controller
{
    public class User
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
        public string Email
        {
            get;
            set;
        }
    }
}