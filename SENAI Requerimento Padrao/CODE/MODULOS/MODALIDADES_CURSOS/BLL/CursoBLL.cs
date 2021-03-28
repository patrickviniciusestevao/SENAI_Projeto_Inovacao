using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class CursoBLL
    {
		Querys querys = new Querys();
		public RetornoDTO Inserir(CursoDTO cursoDTO)
		{
			return querys.Inserir("CURSO", "nome_curso",
				$"'{cursoDTO.NomeCurso}'");
		}

		public RetornoDTO Excluir(CursoDTO cursoDTO)
		{
			return querys.Excluir("CURSO", "id_curso",
				cursoDTO.IdCurso);
		}

		public RetornoDTO Alterar(CursoDTO cursoDTO)
		{
			return querys.Alterar("CURSO",
				$"nome_curso = '{cursoDTO.NomeCurso}'",
				"id_curso", cursoDTO.IdCurso
			);
		}

		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("CURSO");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("CURSO", condicao);
		}
	}
}
