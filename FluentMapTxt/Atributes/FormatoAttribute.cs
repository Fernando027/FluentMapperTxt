using System;

namespace CNAB240.BB.Model
{
	public class FormatoAttribute : Attribute
	{
		private Formato v;

		public FormatoAttribute(Formato v)
		{
			this.v = v;
		}
	}
}