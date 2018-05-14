using System;
using System.Collections.Generic;
using System.IO;
using FluentMapTxt.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentMapTxt.Tests
{
	[TestClass]
	public class FluentMapTxt
	{
		const string folderPath = @"C:\temp";
		const string fileName = "text.txt";

		[TestMethod]
		public void ConsigoCriarUmaPastaEOArquivo()
		{
			//var map = new Mapper(folderPath, fileName);

			//map.WriteLine();

			//var path = Path.Combine(folderPath, fileName);
			//Assert.IsTrue(Directory.Exists(folderPath) && File.Exists(path));
			//Directory.Delete(folderPath, true);
		}

		[TestMethod]
		public void ArquivoComMapeamentoCorreto()
		{
			FluentMapper.Initialize(folderPath, fileName, c =>
			 {
				 c.AddMap(new ArquivoModeloMap());
				 c.AddMap(new HeaderMap());
				 c.AddMap(new DetailsMap());
				 c.AddMap(new FooterMap());
			 });

			var arquivo = new ArquivoModelo
			{ 
				Teste = "linha 1",
				Header = new Header
				{
					Nome = "2-Header",
					SobreNome = "2-Header"
				},
				Details = new List<Details>
				{
					new Details
					{
						 DataEvento = DateTime.Now,
						 Evento = "3-detalhe"
					},

					new Details
					{
						 DataEvento = DateTime.Now,
						 Evento = "4-detalhe"
					}
				},
				Footer = new Trailer
				{
					Nome = "5-trailler",
					SobreNome = "5-trailler",
					Tipo = 1
				}
			};

			FluentMapper.Write(arquivo);

			var path = Path.Combine(folderPath, fileName);
			Assert.IsTrue(Directory.Exists(folderPath) && File.Exists(path));

		}

		private class ArquivoModeloMap : EntityMap<ArquivoModelo>
		{
			public ArquivoModeloMap()
			{
				Map(p => p.Teste).PositionStart(0).LengthCharacter(5).SetPositionSort(3);
				Map(p => p.Header).SetPositionSort(2);
				Map(p => p.Details).SetPositionSort(1);
				Map(p => p.Footer).SetPositionSort(0);
			}
		}

		private class HeaderMap : EntityMap<Header>
		{
			public HeaderMap()
			{
				Map(p => p.Nome).PositionStart(0).LengthCharacter(8).SetPositionSort(0);
				Map(p => p.SobreNome).PositionStart(20).LengthCharacter(8).SetPositionSort(1);
				Map(p => p.Tipo).PositionStart(40).LengthCharacter(1).SetPositionSort(2);
			}
		}

		private class DetailsMap : EntityMap<Details>
		{
			public DetailsMap()
			{
				Map(p => p.DataEvento).PositionStart(0).LengthCharacter(10);
				Map(p => p.Evento).PositionStart(20).LengthCharacter(20);
			}
		}

		private class FooterMap : EntityMap<Trailer>
		{
			public FooterMap()
			{
				Map(p => p.Nome).PositionStart(0).LengthCharacter(10);
				Map(p => p.SobreNome).PositionStart(20).LengthCharacter(10);
				Map(p => p.Tipo).PositionStart(40).LengthCharacter(1);
			}
		}
	}
}
