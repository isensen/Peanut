using Smark.Core;
using System;
using System.Collections.Specialized;
using System.Reflection;
namespace Peanut.Binding
{
    class ParameterBinder
    {
        public ParameterBinder(System.Reflection.ParameterInfo pi)
        {
            Info = pi;
            BindAttribute[] bas = Functions.GetParemeterAttributes<BindAttribute>(pi, false);
            if (bas.Length > 0)
                Binder = bas[0];
            ViewStateAttribute[] vsa = Functions.GetParemeterAttributes<ViewStateAttribute>(pi, false);
            if (vsa.Length > 0)
                ViewState = vsa[0];


        }

        public ViewStateAttribute ViewState
        {
            get;
            set;
        }

        public System.Reflection.ParameterInfo Info
        {
            get;
            set;
        }

        public BindAttribute Binder
        {
            get;
            set;
        }

        private bool GetValueTypeValue(System.Collections.Specialized.NameValueCollection data, string Prefix, out object value)
        {
            IConvert convert = null;
            value = null;
            Type createtype = Info.ParameterType;
            if (Binder != null && Binder.Convert == null && Binder.Fungible != null)
                createtype = Binder.Fungible;
            bool succed = false;
            if (Binder != null && !string.IsNullOrEmpty(Binder.Prefix))
                Prefix = Binder.Prefix;
            if (Binder != null)
                convert = Binder.GetConvert();
            if (convert == null)
            {
                if (BindUtils.Converts.ContainsKey(createtype))
                    convert = BindUtils.Converts[createtype];
            }
            if (convert != null)
            {
                value = convert.Parse(data, Info.Name, Prefix, out succed);
            }
            else
            {
                if (createtype.IsEnum)
                {
                    string pvalue = BindUtils.GetValue(data, Info.Name, Prefix);
                    IEnumValue evalue = BindUtils.GetEnumConvert(createtype);
                    value = evalue.GetValue(pvalue, out succed);


                }

            }
            return succed;
        }

        private bool GetClassValue(System.Collections.Specialized.NameValueCollection data, string Prefix, out object value)
        {
            IConvert convert = null;
            value = null;
            Type createtype = Info.ParameterType;
            if (Binder != null && Binder.Convert == null && Binder.Fungible != null)
                createtype = Binder.Fungible;
            bool succed = false;
            if (Binder != null && !string.IsNullOrEmpty(Binder.Prefix))
                Prefix = Binder.Prefix;
            if (Binder != null)
                convert = Binder.GetConvert();
            if (convert == null)
            {
                if (BindUtils.Converts.ContainsKey(createtype))
                    convert = BindUtils.Converts[createtype];
            }
            if (convert != null)
            {
                value = convert.Parse(data, Info.Name, Prefix, out succed);
            }
            else if (createtype.IsArray)
            {
                if (createtype.GetElementType().IsEnum)
                {
                    Type toenumtype = typeof(ToEnumArray<>).MakeGenericType(createtype.GetElementType());
                    IConvert tea = (IConvert)Activator.CreateInstance(toenumtype);
                    BindUtils.AddCustomConvert(toenumtype, tea);
                    value = tea.Parse(data, Info.Name, Prefix, out succed);
                }
            }
            else
            {
                if (createtype.IsClass && !createtype.IsInterface &&
                  !createtype.IsAbstract)
                {
                    ClassBinder cb = BindUtils.GetBinder(createtype);
                    succed = true;
                    value = cb.CreateObject(data, Prefix);
                }
            }

            return succed;
        }

        public bool GetValue(System.Collections.Specialized.NameValueCollection data, string Prefix, out object value)
        {
            Type createtype = Info.ParameterType;
            if (createtype.IsValueType || createtype.IsEnum || createtype == typeof(string))
            {
                return GetValueTypeValue(data, Prefix, out value);
            }
            else
            {
                return GetClassValue(data, Prefix, out value);
            }

        }

    }
}
