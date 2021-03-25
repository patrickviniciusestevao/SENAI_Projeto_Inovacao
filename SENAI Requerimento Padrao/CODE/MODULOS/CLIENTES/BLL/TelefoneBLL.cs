using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class TelefoneBLL
    {
        AcessoBancoDados bd;
        Querys querys = new Querys();
        public void Inserir(TelefoneDTO telefoneDTO)
        {
            querys.Inserir("TELEFONE", "id_cliente, numero_telefone, whatsapp, categoria_telefone",
                "'" + telefoneDTO.IdCliente + "', " +
                    "'" + telefoneDTO.NumeroTelefone + "', " +
                    "'" + telefoneDTO.Whatsapp + "', " +
                    "'" + telefoneDTO.CategoriaTelefone + "'");
        }
        public void Excluir(TelefoneDTO telefoneDTO)
        {
            querys.Excluir("TELEFONE", "id_telefone", "'" + telefoneDTO.IdTelefone + "'");
        }
        public void Alterar(TelefoneDTO telefoneDTO)
        {
            querys.Alterar("TELEFONE",
                "id_cliente = '" + telefoneDTO.IdCliente + "', " +
                "numero_telefone = '" + telefoneDTO.NumeroTelefone + "', " +
                "whatsapp = '" + telefoneDTO.Whatsapp + "', " +
                "categoria_telefone = '" + telefoneDTO.CategoriaTelefone + "'", 
                "id_endereco", telefoneDTO.IdTelefone.ToString());
        }
        public DataTable SelecionarTodos()
        {
            return querys.SelecionarTodos("TELEFONE");
        }
        public DataTable SelecionarComFiltro(TelefoneDTO telefoneDTO)
        {
            return querys.SelecionarComCondicao("TELEFONE", "id_telefone like '" + telefoneDTO.IdTelefone + "%'");
        }
        public DataTable SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("TELEFONE", condicao);
        }
    }
}
