using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;
using System.Windows.Forms;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class ItemRequerimentoBLL
    {
		AcessoBancoDados bd;
		public void Inserir(ItemRequerimentoDTO itemRequerimentoDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "INSERT INTO ITEM_REQUERIMENTO (id_funcao, nome, valor) values (" +
					"'" + itemRequerimentoDTO.IdFuncao + "'," +
					"'" + itemRequerimentoDTO.Nome + "'," +
					"'" + itemRequerimentoDTO.Valor + "')";
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao tentar inserir: " + excecao.ToString());
			}
			finally
			{
				bd = null;
			}
		}

		public void Excluir(ItemRequerimentoDTO itemRequerimentoDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string comando = "DELETE FROM ITEM_REQUERIMENTO where item_requerimento = '" + 
					itemRequerimentoDTO.ItemRequerimento + "'";
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao tentar Excluir: " + excecao.ToString());
			}
			finally
			{
				bd = null;
			}
		}

		public void Alterar(ItemRequerimentoDTO itemRequerimentoDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "UPDATE ITEM_REQUERIMENTO set " +
					"funcao = '" + itemRequerimentoDTO.IdFuncao + "'," +
					"nivel_permissao = '" + itemRequerimentoDTO.Nome + "'" +
					"nivel_permissao = '" + itemRequerimentoDTO.Valor + "'" +
					"where id_funcao = '" + itemRequerimentoDTO.ItemRequerimento + "'";

				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao alterar: " + excecao.ToString());
			}
			finally
			{
				bd = null;
			}
		}

		public DataTable SelecionarTodos()
		{
			DataTable dt = new DataTable();
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select * from ITEM_REQUERIMENTO");
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao selecionar :" + excecao.ToString());
			}
			finally
			{
				bd = null;
			}

			return dt;
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			DataTable dataTable = new DataTable();

			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dataTable = bd.RetDataTable("Select * from ITEM_REQUERIMENTO where " + condicao);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao listar com condição: " + excecao.ToString());
			}

			return dataTable;
		}
	}
}
