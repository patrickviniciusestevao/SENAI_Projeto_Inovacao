using System;
using SENAI_Requerimento_Padrao.CODE.DTO;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class ModalidadeCursoBLL
    {
		Querys querys = new Querys();
		public void Inserir(ModalidadeCursoDTO modalidadeCursoDTO)
		{
			querys.Inserir("MODALIDADE_CURSO", "id_modalidade, id_curso",
				$"'{modalidadeCursoDTO.IdModalidade}', " +
				$"'{modalidadeCursoDTO.IdCurso}'");
		}

		public void Excluir(ModalidadeCursoDTO modalidadeCursoDTO)
		{
			querys.Excluir("MODALIDADE_CURSO", "id_modalidade_curso",
				modalidadeCursoDTO.IdModalidadeCurso.ToString());
		}

		public void Alterar(ModalidadeCursoDTO modalidadeCursoDTO)
		{
			querys.Alterar("MODALIDADE_CURSO",
				$"id_modalidade = '{modalidadeCursoDTO.IdModalidade}', " +
				$"id_curso = '{modalidadeCursoDTO.IdCurso}'",
				"id_modalidade_curso", modalidadeCursoDTO.IdModalidadeCurso.ToString()
			);
		}

		public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("MODALIDADE_CURSO");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("MODALIDADE_CURSO", condicao);
		}
	}
}
