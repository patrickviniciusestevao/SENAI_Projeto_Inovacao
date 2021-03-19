using System;
using System.Windows.Forms;
using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class TelefoneBLL
    {
        AcessoBancoDados bd;

        public void Inserir(TelefoneDTO telefoneDTO)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                string comando = "INSERT INTO TELEFONE(id_cliente, numero_telefone, whatsapp, categoria_telefone) " +
                    "values ('" + telefoneDTO.IdCliente + "', " +
                    "'" + telefoneDTO.NumeroTelefone + "', " +
                    "'" + telefoneDTO.Whatsapp + "', " +
                    "'" + telefoneDTO.CategoriaTelefone + "')";

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

        public void Excluir(TelefoneDTO telefoneDTO)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM TELEFONE " +
                    "where id_telefone = '" + telefoneDTO.IdTelefone + "'";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao tentar excluir: " + excecao.ToString());
            }
            finally
            {
                bd = null;
            }

        }

        public void Alterar(TelefoneDTO telefoneDTO)
        {
            
        }

        public DataTable SelecionarTodos()
        {
            DataTable dataTable = new DataTable();

            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dataTable = bd.RetDataTable("Select * from TELEFONE");
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao tentar Selecionar todos os telefones: " + excecao);
            }
            finally
            {
                bd = null;
            }

            return dataTable;
        }
    }
}
