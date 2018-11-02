using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace fluentMapTxt.Model
{
	public class CampoAttribute : Attribute
	{
		public CampoAttribute()
		{
		}

		//private string Codigo { get; set; }
		//public int Ordem { get; set; }
		public int QuantidadeDigitos { get; set; }
		public char PadLeftPadrao { get; set; }

        public Formato Formato { get; set; }
        public string DateTimeMascara { get; set; }
        public string ValorPadrao { get; set; }
        public bool Brancos { get; set; }

        //public string[] Condicional { get; set; }
        //public string[] Escolha { get; set; }

        //public List<KeyValuePair<string, string>> Teste { get; set; }
    }
}