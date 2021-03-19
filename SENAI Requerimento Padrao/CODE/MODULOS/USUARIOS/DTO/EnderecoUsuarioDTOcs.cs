namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class EnderecoUsuarioDTOcs
    {
        private int id_endereco_usuario;
        private int id_usuario;
        private string logradouro;
        private string numero;
        private string cep;
        private string bairro;
        private string complemento;
        private string cidade;
        private string uf;
        private string categoria_endereco;

        public int IdEnderecoUsuario { get => id_endereco_usuario; set => id_endereco_usuario = value; }
        public int IdUsuario { get => id_usuario; set => id_usuario = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string CategoriaEndereco { get => categoria_endereco; set => categoria_endereco = value; }
    }
}
