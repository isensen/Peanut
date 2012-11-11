using System;
using System.IO;
namespace Peanut
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public abstract class OutputContractAttribute : Attribute
	{
		public abstract void Execute(Stream stream, object data);
	}
}
