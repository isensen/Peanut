using System;
namespace Peanut
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public abstract class FilterAttribute : Attribute
	{
		public abstract void Execute(FilterContext context);
	}
}
