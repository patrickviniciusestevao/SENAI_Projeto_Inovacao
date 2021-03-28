using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class DocumentoClienteBLL
    {
        Querys querys = new Querys();

        public RetornoDTO Inserir(DocumentoClienteDTO documentoClienteDTO)
        {
            return querys.Inserir("DOCUMENTO_CLIENTE", "id_cliente, id_documento, data_cadastro, diretorio_arquivo", 
                "'"+ documentoClienteDTO.IdCliente +"'," +
                "'" + documentoClienteDTO.IdDocumento + "'," +
                " NOW()," +
                "'" + documentoClienteDTO.DiretorioArquivo + "'");
        }
        public RetornoDTO Excluir(DocumentoClienteDTO documentoClienteDTO)
        {
            return querys.Excluir("DOCUMENTO_CLIENTE","id_documento_cliente", documentoClienteDTO.IdDocumentoCliente);
        }
        public RetornoDTO Alterar(DocumentoClienteDTO documentoClienteDTO)
        {
            return querys.Alterar("DOCUMENTO_CLIENTE",
                "id_cliente = '" + documentoClienteDTO.IdCliente + "'," +
                "id_documento = '" + documentoClienteDTO.IdDocumento + "'," +
                "diretorio_arquivo = '" + documentoClienteDTO.DiretorioArquivo + "'", 
                "id_documento_cliente", documentoClienteDTO.IdDocumentoCliente);
        }
        public SelecionarRetornoDTO SelecionarTodos()
        {
            return querys.SelecionarTodos("DOCUMENTO_CLIENTE");
        }
        public SelecionarRetornoDTO SelecionarComFiltro(DocumentoClienteDTO documentoClienteDTO)
        {
            return querys.SelecionarComCondicao("DOCUMENTO_CLIENTE", "id_documento_cliente like '%" + documentoClienteDTO.IdDocumentoCliente + "%'");
        }
        public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("DOCUMENTO_CLIENTE", condicao);
        }
    }
}
