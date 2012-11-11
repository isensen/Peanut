using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
namespace Peanut
{
	public class PublicFilter : ConfigurationElement
	{
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string NamePropertyName = "name";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string TypePropertyName = "type";
		[Description("The Name."), ConfigurationProperty("name", IsRequired = true, IsKey = true, IsDefaultCollection = false), GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public virtual string Name
		{
			get
			{
				return (string)base["name"];
			}
			set
			{
				base["name"] = value;
			}
		}
		[ConfigurationProperty("type", IsRequired = true, IsKey = false, IsDefaultCollection = false), GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The Type.")]
		public virtual string Type
		{
			get
			{
				return (string)base["type"];
			}
			set
			{
				base["type"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override bool IsReadOnly()
		{
			return false;
		}
	}
}
