using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FluentMapTxt
{
	public static class FluentMapper
	{
		private static readonly MapConfiguration _configuration = new MapConfiguration();
		public static readonly ConcurrentDictionary<Type, IEntityMap> EntityMaps = new ConcurrentDictionary<Type, IEntityMap>();
		private static string _fullPath;

		public static void Initialize(string folderPath, string fileName, Action<MapConfiguration> configure)
		{
			configure(_configuration);

			if (!Directory.Exists(folderPath))
				Directory.CreateDirectory(folderPath);

			_fullPath = Path.Combine(folderPath, fileName);
		}


		public static void Write<TEntity>(TEntity entity) where TEntity : class
		{
			Type type = typeof(TEntity);
			var lines = new List<string>();

			if (EntityMaps.ContainsKey(typeof(TEntity)))
			{
				lines.Concat(WriteLines(entity, lines));
			}


			System.IO.File.WriteAllLines(_fullPath, lines, Encoding.ASCII);

			//foreach (var prop in type.GetProperties())
			//{
			//	if (prop is IList && prop.GetType().IsGenericType)
			//	{
			//		var collection = (IEnumerable)prop.GetValue(entity, null);

			//		foreach (var item in collection)
			//		{
			//			line = writeLine(item, line);
			//		}
			//	}
			//	else
			//	{
			//		if (EntityMaps.ContainsKey(typeof(TEntity)))
			//		{
			//			line = writeLine(entity, line);
			//		}
			//		else
			//		{
			//			line = writeLine(prop.GetValue(entity), line);
			//		}
			//	}
			//}
		}

		private static IList<string> WriteLines<TEntity>(TEntity entity, IList<string> lines) where TEntity : class
		{
			var line = string.Empty.PadLeft(100, ' ');
			var properties = EntityMaps[entity.GetType()].PropertyMaps.OrderBy(x => x.PositionSort).ToList();

			foreach (var item in properties)
			{
				object value = item.PropertyInfo.GetValue(entity);
				if (item.PropertyInfo.PropertyType.IsPrimitive
					|| item.PropertyInfo.PropertyType == typeof(Decimal)
					|| item.PropertyInfo.PropertyType == typeof(DateTime)
					|| item.PropertyInfo.PropertyType == typeof(String))
				{
					string text = string.Empty;

					if (value != null)
						text = value.ToString();

					line = InsertInLine(line, text, item.Position, item.Length);
				}
			}

			lines.Add(line);

			foreach (var item in properties)
			{
				object value = item.PropertyInfo.GetValue(entity);
				if (value is IList && value.GetType().IsGenericType)
				{
					var collection = (IEnumerable)item.PropertyInfo.GetValue(entity, null);

					foreach (var itemCollecion in collection)
					{
						lines.Concat(WriteLines(itemCollecion, lines));
					}
				}
				else
				{
					if (!item.PropertyInfo.PropertyType.IsPrimitive
					&& item.PropertyInfo.PropertyType != typeof(Decimal)
					&& item.PropertyInfo.PropertyType != typeof(DateTime)
					&& item.PropertyInfo.PropertyType != typeof(String))
					{
						lines.Concat(WriteLines(value, lines));
					}
				}
			}

			return lines;
		}

		private static string InsertInLine(string line, string text, int position, int length)
		{
			if (position + length > line.Length)
				throw new Exception("O Texto não cabe na linha.");

			var textToInsert = text.PadLeft(length, ' ');
			line = line.Insert(position, textToInsert);
			return line;
		}
	}
}


