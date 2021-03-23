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
				string comando = "INSERT INTO FUNCAO (funcao, nivel_permissao) values ('" + funcao + "','" + dto.NivelPermissao + "')";
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
			string comando = "DELETE FROM FUNCAO where id_funcao = '" + dto.IdFuncao + "'";
			bd.ExecutarComandoSQL(comando);
		}

		public void Alterar(FuncaoDTO dto)
		{
			bd = new AcessoBancoDados();
			bd.Conectar();
			string funcao = TrocarAspas(dto);
			string comando = "UPDATE FUNCAO set funcao = '" + funcao + "', nivel_permissao = '" + dto.NivelPermissao + "' where id_funcao = '" + dto.IdFuncao + "'";
			bd.ExecutarComandoSQL(comando);
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
				dt = bd.RetDataTable("Select * from FUNCAO where funcao like '" + dto.Funcao + "%'");
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
