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
		public RetornoDTO Inserir(ModalidadeCursoDTO modalidadeCursoDTO)
		{
			return querys.Inserir("MODALIDADE_CURSO", "id_modalidade, id_curso",
				$"'{modalidadeCursoDTO.IdModalidade}', " +
				$"'{modalidadeCursoDTO.IdCurso}'");
		}

		public RetornoDTO Excluir(ModalidadeCursoDTO modalidadeCursoDTO)
		{
			return querys.Excluir("MODALIDADE_CURSO", "id_modalidade_curso",
				modalidadeCursoDTO.IdModalidadeCurso);
		}

		public RetornoDTO Alterar(ModalidadeCursoDTO modalidadeCursoDTO)
		{
			return querys.Alterar("MODALIDADE_CURSO",
				$"id_modalidade = '{modalidadeCursoDTO.IdModalidade}', " +
				$"id_curso = '{modalidadeCursoDTO.IdCurso}'",
				"id_modalidade_curso", modalidadeCursoDTO.IdModalidadeCurso
			);
		}

		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("MODALIDADE_CURSO");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("MODALIDADE_CURSO", condicao);
		}
	}
}
