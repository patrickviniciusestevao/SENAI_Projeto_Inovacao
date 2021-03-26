using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.MODULOS.DOCUMENTOS.BLL
{
    class DocumentoBLL
    {
        AcessoBancoDados bd;
        Querys querys = new Querys();

        public RetornoDTO Inserir(DocumentoDTO documentoDTO)
        {
                return querys.Inserir("DOCUMENTOS", "documento",
                    $"'{documentoDTO.Documento}'"                 
                );
        }

        public RetornoDTO Excluir(DocumentoDTO documentoDTO)
        {
            return querys.Excluir  ("DOCUMENTOS", "id_documento",  
                    documentoDTO.IdDocumento.ToString()                    
                    );
        }

        public RetornoDTO Alterar(DocumentoDTO documentoDTO)
        {
            return querys.Alterar("DOCUMENTOS",
                   $"documento = '{documentoDTO.Documento}'",
                    "id_documento", documentoDTO.IdDocumento.ToString());
        }

        public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("DOCUMENTO");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("DOCUMENTO", condicao);
		}
    }
}
