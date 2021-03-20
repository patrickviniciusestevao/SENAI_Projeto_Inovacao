namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class ClienteRequerimentoDTO
    {
        private int id_cliente_requerimento;
        private int id_cliente;
        private int id_requerimento;

        public int IdClienteRequerimento { get => id_cliente_requerimento; set => id_cliente_requerimento = value; }
        public int IdCliente { get => id_cliente; set => id_cliente = value; }
        public int IdRequerimento { get => id_requerimento; set => id_requerimento = value; }
    }
}
