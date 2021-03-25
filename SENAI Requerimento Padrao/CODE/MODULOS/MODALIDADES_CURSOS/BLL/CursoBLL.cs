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
		public void Inserir(CursoDTO cursoDTO)
		{
			querys.Inserir("CURSO", "nome_curso",
				$"'{cursoDTO.NomeCurso}'");
		}

		public void Excluir(CursoDTO cursoDTO)
		{
			querys.Excluir("CURSO", "id_curso",
				cursoDTO.IdCurso.ToString());
		}

		public void Alterar(CursoDTO cursoDTO)
		{
			querys.Alterar("CURSO",
				$"nome_curso = '{cursoDTO.NomeCurso}'",
				"id_curso", cursoDTO.IdCurso.ToString()
			);
		}

		public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("CURSO");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("CURSO", condicao);
		}
	}
}
