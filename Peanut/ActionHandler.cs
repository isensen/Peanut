using System;
using System.Web;
namespace Peanut
{
	/// <summary>
	/// 
	/// </summary>
    public class ActionHandler : IHttpHandler
	{
		public bool IsReusable
		{
			get
			{
				return true;
			}
		}
		public void ProcessRequest(HttpContext context)
		{
			try
			{
				string filePath = context.Request.FilePath;
				string text = filePath.Substring(0, filePath.LastIndexOf('.'));
				ActionItem action = WebContext.Current.Action;
				if (action != null)
				{
					if (action.Output != null)
					{
						action.Output.Execute(context.Response.OutputStream, WebContext.Current.Result);
					}
				}
			}
			catch (Exception appError)
			{
				WebContext.Current.AppError = appError;
			}
		}
	}
}
