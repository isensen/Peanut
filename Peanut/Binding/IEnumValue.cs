using System;
namespace Peanut.Binding
{
	internal interface IEnumValue
	{
		object GetValue(string value, out bool succeed);
	}
}
