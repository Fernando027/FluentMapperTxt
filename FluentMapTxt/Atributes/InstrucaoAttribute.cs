using System;

namespace CNAB240.BB.Model
{
	public class InstrucaoAttribute : Attribute
	{
		private string v;

		public InstrucaoAttribute(string v)
		{
			this.v = v;
		}
	}
}