namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class CursoDTO
    {
        private int id_curso;
        private string nome_curso;

        public int IdCurso { get => id_curso; set => id_curso = value; }
        public string NomeCurso { get => nome_curso; set => nome_curso = value; }
    }
}
