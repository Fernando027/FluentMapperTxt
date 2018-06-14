namespace CNAB240.BB.Model
{
	public class SegmentoA
	{
		[Campo("01.3A", Digitos = 3, Formato = Formato.Numerico)]
		public string Controle_CodigodoBanconaCompensacao { get; set; }

		[Campo("02.3A", Digitos = 4, Formato = Formato.Numerico)]
		public string Controle_LotedeServico { get; set; }

		[Campo("03.3A", Digitos = 1, Formato = Formato.Numerico)]
		public string Controle_TipodeRegistro { get; set; }

		[Campo("04.3A", Digitos = 5, Formato = Formato.Numerico)]
		public string Servico_NumSequencialdoRegistronoLote { get; set; }

		[Campo("05.3A", Digitos = 1, Formato = Formato.Alfanumerico)]
		public string Servico_CodSegmentodoRegistroDetalhe { get; set; }

		[Campo("06.3A", Digitos = 1, Formato = Formato.Numerico)]
		public string Servico_Movimento_TipodeMovimento { get; set; }

		[Campo("07.3A", Digitos = 2, Formato = Formato.Numerico)]
		public string Servico_Movimento_CodigodaInstrucaoMovimento { get; set; }

		[Campo("08.3A", Digitos = 3, Formato = Formato.Numerico)]
		public string Favorecido_CodigodaCâmaraCentralizadora { get; set; }

		[Campo("09.3A", Digitos = 3, Formato = Formato.Numerico)]
		public string Favorecido_CodigodoBancodoFavorecido { get; set; }

		[Campo("10.3A", Digitos = 5, Formato = Formato.Numerico)]
		public string Favorecido_ContaCorrente_Agencia_Codigo { get; set; }

		[Campo("11.3A", Digitos = 1, Formato = Formato.Alfanumerico)]
		public string Favorecido_ContaCorrente_Agencia_DIgitoVerificado { get; set; }

		[Campo("12.3A", Digitos = 12, Formato = Formato.Numerico)]
		public string Favorecido_ContaCorrente_Conta_Número { get; set; }

		[Campo("13.3A", Digitos = 1, Formato = Formato.Alfanumerico)]
		public string Favorecido_ContaCorrente_Conta_DIgitoVerificador { get; set; }

		[Campo("14.3A", Digitos = 1, Formato = Formato.Alfanumerico)]
		public string Favorecido_ContaCorrente_DIgitoVerificador { get; set; }

		[Campo("15.3A", Digitos = 30, Formato = Formato.Alfanumerico)]
		public string Favorecido_Nome { get; set; }

		[Campo("16.3A", Digitos = 20, Formato = Formato.Alfanumerico)]
		public string Credito_SeuNumero { get; set; }

		[Campo("17.3A", Digitos = 8, Formato = Formato.Numerico)]
		public string Credito_DatadoPagamento { get; set; }

		[Campo("18.3A", Digitos = 3, Formato = Formato.Alfanumerico)]
		public string Credito_Moeda_Tipo { get; set; }

		[Campo("19.3A", Digitos = 10, Formato = Formato.Numerico)]
		public string Credito_Moeda_Quantidade { get; set; }

		[Campo("20.3A", Digitos = 13, Formato = Formato.Numerico)]
		public string Credito_ValorDoPagamento { get; set; }

		[Campo("21.3A", Digitos = 20, Formato = Formato.Alfanumerico)]
		public string Credito_NossoNumero { get; set; }

		[Campo("22.3A", Digitos = 8, Formato = Formato.Numerico)]
		public string Credito_DataReal { get; set; }

		[Campo("23.3A", Digitos = 13, Formato = Formato.Numerico)]
		public string Credito_ValorReal { get; set; }

		[Campo("24.3A", Digitos = 40, Formato = Formato.Alfanumerico)]
		public string Informacao2_OutrasInformacoes { get; set; }

		[Campo("25.3A", Digitos = 2, Formato = Formato.Alfanumerico)]
		public string CodigoFinalidadeDOC { get; set; }

		[Campo("26.3A", Digitos = 5, Formato = Formato.Alfanumerico)]
		public string CodigofinalidadedaTED { get; set; }

		[Campo("27.3A", Digitos = 2, Formato = Formato.Alfanumerico)]
		public string CodigoFinalidadeComplementar { get; set; }

		[Campo("28.3A", Digitos = 3, Formato = Formato.Alfanumerico)]
		public string CNAB2 { get; set; }

		[Campo("29.3A", Digitos = 1, Formato = Formato.Numerico)]
		public string AvisoAoFavorecido { get; set; }

		[Campo("29.3A", Digitos = 10, Formato = Formato.Alfanumerico)]
		public string CodigosDasOcorrenciasRetorno { get; set; }
	}
}