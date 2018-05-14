
using FluentMapTxt;
using System.Collections.Generic;
/// <summary>
/// Represents a typed mapping of an entity.
/// This serves as a marker interface for generic type inference.
/// </summary>
/// <typeparam name="TEntity">The type of the entity to configure the mapping for.</typeparam>
public interface IEntityMap<TEntity> : IEntityMap
{
}

/// <summary>
/// Represents a non-typed mapping of an entity.
/// </summary>
public interface IEntityMap
{
	/// <summary>
	/// Gets the collection of mapped properties.
	/// </summary>
	IList<IPropertyMap> PropertyMaps { get; }
}