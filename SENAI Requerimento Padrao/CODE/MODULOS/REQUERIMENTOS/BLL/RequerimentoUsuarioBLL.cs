using System;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;

namespace SENAI_Requerimento_Padrao.CODE.MODULOS.REQUERIMENTOS.BLL
{
    class RequerimentoUsuarioBLL
    {
		AcessoBancoDados bd;
		public void Inserir(RequerimentoUsuarioDTO requerimentoUsuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "INSERT INTO REQUERIMENTO_USUARIO (id_requerimento, id_usuario, data_cadastro, acao, justificativa_cancelamento) values (" +
					"'" + requerimentoUsuarioDTO.IdRequerimento + "'," +
					"'" + requerimentoUsuarioDTO.IdUsuario + "'," +
					"'" + requerimentoUsuarioDTO.DataCadastro + "'," +
					"'" + requerimentoUsuarioDTO.Acao + "'," +
					"'" + requerimentoUsuarioDTO.JustificativaCancelamento + "')";
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

		public void Excluir(RequerimentoUsuarioDTO requerimentoUsuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string comando = "DELETE FROM REQUERIMENTO_USUARIO where id_requerimento_usuario = '" +
					requerimentoUsuarioDTO.IdRequerimentoUsuario + "'";
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

		public void Alterar(RequerimentoUsuarioDTO requerimentoUsuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "UPDATE REQUERIMENTO_USUARIO set " +
					"id_requerimento = '" + requerimentoUsuarioDTO.IdRequerimento+ "'," +
					"id_usuario = '" + requerimentoUsuarioDTO.IdUsuario + "'," +
					"data_cadastro = '" + requerimentoUsuarioDTO.DataCadastro+ "'," +
					"acao = '" + requerimentoUsuarioDTO.Acao + "'," +
					"justificativa_cancelamento = '" + requerimentoUsuarioDTO.JustificativaCancelamento + "'" +
					"where id_requerimento_usuario = '" + requerimentoUsuarioDTO.IdRequerimentoUsuario+ "'";

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
				dt = bd.RetDataTable("Select * from REQUERIMENTO_USUARIO");
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao selecionar:" + excecao.ToString());
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
				dataTable = bd.RetDataTable("Select * from REQUERIMENTO_USUARIO where " + condicao);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao listar com condição: " + excecao.ToString());
			}

			return dataTable;
		}
	}
}
