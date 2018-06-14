using System;
using System.Collections.Generic;
using System.Text;
using CNAB240.BB.Model;

namespace CNAB240.BB.Model
{
	public class Arquivo
	{
		public HeaderDoArquivo HeaderDoArquivo { get; set; }
		public HeaderLote HeaderLote { get; set; }
		public SegmentoA SegmentoA { get; set; }
		public TraillerArquivo TraillerArquivo { get; set; }
	}
}