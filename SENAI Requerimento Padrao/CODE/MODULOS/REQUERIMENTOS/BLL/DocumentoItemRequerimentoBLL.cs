using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class DocumentoItemRequerimentoBLL
    {
		Querys querys = new Querys();
		public void Inserir(DocumentoItemRequerimentoDTO documentoItemRequerimentoDTO)
		{
			querys.Inserir("DOCUMENTO_ITEM_REQUERIMENTO", "id_documento, item_requerimento",
				$"'{documentoItemRequerimentoDTO.IdDocumento}', " +
				$"'{documentoItemRequerimentoDTO.ItemRequerimento}'");
		}

		public void Excluir(DocumentoItemRequerimentoDTO documentoItemRequerimentoDTO)
		{
			querys.Excluir("DOCUMENTO_ITEM_REQUERIMENTO", "id_documento_item_requerimento", 
				documentoItemRequerimentoDTO.IdDocumentoItemRequerimento.ToString());
		}

		public void Alterar(DocumentoItemRequerimentoDTO documentoItemRequerimentoDTO)
		{
			querys.Alterar("DOCUMENTO_ITEM_REQUERIMENTO",
				$"id_documento = '{documentoItemRequerimentoDTO.IdDocumento}', " +
				$"item_requerimento = '{documentoItemRequerimentoDTO.ItemRequerimento}'",
				"id_documento_item_requerimento", documentoItemRequerimentoDTO.IdDocumentoItemRequerimento.ToString()
			);
		}

		public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("DOCUMENTO_ITEM_REQUERIMENTO");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("DOCUMENTO_ITEM_REQUERIMENTO", condicao);
		}
	}
}
}
