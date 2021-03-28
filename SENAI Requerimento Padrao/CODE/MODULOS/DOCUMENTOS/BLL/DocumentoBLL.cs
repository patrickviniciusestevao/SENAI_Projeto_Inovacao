using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class DocumentoBLL
    {
        Querys querys = new Querys();

        public RetornoDTO Inserir(DocumentoDTO documentoDTO)
        {
                return querys.Inserir("DOCUMENTO", "documento",
                    $"'{documentoDTO.Documento}'"                 
                );
        }

        public RetornoDTO Excluir(DocumentoDTO documentoDTO)
        {
            return querys.Excluir  ("DOCUMENTO", "id_documento",  
                    documentoDTO.IdDocumento                    
                    );
        }

        public RetornoDTO Alterar(DocumentoDTO documentoDTO)
        {
            return querys.Alterar("DOCUMENTO",
                   $"documento = '{documentoDTO.Documento}'",
                    "id_documento", documentoDTO.IdDocumento);
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
