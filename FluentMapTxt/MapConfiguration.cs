using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace FluentMapTxt
{
	public class MapConfiguration
	{
		public void AddMap<TEntity>(IEntityMap<TEntity> mapper) where TEntity : class
		{
			if (!FluentMapper.EntityMaps.TryAdd(typeof(TEntity), mapper))			
			{
				throw new InvalidOperationException($"Adding entity map for type '{typeof(TEntity)}' failed. The type already exists. Current entity maps: ");
			}
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
		#endregion

	}
}
