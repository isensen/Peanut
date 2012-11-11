using System;
namespace Peanut.Binding
{
	[Convert(typeof(bool[])), Convert(typeof(bool?[]))]
	internal class ToBooleanArray : ToArray<bool>
	{
		protected override bool Parse(string value, out bool result)
		{
			return bool.TryParse(value, out result);
		}
	}
}
