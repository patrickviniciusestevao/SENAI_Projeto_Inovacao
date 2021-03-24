using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DAL;
using SENAI_Requerimento_Padrao.CODE.DTO;

namespace SENAI_Requerimento_Padrao.CODE.FUNCTIONS
{
	class Querys
	{
        AcessoBancoDados bd;
        private string TrocarAspas(string nome)
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
                bd = null;
            }
        }

        public void Excluir(string tabela, string colunas_id, string valor_id)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "" +
                    "DELETE FROM "+ tabela +" where "+ colunas_id + " = '" + valor_id + "'";
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

        public void Alterar(string tabela, string valores, string condicao)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();


                string comando =
                    "UPDATE "+ tabela + " set " +
                    valores + 
                    " where " + condicao;

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
                bd = null;
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
                bd = null;
            }

            return dataTable;
        }
    }
}
