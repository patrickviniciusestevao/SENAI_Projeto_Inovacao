using System;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class RequerimentoUsuarioBLL
    {
		Querys querys = new Querys();

		public void Inserir(RequerimentoUsuarioDTO requerimentoUsuarioDTO)
		{
			querys.Inserir("REQUERIMENTO_USUARIO", "id_requerimento, id_usuario, data_cadastro, acao, justificativa_cancelamento",
				$"'{requerimentoUsuarioDTO.IdRequerimento}', " +
				$"'{requerimentoUsuarioDTO.IdUsuario}', " +
				$"'{requerimentoUsuarioDTO.DataCadastro}', " +
				$"'{requerimentoUsuarioDTO.Acao}', " +
				$"'{requerimentoUsuarioDTO.JustificativaCancelamento}'"
			);
		}

		public void Excluir(RequerimentoUsuarioDTO requerimentoUsuarioDTO)
		{
			querys.Excluir("REQUERIMENTO_USUARIO", "id_requerimento_usuario", requerimentoUsuarioDTO.IdRequerimentoUsuario.ToString());
		}

		public void Alterar(RequerimentoUsuarioDTO requerimentoUsuarioDTO)
		{
			querys.Alterar("REQUERIMENTO_USUARIO",
				$"id_requerimento = '{requerimentoUsuarioDTO.IdRequerimento}', " +
				$"id_usuario = '{requerimentoUsuarioDTO.IdUsuario}', " +
				$"data_cadastro = '{requerimentoUsuarioDTO.DataCadastro}', " +
				$"acao = '{requerimentoUsuarioDTO.Acao}', " +
				$"justificativa_cancelamento = '{requerimentoUsuarioDTO.JustificativaCancelamento}'",
				"id_requerimento_usuario", requerimentoUsuarioDTO.IdRequerimentoUsuario.ToString()
			);
		}
		public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("REQUERIMENTO_USUARIO");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("REQUERIMENTO_USUARIO", condicao);
		}
	}
}
