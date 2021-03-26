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
		public RetornoDTO Inserir(ModalidadeDTO modalidadeDTO)
		{
			return querys.Inserir("MODALIDADE", "modalidade",
				$"'{modalidadeDTO.Modalidade}'");
		}

		public RetornoDTO Excluir(ModalidadeDTO modalidadeDTO)
		{
			return querys.Excluir("MODALIDADE", "id_modalidade",
				modalidadeDTO.IdModalidade.ToString());
		}

		public RetornoDTO Alterar(ModalidadeDTO modalidadeDTO)
		{
			return querys.Alterar("MODALIDADE",
				$"modalidade = '{modalidadeDTO.Modalidade}'",
				"id_modalidade", modalidadeDTO.IdModalidade.ToString()
			);
		}

		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("MODALIDADE");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("MODALIDADE", condicao);
		}
	}
}
