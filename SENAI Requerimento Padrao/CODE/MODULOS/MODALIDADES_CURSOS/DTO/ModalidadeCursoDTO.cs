namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class ModalidadeCursoDTO
    {
        private int id_modalidade_curso;
        private int id_modalidade;
        private int id_curso;

        public int IdModalidadeCurso { get => id_modalidade_curso; set => id_modalidade_curso = value; }
        public int IdModalidade { get => id_modalidade; set => id_modalidade = value; }
        public int IdCurso { get => id_curso; set => id_curso = value; }
    }
}
