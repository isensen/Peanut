﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Smark.Core;
namespace Peanut
{
    public class WebContext
    {

        const string WEBCONTEXT = "__WEBCONTEXT";

        public HttpRequest Request
        {
            get
            {
                return HttpContext.Current.Request;
            }
        }

        private static List<FilterAttribute> mPublicFilters = new List<FilterAttribute>(8);

        private KeyValueCollection<object> mProperties = new KeyValueCollection<object>();

        public static IList<FilterAttribute> PublicFilters
        {
            get
            {
                return mPublicFilters;
            }
        }

        public object this[string name]
        {
            get
            {
                return mProperties[name];
            }
            set
            {
                mProperties[name] = value;
            }
        }

        public object Result
        {
            get;
            set;
        }

        public static WebContext Current
        {
            get
            {
              
                if (HttpContext.Current.Items[WEBCONTEXT] == null)
                    HttpContext.Current.Items[WEBCONTEXT] = new WebContext();
                return (WebContext)HttpContext.Current.Items[WEBCONTEXT];
            }
            
        }
        internal ActionItem Action
        {
            get;
            set;
        }

      

        //public static void SetActionOutput(OutputContractAttribute output)
        //{
        //    if (ActionHandler.CurrentAction != null)
        //        ActionHandler.CurrentAction.Output = output;
        //}

        public HttpResponse Response
        {
            get
            {
                return HttpContext.Current.Response;
            }
        }

        public Exception AppError
        {
            get
            {
                return (Exception)this["_ERROR"];
            }
            set{
                this["_ERROR"] = value;
            }
        }

        public IView View
        {
            get
            {
                return (IView)this["_IVIEW"];
            }
            set
            {
                this["_IVIEW"] = value;
            }
        }

        public T GetResult<T>()
        {
            object value = View;
            if (value == null)
                return default(T);
            return (T)value;
                    
        }

        public T GetValue<T>(string name)
        {
            object data = this[name];
            if (data != null)
                return (T)data;
            return default(T);
        }

    }
}
