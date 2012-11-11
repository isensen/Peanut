using Smark.Core;
using System;
using System.Reflection;
namespace Peanut
{
	internal class UrlParamterBuilder
	{
		public string Name
		{
			get;
			set;
		}
		public UrlParameterAttribute Attribute
		{
			get;
			set;
		}
		public PropertyHandler Handler
		{
			get;
			set;
		}
		public UrlParamterBuilder(PropertyInfo pi)
		{
			this.Handler = new PropertyHandler(pi);
			this.Name = pi.Name;
		}
	}
}
