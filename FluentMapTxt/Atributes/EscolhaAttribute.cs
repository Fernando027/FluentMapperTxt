using System;

namespace fluentMapTxt.Model
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
	public class EscolhaAttribute : Attribute
	{
		public string Key { get; set; }
		public string Value { get; set; }
	}
}