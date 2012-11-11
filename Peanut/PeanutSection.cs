using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
namespace Peanut
{
	public class PeanutSection : ConfigurationSection
	{
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string PeanutSectionSectionName = "peanutSection";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string XmlnsPropertyName = "xmlns";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string TypesPropertyName = "types";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string BasePathPropertyName = "basePath";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string AssembliesPropertyName = "assemblies";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string FiltersPropertyName = "filters";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public static PeanutSection Instance
		{
			get
			{
				return (PeanutSection)ConfigurationManager.GetSection("peanutSection");
			}
		}
		[ConfigurationProperty("xmlns", IsRequired = false, IsKey = false, IsDefaultCollection = false), GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public string Xmlns
		{
			get
			{
				return (string)base["xmlns"];
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The Types."), ConfigurationProperty("types", IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = ".aspx")]
		public virtual string Types
		{
			get
			{
				return (string)base["types"];
			}
			set
			{
				base["types"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The BasePath."), ConfigurationProperty("basePath", IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = "/")]
		public virtual string BasePath
		{
			get
			{
				return (string)base["basePath"];
			}
			set
			{
				base["basePath"] = value;
			}
		}
		[ConfigurationProperty("assemblies", IsRequired = false, IsKey = false, IsDefaultCollection = false), Description("The Assemblies."), GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public virtual AssemblyCollection Assemblies
		{
			get
			{
				return (AssemblyCollection)base["assemblies"];
			}
			set
			{
				base["assemblies"] = value;
			}
		}
		[ConfigurationProperty("filters", IsRequired = false, IsKey = false, IsDefaultCollection = false), Description("The Filters."), GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public virtual FilterCollection Filters
		{
			get
			{
				return (FilterCollection)base["filters"];
			}
			set
			{
				base["filters"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override bool IsReadOnly()
		{
			return false;
		}
	}
}
