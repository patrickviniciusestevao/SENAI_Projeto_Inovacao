namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class ItemRequerimentoDTO
    {
        private int item_requerimento;
        private int id_funcao;
        private string nome;
        private decimal valor;

        public int ItemRequerimento { get => item_requerimento; set => item_requerimento = value; }
        public int IdFuncao { get => id_funcao; set => id_funcao = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Valor { get => valor; set => valor = value; }
    }
}
