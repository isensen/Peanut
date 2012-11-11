using System;
namespace Peanut
{
	[AttributeUsage(AttributeTargets.Property)]
	public class UrlParameterAttribute : Attribute
	{
		public string Format
		{
			get;
			internal set;
		}
		public UrlParameterAttribute()
		{
			this.Format = "{0}";
		}
		public UrlParameterAttribute(string format)
		{
			this.Format = format;
		}
	}
}
