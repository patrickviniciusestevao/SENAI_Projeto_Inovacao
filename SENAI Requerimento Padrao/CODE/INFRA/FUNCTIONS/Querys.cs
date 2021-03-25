using System;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DAL;

namespace SENAI_Requerimento_Padrao.CODE.FUNCTIONS
{
	class Querys
	{
        AcessoBancoDados bd;
        public string TrocarAspas(string nome)
        {
            return nome.Replace("'", "''");
        }
        public void Inserir(string tabela, string colunas, string valores)
		{
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                string comando = "INSERT INTO " + tabela + "(" + colunas + ") " +
                     "values (" + valores + ")";

                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao tentar inserir: " + excecao);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public void Excluir(string tabela, string coluna_id, string valor_id)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "" +
                    "DELETE FROM "+ tabela +" where "+ coluna_id + " = '" + valor_id + "'";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao tentar Excluir: " + excecao.ToString());
            }
            finally
            {
                bd.Fechar();
            }
        }

        public void Alterar(string tabela, string valores, string coluna_id, string valor_id)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                string comando =
                    "UPDATE "+ tabela + " set " +
                    valores + 
                    " where " + coluna_id + " = '" + valor_id + "'";

                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao alterar: " + excecao);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public DataTable SelecionarTodos(string tabela)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("Select * from "+ tabela +"");
            }
            catch (Exception excecao)
            {
                Console.WriteLine("Erro ao tentar selecionar dados: " + excecao);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }

        public DataTable SelecionarComCondicao(string tabela, string condicao)
        {
            DataTable dataTable = new DataTable();

            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dataTable = bd.RetDataTable("Select * from "+ tabela + " where " + condicao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar com condição" + ex.ToString());
            }
            finally
            {
                bd.Fechar();
            }

            return dataTable;
        }

        public DataTable SelecionarTodosComInnerJoin(string primeira_tabela, string segunda_tabela, string coluna_primeira, string coluna_segunda)
        {
            DataTable dataTable = new DataTable();

            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dataTable = bd.RetDataTable($"SELECT * FROM {primeira_tabela} " +
                                            $"INNER JOIN {segunda_tabela} " +
                                            $"ON {primeira_tabela}.{coluna_primeira} = {segunda_tabela}.{coluna_segunda}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar com inner join" + ex.ToString());
            }
            finally
            {
                bd.Fechar();
            }

            return dataTable;
        }
    }
}
