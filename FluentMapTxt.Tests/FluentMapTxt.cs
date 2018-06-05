using System;
using System.Collections.Generic;
using System.IO;
using CNAB240.BB.Model;
using FluentMapTxt.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentMapTxt.Tests
{
	[TestClass]
	public class FluentMapTxt
	{
		private const string folderPath = @"C:\temp";
		private const string fileName = "text.txt";

		[TestMethod]
		public void ArquivoComMapeamentoCorreto()
		{
			FluentMapper.Initialize(folderPath, fileName, c =>
			 {
				 c.AddMap(new ArquivoModeloMap());
				 c.AddFromDataAnnotations<HeaderDoArquivo>(typeof(HeaderDoArquivo));
				 //c.AddMap(new HeaderMap());
				 //c.AddMap(new DetailsMap());
				 //c.AddMap(new FooterMap());
			 });

			var arquivo = new HeaderDoArquivo
			{
				Arquivo_Codigo = "1",
				Arquivo_HoradeGeraçãoDoArquivo = "2"
			};

			FluentMapper.Write(arquivo);

			var path = Path.Combine(folderPath, fileName);
			Assert.IsTrue(Directory.Exists(folderPath) && File.Exists(path));
		}

		private class ArquivoModeloMap : EntityMap<ArquivoModelo>
		{
			public ArquivoModeloMap()
			{
				Map(p => p.Teste).ComDigitos(10);
			}
		}

		//private class HeaderMap : EntityMap<Header>
		//{
		//	public HeaderMap()
		//	{
		//		Map(p => p.Nome).PositionStart(0).LengthCharacter(8).SetPositionSort(0);
		//		Map(p => p.SobreNome).PositionStart(20).LengthCharacter(8).SetPositionSort(1);
		//		Map(p => p.Tipo).PositionStart(40).LengthCharacter(1).SetPositionSort(2);
		//	}
		//}

		//private class DetailsMap : EntityMap<Details>
		//{
		//	public DetailsMap()
		//	{
		//		Map(p => p.DataEvento).PositionStart(0).LengthCharacter(10);
		//		Map(p => p.Evento).PositionStart(20).LengthCharacter(20);
		//	}
		//}

		//private class FooterMap : EntityMap<Trailer>
		//{
		//	public FooterMap()
		//	{
		//		Map(p => p.Nome).PositionStart(0).LengthCharacter(10);
		//		Map(p => p.SobreNome).PositionStart(20).LengthCharacter(10);
		//		Map(p => p.Tipo).PositionStart(40).LengthCharacter(1);
		//	}
		//}
	}

	//public class Escritor
	//{
	//	public string EscreverArquivo(object arquivo) { }
	//}
}