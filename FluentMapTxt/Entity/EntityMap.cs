using FluentMapTxt;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

/// <summary>
/// Represents a typed mapping of an entity.
/// </summary>
/// <typeparam name="TEntity">The type of the entity to configure the mapping for.</typeparam>
public abstract class EntityMap<TEntity> : EntityMapBase<TEntity, PropertyMap>
	where TEntity : class
{
	/// <inheritdoc />
	protected override PropertyMap GetPropertyMap(PropertyInfo info)
	{
		return new PropertyMap(info);
	}
}
