using System;
using System.Collections.Generic;
using System.Text;
using CNAB240.BB.Model;

namespace CNAB240.BB.Model
{
	public class HeaderDoArquivo
	{
		[Campo("01.0")]
		// [Ordem(1)]
		[Digitos(3)]
		[Formato(Formato.Numerico)]
		[Instrucao("001")]
		public string Controle_Banco { get; set; }

		[Campo("02.0")]
		// [Ordem(2)]
		[Digitos(4)]
		[Formato(Formato.Numerico)]
		[Instrucao("0000")]
		public string Controle_Lote { get; set; }


		[Campo("03.0")]
		// [Ordem(3)]
		[Digitos(1)]
		[Formato(Formato.Numerico)]
		[Instrucao("0")]
		public string Controle_Registro { get; set; }

		[Campo("04.0")]
		// [Ordem(4)]
		[Digitos(9)]
		[Formato(Formato.Alfanumerico)]
		[Brancos]
		public string CNAB { get; set; }

		[Campo("05.0")]
		// [Ordem(5)]
		[Digitos(1)]
		[Formato(Formato.Numerico)]
		[Escolha(Key = "CPF", Value = "1")]
		[Escolha(Key = "CNPJ", Value = "2")]
		public string Empresa_Inscricao_Tipo { get; set; }


		[Campo("06.0")]
		// [Ordem(6)]
		[Digitos(14)]
		[Formato(Formato.Numerico)]
		public string Empresa_Inscricao_Numero { get; set; }


		[Campo("07.0 BB1")]
		// [Ordem(7)]
		[Digitos(9)]
		[Formato(Formato.Numerico)]
		public string Empresa_Convenio_NumeroConvenio { get; set; }


		[Campo("07.0 BB2")]
		// [Ordem(8)]
		[Digitos(4)]
		[Formato(Formato.Numerico)]
		[Instrucao("0126")]
		public string Empresa_Convenio_Codigo { get; set; }


		[Campo("07.0 BB3")]
		// [Ordem(9)]
		[Digitos(5)]
		[Formato(Formato.Alfanumerico)]
		[Brancos]
		public string Empresa_Convenio_UsoReservadoBanco { get; set; }

		[Campo("07.0 BB4")]
		// [Ordem(10)]
		[Digitos(2)]
		[Formato(Formato.Alfanumerico)]
		[Escolha(Key = "Teste", Value = "TS")]
		[Escolha(Key = "Producao", Value = "  ")]
		public string Empresa_Convenio_ArquivoTeste { get; set; }


		[Campo("08.0")]
		// [Ordem(11)]
		[Digitos(5)]
		[Formato(Formato.Numerico)]
		public string Empresa_ContaCorrente_Agencia_Codigo { get; set; }


		[Campo("09.0")]
		// [Ordem(12)]
		[Digitos(1)]
		[Formato(Formato.Alfanumerico)]
		public string Empresa_ContaCorrente_Agencia_DV { get; set; }


		[Campo("10.0")]
		// [Ordem(13)]
		[Digitos(12)]
		[Formato(Formato.Numerico)]
		public string Empresa_ContaCorrente_Conta_Numero { get; set; }


		[Campo("11.0")]
		// [Ordem(14)]
		[Digitos(1)]
		[Formato(Formato.Alfanumerico)]
		public string Empresa_ContaCorrente_Conta_Dv { get; set; }


		[Campo("12.0")]
		// [Ordem(15)]
		[Digitos(1)]
		[Formato(Formato.Alfanumerico)]
		[Instrucao("0")]
		public string Empresa_ContaCorrente_Dv { get; set; }



		[Campo("13.0")]
		// [Ordem(16)]
		[Digitos(30)]
		[Formato(Formato.Alfanumerico)]
		[Instrucao("0")]
		public string Empresa_Nome { get; set; }


		[Campo("14.0")]
		// [Ordem(17)]
		[Digitos(30)]
		[Formato(Formato.Alfanumerico)]
		[Instrucao("BANCO DO BRASIL")]
		public string NomedoBanco { get; set; }

		[Campo("15.0")]
		// [Ordem(18)]
		[Formato(Formato.Alfanumerico)]
		[Digitos(10)]
		[Brancos]
		public string CNAB_2 { get; set; }

		[Campo("16.0")]
		// [Ordem(19)]
		[Digitos(1)]
		[Formato(Formato.Numerico)]
		[Escolha(Key = "Remessa", Value = "1")]
		[Escolha(Key = "Retorno", Value = "2")]
		public string Arquivo_Codigo { get; set; }

		[Campo("17.0")]
		[Digitos(8)]
		// [Ordem(20)]
		[Formato(Formato.Data)]
		public string Arquivo_DataDeGeracaoDoArquivo { get; set; }

		[Campo("18.0")]
		[Digitos(6)]
		// [Ordem(22)]
		[Formato(Formato.Hora)]
		public string Arquivo_HoradeGeraçãoDoArquivo { get; set; }

		[Campo("19.0")]
		// [Ordem(23)]
		[Digitos(6)]
		[Formato(Formato.Sequencial)]
		public string Arquivo_NumeroSequencialDoArquivo { get; set; }

		[Campo("20.0")]
		[Digitos(3)]
		// [Ordem(24)]
		[Instrucao("083")]
		public string Arquivo_NumdaVersaoDoLayoutdoArquivo { get; set; }

		[Campo("21.0")]
		// [Ordem(25)]
		[Digitos(5)]
		[Brancos]
		public string DensidadedeGravacaodoArquivo { get; set; }

		[Campo("22.0")]
		[Digitos(20)]
		// [Ordem(26)]
		[Brancos]
		public string ParaUsoReservadoDoBanco { get; set; }

		[Campo("23.0")]
		[Digitos(20)]
		// [Ordem(27)]
		[Brancos]
		public string ParaUsoReservadoDaEmpresa { get; set; }

		[Campo("24.0")]
		[Digitos(29)]
		// [Ordem(28)]
		[Brancos]
		public string UsoExclusivoFEBRABANCNAB { get; set; }


		[Campo("25.0")]
		[Digitos(2)]
		// [Ordem(29)]
		[Brancos]
		public string IdentificacaoCobrancaSemPapel { get; set; }

		[Campo("26.0")]
		[Digitos(3)]
		// [Ordem(31)]
		[Instrucao("000")]
		public string UsoExclusivoVANS { get; set; }

		[Campo("27.0")]
		[Digitos(2)]
		// [Ordem(32)]
		[Instrucao("00")]
		public string TipoServico { get; set; }

		[Campo("28.0")]
		[Digitos(10)]
		// [Ordem(33)]
		[Instrucao("0000000000")]
		public string CodigoOcorrencias { get; set; }

	}
}
