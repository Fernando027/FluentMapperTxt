using System;

namespace CNAB240.BB.Model
{
	public class DigitosAttribute : Attribute
	{
		private int v;

		public DigitosAttribute(int v)
		{
			this.v = v;
		}
	}
}