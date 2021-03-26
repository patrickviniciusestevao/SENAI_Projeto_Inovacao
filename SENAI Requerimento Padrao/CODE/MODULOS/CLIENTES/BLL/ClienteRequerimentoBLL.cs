using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.MODULOS.CLIENTES.BLL
{
    class ClienteRequerimentoBLL
    {
        Querys querys = new Querys();

        public RetornoDTO Inserir(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            return querys.Inserir("CLIENTE_REQUERIMENTO", "id_cliente, id_requerimento",
                "'" + clienteRequerimentoDTO.IdCliente + "'," +
                "'" + clienteRequerimentoDTO.IdRequerimento + "'");
        }

        public RetornoDTO Excluir(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            return querys.Excluir("CLIENTE_REQUERIMENTO", "id_cliente_requerimento", "'" + clienteRequerimentoDTO.IdClienteRequerimento + "'");
        }
        public RetornoDTO Alterar(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            return querys.Alterar("CLIENTE_REQUERIMENTO", "id_cliente = '" + clienteRequerimentoDTO.IdCliente + "'," +
                "id_requerimento = '" + clienteRequerimentoDTO.IdRequerimento + "'", 
                "id_cliente_requerimento", clienteRequerimentoDTO.IdClienteRequerimento.ToString());
        }
        public SelecionarRetornoDTO SelecionarTodos()
        {
            return querys.SelecionarTodos("CLIENTE_REQUERIMENTO");
        }
        public SelecionarRetornoDTO SelecionarComFiltro(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            return querys.SelecionarComCondicao("CLIENTE_REQUERIMENTO", "id_cliente_requerimento like '" + clienteRequerimentoDTO.IdClienteRequerimento + "%'");
        }
        public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("CLIENTE_REQUERIMENTO", condicao);
        }
    }
}
