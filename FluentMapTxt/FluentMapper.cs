using fluentMapTxt.Domain.Core.MapperTXT;
using fluentMapTxt.Domain.Core.MapperTXT.Entity;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace fluentMapTxt
{
    public static class FluentMapper
    {
        private static readonly MapConfiguration _configuration = new MapConfiguration();
        public static ConcurrentDictionary<Type, IEntityMap> EntityMaps = new ConcurrentDictionary<Type, IEntityMap>();
        private static string _fullPath;

        public static void Initialize(Action<MapConfiguration> configure)
        {
            configure(_configuration);
        }

        public static void Write<TEntity>(string folderPath, string fileName, TEntity entity) where TEntity : class
        {
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            _fullPath = Path.Combine(folderPath, fileName);

            var lines = new List<string>();

            if (EntityMaps.ContainsKey(typeof(TEntity)))
            {
                lines.Add(WriteLines(entity, lines));
            }

            System.IO.File.AppendAllLines(_fullPath, lines, Encoding.ASCII);
        }

        private static string WriteLines<TEntity>(TEntity entity, IList<string> lines, string line = "") where TEntity : class
        {
            var properties = EntityMaps[entity.GetType()].PropertyMaps.ToList();
            //var line = line; //string.Empty.PadLeft(size, ' ');
            var start = 0;
            for (var index = start; index < properties.Count; index++)
            {
                if (properties[index].PropertyInfo.PropertyType.GetInterfaces().Contains(typeof(IChild)))
                {
                    line = WriteLines(properties[index].PropertyInfo.GetValue(entity), lines, line);
                    continue;
                }
                var item = properties[index];
                var value = item.PropertyInfo.GetValue(entity);
                if (item.PropertyInfo.PropertyType.IsPrimitive
                    || item.PropertyInfo.PropertyType == typeof(Decimal)
                    || item.PropertyInfo.PropertyType == typeof(Decimal?)
                    || item.PropertyInfo.PropertyType == typeof(DateTime)
                    || item.PropertyInfo.PropertyType == typeof(DateTime?)
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

            //lines.Add(line);

            //return lines;
            return line;
        }

        private static string InsertInLine(string line, string valorPropriedade, IPropertyMap prop, int start, int index)
        {
            var listaRegras = new List<IRegraCampo>();
            listaRegras.Add(new CampoBranco(prop));
            listaRegras.Add(new CampoValorPadrao(prop));
            listaRegras.Add(new CampoDateTimeMascara(prop));
            listaRegras.Add(new CampoPadrao(prop));


            foreach (var item in listaRegras)
            {
                if (item.PossoExecutar())
                {
                    valorPropriedade = item.Executa(valorPropriedade);
                }
            }

            line = line + valorPropriedade;

            if (prop.QuantidadeDigitos > line.Length)
                throw new Exception("O Texto não cabe na linha.");



            //else if (prop.Formato == Formato.Sequencial)
            //{
            //	var textToInsert = index.ToString().PadLeft(prop.QuantidadeDigitos, prop.PadLeftPadrao).Substring(0, prop.QuantidadeDigitos);
            //	line = line.Insert(start, textToInsert);
            //}
            //else
            //{
            //    var textToInsert = text.PadLeft(prop.QuantidadeDigitos, prop.PadLeftPadrao).Substring(0, prop.QuantidadeDigitos);
            //    line = line.Insert(start, textToInsert);
            //}

            start = start + prop.QuantidadeDigitos;
            return line;
        }
    }
}