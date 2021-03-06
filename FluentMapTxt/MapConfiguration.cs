﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace fluentMapTxt
{
	public class MapConfiguration
	{
		public void AddFromMap<TEntity>(IEntityMap<TEntity> mapper) where TEntity : class
		{
			if (!FluentMapper.EntityMaps.TryAdd(typeof(TEntity), mapper))
			{
				throw new InvalidOperationException($"Adding entity map for type '{typeof(TEntity)}' failed. The type already exists. Current entity maps: ");
			}
		}

		public void AddFromDataAnnotations<TEntity>(Type type) where TEntity : class
		{
			EntityMap<TEntity> mapper = new EntityMap<TEntity>();
			mapper.PropertyMaps = ReflectionHelper.GetAttributeValue(type);
			this.AddFromMap<TEntity>(mapper);
		}

		#region EditorBrowsableStates

		/// <inheritdoc/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		/// <inheritdoc/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <inheritdoc/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <inheritdoc/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Type GetType()
		{
			return base.GetType();
		}

		#endregion EditorBrowsableStates
	}
}