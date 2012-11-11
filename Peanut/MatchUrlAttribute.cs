using System;
namespace Peanut
{
	[AttributeUsage(AttributeTargets.Class)]
	public class MatchUrlAttribute : Attribute
	{
		public string Regex
		{
			get;
			set;
		}
		internal ActionItem Item
		{
			get;
			set;
		}
		public MatchUrlAttribute(string regex)
		{
			this.Regex = regex;
		}
	}
}
