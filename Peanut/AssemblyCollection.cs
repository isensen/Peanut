using System;
using System.CodeDom.Compiler;
using System.Configuration;
namespace Peanut
{
	[ConfigurationCollection(typeof(AssemblyItem), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMapAlternate, AddItemName = "add", RemoveItemName = "remove", ClearItemsName = "clear")]
	public class AssemblyCollection : ConfigurationElementCollection
	{
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string AssemblyItemPropertyName = "assemblyItem";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.AddRemoveClearMapAlternate;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override string ElementName
		{
			get
			{
				return "assemblyItem";
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public AssemblyItem this[int index]
		{
			get
			{
				return (AssemblyItem)base.BaseGet(index);
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public AssemblyItem this[object assembly]
		{
			get
			{
				return (AssemblyItem)base.BaseGet(assembly);
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override bool IsElementName(string elementName)
		{
			return elementName == "assemblyItem";
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((AssemblyItem)element).Assembly;
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override ConfigurationElement CreateNewElement()
		{
			return new AssemblyItem();
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public void Add(AssemblyItem assemblyItem)
		{
			base.BaseAdd(assemblyItem);
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public void Remove(AssemblyItem assemblyItem)
		{
			base.BaseRemove(this.GetElementKey(assemblyItem));
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public AssemblyItem GetItemAt(int index)
		{
			return (AssemblyItem)base.BaseGet(index);
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public AssemblyItem GetItemByKey(string assembly)
		{
			return (AssemblyItem)base.BaseGet(assembly);
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override bool IsReadOnly()
		{
			return false;
		}
	}
}
