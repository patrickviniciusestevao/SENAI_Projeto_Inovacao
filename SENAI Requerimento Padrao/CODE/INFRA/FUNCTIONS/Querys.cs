using System;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DAL;
using SENAI_Requerimento_Padrao.CODE.DTO;

namespace SENAI_Requerimento_Padrao.CODE.FUNCTIONS
{
    class Querys
    {
        AcessoBancoDados bd = new AcessoBancoDados();
        public string TrocarAspas(string nome)
        {
            return nome.Replace("'", "''");
        }

        public RetornoDTO Inserir(string tabela, string colunas, string valores)
        { 
            RetornoDTO retorno = bd.Conectar();

            if (retorno.codigo != 0)
            {
                return retorno;
            }

            string comando = "INSERT INTO " + tabela + "(" + colunas + ") " +
                    "values (" + valores + ")";

            return bd.ExecutarComandoSQL(comando);
        }

        public RetornoDTO Excluir(string tabela, string coluna_id, int valor_id)
        {
            RetornoDTO retorno = bd.Conectar();

            if (retorno.codigo != 0)
            {
                return retorno;
            }

            string comando = "" +
                "DELETE FROM " + tabela + " where " + coluna_id + " = '" + valor_id + "'";
            return bd.ExecutarComandoSQL(comando);
        }

        public RetornoDTO Alterar(string tabela, string valores, string coluna_id, int valor_id)
        {
            RetornoDTO retorno = bd.Conectar();

            if (retorno.codigo != 0)
            {
                return retorno;
            }

            string comando =
                "UPDATE " + tabela + " set " +
                valores +
                " where " + coluna_id + " = '" + valor_id + "'";

            return bd.ExecutarComandoSQL(comando);
        }

        public SelecionarRetornoDTO SelecionarTodos(string tabela)
        {
            RetornoDTO verificacao = bd.Conectar();

            if (verificacao.codigo != 0)
            {
                SelecionarRetornoDTO retorno = new SelecionarRetornoDTO();
                retorno.codigo = verificacao.codigo;
                retorno.mensagem = verificacao.mensagem;
                retorno.tabela = new DataTable();

                return retorno;
            }
            
            return bd.RetDataTable("Select * from " + tabela + "");
        }

        public SelecionarRetornoDTO SelecionarComCondicao(string tabela, string condicao)
        {
            RetornoDTO verificacao = bd.Conectar();

            if (verificacao.codigo != 0)
            {
                SelecionarRetornoDTO retorno = new SelecionarRetornoDTO();
                retorno.codigo = verificacao.codigo;
                retorno.mensagem = verificacao.mensagem;
                retorno.tabela = new DataTable();

                return retorno;
            }

            return bd.RetDataTable("Select * from " + tabela + " where " + condicao);
        }

        public SelecionarRetornoDTO SelecionarTodosComInnerJoin(string primeira_tabela, string segunda_tabela, string coluna_primeira, string coluna_segunda)
        {
            RetornoDTO verificacao = bd.Conectar();

            if (verificacao.codigo != 0)
            {
                SelecionarRetornoDTO retorno = new SelecionarRetornoDTO();
                retorno.codigo = verificacao.codigo;
                retorno.mensagem = verificacao.mensagem;
                retorno.tabela = new DataTable();

                return retorno;
            }
            return bd.RetDataTable($"SELECT * FROM {primeira_tabela} " +
                                   $"INNER JOIN {segunda_tabela} " +
                                   $"ON {primeira_tabela}.{coluna_primeira} = {segunda_tabela}.{coluna_segunda}");
        }
    }
}