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
				string funcao = TrocarAspas(funcaoDTO);

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
			querys.Excluir("FUNCAO", "id_funcao", "'" + funcaoDTO.IdFuncao + "'");
		}

		public void Alterar(FuncaoDTO funcaoDTO)
		{
			querys.Alterar("FUNCAO",
				"funcao = '" + funcaoDTO.Funcao + "'," +
				"nivel_permissao = '" + funcaoDTO.NivelPermissao + "'",
				"id_funcao", "'" + funcaoDTO.IdFuncao + "'"
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
			DataTable dataTable = new DataTable();

			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dataTable = bd.RetDataTable("Select * from FUNCAO where " + condicao);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao listar com condição: " + excecao.ToString());
			}

			return dataTable;
		}

		private string TrocarAspas(FuncaoDTO dto)
		{
			string resultado = dto.Funcao.Replace("'", "''");
			return resultado;
		}
	}
}
