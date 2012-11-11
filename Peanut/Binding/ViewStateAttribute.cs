using System;
namespace Peanut.Binding
{
	[AttributeUsage(AttributeTargets.Property)]
	public class ViewStateAttribute : Attribute
	{
		public bool ByPostData
		{
			get;
			set;
		}
	}
}
