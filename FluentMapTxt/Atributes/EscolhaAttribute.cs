using System;

namespace CNAB240.BB.Model
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
	public class EscolhaAttribute : Attribute
	{
		public string Key { get; set; }
		public string Value { get; set; }
	}
}