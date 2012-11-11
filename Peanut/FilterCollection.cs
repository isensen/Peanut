using System;
using System.CodeDom.Compiler;
using System.Configuration;
namespace Peanut
{
	[ConfigurationCollection(typeof(PublicFilter), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMapAlternate, AddItemName = "add", RemoveItemName = "remove", ClearItemsName = "clear")]
	public class FilterCollection : ConfigurationElementCollection
	{
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string PublicFilterPropertyName = "publicFilter";
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
				return "publicFilter";
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public PublicFilter this[int index]
		{
			get
			{
				return (PublicFilter)base.BaseGet(index);
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public PublicFilter this[object name]
		{
			get
			{
				return (PublicFilter)base.BaseGet(name);
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override bool IsElementName(string elementName)
		{
			return elementName == "publicFilter";
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((PublicFilter)element).Name;
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override ConfigurationElement CreateNewElement()
		{
			return new PublicFilter();
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public void Add(PublicFilter publicFilter)
		{
			base.BaseAdd(publicFilter);
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public void Remove(PublicFilter publicFilter)
		{
			base.BaseRemove(this.GetElementKey(publicFilter));
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public PublicFilter GetItemAt(int index)
		{
			return (PublicFilter)base.BaseGet(index);
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public PublicFilter GetItemByKey(string name)
		{
			return (PublicFilter)base.BaseGet(name);
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override bool IsReadOnly()
		{
			return false;
		}
	}
}
