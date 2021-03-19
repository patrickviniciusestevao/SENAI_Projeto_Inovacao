namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class RequerimentoUsuarioDTO
    {
        private int id_requerimento_usuario;
        private int id_requerimento;
        private int id_usuario;
        private DateTime data_cadastro;
        private string acao;
        private string justificativa_cancelamento;

        public int IdRequerimentoUsuario { get => id_requerimento_usuario; set => id_requerimento_usuario = value; }
        public int IdRequerimento { get => id_requerimento; set => id_requerimento = value; }
        public int IdUsuario { get => id_usuario; set => id_usuario = value; }
        public DateTime DataCadastro { get => data_cadastro; set => data_cadastro = value; }
        public string Acao { get => acao; set => acao = value; }
        public string JustificativaCancelamento { get => justificativa_cancelamento; set => justificativa_cancelamento = value; }
    }
}
