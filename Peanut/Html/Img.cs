using System;
namespace Peanut.Html
{
	public class Img : HtmlElement
	{
		public override string ToString()
		{
			return "<Img " + this.mAttributes.ToString() + "/>";
		}
	}
}
