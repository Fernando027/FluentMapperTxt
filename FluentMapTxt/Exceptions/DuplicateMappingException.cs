using System;
using System.Collections.Generic;
using System.Text;

namespace FluentMapTxt.Exceptions
{
    public class DuplicateMappingException : Exception
	{
		public DuplicateMappingException(IPropertyMap map): base($"Duplicate mapping detected. Property '{map.PropertyInfo.Name}' is already mapped.")
		{

		}
    }
}
