using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CNAB240.BB.Model;

namespace FluentMapTxt
{
	public static class FluentMapper
	{
		private static readonly MapConfiguration _configuration = new MapConfiguration();
		public static ConcurrentDictionary<Type, IEntityMap> EntityMaps = new ConcurrentDictionary<Type, IEntityMap>();
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
			var lines = new List<string>();

			if (EntityMaps.ContainsKey(typeof(TEntity)))
			{
				lines.Concat(WriteLines(entity, lines));
			}

			System.IO.File.WriteAllLines(_fullPath, lines, Encoding.ASCII);
		}

		private static IList<string> WriteLines<TEntity>(TEntity entity, IList<string> lines) where TEntity : class
		{
			var properties = EntityMaps[entity.GetType()].PropertyMaps.ToList();
			var size = properties.Sum(x => x.Digitos);
			var line = string.Empty.PadLeft(size, ' ');
			var start = 0;
			for (var index = 0; index < properties.Count; index++)
			{
				var item = properties[index];
				var value = item.PropertyInfo.GetValue(entity);
				if (item.PropertyInfo.PropertyType.IsPrimitive
					|| item.PropertyInfo.PropertyType == typeof(Decimal)
					|| item.PropertyInfo.PropertyType == typeof(DateTime)
					|| item.PropertyInfo.PropertyType == typeof(String))
				{
					var text = string.Empty;

					if (value != null)
					{
						text = value.ToString();
					}

					line = InsertInLine(line, text, item, start, index);
				}
			}

			lines.Add(line);

			//foreach (var item in properties)
			//{
			//	object value = item.PropertyInfo.GetValue(entity);
			//	if (value is IList && value.GetType().IsGenericType)
			//	{
			//		var collection = (IEnumerable)item.PropertyInfo.GetValue(entity, null);

			//		foreach (var itemCollecion in collection)
			//		{
			//			lines.Concat(WriteLines(itemCollecion, lines));
			//		}
			//	}
			//	else
			//	{
			//		if (!item.PropertyInfo.PropertyType.IsPrimitive
			//		&& item.PropertyInfo.PropertyType != typeof(Decimal)
			//		&& item.PropertyInfo.PropertyType != typeof(DateTime)
			//		&& item.PropertyInfo.PropertyType != typeof(String))
			//		{
			//			lines.Concat(WriteLines(value, lines));
			//		}
			//	}
			//}

			return lines;
		}

		private static string InsertInLine(string line, string text, IPropertyMap prop, int start, int index)
		{
			prop.PadLeftPadrao = ' ';
			if (prop.Digitos > line.Length)
				throw new Exception("O Texto não cabe na linha.");

			if (prop.Brancos)
			{
				var blanktext = "".PadLeft(prop.Digitos, prop.PadLeftPadrao).Substring(0, prop.Digitos);
				line = line.Insert(start, blanktext);
			}
			else if (!string.IsNullOrEmpty(prop.Instrucao))
			{
				var instrucao = prop.Instrucao.PadLeft(prop.Digitos, prop.PadLeftPadrao).Substring(0, prop.Digitos);
				line = line.Insert(start, instrucao);
			}
			else if (prop.Formato == Formato.Sequencial)
			{
				var textToInsert = index.ToString().PadLeft(prop.Digitos, prop.PadLeftPadrao).Substring(0, prop.Digitos);
				line = line.Insert(start, textToInsert);
			}
			else
			{
				var textToInsert = text.PadLeft(prop.Digitos, prop.PadLeftPadrao).Substring(0, prop.Digitos);
				line = line.Insert(start, textToInsert);
			}

			start = start + prop.Digitos;
			return line;
		}
	}
}