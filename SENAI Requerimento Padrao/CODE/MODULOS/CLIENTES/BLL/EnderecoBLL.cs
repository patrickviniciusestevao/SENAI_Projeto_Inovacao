using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class EnderecoBLL
    {
        AcessoBancoDados bd;
        Querys querys = new Querys();
        public void Inserir(EnderecoDTO enderecoDTO)
        {
            querys.Inserir("ENDERECO", "id_cliente, logradouro, numero, cep, bairro, complemento, cidade, uf, categoria_endereco",
                "'" + enderecoDTO.IdCliente + "', " +
                "'" + enderecoDTO.Logradouro + "', " +
                "'" + enderecoDTO.Numero + "', " +
                "'" + enderecoDTO.Cep + "', " +
                "'" + enderecoDTO.Bairro + "', " +
                "'" + enderecoDTO.Complemento + "', " +
                "'" + enderecoDTO.Cidade + "', " +
                "'" + enderecoDTO.Uf + "', " +
                "'" + enderecoDTO.CategoriaEndereco + "'");
        }
        public void Excluir(EnderecoDTO enderecoDTO)
        {
            querys.Excluir("ENDERECO", "id_endereco", "'" + enderecoDTO.IdEndereco + "'");
        }
        public void Alterar(EnderecoDTO enderecoDTO)
        {
            querys.Alterar("ENDERECO", 
                "id_cliente = '" + enderecoDTO.IdCliente + "', " +
                "logradouro = '" + enderecoDTO.Logradouro + "', " +
                "numero = '" + enderecoDTO.Numero + "', " +
                "cep = '" + enderecoDTO.Cep + "', " +
                "bairro = '" + enderecoDTO.Bairro + "', " +
                "complemento = '" + enderecoDTO.Complemento + "', " +
                "cidade = '" + enderecoDTO.Cidade + "', " +
                "uf = '" + enderecoDTO.Uf + "'" +
                "categoria_endereco = '" + enderecoDTO.CategoriaEndereco + "'",
                "id_endereco", enderecoDTO.IdEndereco.ToString());
        }
        public DataTable SelecionarTodos()
        {
            return querys.SelecionarTodos("ENDERECO");
        }
        public DataTable SelecionarComFiltro(EnderecoDTO enderecoDTO)
        {
            return querys.SelecionarComCondicao("ENDERECO", "id_endereco like '" + enderecoDTO.IdEndereco + "%'");
        }
        public DataTable SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("ENDERECO", condicao);
        }
    }
}
