using System;
using System.Web;
namespace Peanut
{
	public class RedirectTo : IResult
	{
		public string Url
		{
			get;
			set;
		}
		public RedirectTo(string url)
		{
			this.Url = url;
		}
		public void Execute()
		{
			HttpContext.Current.Response.Redirect(this.Url);
		}
	}
}
