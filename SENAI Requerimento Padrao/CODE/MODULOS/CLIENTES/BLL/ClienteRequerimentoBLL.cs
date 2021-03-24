using System;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;

namespace SENAI_Requerimento_Padrao.CODE.MODULOS.CLIENTES.BLL
{
    class ClienteRequerimentoBLL
    {
        AcessoBancoDados bd;

        public void Inserir(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                string comando = "INSERT INTO CLIENTE_REQUERIMENTO(id_cliente, id_requerimento) " +
                    "values ('" + clienteRequerimentoDTO.IdCliente + "'," +
                    "'" + clienteRequerimentoDTO.IdRequerimento + "')";
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

        public void Excluir(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                string comando = "DELETE FROM CLIENTE_REQUERIMENTO where id_cliente_requerimento = '" + clienteRequerimentoDTO.IdClienteRequerimento + "'";
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
        public void Alterar(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                string comando = "UPDATE CLIENTE_REQUERIMENTO set " +
                    "id_cliente = '" + clienteRequerimentoDTO.IdCliente + "'," +
                    "id_requerimento = '" + clienteRequerimentoDTO.IdRequerimento + "'";

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
        public DataTable SelecionarTodos()
        {
            DataTable dataTable = new DataTable();

            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dataTable = bd.RetDataTable("Select * from CLIENTE_REQUERIMENTO");
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao tentar Selecionar todos os clientes_requerimentos: " + excecao);
            }
            finally
            {
                bd = null;
            }

            return dataTable;
        }
        public DataTable SelecionarComCondicao(string condicao)
        {
            DataTable dataTable = new DataTable();

            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dataTable = bd.RetDataTable("Select * from CLIENTE_REQUERIMENTO where " + condicao);
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
