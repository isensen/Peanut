using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
namespace Peanut
{
	[Serializable]
	public class UrlParams : IUrlParams
	{
		public const string DATA_TAG = "URLParams";
		protected Dictionary<string, string> mProperties = new Dictionary<string, string>();
		public void Add(string key, string value)
		{
			this.mProperties.Add(key, value);
		}
		public string GetParams()
		{
			string result;
			if (this.mProperties.Count == 0)
			{
				result = "";
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (string current in this.mProperties.Keys)
				{
					string text = this.mProperties[current];
					stringBuilder.Append(string.Format("{0}={1}&", current, (text == null) ? "" : HttpUtility.UrlEncode(text)));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}
	}
}
