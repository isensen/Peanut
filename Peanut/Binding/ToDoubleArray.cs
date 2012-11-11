using System;
namespace Peanut.Binding
{
	[Convert(typeof(double[])), Convert(typeof(double?[]))]
	internal class ToDoubleArray : ToArray<double>
	{
		protected override bool Parse(string value, out double result)
		{
			return double.TryParse(value, out result);
		}
	}
}
