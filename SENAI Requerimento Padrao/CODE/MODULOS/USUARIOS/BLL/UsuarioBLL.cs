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
		MySqlDataReader dr;

		public void Inserir(UsuarioDTO dto)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string nome = TrocarAspas(dto);
				
				string comando = "INSERT INTO USUARIO (id_funcao, url_foto_usuario," +
					"nome_completo, matricula, email_institucional, senha, situacao)" +
					"values ("+dto.IdFuncao+",'C:/foto.jpeg','"+dto.NomeCompleto+"','"+ dto.Matricula + "','"+ dto.EmailInstitucional + "','123','"+ dto.Situacao + "')";

				MessageBox.Show(comando);
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			finally
			{
				bd = null;
			}
		}

		public void Excluir(UsuarioDTO dto)
		{

		}
		public void Alterar(UsuarioDTO dto)
		{

		}

		private string TrocarAspas(UsuarioDTO dto)
		{
			string resultado = dto.NomeCompleto.Replace("'", "''");
			return resultado;
		}

		public DataTable SelecionaTodosUsuarios()
		{
			DataTable dt = new DataTable();
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select * from USUARIO");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao tentar selecionar todos os usuários: " + ex);
			}
			return dt;
		}

		public DataTable SelecionaTodosFuncoes()
		{
			DataTable dt = new DataTable();
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select * from FUNCAO");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao tentar Selecionar todas as funções: " + ex);
				MessageBox.Show(ex.ToString());
			}

			return dt;
		}

		public MySqlDataReader SelecionaTodosUsuariosDATAREADER()
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dr = bd.RetDataReader("Select * from USUARIO");
				//return dr;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao tentar selecionar todos os usuários: " + ex);
			}
			return dr;
		}
	}
}
