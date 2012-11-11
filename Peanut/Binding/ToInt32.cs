using System;
using System.Collections.Specialized;
namespace Peanut.Binding
{
	[Convert(typeof(int)), Convert(typeof(int?))]
	internal class ToInt32 : IConvert
	{
		public object Parse(NameValueCollection data, string key, string prefix, out bool succeed)
		{
			string value = BindUtils.GetValue(data, key, prefix);
			int num = 0;
			succeed = int.TryParse(value, out num);
			return num;
		}
	}
}
