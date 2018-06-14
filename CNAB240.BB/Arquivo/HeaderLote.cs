namespace CNAB240.BB.Model
{
	public class HeaderLote
	{
		[Campo("01.1", Digitos = 3, Formato = Formato.Numerico)]
		public string Controle_CodigodoBanconaCompensacao { get; set; }

		[Campo("02.1", Digitos = 4, Formato = Formato.Numerico)]
		public string Controle_LotedeServico { get; set; }

		[Campo("03.1", Digitos = 1, Formato = Formato.Numerico, Instrucao = "1")]
		public string Controle_TipodeRegistro { get; set; }

		[Campo("04.1", Digitos = 1, Formato = Formato.Alfanumerico, Instrucao = "C")]
		public string Servico_TipodeOperacao { get; set; }

		[Campo("05.1", Digitos = 2, Formato = Formato.Numerico)]
		public string Servico_TipodeServico { get; set; }

		[Campo("06.1", Digitos = 2, Formato = Formato.Numerico)]
		public string Servico_FormadeLancamento { get; set; }

		[Campo("07.1", Digitos = 3, Formato = Formato.Numerico, Instrucao = "042")]
		public string Servico_NumdaVersaodoLayoutdoLote { get; set; }

		[Campo("08.1", Digitos = 1, Formato = Formato.Alfanumerico, Instrucao = "Brancos")]
		public string CNAB1 { get; set; }

		[Campo("09.1", Digitos = 1, Formato = Formato.Numerico)]
		public string Empresa_Inscricao_TipodeInscricaodaEmpresa { get; set; }

		[Campo("10.1", Digitos = 14, Formato = Formato.Numerico)]
		public string Empresa_Inscricao_NumdeInscricaodaEmpresa { get; set; }

		[Campo("11.1BB1", Digitos = 9, Formato = Formato.Numerico)]
		public string Empresa_Convenio_NumDoConvenio { get; set; }

		[Campo("11.1BB2", Digitos = 4, Formato = Formato.Numerico, Instrucao = "0126")]
		public string Empresa_Convenio_Codigo { get; set; }

		[Campo("11.1BB3", Digitos = 5, Formato = Formato.Alfanumerico, Instrucao = "Brancos")]
		public string Empresa_Convenio_UsoReservadoDoBanco { get; set; }

		[Campo("11.1BB4", Digitos = 2, Formato = Formato.Alfanumerico, Escolha = new[] { "Teste:TS", "Producao:  " })]
		public string ArquivoTeste { get; set; }

		[Campo("12.1", Digitos = 5, Formato = Formato.Numerico)]
		public string Empresa_ContaCorrente_Agencia_Codigo { get; set; }

		[Campo("13.1", Digitos = 1, Formato = Formato.Alfanumerico)]
		public string Empresa_ContaCorrente_Agencia_DigitoVerificador { get; set; }

		[Campo("14.1", Digitos = 12, Formato = Formato.Numerico)]
		public string Empresa_ContaCorrente_Conta_Numero { get; set; }

		[Campo("15.1", Digitos = 1, Formato = Formato.Alfanumerico)]
		public string Empresa_ContaCorrente_Conta_DigitoVerificador { get; set; }

		[Campo("16.1", Digitos = 1, Formato = Formato.Alfanumerico)]
		public string Empresa_DigitoVerificadorDaAg_Conta { get; set; }

		[Campo("17.1", Digitos = 30, Formato = Formato.Alfanumerico)]
		public string Empresa_Nome { get; set; }

		[Campo("18.1", Digitos = 40, Formato = Formato.Alfanumerico)]
		public string Informacao1_Mensagem { get; set; }

		[Campo("19.1", Digitos = 30, Formato = Formato.Alfanumerico)]
		public string EnderecoDaEmpresa_Logradouro { get; set; }

		[Campo("20.1", Digitos = 5, Formato = Formato.Numerico)]
		public string EnderecoDaEmpresa_Numero { get; set; }

		[Campo("21.1", Digitos = 15, Formato = Formato.Alfanumerico)]
		public string EnderecoDaEmpresa_Complemento { get; set; }

		[Campo("22.1", Digitos = 20, Formato = Formato.Alfanumerico)]
		public string EnderecoDaEmpresa_Cidade { get; set; }

		[Campo("23.1", Digitos = 5, Formato = Formato.Numerico)]
		public string EnderecoDaEmpresa_CEP { get; set; }

		[Campo("24.1", Digitos = 3, Formato = Formato.Alfanumerico)]
		public string EnderecoDaEmpresa_ComplementodoCEP { get; set; }

		[Campo("25.1", Digitos = 2, Formato = Formato.Alfanumerico)]
		public string EnderecoDaEmpresa_SiglaDoEstado { get; set; }

		[Campo("26.1", Digitos = 8, Formato = Formato.Alfanumerico)]
		public string CNAB2 { get; set; }

		[Campo("27.1", Digitos = 10, Instrucao = "0000000000")]
		public string CodigoOcorrencias { get; set; }
	}
}