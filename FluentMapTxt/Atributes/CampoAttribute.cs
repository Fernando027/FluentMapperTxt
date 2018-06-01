using System;

namespace CNAB240.BB.Model
{
	public class CampoAttribute : Attribute
	{
		private string v;

		public CampoAttribute(string v)
		{
			this.v = v;
		}
	}
}