using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
namespace Peanut
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class JSONContractAttribute : OutputContractAttribute
	{
		private static Dictionary<Type, DataContractJsonSerializer> mJsonSerializers = new Dictionary<Type, DataContractJsonSerializer>(256);
		private static DataContractJsonSerializer GetSerializer(Type type)
		{
			DataContractJsonSerializer dataContractJsonSerializer;
			lock (JSONContractAttribute.mJsonSerializers)
			{
				if (!JSONContractAttribute.mJsonSerializers.TryGetValue(type, out dataContractJsonSerializer))
				{
					dataContractJsonSerializer = new DataContractJsonSerializer(type);
					JSONContractAttribute.mJsonSerializers.Add(type, dataContractJsonSerializer);
				}
			}
			return dataContractJsonSerializer;
		}
		public override void Execute(Stream stream, object data)
		{
			if (data != null)
			{
				DataContractJsonSerializer serializer = JSONContractAttribute.GetSerializer(data.GetType());
				serializer.WriteObject(stream, data);
			}
		}
	}
}
