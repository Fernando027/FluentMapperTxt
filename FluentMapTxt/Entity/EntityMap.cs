using FluentMapTxt;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

/// <summary>
/// Represents a typed mapping of an entity.
/// </summary>
/// <typeparam name="TEntity">The type of the entity to configure the mapping for.</typeparam>
public class EntityMap<TEntity> : EntityMapBase<TEntity, PropertyMap>
	where TEntity : class
{
	/// <inheritdoc />
	public override PropertyMap GetPropertyMap(PropertyInfo info)
	{
		return new PropertyMap(info);
	}
}