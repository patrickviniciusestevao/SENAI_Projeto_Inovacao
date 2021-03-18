using System;
using System.Collections.Generic;
using System.Text;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;
using System.Windows.Forms;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
	class FuncaoBLL
	{
		AcessoBancoDados bd;
		public void Inserir(FuncaoDTO dto)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string funcao = TrocarAspas(dto);
				string comando = "INSERT INTO FUNCOES (funcao, nivel_permissao) values ('" + funcao + "','" + dto.Nivel_permissao + "')";
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

		public void Excluir(FuncaoDTO dto)
		{
			bd = new AcessoBancoDados();
			bd.Conectar();
			string comando = "DELETE FROM FUNCOES where id_funcao = '" + dto.Id_funcao + "'";
			bd.ExecutarComandoSQL(comando);
		}

		public void Alterar(FuncaoDTO dto)
		{
			bd = new AcessoBancoDados();
			bd.Conectar();
			string funcao = TrocarAspas(dto);
			string comando = "UPDATE FUNCOES set funcao = '" + funcao + "', nivel_permissao = '" + dto.Nivel_permissao + "' where id_funcao = '" + dto.Id_funcao + "'";
			bd.ExecutarComandoSQL(comando);
		}

		public DataTable SelecionaTodosFuncoes()
		{
			DataTable dt = new DataTable();
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select id_funcao, funcao, nivel_permissao from funcoes");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao tentar Selecionar todas as funções: " + ex);
			}

			return dt;
		}

		public void VerificarRegistroDuplicidade(FuncaoDTO dto)
		{

		
		}

		public DataTable SelecionaFiltro(FuncaoDTO dto)
		{
			DataTable dt = new DataTable();
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				dt = bd.RetDataTable("Select * from funcoes where funcao like '" + dto.Funcao + "%'");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro: " + ex);
			}

			return dt;
		}

		private string TrocarAspas(FuncaoDTO dto)
		{
			string resultado = dto.Funcao.Replace("'", "''");
			return resultado;
		}
	}
}
