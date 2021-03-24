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
        public void Inserir(String tabela, String colunas, String valores)
		{
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                string comando = "INSERT INTO " + tabela + "(" + colunas + ") " +
                     "values ('" + valores + "')";

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

        public void Excluir(String tabela, String colunas_id, String valor_id)
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

        public void Alterar(String tabela, UsuarioDTO usuarioDTO)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                // Se houver aspas, coloque mais uma para evitar possíveis erros no banco
                string nome_completo = this.TrocarAspas(usuarioDTO.NomeCompleto);

                string comando =
                    "UPDATE "+ tabela + " set " +
                    " id_funcao = '" + usuarioDTO.IdFuncao + "'," +
                    " url_foto_usuario = '" + usuarioDTO.UrlFotoUsuario + "'," +
                    " nome_completo = '" + nome_completo + "'," +
                    " matricula = '" + usuarioDTO.Matricula + "'," +
                    " email_institucional = '" + usuarioDTO.EmailInstitucional + "'," +
                    " senha = '" + usuarioDTO.Senha + "'," +
                    " situacao = '" + usuarioDTO.Situacao +
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

        public DataTable SelecionarTodos(String tabela)
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

        public DataTable SelecionarComCondicao(String tabela, String condicao)
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
