using System;
using System.Collections.Specialized;
namespace Peanut.Binding
{
	public class ToEnum<T> : IConvert where T : struct
	{
		public object Parse(NameValueCollection data, string key, string prefix, out bool succeed)
		{
			string value = BindUtils.GetValue(data, key, prefix);
			object result;
			if (string.IsNullOrEmpty(value))
			{
				succeed = true;
				result = default(T);
			}
			else
			{
				IEnumValue enumConvert = BindUtils.GetEnumConvert(typeof(T));
				result = enumConvert.GetValue(value, out succeed);
			}
			return result;
		}
	}
}
