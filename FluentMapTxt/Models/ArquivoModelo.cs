using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentMapTxt.Tests.Models
{
	public class ArquivoModelo
	{
		public string Teste { get; set; }

		public Header Header { get; set; }

		public IList<Details> Details { get; set; }

		public Trailer Footer { get; set; }
	}
}
