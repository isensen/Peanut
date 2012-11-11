using System;
using System.Collections.Specialized;
namespace Peanut.Binding
{
	public class ToEnumArray<T> : IConvert where T : struct
	{
		public object Parse(NameValueCollection data, string key, string prefix, out bool succeed)
		{
			Array array = Array.CreateInstance(typeof(T), 0);
			string[] values = BindUtils.GetValues(data, key, prefix);
			if (values != null)
			{
				array = Array.CreateInstance(typeof(T), values.Length);
				for (int i = 0; i < values.Length; i++)
				{
					IEnumValue enumConvert = BindUtils.GetEnumConvert(typeof(T));
					array.SetValue(enumConvert.GetValue(values[i], out succeed), i);
				}
			}
			succeed = true;
			return array;
		}
	}
}
