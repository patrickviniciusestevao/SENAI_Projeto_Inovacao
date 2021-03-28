using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
	class FuncaoBLL
	{
		Querys querys = new Querys();
		public RetornoDTO Inserir(FuncaoDTO funcaoDTO)
		{
			int jaExisteUmaFuncao = querys.SelecionarComCondicao("FUNCAO", "funcao = '" + funcaoDTO.Funcao + "'").tabela.Rows.Count;

			// Comparando se já existe uma função
			if (jaExisteUmaFuncao == 0)
			{
				string funcao = querys.TrocarAspas(funcaoDTO.Funcao);

				return querys.Inserir("FUNCAO", "funcao, nivel_permissao",
					"'" + funcao + "'," +
					"'" + funcaoDTO.NivelPermissao + "'"
				);
			}
			else
			{
				RetornoDTO retorno = new RetornoDTO();
				retorno.codigo = -1;
				retorno.mensagem = "Já existe uma função com mesmo nome";

				return retorno;
			}
		}

		public RetornoDTO Excluir(FuncaoDTO funcaoDTO)
		{
			return querys.Excluir("FUNCAO", "id_funcao", funcaoDTO.IdFuncao);
		}

		public RetornoDTO Alterar(FuncaoDTO funcaoDTO)
		{
			string funcao = querys.TrocarAspas(funcaoDTO.Funcao);

			return querys.Alterar("FUNCAO",
				"funcao = '" + funcao + "'," +
				"nivel_permissao = '" + funcaoDTO.NivelPermissao + "'",
				"id_funcao", funcaoDTO.IdFuncao
			);
		}

		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("FUNCAO");
		}

		public SelecionarRetornoDTO SelecionarComFiltro(FuncaoDTO funcaoDTO)
		{
			return querys.SelecionarComCondicao("FUNCAO", "funcao like '" + funcaoDTO.Funcao + "%'");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("FUNCAO", condicao);
		}
	}
}