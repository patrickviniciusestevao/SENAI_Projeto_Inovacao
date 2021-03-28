using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class CategoriaClienteBLL
    {
        Querys querys = new Querys();

        public RetornoDTO Inserir(CategoriaClienteDTO categoriaClienteDTO)
        {
            return querys.Inserir("CATEGORIA_CLIENTE", "categoria_cliente", "'"+ categoriaClienteDTO.CategoriaCliente +"'");
        }
        public RetornoDTO Excluir(CategoriaClienteDTO categoriaClienteDTO)
        {
            return querys.Excluir("CATEGORIA_CLIENTE", "id_categoria_cliente", categoriaClienteDTO.IdCategoriaCliente);
        }
        public RetornoDTO Alterar(CategoriaClienteDTO categoriaClienteDTO)
        {
            return querys.Alterar("CATEGORIA_CLIENTE","categoria_cliente = '"+ categoriaClienteDTO.CategoriaCliente +"'","id_categoria_cliente", categoriaClienteDTO.IdCategoriaCliente);
        }
        public SelecionarRetornoDTO SelecionarTodos()
        {
            return querys.SelecionarTodos("CATEGORIA_CLIENTE");
        }

        public SelecionarRetornoDTO SelecionarComFiltro(CategoriaClienteDTO categoriaClienteDTO)
        {
            return querys.SelecionarComCondicao("CATEGORIA_CLIENTE", "id_categoria_cliente like '" + categoriaClienteDTO.IdCategoriaCliente + "%'");
        }

        public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("CATEGORIA_CLIENTE", condicao);
        }
    }
}
