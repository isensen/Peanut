using Smark.Core;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
namespace Peanut.Binding
{
	internal class BindUtils
	{
		private static Dictionary<Type, IEnumValue> mEnumConvert = new Dictionary<Type, IEnumValue>(128);
		private static IDictionary<Type, IConvert> mConverts;
		private static Dictionary<Type, ClassBinder> mClassBinders = new Dictionary<Type, ClassBinder>();
		internal static IDictionary<Type, IConvert> Converts
		{
			get
			{
				if (BindUtils.mConverts == null)
				{
					BindUtils.LoadConverts();
				}
				return BindUtils.mConverts;
			}
		}
		internal static string GetValue(NameValueCollection data, string key, string prefix)
		{
			string text = data[key];
			string result;
			if (string.IsNullOrEmpty(prefix))
			{
				result = text;
			}
			else
			{
				if (string.IsNullOrEmpty(text))
				{
					text = data[prefix + "." + key];
				}
				if (string.IsNullOrEmpty(text))
				{
					text = data[prefix + "_" + key];
				}
				if (string.IsNullOrEmpty(text))
				{
					text = data[prefix + key];
				}
				result = text;
			}
			return result;
		}
		public static IEnumValue GetEnumConvert(Type type)
		{
			IEnumValue enumValue;
			lock (BindUtils.mEnumConvert)
			{
				if (!BindUtils.mEnumConvert.TryGetValue(type, out enumValue))
				{
					Type type2 = typeof(EnumValue<>).MakeGenericType(new Type[]
					{
						type
					});
					enumValue = (IEnumValue)Activator.CreateInstance(type2);
					BindUtils.mEnumConvert.Add(type, enumValue);
				}
			}
			return enumValue;
		}
		internal static string[] GetValues(NameValueCollection data, string key, string prefix)
		{
			string[] values = data.GetValues(key);
			string[] result;
			if (string.IsNullOrEmpty(prefix))
			{
				result = values;
			}
			else
			{
				if (values.Length == 0)
				{
					values = data.GetValues(prefix + "." + key);
				}
				if (values.Length == 0)
				{
					values = data.GetValues(prefix + "_" + key);
				}
				if (values.Length == 0)
				{
					values = data.GetValues(prefix + key);
				}
				result = values;
			}
			return result;
		}
		internal static IConvert GetConvert(Type type)
		{
			IConvert result = null;
			BindUtils.Converts.TryGetValue(type, out result);
			return result;
		}
		private static void LoadConverts()
		{
			lock (typeof(BindUtils))
			{
				if (BindUtils.mConverts == null)
				{
					BindUtils.mConverts = new Dictionary<Type, IConvert>();
					BindUtils.LoadBaseConvert();
				}
			}
		}
		private static void AddConvert(Type convert, ConvertAttribute[] ca)
		{
			if (ca.Length > 0)
			{
				for (int i = 0; i < ca.Length; i++)
				{
					ConvertAttribute convertAttribute = ca[i];
					if (BindUtils.Converts.ContainsKey(convertAttribute.Convert))
					{
						BindUtils.Converts[convertAttribute.Convert] = (IConvert)Activator.CreateInstance(convert);
					}
					else
					{
						BindUtils.Converts.Add(convertAttribute.Convert, (IConvert)Activator.CreateInstance(convert));
					}
				}
			}
		}
		private static void LoadBaseConvert()
		{
			Assembly assembly = typeof(BindUtils).Assembly;
			BindUtils.LoadConvertByAssembly(assembly);
		}
		private static void LoadConvertByAssembly(Assembly ass)
		{
			Type[] types = ass.GetTypes();
			for (int i = 0; i < types.Length; i++)
			{
				Type type = types[i];
				if (type.GetInterface(typeof(IConvert).FullName) != null)
				{
					BindUtils.AddConvert(type, Functions.GetTypeAttributes<ConvertAttribute>(type, false));
				}
			}
		}
		public static void AddCustomConvert(params Assembly[] assemblies)
		{
			for (int i = 0; i < assemblies.Length; i++)
			{
				Assembly ass = assemblies[i];
				BindUtils.LoadConvertByAssembly(ass);
			}
		}
		internal static ClassBinder GetBinder(Type type)
		{
			if (type.GetConstructor(new Type[0]) == null)
			{
				throw new Exception(string.Format("{0}不存在默认构造函数,无法构建数据绑定!", type.Name));
			}
			ClassBinder result;
			if (BindUtils.mClassBinders.ContainsKey(type))
			{
				result = BindUtils.mClassBinders[type];
			}
			else
			{
				lock (BindUtils.mClassBinders)
				{
					if (!BindUtils.mClassBinders.ContainsKey(type))
					{
						BindUtils.mClassBinders.Add(type, new ClassBinder(type));
					}
					result = BindUtils.mClassBinders[type];
				}
			}
			return result;
		}
		public static void AddCustomConvert(Type type, IConvert convert)
		{
			lock (BindUtils.mConverts)
			{
				if (!BindUtils.mConverts.ContainsKey(type))
				{
					BindUtils.mConverts.Add(type, convert);
				}
			}
		}
	}
}
