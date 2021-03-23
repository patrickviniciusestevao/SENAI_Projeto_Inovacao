using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;
using System.Windows.Forms;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
	class FuncaoBLL
	{
		AcessoBancoDados bd;
		public void Inserir(FuncaoDTO funcaoDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				int jaExisteUmaFuncao = this.SelecionarComCondicao("categoria_cliente = '" + funcaoDTO.Funcao + "'").Rows.Count;

				// Comparando se já existe uma função
				if (jaExisteUmaFuncao == 0)
                {
					string funcao = TrocarAspas(funcaoDTO);

					string comando = "INSERT INTO FUNCAO (funcao, nivel_permissao) values (" +
						"'" + funcao + "'," +
						"'" + funcaoDTO.NivelPermissao + "')";
					bd.ExecutarComandoSQL(comando);
				}
				else
                {
					MessageBox.Show("Já existe uma função com o mesmo nome");
				}
				

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

		public void Excluir(FuncaoDTO funcaoDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string comando = "DELETE FROM FUNCAO where id_funcao = '" + funcaoDTO.IdFuncao + "'";
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

		public void Alterar(FuncaoDTO funcaoDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "UPDATE FUNCAO set " +
					"funcao = '" + funcaoDTO.Funcao + "'," +
					"nivel_permissao = '" + funcaoDTO.NivelPermissao + "'" + 
					"where id_funcao = '" + funcaoDTO.IdFuncao + "'";

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
				dt = bd.RetDataTable("Select * from FUNCAO");
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

		public DataTable SelecionarComFiltro(FuncaoDTO funcaoDTO)
		{
			DataTable dt = new DataTable();
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select * from FUNCAO where funcao like '" + funcaoDTO.Funcao + "%'");
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
