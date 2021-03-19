namespace SENAI_Requerimento_Padrao.CODE.DTO
{
	class FuncaoDTO
	{
		private int id_funcao;
		private string funcao;
		private int nivel_permissao;


		public int Id_funcao { get => id_funcao; set => id_funcao = value; }
		public string Funcao { get => funcao; set => funcao = value; }
		public int Nivel_permissao { get => nivel_permissao; set => nivel_permissao = value; }

	}
}
