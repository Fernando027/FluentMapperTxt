using System;

namespace fluentMapTxt.Exceptions
{
    public class DuplicateMappingException : Exception
    {
        public DuplicateMappingException(IPropertyMap map) : base($"Duplicate mapping detected. Property '{map.PropertyInfo.Name}' is already mapped.")
        {

        }
    }
}
