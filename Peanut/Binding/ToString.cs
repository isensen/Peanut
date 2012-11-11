using System;
using System.Collections.Specialized;
namespace Peanut.Binding
{
	[Convert(typeof(string))]
	internal class ToString : IConvert
	{
		public object Parse(NameValueCollection data, string key, string prefix, out bool succeed)
		{
			string value = BindUtils.GetValue(data, key, prefix);
			if (string.IsNullOrEmpty(value))
			{
				succeed = false;
			}
			else
			{
				succeed = true;
			}
			return value;
		}
	}
}
