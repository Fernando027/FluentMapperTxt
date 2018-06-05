using System.Reflection;

namespace FluentMapTxt
{
	/// <summary>
	/// Represents the mapping of a property.
	/// </summary>
	public class PropertyMap : PropertyMapBase<PropertyMap>, IPropertyMap
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Dapper.FluentMap.Mapping.PropertyMap"/> class
		/// with the specified <see cref="System.Reflection.PropertyInfo"/> object.
		/// </summary>
		/// <param name="info">The information about the property.</param>
		public PropertyMap(PropertyInfo info)
			: base(info)
		{
		}
	}
}