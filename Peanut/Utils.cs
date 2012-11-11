using Smark.Core;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
namespace Peanut
{
	internal class Utils
	{
		private static Dictionary<string, string> mFileTypes;
		private static Dictionary<string, ActionItem> mActions;
		private static IList<MatchUrlAttribute> mMatchUrls;
		private static Dictionary<string, bool> mNonActions;
		static Utils()
		{
			Utils.mFileTypes = new Dictionary<string, string>();
			Utils.mActions = new Dictionary<string, ActionItem>(256);
			Utils.mMatchUrls = new List<MatchUrlAttribute>(256);
			Utils.mNonActions = new Dictionary<string, bool>(256);
			string[] array = PeanutSection.Instance.Types.Split(new char[]
			{
				'|'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				Utils.mFileTypes.Add(text.ToLower(), text);
			}
			foreach (AssemblyItem assemblyItem in PeanutSection.Instance.Assemblies)
			{
				Utils.LoadAssembly(Assembly.Load(assemblyItem.Assembly));
			}
		}
		private static void LoadAssembly(Assembly assembly)
		{
			Type[] types = assembly.GetTypes();
			for (int i = 0; i < types.Length; i++)
			{
				Type type = types[i];
				ControllerAttribute[] typeAttributes = Functions.GetTypeAttributes<ControllerAttribute>(type, false);
				if (typeAttributes.Length > 0)
				{
					Utils.LoadController(typeAttributes[0], type, Functions.GetTypeAttributes<FilterAttribute>(type, true), Functions.GetTypeAttributes<OutputContractAttribute>(type, true));
				}
			}
		}
		private static void LoadController(ControllerAttribute controller, Type type, FilterAttribute[] filters, OutputContractAttribute[] outputs)
		{
			string text = WebContext.Current.Request.ApplicationPath;
			if (!string.IsNullOrEmpty(controller.Path))
			{
				text += controller.Path;
			}
			Type[] nestedTypes = type.GetNestedTypes();
			for (int i = 0; i < nestedTypes.Length; i++)
			{
				Type type2 = nestedTypes[i];
				if (type2.GetInterface("Peanut.IView") != null)
				{
					string text2 = text + type2.Name;
					ActionItem actionItem = new ActionItem(type2);
					if (outputs.Length > 0)
					{
						actionItem.Output = outputs[0];
					}
					outputs = Functions.GetTypeAttributes<OutputContractAttribute>(type2, true);
					if (outputs.Length > 0)
					{
						actionItem.Output = outputs[0];
					}
					for (int j = 0; j < filters.Length; j++)
					{
						FilterAttribute item = filters[j];
						actionItem.Filters.Add(item);
					}
					FilterAttribute[] typeAttributes = Functions.GetTypeAttributes<FilterAttribute>(type2, true);
					for (int j = 0; j < typeAttributes.Length; j++)
					{
						FilterAttribute item = typeAttributes[j];
						actionItem.Filters.Add(item);
					}
					if (Utils.mActions.ContainsKey(text.ToLower()))
					{
						Utils.mActions[text2.ToLower()] = actionItem;
					}
					else
					{
						Utils.mActions.Add(text2.ToLower(), actionItem);
					}
					MatchUrlAttribute[] typeAttributes2 = Functions.GetTypeAttributes<MatchUrlAttribute>(type2, false);
					if (typeAttributes2.Length > 0)
					{
						typeAttributes2[0].Item = actionItem;
						Utils.mMatchUrls.Add(typeAttributes2[0]);
					}
				}
			}
		}
		internal static ActionItem GetAction(string url)
		{
			url = url.ToLower();
			ActionItem matchUrls;
			if (!Utils.mActions.TryGetValue(url, out matchUrls))
			{
				if (!Utils.mNonActions.ContainsKey(url))
				{
					matchUrls = Utils.GetMatchUrls(url);
				}
			}
			return matchUrls;
		}
		internal static ActionItem GetMatchUrls(string url)
		{
			ActionItem result;
			lock (Utils.mMatchUrls)
			{
				ActionItem actionItem = null;
				if (!Utils.mActions.TryGetValue(url, out actionItem))
				{
					for (int i = 0; i < Utils.mMatchUrls.Count; i++)
					{
						if (Regex.IsMatch(url, Utils.mMatchUrls[i].Regex))
						{
							Utils.mActions.Add(url, Utils.mMatchUrls[i].Item);
							actionItem = Utils.mMatchUrls[i].Item;
						}
					}
					if (actionItem == null)
					{
						if (!Utils.mNonActions.ContainsKey(url))
						{
							Utils.mNonActions.Add(url, true);
						}
					}
				}
				result = actionItem;
			}
			return result;
		}
		internal static bool IsHandler(string type)
		{
			return Utils.mFileTypes.ContainsKey(type.ToLower());
		}
	}
}
