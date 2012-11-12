using System;
using System.IO;
using System.Web;
namespace Peanut
{
	/// <summary>
	/// ����������ģ��
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
            WebContext context = WebContext.Current;
            try
			{
				string filePath = WebContext.Current.Request.FilePath;
                //�жϵ�ǰ�����Ƿ���Ҫ����ģ�崦��,Ĭ��ֻ��aspx���д���
				if (Utils.IsHandler(Path.GetExtension(filePath)))
				{
                    
                    string url = filePath.Substring(0, filePath.LastIndexOf('.'));
                    //��ȡ��Ӧ�Ŀ���������
					ActionItem action = Utils.GetAction(url);
                    context.ActionPath = url;
                    context.Action = action;
                    context.RequestType = (RequestType)Enum.Parse(typeof(RequestType), context.Request.RequestType);
					if (action != null)
					{
						object obj = action.Execute();
                        context.Result = obj;
                        //�����һ����������
						if (obj != null && obj is IResult)
						{
							((IResult)obj).Execute();
						}
					}
				}
			}
			catch (Exception appError)
			{
                context.AppError = appError;
			}
		}
		private void OnEndRequest(object sender, EventArgs e)
		{
		}
	}
}
