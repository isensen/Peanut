﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Smark.Core;
using System.Reflection;
using Peanut.Binding;
using System.Collections.Specialized;
namespace Peanut
{
    public class ActionItem
    {
        public ActionItem(Type info)
        {
            Filters = new List<FilterAttribute>();
            View = info;
            Init();
        }

        private void Init()
        {

            foreach (PropertyInfo pi in View.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                InvokeParameter parameter = new InvokeParameter(pi);
                BindAttribute[] ba = Functions.GetPropertyAttributes<BindAttribute>(pi, false);
                if (ba.Length > 0)
                    parameter.Binder = ba[0];
                Parameters.Add(parameter);
            }
        }

        public OutputContractAttribute Output
        {
            get;
            set;
        }

        public IList<FilterAttribute> Filters
        {
            get;
            set;
        }

        private IView GetView()
        {
            IView result = (IView)Activator.CreateInstance(View);

            return result;
        }

        private void BindView(IView view)
        {
            NameValueCollection data = WebContext.Current.Request.Params;
            object[] p = new object[mParameters.Count];
            for (int i = 0; i < Parameters.Count; i++)
            {
                object value = mParameters[i].GetValue(data);
                mParameters[i].Handler.Set(view, value);
            }
        }

        public Type View
        {
            get;
            set;
        }

        private List<InvokeParameter> mParameters = new List<InvokeParameter>();

        public IList<InvokeParameter> Parameters
        {
            get
            {
                return mParameters;
            }
        }

        public object Execute()
        {

            FilterContext filtercontext = new FilterContext(Filters);
            filtercontext.View = GetView();

            try
            {
                BindView(filtercontext.View);
                filtercontext.Execute();
            }
            catch (Exception e_)
            {
                WebContext.Current.AppError = e_;
            }
            finally
            {
                if (WebContext.Current != null)
                {
                    for (int i = 0; i < mParameters.Count; i++)
                    {
                        WebContext.Current[mParameters[i].Info.Name] = mParameters[i].Handler.Get(filtercontext.View);
                    }
                    WebContext.Current.View = filtercontext.View;
                }
            }
            return filtercontext.Result;
        }

        public class InvokeParameter
        {
            public InvokeParameter(PropertyInfo info)
            {
                Info = info;
                Handler = new PropertyHandler(info);
            }

            public PropertyInfo Info
            {
                get;
                set;
            }

            public PropertyHandler Handler
            {
                get;
                set;
            }

            public BindAttribute Binder
            {
                get;
                set;
            }

            public object GetValue(NameValueCollection data)
            {
                object value = null;
                bool succeed = false;
                if (Binder != null)
                {
                    value = Binder.GetConvert().Parse(data, Info.Name, Binder.Prefix, out succeed);
                    if (!succeed && Binder.Fungible != null)
                        value = Activator.CreateInstance(Binder.Fungible);
                    return value;
                }
                else
                {
                    IConvert convert = BindUtils.GetConvert(Info.PropertyType);
                    if (convert != null)
                    {
                        value = convert.Parse(data, Info.Name, null, out succeed);

                    }
                    else
                    {
                        if (Info.PropertyType.IsValueType)
                        {
                            value = BinderHelper.GetValue(Info.PropertyType, Info.Name);
                        }
                        else
                        {
                            value = GetObject(data);
                        }
                    }
                }
                return value;
            }

            private object GetObject(NameValueCollection data)
            {
                if (Info.PropertyType.GetInterface(typeof(IList<>).Name) != null || Info.PropertyType.Name == "IList`1")
                {
                    if (Binder == null)
                    {
                        return BinderHelper.GetList(Info.PropertyType, data, null);
                    }
                    else
                    {
                        return BinderHelper.GetList(Info.PropertyType, data, Binder.Prefix);
                    }
                }
                else
                {
                    if (Binder == null)
                    {
                        return BinderHelper.GetObject(Info.PropertyType, null);
                    }
                    else
                    {
                        return BinderHelper.GetObject(Info.PropertyType, Binder.Prefix);
                    }
                }
            }
        }
    }
}
