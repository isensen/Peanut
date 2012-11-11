using System;
using System.IO;
using System.Web;
namespace Peanut
{
	/// <summary>
	/// 控制器处理模块
	/// </summary>
    public class ActionModule : IHttpModule
	{
		public void Dispose()
		{
		}
		public void Init(HttpApplication context)
		{
			context.BeginRequest += new EventHandler(this.OnRequest);
			context.EndRequest += new EventHandler(this.OnEndRequest);
		}
		private void OnRequest(object sender, EventArgs e)
		{
			try
			{
				string filePath = WebContext.Current.Request.FilePath;
                //判断当前类型是否需要进行模板处理,默认只对aspx进行处理
				if (Utils.IsHandler(Path.GetExtension(filePath)))
				{
					string url = filePath.Substring(0, filePath.LastIndexOf('.'));
                    //获取对应的控制器方法
					ActionItem action = Utils.GetAction(url);
					WebContext.Current.Action = action;
					if (action != null)
					{
						object obj = action.Execute();
						WebContext.Current.Result = obj;
                        //如果是一个返回类型
						if (obj != null && obj is IResult)
						{
							((IResult)obj).Execute();
						}
					}
				}
			}
			catch (Exception appError)
			{
				WebContext.Current.AppError = appError;
			}
		}
		private void OnEndRequest(object sender, EventArgs e)
		{
		}
	}
}
