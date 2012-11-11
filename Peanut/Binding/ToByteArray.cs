using System;
namespace Peanut.Binding
{
	[Convert(typeof(byte[])), Convert(typeof(byte?[]))]
	internal class ToByteArray : ToArray<byte>
	{
		protected override bool Parse(string value, out byte result)
		{
			return byte.TryParse(value, out result);
		}
	}
}
