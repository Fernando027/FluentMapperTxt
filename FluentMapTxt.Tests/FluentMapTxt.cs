using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace FluentMapTxt.Tests
{
    [TestClass]
    public class FluentMapTxtTests
    {
        private const string folderPath = @"C:\temp";
        private const string fileName = "text.txt";

        [TestMethod]
        public void ArquivoComMapeamentoCorreto()
        {
            //FluentMapper.Initialize(c =>
            // {
            //     c.AddFromDataAnnotations<HeaderArquivo604>(typeof(HeaderArquivo604));
            //     c.AddFromDataAnnotations<DetalheArquivo604>(typeof(DetalheArquivo604));
            //     c.AddFromDataAnnotations<NumeroIdentificadoOperacao>(typeof(NumeroIdentificadoOperacao));
            // });

            //var dados = Builder<HeaderArquivo604>.CreateNew().Build();
            //var dados2 = Builder<DetalheArquivo604>.CreateNew().Build();
            ////var dados3 = Builder<NumeroIdentificadoOperacao>.CreateNew().Build();
            ////dados2.NumeroIdentificadoOperacao = dados3;

            //FluentMapper.Write(folderPath, fileName, dados);
            //FluentMapper.Write(folderPath, fileName, dados2);

            var path = Path.Combine(folderPath, fileName);
            Assert.IsTrue(Directory.Exists(folderPath) && File.Exists(path));
        }

        //private class ArquivoModeloMap : EntityMap<ArquivoModelo>
        //{
        //    public ArquivoModeloMap()
        //    {
        //        Map(p => p.Teste).ComDigitos(10);
        //    }
        //}

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