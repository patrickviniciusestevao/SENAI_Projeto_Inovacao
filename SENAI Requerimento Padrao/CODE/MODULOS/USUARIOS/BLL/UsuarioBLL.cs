using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{//teste lucas
	class UsuarioBLL
	{
		Querys querys = new Querys();

		public RetornoDTO Inserir(UsuarioDTO usuarioDTO)
		{
			string nome_completo = querys.TrocarAspas(usuarioDTO.NomeCompleto);

			return querys.Inserir("USUARIO", "id_funcao, url_foto_usuario, nome_completo, matricula, email_institucional, senha, situacao",
				$"'{usuarioDTO.IdFuncao}'," +
				$"'{usuarioDTO.UrlFotoUsuario}'," +
				$"'{nome_completo}', " +
				$"'{usuarioDTO.Matricula}'," +
				$"'{usuarioDTO.EmailInstitucional}'," +
				$"'{usuarioDTO.Senha}'," +
				$"'{usuarioDTO.Situacao}'"
			);
		}
		
		public RetornoDTO Excluir(UsuarioDTO usuarioDTO)
		{
			return querys.Excluir("USUARIO", "id_usuario", usuarioDTO.IdUsuario.ToString()); 
		}
		
		public RetornoDTO Alterar(UsuarioDTO usuarioDTO)
		{
			// Se houver aspas, coloque mais uma para evitar possíveis erros no banco
			string nome_completo = querys.TrocarAspas(usuarioDTO.NomeCompleto);

			return querys.Alterar("USUARIO",
				$"id_funcao = '{usuarioDTO.IdFuncao}', " +
				$"url_foto_usuario = '{usuarioDTO.UrlFotoUsuario}', " +
				$"nome_completo = '{nome_completo}', " +
				$"matricula = '{usuarioDTO.Matricula}', " +
				$"email_institucional = '{usuarioDTO.EmailInstitucional}', " +
				$"senha = '{usuarioDTO.Senha}', " +
				$"situacao = '{usuarioDTO.Situacao}' ",
				"id_usuario", usuarioDTO.IdUsuario.ToString());
		}

		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("USUARIO");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("USUARIO", condicao);
		}
	}
}
