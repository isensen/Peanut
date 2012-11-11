using System;
namespace Peanut
{
	public interface IView
	{
		object Execute(RequestType type);
	}
}
