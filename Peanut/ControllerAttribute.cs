using System;
namespace Peanut
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ControllerAttribute : Attribute
	{
		public string Path
		{
			get;
			set;
		}
		public ControllerAttribute()
		{
		}
		public ControllerAttribute(string path)
		{
			this.Path = path;
		}
	}
}
