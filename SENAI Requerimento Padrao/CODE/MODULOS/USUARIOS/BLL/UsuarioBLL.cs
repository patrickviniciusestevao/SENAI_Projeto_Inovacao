using System;
using System.Collections.Generic;
using System.Text;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
	class UsuarioBLL
	{
		AcessoBancoDados bd;
		
		public void Inserir(UsuarioDTO usuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string nome_completo = TrocarAspas(usuarioDTO.NomeCompleto);
				
				string comando = "INSERT INTO USUARIO (id_funcao, url_foto_usuario," +
					"nome_completo, matricula, email_institucional, senha, situacao)" +
					"values (" +
						usuarioDTO.IdFuncao + "," +
						"'C:/foto.jpeg'," +
						"'"+ nome_completo + "'," +
						"'"+ usuarioDTO.Matricula + "'," +
						"'"+ usuarioDTO.EmailInstitucional + "'," +
						"'123'," +
						"'"+ usuarioDTO.Situacao + "')";

				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao inserir: " + excecao.ToString());
			}
			finally
			{
				bd = null;
			}
		}
		
		public void Excluir(UsuarioDTO usuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string comando = "" +
					"DELETE FROM USUARIO where id_cliente = '" + usuarioDTO.IdUsuario + "'";
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
		
		public void Alterar(UsuarioDTO usuarioDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				// Se houver aspas, coloque mais uma para evitar possíveis erros no banco
				string nome_completo = this.TrocarAspas(usuarioDTO.NomeCompleto);

				string comando =
					"UPDATE USUARIO set " +
					" id_funcao = '" + usuarioDTO.IdFuncao + "'," +
					" url_foto_usuario = '" + usuarioDTO.UrlFotoUsuario + "'," +
					" nome_completo = '" + nome_completo + "'," +
					" matricula = '" + usuarioDTO.Matricula + "'," +
					" email_institucional = '" + usuarioDTO.EmailInstitucional + "'," +
					" senha = '" + usuarioDTO.Senha + "'," +
					" situacao = '" + usuarioDTO.Situacao+
					"' where id = '" + usuarioDTO.IdUsuario + "'";

				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao alterar: " + excecao);
			}
			finally
			{
				bd = null;
			}
		}
		
		private string TrocarAspas(string nome)
		{
			return nome.Replace("'", "''");
		}

		public DataTable SelecionarTodos()
		{
			DataTable dt = new DataTable();
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select * from USUARIO");
			}
			catch (Exception excecao)
			{
				Console.WriteLine("Erro ao tentar selecionar todos os usuários: " + excecao);
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
				dataTable = bd.RetDataTable("Select * from USUARIO where " + condicao);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao listar com condição" + ex.ToString());
			}
			finally
			{
				bd = null;
			}

			return dataTable;
		}
	}
}
