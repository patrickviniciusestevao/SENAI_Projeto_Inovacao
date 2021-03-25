using System.Data;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.DAL;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.MODULOS.CLIENTES.BLL
{
    class DocumentoClienteBLL
    {
        AcessoBancoDados bd;
        Querys querys = new Querys();

        public void Inserir(DocumentoClienteDTO documentoClienteDTO)
        {
            querys.Inserir("DOCUMENTO_CLIENTE", "id_cliente, id_documento, data_cadastro, diretorio_arquivo", 
                "'"+ documentoClienteDTO.IdCliente +"'," +
                "'" + documentoClienteDTO.IdDocumento + "'," +
                "'" + documentoClienteDTO.DataCadastro + "'," +
                "'" + documentoClienteDTO.Diretorio_arquivo + "',");
        }
        public void Excluir(DocumentoClienteDTO documentoClienteDTO)
        {
            querys.Excluir("DOCUMENTO_CLIENTE","id_documento_cliente","'"+ documentoClienteDTO.IdDocumentoCliente +"'");
        }
        public void Alterar(DocumentoClienteDTO documentoClienteDTO)
        {
            querys.Alterar("DOCUMENTO_CLIENTE", 
                "'" + documentoClienteDTO.IdCliente + "'," +
                "'" + documentoClienteDTO.IdDocumento + "'," +
                "'" + documentoClienteDTO.DataCadastro + "'," +
                "'" + documentoClienteDTO.Diretorio_arquivo + "',", 
                "id_documento_cliente", documentoClienteDTO.IdDocumentoCliente.ToString());
        }
        public DataTable SelecionarTodos()
        {
            return querys.SelecionarTodos("DOCUMENTO_CLIENTE");
        }
        public DataTable SelecionarComFiltro(DocumentoClienteDTO documentoClienteDTO)
        {
            return querys.SelecionarComCondicao("DOCUMENTO_CLIENTE", "id_documento_cliente like '" + documentoClienteDTO.IdDocumentoCliente + "%'");
        }
        public DataTable SelecionarComCondicao(string condicao)
        {
            return querys.SelecionarComCondicao("DOCUMENTO_CLIENTE", condicao);
        }
    }
}
