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

		/// <summary>
		/// Initializes a new instance of the <see cref="Dapper.FluentMap.Mapping.PropertyMap"/> class
		/// with the specified <see cref="System.Reflection.PropertyInfo"/> object and column name.
		/// </summary>
		/// <param name="info">The information about the property.</param>
		/// <param name="columnName">The column name.</param>
		public PropertyMap(PropertyInfo info, int position)
			: base(info, position)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Dapper.FluentMap.Mapping.PropertyMap"/> class
		/// with the specified <see cref="System.Reflection.PropertyInfo"/> object, column name
		/// and a value indicating whether the mapping should be case sensitive.
		/// </summary>
		/// <param name="info">The information about the property.</param>
		/// <param name="columnName">The column name.</param>
		/// <param name="caseSensitive">A value indicating whether the mappig should be case sensitive.</param>
		public PropertyMap(PropertyInfo info, int position, int length)
			: base(info, position, length)
		{
		}
	}
}
