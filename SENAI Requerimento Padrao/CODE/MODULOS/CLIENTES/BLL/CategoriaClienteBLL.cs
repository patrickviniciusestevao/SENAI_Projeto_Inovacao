using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class CategoriaClienteBLL
    {
        Querys querys = new Querys();

        public void Inserir(CategoriaClienteDTO categoriaClienteDTO)
        {
            querys.Inserir("CATEGORIA_CLIENTE", "categoria_cliente", "'"+ categoriaClienteDTO.CategoriaCliente +"'");
        }
        public void Excluir(CategoriaClienteDTO categoriaClienteDTO)
        {
            querys.Excluir("CATEGORIA_CLIENTE", "id_categoria_cliente", "'" + categoriaClienteDTO.IdCategoriaCliente + "'");
        }
        public void Alterar(CategoriaClienteDTO categoriaClienteDTO)
        {
            querys.Alterar("CATEGORIA_CLIENTE","categoria_cliente = '"+ categoriaClienteDTO.CategoriaCliente +"'","id_categoria_cliente", categoriaClienteDTO.IdCategoriaCliente.ToString());
        }
        public DataTable SelecionarTodos()
        {
            return querys.SelecionarTodos("CATEGORIA_CLIENTE");
        }

        public DataTable SelecionarComFiltro(CategoriaClienteDTO categoriaClienteDTO)
        {
            return querys.SelecionarComCondicao("CATEGORIA_CLIENTE", "id_categoria_cliente like '" + categoriaClienteDTO.IdCategoriaCliente + "%'");
        }

        public DataTable SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("CATEGORIA_CLIENTE", condicao);
        }
    }
}
