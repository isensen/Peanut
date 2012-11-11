using System;
using System.Collections.Specialized;
namespace Peanut.Binding
{
	[Convert(typeof(bool?)), Convert(typeof(bool))]
	internal class ToBoolean : IConvert
	{
		public object Parse(NameValueCollection data, string key, string prefix, out bool succeed)
		{
			string value = BindUtils.GetValue(data, key, prefix);
			bool flag = false;
			succeed = bool.TryParse(value, out flag);
			return flag;
		}
	}
}
