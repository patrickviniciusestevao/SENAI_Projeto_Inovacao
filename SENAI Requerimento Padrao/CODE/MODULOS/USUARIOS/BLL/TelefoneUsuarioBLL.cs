using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;
using System.Windows.Forms;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class TelefoneUsuarioBLL
    {
		AcessoBancoDados bd;
		public void Inserir(TelefoneUsuarioDTO telefoneUsuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "INSERT INTO TELEFONE_USUARIO (id_usuario, numero_telefone, whatsapp, categoria_telefone) values (" +
					"'" + telefoneUsuarioDTO.IdUsuario + "'," +
					"'" + telefoneUsuarioDTO.NumeroTelefone + "'," +
					"'" + telefoneUsuarioDTO.Whatsapp + "'," +
					"'" + telefoneUsuarioDTO.CategoriaTelefone +
					"')";
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

		public void Excluir(TelefoneUsuarioDTO telefoneUsuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string comando = "DELETE FROM TELEFONE_USUARIO where id_funcao = '" + telefoneUsuarioDTO.IdTelefoneUsuario + "'";
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

		public void Alterar(TelefoneUsuarioDTO telefoneUsuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "UPDATE TELEFONE_USUARIO set " +
					"id_usuario = '" + telefoneUsuarioDTO.IdUsuario + "'," +
					"numero_telefone = '" + telefoneUsuarioDTO.NumeroTelefone + "'," +
					"whatsapp = '" + telefoneUsuarioDTO.Whatsapp + "'," +
					"categoria_telefone = '" + telefoneUsuarioDTO.CategoriaTelefone + "'" +
					"where id_telefone_usuario = '" + telefoneUsuarioDTO.IdTelefoneUsuario + "'";

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
				dt = bd.RetDataTable("Select * from TELEFONE_USUARIO");
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
				dataTable = bd.RetDataTable("Select * from TELEFONE_USUARIO where " + condicao);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao listar com condição: " + excecao.ToString());
			}

			return dataTable;
		}
	}
}
