using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
namespace Peanut.Html
{
	public abstract class HtmlElement
	{
		protected StringBuilder mAttributes = new StringBuilder();
		private IList<HtmlElement> mControls = new List<HtmlElement>();
		protected IList<HtmlElement> Controls
		{
			get
			{
				return this.mControls;
			}
		}
		public HtmlElement Attr(HtmlAttribute attributre, string value)
		{
			return this.Attr(attributre.ToString().ToLower(), value);
		}
		public HtmlElement Attr(string attributre, string value)
		{
			this.mAttributes.Append(string.Format(" {0}=\"{1}\" ", attributre, value));
			return this;
		}
		public HtmlElement Accesskey(string value)
		{
			return this.Attr(HtmlAttribute.Accesskey, value);
		}
		public HtmlElement Class(string value)
		{
			return this.Attr(HtmlAttribute.Class, value);
		}
		public HtmlElement Dir(string value)
		{
			return this.Attr(HtmlAttribute.Dir, value);
		}
		public HtmlElement Disabled(string value)
		{
			return this.Attr(HtmlAttribute.Disabled, value);
		}
		public HtmlElement Id(string value)
		{
			return this.Attr(HtmlAttribute.Id, value);
		}
		public HtmlElement Lang(string value)
		{
			return this.Attr(HtmlAttribute.Lang, value);
		}
		public HtmlElement Maxlength(string value)
		{
			return this.Attr(HtmlAttribute.Maxlength, value);
		}
		public HtmlElement Name(string value)
		{
			return this.Attr(HtmlAttribute.Name, value);
		}
		public HtmlElement Readonly(string value)
		{
			return this.Attr(HtmlAttribute.Readonly, value);
		}
		public HtmlElement Size(string value)
		{
			return this.Attr(HtmlAttribute.Size, value);
		}
		public HtmlElement Style(string value)
		{
			return this.Attr(HtmlAttribute.Style, value);
		}
		public HtmlElement Tabindex(string value)
		{
			return this.Attr(HtmlAttribute.Tabindex, value);
		}
		public HtmlElement Title(string value)
		{
			return this.Attr(HtmlAttribute.Title, value);
		}
		public HtmlElement Value(object value)
		{
			string value2 = (value == null) ? "" : value.ToString();
			return this.Attr(HtmlAttribute.Value, value2);
		}
		public HtmlElement Visible(string value)
		{
			return this.Attr(HtmlAttribute.Visible, value);
		}
		public HtmlElement Checked(bool value)
		{
			HtmlElement result;
			if (value)
			{
				result = this.Attr(HtmlAttribute.Checked, "Checked");
			}
			else
			{
				result = this;
			}
			return result;
		}
		public HtmlElement Src(string value)
		{
			return this.Attr(HtmlAttribute.Src, value);
		}
		public HtmlElement CustomAttr(object attribute)
		{
			this.mAttributes.Append(" " + attribute + " ");
			return this;
		}
		public void Output()
		{
			HttpContext.Current.Response.Write(this.ToString());
		}
	}
}
