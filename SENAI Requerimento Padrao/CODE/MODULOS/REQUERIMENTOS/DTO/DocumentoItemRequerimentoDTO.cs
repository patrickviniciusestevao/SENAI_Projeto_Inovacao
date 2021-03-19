namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class DocumentoItemRequerimentoDTO
    {
        private int id_documento_item_requerimento;
        private int id_documento;
        private int item_requerimento;

        public int IdDocumentoItemRequerimento { get => id_documento_item_requerimento; set => id_documento_item_requerimento = value; }
        public int IdDocumento { get => id_documento; set => id_documento = value; }
        public int ItemRequerimento { get => item_requerimento; set => item_requerimento = value; }
    }
}
