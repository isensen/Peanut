using System;
namespace Peanut.Html
{
	public class Link : HtmlElement
	{
		public new string Name
		{
			get;
			set;
		}
		public Link(string url, string name)
		{
			base.Attr("href", url);
			this.Name = name;
		}
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"<a ", 
				this.mAttributes.ToString(), 
				">", 
				this.Name, 
				"</a>"
			});
		}
	}
}
