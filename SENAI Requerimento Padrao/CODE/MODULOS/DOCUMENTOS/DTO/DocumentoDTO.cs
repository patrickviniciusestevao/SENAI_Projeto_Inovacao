namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class DocumentoDTO
    {
        private int id_documento;
        private string documento;

        public int IdDocumento { get => id_documento; set => id_documento = value; }
        public string Documento { get => documento; set => documento = value; }
    }
}
