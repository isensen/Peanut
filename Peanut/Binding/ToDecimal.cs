using System;
using System.Collections.Specialized;
namespace Peanut.Binding
{
	[Convert(typeof(decimal)), Convert(typeof(decimal?))]
	internal class ToDecimal : IConvert
	{
		public object Parse(NameValueCollection data, string key, string prefix, out bool succeed)
		{
			string value = BindUtils.GetValue(data, key, prefix);
			decimal num = 0m;
			succeed = decimal.TryParse(value, out num);
			return num;
		}
	}
}
