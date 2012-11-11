﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using Smark.Core;
namespace Peanut.Html
{
    public class HtmlHelper
    {
        public static HtmlElement Input(InputType type, string name)
        {
            return new InputControl { Type = type }.Name(name);
        }
        public static HtmlElement Img()
        {
            return new Img();
        }
        public static Option Option(string name, bool selected = false)
        {
            return Option(name, name, selected);
        }
        public static Option Option(string name, string value, bool selected = false)
        {
            return new Option(name, value, selected);
        }
        public static HtmlElement Textarea(string value, string name)
        {
            return new Textarea(value).Name(name);
        }


        public static HtmlElement Link(string url, string text)
        {
            return new Link(url, text);
        }
        public object Value(EventGetValue exp)
        {
            try
            {
                return exp();
            }
            catch (Exception e_)
            {
                return null;
            }
        }

        public static void Each<T>(IList<T> items, Action<int, T> handler)
        {
            if (items != null)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    handler(i, items[i]);
                }
            }
        }

        public static string WriteDataPage(string order)
        {
            IDataPage mDataPage = WebContext.Current.GetValue<IDataPage>("DataPage");
            if (mDataPage == null)
                mDataPage = new DataPage();
            return WriteDataPage(mDataPage, order, mDataPage.PageIndex, GetUrlParams());
        }
        public static string WriteDataPage(IDataPage info, string order, int? index)
        {
            return WriteDataPage(info, order, index, null);
        }
        public static string WriteDataPage(IDataPage info, string order, int? index, IUrlParams geturl)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string paramurl;
            HttpRequest request = HttpContext.Current.Request;
            HttpResponse response = HttpContext.Current.Response;
            string orderfield = "";
            sb.Append(request.FilePath);
            if (index != null)
            {
                sb.Append("?PageIndex=" + index);
            }
            else
            {
                sb.Append("?PageIndex=" + info.PageIndex);
            }
            sb.Append("&PageSize=" + info.PageSize);
            if (order == null || order == "")
            {
                orderfield = info.OrderField;
            }
            else
            {
                if (info.OrderField == null || info.OrderField == "")
                {
                    orderfield = order + " asc";
                }
                else
                {
                    if (info.OrderField.IndexOf(order + " asc") >= 0)
                    {
                        orderfield = order + " desc";
                    }
                    else
                    {
                        orderfield = order + " asc";
                    }
                }
            }
            if (orderfield != "")
            {
                sb.Append("&OrderField=" + HttpUtility.UrlEncode(orderfield));
            }
            if (geturl != null)
            {
                paramurl = geturl.GetParams();
                if (paramurl != null && paramurl != "")
                {
                    sb.Append("&" + geturl.GetParams());
                }
            }
            return sb.ToString();

        }

        public static UrlParams GetUrlParams()
        {
            UrlParams urlparam = (UrlParams)WebContext.Current[UrlParams.DATA_TAG];
            if (urlparam == null)
            {
                urlparam = new UrlParams();
                foreach (string key in WebContext.Current.Request.QueryString.Keys)
                {
                    if (key != null && key != "OrderField" && key != "PageCount" && key != "PageIndex" && key != "PageSize" && key != "RecordCount")
                        urlparam.Add(key, WebContext.Current.Request.QueryString[key]);
                }
                WebContext.Current[UrlParams.DATA_TAG] = urlparam;
            }
            return urlparam;


        }


        public static string WriteDataPage(IDataPageProperty info, string order, int? index)
        {
            return WriteDataPage(info.DataPage, order, index, null);
        }

        public static string WriteDataPage(IDataPageProperty info, string order, int index, IUrlParams geturl)
        {
            return WriteDataPage(info.DataPage, order, index, geturl);
        }

        public static void Include(System.Web.UI.Page page, string controlfile)
        {
            page.LoadControl(controlfile).RenderControl(new HtmlTextWriter(WebContext.Current.Response.Output));
        }
    }
 


}
