using System;

namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class DocumentoClienteDTO
    {
        private int id_documento_cliente;
        private int id_cliente;
        private int id_documento;
        private string diretorio_arquivo;
        private DateTime data_cadastro;

        public int IdDocumentoCliente { get => id_documento_cliente; set => id_documento_cliente = value; }
        public int IdCliente { get => id_cliente; set => id_cliente = value; }
        public int IdDocumento { get => id_documento; set => id_documento = value; }
        public string DiretorioArquivo { get => diretorio_arquivo; set => diretorio_arquivo = value; }
        public DateTime DataCadastro { get => data_cadastro; set => data_cadastro = value; }
    }
}
