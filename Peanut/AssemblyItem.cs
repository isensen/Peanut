using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
namespace Peanut
{
	public class AssemblyItem : ConfigurationElement
	{
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string AssemblyPropertyName = "assembly";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), ConfigurationProperty("assembly", IsRequired = true, IsKey = true, IsDefaultCollection = false), Description("The Assembly.")]
		public virtual string Assembly
		{
			get
			{
				return (string)base["assembly"];
			}
			set
			{
				base["assembly"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override bool IsReadOnly()
		{
			return false;
		}
	}
}
