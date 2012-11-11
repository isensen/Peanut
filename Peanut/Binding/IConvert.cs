using System;
using System.Collections.Specialized;
namespace Peanut.Binding
{
	public interface IConvert
	{
		object Parse(NameValueCollection data, string key, string prefix, out bool succeed);
	}
}
