using System;
using System.ComponentModel;
using System.Reflection;

namespace FluentMapTxt
{
	/// <summary>
	/// Serves as the base class for all property mapping implementations.
	/// </summary>
	/// <typeparam name="TPropertyMap">The type of the property mapping.</typeparam>
	public abstract class PropertyMapBase<TPropertyMap> where TPropertyMap : class, IPropertyMap
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Dapper.FluentMap.Mapping.PropertyMap"/> using
		/// the specified <see cref="T:System.Reflection.PropertyInfo"/> object representing the property to map.
		/// </summary>
		/// <param name="info">The <see cref="T:System.Reflection.PropertyInfo"/> object representing to the property to map.</param>
		protected PropertyMapBase(PropertyInfo info)
		{
			PropertyInfo = info;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Dapper.FluentMap.Mapping.PropertyMap"/> using
		/// the specified <see cref="T:System.Reflection.PropertyInfo"/> object representing the property to map
		/// and column name to map the property to.
		/// </summary>
		/// <param name="info">The <see cref="T:System.Reflection.PropertyInfo"/> object representing to the property to map.</param>
		/// <param name="columnName">The column name in the database to map the property to.</param>
		internal PropertyMapBase(PropertyInfo info, int position)
		{
			PropertyInfo = info;
			Position = position;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Dapper.FluentMap.Mapping.PropertyMap"/> using
		/// the specified <see cref="T:System.Reflection.PropertyInfo"/> object representing the property to map,
		/// column name to map the property to and a value indicating whether the mapping should be case sensitive.
		/// </summary>
		/// <param name="info">The <see cref="T:System.Reflection.PropertyInfo"/> object representing to the property to map.</param>
		/// <param name="columnName">The column name in the database to map the property to.</param>
		/// <param name="caseSensitive">A value indicating whether the mappig should be case sensitive.</param>
		internal PropertyMapBase(PropertyInfo info, int position, int length)
		{
			PropertyInfo = info;
			Length = length;
			Position = position;
		}

		/// <summary>
		/// Gets a value indicating the property should be ignored when mapping.
		/// </summary>
		public bool Ignored { get; private set; }

		public int Position { get; private set; }

		public int PositionSort { get; private set; }

		public int Length { get; private set; }

		/// <summary>
		/// Gets a reference to the <see cref="System.Reflection.PropertyInfo"/> of this mapping.
		/// </summary>
		public PropertyInfo PropertyInfo { get; }

		public TPropertyMap PositionStart(int position)
		{
			Position = position;
			return this as TPropertyMap;
		}

		public TPropertyMap SetPositionSort(int positionSort)
		{
			PositionSort = positionSort;
			return this as TPropertyMap;
		}


		public TPropertyMap LengthCharacter(int length)
		{
			Length = length;
			return this as TPropertyMap;
		}


		/// <summary>
		/// Marks the current property as ignored, resulting in the property not being mapped by Dapper.
		/// </summary>
		/// <returns>The current <see cref="T:Dapper.FluentMap.Mapping.PropertyMap"/> instance. This enables a fluent API.</returns>
		public TPropertyMap Ignore()
		{
			Ignored = true;
			return this as TPropertyMap;
		}


		#region EditorBrowsableStates
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Type GetType()
		{
			return base.GetType();
		}
		#endregion
	}
}
