namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class TelefoneUsuarioDTO
    {
        private int id_telefone_usuario;
        private int id_usuario;
        private string numero_telefone;
        private bool whatsapp;
        private string caregoria_telefone;

        public int IdTelefoneUsuario { get => id_telefone_usuario; set => id_telefone_usuario = value; }
        public int IdUsuario { get => id_usuario; set => id_usuario = value; }
        public string NumeroTelefone { get => numero_telefone; set => numero_telefone = value; }
        public bool Whatsapp { get => whatsapp; set => whatsapp = value; }
        public string CaregoriaTelefone { get => caregoria_telefone; set => caregoria_telefone = value; }
    }
}
