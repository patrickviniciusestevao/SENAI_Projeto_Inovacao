using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class ModalidadeBLL
    {
		Querys querys = new Querys();
		public void Inserir(ModalidadeDTO modalidadeDTO)
		{
			querys.Inserir("MODALIDADE", "modalidade",
				$"'{modalidadeDTO.Modalidade}'");
		}

		public void Excluir(ModalidadeDTO modalidadeDTO)
		{
			querys.Excluir("MODALIDADE", "id_modalidade",
				modalidadeDTO.IdModalidade.ToString());
		}

		public void Alterar(ModalidadeDTO modalidadeDTO)
		{
			querys.Alterar("MODALIDADE",
				$"modalidade = '{modalidadeDTO.Modalidade}'",
				"id_modalidade", modalidadeDTO.IdModalidade.ToString()
			);
		}

		public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("MODALIDADE");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("MODALIDADE", condicao);
		}
	}
}
