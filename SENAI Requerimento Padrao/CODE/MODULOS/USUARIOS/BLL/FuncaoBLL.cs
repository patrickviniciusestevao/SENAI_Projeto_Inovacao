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
		public void Inserir(FuncaoDTO funcaoDTO)
		{
			int jaExisteUmaFuncao = querys.SelecionarComCondicao("FUNCAO", "categoria_cliente = '" + funcaoDTO.Funcao + "'").Rows.Count;

			// Comparando se já existe uma função
			if (jaExisteUmaFuncao == 0)
			{
				string funcao = querys.TrocarAspas(funcaoDTO.Funcao);

				querys.Inserir("FUNCAO", "funcao, nivel_permissao",
					"'" + funcao + "'," +
					"'" + funcaoDTO.NivelPermissao + "'"
				);
			}
			else
			{
				MessageBox.Show("Já existe uma função com o mesmo nome");
			}
		}

		public void Excluir(FuncaoDTO funcaoDTO)
		{
			querys.Excluir("FUNCAO", "id_funcao", funcaoDTO.IdFuncao.ToString());
		}

		public void Alterar(FuncaoDTO funcaoDTO)
		{
			string funcao = querys.TrocarAspas(funcaoDTO.Funcao);

			querys.Alterar("FUNCAO",
				"funcao = '" + funcao + "'," +
				"nivel_permissao = '" + funcaoDTO.NivelPermissao + "'",
				"id_funcao", funcaoDTO.IdFuncao.ToString()
			);
		}

		public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("FUNCAO");
		}

		public DataTable SelecionarComFiltro(FuncaoDTO funcaoDTO)
		{
			return querys.SelecionarComCondicao("FUNCAO", "funcao like '" + funcaoDTO.Funcao + "%'");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("FUNCAO", condicao);
		}
	}
}
