using System;
using System.Collections.Specialized;
namespace Peanut.Binding
{
	[Convert(typeof(float?)), Convert(typeof(float))]
	internal class ToFloat : IConvert
	{
		public object Parse(NameValueCollection data, string key, string prefix, out bool succeed)
		{
			string value = BindUtils.GetValue(data, key, prefix);
			float num = 0f;
			succeed = float.TryParse(value, out num);
			return num;
		}
	}
}
