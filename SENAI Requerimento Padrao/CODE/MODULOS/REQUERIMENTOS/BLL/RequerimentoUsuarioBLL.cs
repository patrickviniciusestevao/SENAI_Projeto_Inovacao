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

		public RetornoDTO Inserir(RequerimentoUsuarioDTO requerimentoUsuarioDTO)
		{
			return querys.Inserir("REQUERIMENTO_USUARIO", "id_requerimento, id_usuario, data_cadastro, acao, justificativa_cancelamento",
				$"'{requerimentoUsuarioDTO.IdRequerimento}', " +
				$"'{requerimentoUsuarioDTO.IdUsuario}', " +
				$"NOW(), " +
				$"'{requerimentoUsuarioDTO.Acao}', " +
				$"'{requerimentoUsuarioDTO.JustificativaCancelamento}'"
			);
		}

		public RetornoDTO Excluir(RequerimentoUsuarioDTO requerimentoUsuarioDTO)
		{
			return querys.Excluir("REQUERIMENTO_USUARIO", "id_requerimento_usuario", requerimentoUsuarioDTO.IdRequerimentoUsuario);
		}

		public RetornoDTO Alterar(RequerimentoUsuarioDTO requerimentoUsuarioDTO)
		{
			return querys.Alterar("REQUERIMENTO_USUARIO",
				$"id_requerimento = '{requerimentoUsuarioDTO.IdRequerimento}', " +
				$"id_usuario = '{requerimentoUsuarioDTO.IdUsuario}', " +
				$"acao = '{requerimentoUsuarioDTO.Acao}', " +
				$"justificativa_cancelamento = '{requerimentoUsuarioDTO.JustificativaCancelamento}'",
				"id_requerimento_usuario", requerimentoUsuarioDTO.IdRequerimentoUsuario
			);
		}
		
		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("REQUERIMENTO_USUARIO");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("REQUERIMENTO_USUARIO", condicao);
		}
	}
}
