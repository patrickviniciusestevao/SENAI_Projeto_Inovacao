using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class EnderecoBLL
    {
        Querys querys = new Querys();
        public RetornoDTO Inserir(EnderecoDTO enderecoDTO)
        {
           return querys.Inserir("ENDERECO", "id_cliente, logradouro, numero, cep, bairro, complemento, cidade, uf, categoria_endereco",
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
        public RetornoDTO Excluir(EnderecoDTO enderecoDTO)
        {
            return querys.Excluir("ENDERECO", "id_endereco", "'" + enderecoDTO.IdEndereco + "'");
        }
        public RetornoDTO Alterar(EnderecoDTO enderecoDTO)
        {
            return querys.Alterar("ENDERECO", 
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
        public SelecionarRetornoDTO SelecionarTodos()
        {
            return querys.SelecionarTodos("ENDERECO");
        }
        public SelecionarRetornoDTO SelecionarComFiltro(EnderecoDTO enderecoDTO)
        {
            return querys.SelecionarComCondicao("ENDERECO", "id_endereco like '" + enderecoDTO.IdEndereco + "%'");
        }
        public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("ENDERECO", condicao);
        }
    }
}
