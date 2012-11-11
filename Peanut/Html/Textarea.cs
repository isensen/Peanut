using System;
namespace Peanut.Html
{
	public class Textarea : HtmlElement
	{
		public string Text
		{
			get;
			set;
		}
		public Textarea(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				value = "";
			}
			this.Text = value;
		}
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"<textarea ", 
				this.mAttributes.ToString(), 
				">", 
				this.Text, 
				"</Textarea>"
			});
		}
	}
}
