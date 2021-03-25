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
        public void Inserir(DocumentoDTO documentoDTO)
        {
                querys.Inserir("DOCUMENTO", "documento",
                    $"'{documentoDTO.Documento}',"                 
                    );
        }
        public void Excluir(DocumentoDTO documentoDTO)
        {
            querys.Excluir  ("DOCUMENTO", "id_documento",  
                    documentoDTO.IdDocumento.ToString()                    
                    );
        }
        public void Alterar(DocumentoDTO documentoDTO)
        {
            querys.Alterar("DOCUMENTO", 
                $"documento = '{documentoDTO.Documento}'",                 
                "id_documento", documentoDTO.IdDocumento.ToString());
        }
        public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("DOCUMENTO");
		}
        public DataTable SelecionarComFiltro(DocumentoDTO documentoDTO)
        {
            return querys.SelecionarComCondicao("DOCUMENTO", "id_documento like '" + documentoDTO.IdDocumento + "%'");
        }
        public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("DOCUMENTO", condicao);
		}
    }
}
