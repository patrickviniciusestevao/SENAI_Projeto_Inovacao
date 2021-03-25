using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.MODULOS.CLIENTES.BLL
{
    class ClienteRequerimentoBLL
    {
        AcessoBancoDados bd;
        Querys querys = new Querys();

        public void Inserir(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            querys.Inserir("CLIENTE_REQUERIMENTO", "id_cliente, id_requerimento",
                "'" + clienteRequerimentoDTO.IdCliente + "'," +
                "'" + clienteRequerimentoDTO.IdRequerimento + "'");
        }

        public void Excluir(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            querys.Excluir("CLIENTE_REQUERIMENTO", "id_cliente_requerimento", "'" + clienteRequerimentoDTO.IdClienteRequerimento + "'");
        }
        public void Alterar(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            querys.Alterar("CLIENTE_REQUERIMENTO", "id_cliente = '" + clienteRequerimentoDTO.IdCliente + "'," +
                "id_requerimento = '" + clienteRequerimentoDTO.IdRequerimento + "'", 
                "id_cliente_requerimento", clienteRequerimentoDTO.IdClienteRequerimento.ToString());
        }
        public DataTable SelecionarTodos()
        {
            return querys.SelecionarTodos("CLIENTE_REQUERIMENTO");
        }
        public DataTable SelecionarComFiltro(ClienteRequerimentoDTO clienteRequerimentoDTO)
        {
            return querys.SelecionarComCondicao("CLIENTE_REQUERIMENTO", "id_cliente_requerimento like '" + clienteRequerimentoDTO.IdClienteRequerimento + "%'");
        }
        public DataTable SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("CLIENTE_REQUERIMENTO", condicao);
        }
    }
}
