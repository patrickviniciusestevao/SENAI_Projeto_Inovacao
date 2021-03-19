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

		public int Id_usuario { get => id_usuario; set => id_usuario = value; }
		public int Id_funcao { get => id_funcao; set => id_funcao = value; }
		public string Url_foto_usuario { get => url_foto_usuario; set => url_foto_usuario = value; }
		public string Nome_completo { get => nome_completo; set => nome_completo = value; }
		public string Matricula { get => matricula; set => matricula = value; }
		public string Email_institucional { get => email_institucional; set => email_institucional = value; }
		public string Senha { get => senha; set => senha = value; }
		public string Situacao { get => situacao; set => situacao = value; }
	}
}
