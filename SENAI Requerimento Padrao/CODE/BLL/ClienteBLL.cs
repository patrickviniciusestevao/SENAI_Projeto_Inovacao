using System;
using System.Collections.Generic;
using System.Text;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
	class ClienteBLL
	{

		AcessoBancoDados bd;

		public void Inserir(ClienteDTO dto)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string nome = dto.Nome.Replace("'", "''");
				string comando = "INSERT INTO CLIENTE (nome, email) values ('" + nome + "','" + dto.Email + "')";
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao tentar inserir: " + ex);
			}
			finally
			{
				bd = null;
			}
		}

		public void Excluir(ClienteDTO dto)
		{
			bd = new AcessoBancoDados();
			bd.Conectar();
			string comando = "DELETE FROM CLIENTE where id = '" + dto.Id + "'";
			bd.ExecutarComandoSQL(comando);
		}

		public void Alterar(ClienteDTO dto)
		{
			bd = new AcessoBancoDados();
			bd.Conectar();
			string nome = TrocarAspas(dto);
			string comando = "UPDATE CLIENTE set nome = '" + nome + "', email = '" + dto.Email + "' where id = '" + dto.Id + "'";
			bd.ExecutarComandoSQL(comando);
		}

		//using System.Data
		public DataTable SelecionaTodosClientes()
		{
			DataTable dt = new DataTable();

			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select id, nome, email from cliente");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao tentar Selecionar todos os clientes: " + ex);
			}

			return dt;
		}

		public string TrocarAspas(ClienteDTO dto)
		{
			string nome = dto.Nome.Replace("'", "''");
			return nome;
		}

	}
}
