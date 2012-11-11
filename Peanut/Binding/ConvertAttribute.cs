using System;
namespace Peanut.Binding
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class ConvertAttribute : Attribute
	{
		public Type Convert
		{
			get;
			set;
		}
		public ConvertAttribute()
		{
		}
		public ConvertAttribute(Type convert)
		{
			this.Convert = convert;
		}
	}
}
