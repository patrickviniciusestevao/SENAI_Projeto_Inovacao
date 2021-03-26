using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class ItemRequerimentoBLL
    {
		Querys querys = new Querys();
		public RetornoDTO Inserir(ItemRequerimentoDTO itemRequerimentoDTO)
		{
			return querys.Inserir("ITEM_REQUERIMENTO", "id_funcao, nome, valor",
				$"'{itemRequerimentoDTO.IdFuncao}', " +
				$"'{itemRequerimentoDTO.Nome}', " +
				$"'{itemRequerimentoDTO.Valor}'");
		}

		public RetornoDTO Excluir(ItemRequerimentoDTO itemRequerimentoDTO)
		{
			return querys.Excluir("ITEM_REQUERIMENTO", "item_requerimento", itemRequerimentoDTO.ItemRequerimento.ToString());
		}

		public RetornoDTO Alterar(ItemRequerimentoDTO itemRequerimentoDTO)
		{
			return querys.Alterar("ITEM_REQUERIMENTO",
				$"funcao = '{itemRequerimentoDTO.IdFuncao}', " +
				$"nivel_permissao = '{itemRequerimentoDTO.Nome}', " +
				$"valor = '{itemRequerimentoDTO.Valor}'",
				"id_funcao", itemRequerimentoDTO.ItemRequerimento.ToString()
			);
		}

		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("ITEM_REQUERIMENTO");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("ITEM_REQUERIMENTO", condicao);
		}
	}
}
