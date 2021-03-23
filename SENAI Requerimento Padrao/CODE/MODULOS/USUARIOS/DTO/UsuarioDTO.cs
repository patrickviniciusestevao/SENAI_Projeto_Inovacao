namespace SENAI_Requerimento_Padrao.CODE.DTO
{
	class UsuarioDTO
	{
		private int id_usuario;
		private int id_funcao;
		private string url_foto_usuario;
		private string nome_completo;
		private string matricula;
		private string email_institucional;
		private string senha;
		private string situacao;

		public int IdUsuario { get => id_usuario; set => id_usuario = value; }
		public int IdFuncao { get => id_funcao; set => id_funcao = value; }
		public string UrlFotoUsuario { get => url_foto_usuario; set => url_foto_usuario = value; }
		public string NomeCompleto { get => nome_completo; set => nome_completo = value; }
		public string Matricula { get => matricula; set => matricula = value; }
		public string EmailInstitucional { get => email_institucional; set => email_institucional = value; }
		public string Senha { get => senha; set => senha = value; }
		public string Situacao { get => situacao; set => situacao = value; }
	}
}
