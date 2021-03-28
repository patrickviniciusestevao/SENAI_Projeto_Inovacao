using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
	class ClienteBLL
    {
        AcessoBancoDados bd;
		Querys querys = new Querys();

		public RetornoDTO Inserir(ClienteDTO clienteDTO)
		{
			// Se houver aspas, coloque mais uma para evitar possíveis erros no banco
			string nome = querys.TrocarAspas(clienteDTO.NomeCompleto);
			string nome_social = querys.TrocarAspas(clienteDTO.NomeSocial);

			return querys.Inserir("CLIENTE", "id_categoria_cliente, url_foto_usuario, nome_completo, matricula, nome_social, cpf, rg, orgao_emissor, email, situacao",
					"'" + clienteDTO.IdCategoria + "'," +
					"'" + clienteDTO.Url + "','" + nome + "'," +
					"'" + clienteDTO.Matricula + "'," +
					"'" + nome_social + "'," +
					"'" + clienteDTO.Cpf + "'," +
					"'" + clienteDTO.Rg + "'," +
					"'" + clienteDTO.OrgaoEmissor + "'," +
					"'" + clienteDTO.Email + "'," +
					"'" + clienteDTO.Situacao + "'"
					);
		}

		public RetornoDTO Excluir(ClienteDTO clienteDTO)
		{
			return querys.Excluir("CLIENTE", "id_cliente", clienteDTO.IdCliente);
		}

		public RetornoDTO Alterar(ClienteDTO clienteDTO)
		{
			// Se houver aspas, coloque mais uma para evitar possíveis erros no banco
			string nome = querys.TrocarAspas(clienteDTO.NomeCompleto);
			string nome_social = querys.TrocarAspas(clienteDTO.NomeSocial);

			return querys.Alterar("CLIENTE", 
				" id_categoria_cliente = '" + clienteDTO.IdCategoria + "'," +
				" url_foto_usuario = '" + clienteDTO.Url + "'," +
				" nome_completo = '" + nome + "'," +
				" matricula = '" + clienteDTO.Matricula + "'," +
				" nome_social = '" + nome_social + "'," +
				" cpf = '" + clienteDTO.Cpf + "'," +
				" rg = '" + clienteDTO.Rg + "'," +
				" orgao_emissor = '" + clienteDTO.OrgaoEmissor + "'," +
				" email = '" + clienteDTO.Email + "'", "id_cliente", clienteDTO.IdCliente);
		}

		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("CLIENTE");
		}

		public SelecionarRetornoDTO SelecionarComFiltro(ClienteDTO clienteDTO)
		{
			return querys.SelecionarComCondicao("CLIENTE", "id_cliente like '" + clienteDTO.IdCliente + "%'");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("CLIENTE", condicao);
		}
	}
}
