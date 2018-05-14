using System.Reflection;

namespace FluentMapTxt
{
	/// <summary>
	/// Represents the mapping of a property.
	/// </summary>
	public interface IPropertyMap
	{
		/// <summary>
		/// Gets the <see cref="T:System.Reflection.PropertyInfo"/> object for the current property.
		/// </summary>
		PropertyInfo PropertyInfo { get; }

		/// <summary>
		/// Gets a value indicating wether the property should be ignored when mapping.
		/// </summary>
		bool Ignored { get; }

		int Position { get; }

		int Length { get; }
		
		int PositionSort { get; }
	}
}
