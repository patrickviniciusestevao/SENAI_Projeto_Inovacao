﻿using System;
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
				
				string comando = "INSERT INTO USUARIOS (id_funcao, url_foto_usuario," +
					"nome_completo, matricula, email_institucional, senha, situacao)" +
					"values ("+dto.Id_funcao+",'C:/foto.jpeg','"+dto.Nome_completo+"','"+ dto.Matricula + "','"+ dto.Email_institucional + "','123','"+ dto.Situacao + "')";

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
			string resultado = dto.Nome_completo.Replace("'", "''");
			return resultado;
		}

		public DataTable SelecionaTodosUsuarios()
		{
			DataTable dt = new DataTable();
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select * from usuarios");
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
				dt = bd.RetDataTable("Select id_funcao, funcao from funcoes");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao tentar Selecionar todas as funções: " + ex);
			}

			return dt;
		}

		public MySqlDataReader SelecionaTodosUsuariosDATAREADER()
		{

			
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dr = bd.RetDataReader("Select * from usuarios");
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