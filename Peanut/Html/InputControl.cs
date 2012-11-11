using System;
namespace Peanut.Html
{
	public class InputControl : HtmlElement
	{
		public InputType Type
		{
			get;
			set;
		}
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"<input type=\"", 
				this.Type.ToString(), 
				"\"", 
				this.mAttributes.ToString(), 
				"/>"
			});
		}
	}
}
