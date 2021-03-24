using System;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class RequerimentoBLL
    {
		AcessoBancoDados bd;
		public void Inserir(RequerimentoDTO requerimentoDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "INSERT INTO REQUERIMENTO (id_modalidade_curso, item_requerimento, modulo_periodo, turno, informacoes_adicionais, data_hora_periodo, situacao) values (" +
					"'" + requerimentoDTO.IdModalidadeCurso + "'," +
					"'" + requerimentoDTO.ItemRequerimento + "'," +
					"'" + requerimentoDTO.ModuloPeriodo + "'," +
					"'" + requerimentoDTO.Turno + "'," +
					"'" + requerimentoDTO.InformacoesAdicionais + "'," +
					"'" + requerimentoDTO.DataHoraPedido + "'," +
					"'" + requerimentoDTO.Situacao + "')";
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

		public void Excluir(RequerimentoDTO requerimentoDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();
				string comando = "DELETE FROM REQUERIMENTO where id_endereco_usuario = '" +
					requerimentoDTO.IdRequerimento + "'";
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

		public void Alterar(RequerimentoDTO requerimentoDTO)
		{
			try
			{
				bd = new AcessoBancoDados();
				bd.Conectar();

				string comando = "UPDATE REQUERIMENTO set " +
					"id_modalidade_curso = '" + requerimentoDTO.IdModalidadeCurso + "'," +
					"item_requerimento = '" + requerimentoDTO.ItemRequerimento + "'," +
					"modulo_periodo = '" + requerimentoDTO.ModuloPeriodo + "'," +
					"turno = '" + requerimentoDTO.Turno + "'," +
					"informacoes_adicionais = '" + requerimentoDTO.InformacoesAdicionais + "'," +
					"data_hora_pedido = '" + requerimentoDTO.DataHoraPedido+ "'," +
					"situacao = '" + requerimentoDTO.Situacao + "'" +
					"where id_requerimento = '" + requerimentoDTO.IdRequerimento + "'";

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
				dt = bd.RetDataTable("Select * from REQUERIMENTO");
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
				dataTable = bd.RetDataTable("Select * from REQUERIMENTO where " + condicao);
			}
			catch (Exception excecao)
			{
				MessageBox.Show("Erro ao listar com condição: " + excecao.ToString());
			}

			return dataTable;
		}
	}
}
