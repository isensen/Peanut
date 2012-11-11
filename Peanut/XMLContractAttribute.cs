using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
namespace Peanut
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class XMLContractAttribute : OutputContractAttribute
	{
		private static Dictionary<Type, DataContractSerializer> mJsonSerializers = new Dictionary<Type, DataContractSerializer>(256);
		private static DataContractSerializer GetSerializer(Type type)
		{
			DataContractSerializer dataContractSerializer;
			lock (XMLContractAttribute.mJsonSerializers)
			{
				if (!XMLContractAttribute.mJsonSerializers.TryGetValue(type, out dataContractSerializer))
				{
					dataContractSerializer = new DataContractSerializer(type);
					XMLContractAttribute.mJsonSerializers.Add(type, dataContractSerializer);
				}
			}
			return dataContractSerializer;
		}
		public override void Execute(Stream stream, object data)
		{
			if (data != null)
			{
				DataContractSerializer serializer = XMLContractAttribute.GetSerializer(data.GetType());
				serializer.WriteObject(stream, data);
			}
		}
	}
}
