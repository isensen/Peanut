using System;
namespace Peanut.Html
{
	public class Option : HtmlElement
	{
		public new string Name
		{
			get;
			set;
		}
		public new string Value
		{
			get;
			set;
		}
		public bool Selected
		{
			get;
			set;
		}
		public Option(string name, string value, bool selected = false)
		{
			this.Name = name;
			this.Value = value;
			this.Selected = selected;
		}
		public override string ToString()
		{
			return string.Format("<option value=\"{0}\" {2}>{1}</option>", this.Value, this.Name, this.Selected ? "selected" : "");
		}
	}
}
