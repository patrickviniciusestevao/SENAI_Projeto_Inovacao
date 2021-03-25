using System;
using System.Collections.Generic;
using System.Text;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.MODULOS.DOCUMENTOS.BLL
{
    class DocumentoBLL
    {
        Querys querys = new Querys();

        public void Inserir(DocumentoDTO documentoDTO)
        {
                querys.Inserir("DOCUMENTOS", "documento",
                    $"'{documentoDTO.Documento}',"                 
                    );
        }

        public void Excluir(DocumentoDTO documentoDTO)
        {
            querys.Excluir  ("DOCUMENTOS", "id_documento",  
                    documentoDTO.IdDocumento.ToString()                    
                    );
        }

        public void Alterar(DocumentoDTO documentoDTO)
        {
            querys.Alterar("DOCUMENTOS", "id_documento, documento")
                   $"documento = '{documentoDTO.Documento}'",
				    "id_documento", documentoDTO.IdDocumento.ToString()
        }

        public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("DOCUMENTO");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("DOCUMENTO", condicao);
		}
    }
}
