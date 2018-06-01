using System;
using System.Collections.Generic;

namespace CNAB240.BB.Model
{
	public class MapperAttribute : Attribute
	{
		public int De { get; set; }
		public int Ate { get; set; }
		public int Digitos { get; set; }
		public string Formato { get; set; }
		public string Instrucao { get; set; }
		public int Ordem { get; set; }
		public bool Brancos { get; set; }
		public Dictionary<string,int> Escolhas { get; set; }
		public string Campo { get; set; }
	}
}