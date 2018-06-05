using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CNAB240.BB.Model
{
	public class CampoAttribute : Attribute
	{
		public CampoAttribute(string codigo)
		{
			this.Codigo = codigo;
			//var teste = this.Escolha.ToDictionary(x => x.Split(':')[0], x => x.Split(':')[1]);
		}

		private string Codigo { get; set; }
		public int Ordem { get; set; }
		public int Digitos { get; set; }
		public Formato Formato { get; set; }
		public string Instrucao { get; set; }
		public bool Brancos { get; set; }
		public string[] Escolha { get; set; }
	}
}