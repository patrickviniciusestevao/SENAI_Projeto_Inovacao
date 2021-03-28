using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class TelefoneBLL
    {
        Querys querys = new Querys();
        public RetornoDTO Inserir(TelefoneDTO telefoneDTO)
        {
            return querys.Inserir("TELEFONE", "id_cliente, numero_telefone, whatsapp, categoria_telefone",
                "'" + telefoneDTO.IdCliente + "', " +
                    "'" + telefoneDTO.NumeroTelefone + "', " +
                    "'" + telefoneDTO.Whatsapp + "', " +
                    "'" + telefoneDTO.CategoriaTelefone + "'");
        }
        public RetornoDTO Excluir(TelefoneDTO telefoneDTO)
        {
            return querys.Excluir("TELEFONE", "id_telefone", telefoneDTO.IdTelefone);
        }
        public RetornoDTO Alterar(TelefoneDTO telefoneDTO)
        {
            return querys.Alterar("TELEFONE",
                "id_cliente = '" + telefoneDTO.IdCliente + "', " +
                "numero_telefone = '" + telefoneDTO.NumeroTelefone + "', " +
                "whatsapp = '" + telefoneDTO.Whatsapp + "', " +
                "categoria_telefone = '" + telefoneDTO.CategoriaTelefone + "'", 
                "id_endereco", telefoneDTO.IdTelefone);
        }
        public SelecionarRetornoDTO SelecionarTodos()
        {
            return querys.SelecionarTodos("TELEFONE");
        }
        public SelecionarRetornoDTO SelecionarComFiltro(TelefoneDTO telefoneDTO)
        {
            return querys.SelecionarComCondicao("TELEFONE", "id_telefone like '" + telefoneDTO.IdTelefone + "%'");
        }
        public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("TELEFONE", condicao);
        }
    }
}
