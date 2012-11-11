using System;
using System.Collections.Specialized;
namespace Peanut.Binding
{
	[Convert(typeof(string[]))]
	internal class ToStringArray : IConvert
	{
		public object Parse(NameValueCollection data, string key, string prefix, out bool succeed)
		{
			string[] array = BindUtils.GetValues(data, key, prefix);
			succeed = true;
			if (array == null)
			{
				array = new string[0];
			}
			return array;
		}
	}
}
