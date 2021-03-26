using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class DocumentoItemRequerimentoBLL
    {
		Querys querys = new Querys();
		public RetornoDTO Inserir(DocumentoItemRequerimentoDTO documentoItemRequerimentoDTO)
		{
			return querys.Inserir("DOCUMENTO_ITEM_REQUERIMENTO", "id_documento, item_requerimento",
				$"'{documentoItemRequerimentoDTO.IdDocumento}', " +
				$"'{documentoItemRequerimentoDTO.ItemRequerimento}'");
		}

		public RetornoDTO Excluir(DocumentoItemRequerimentoDTO documentoItemRequerimentoDTO)
		{
			return querys.Excluir("DOCUMENTO_ITEM_REQUERIMENTO", "id_documento_item_requerimento", 
				documentoItemRequerimentoDTO.IdDocumentoItemRequerimento.ToString());
		}

		public RetornoDTO Alterar(DocumentoItemRequerimentoDTO documentoItemRequerimentoDTO)
		{
			return querys.Alterar("DOCUMENTO_ITEM_REQUERIMENTO",
				$"id_documento = '{documentoItemRequerimentoDTO.IdDocumento}', " +
				$"item_requerimento = '{documentoItemRequerimentoDTO.ItemRequerimento}'",
				"id_documento_item_requerimento", documentoItemRequerimentoDTO.IdDocumentoItemRequerimento.ToString()
			);
		}

		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("DOCUMENTO_ITEM_REQUERIMENTO");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("DOCUMENTO_ITEM_REQUERIMENTO", condicao);
		}
	}
}
