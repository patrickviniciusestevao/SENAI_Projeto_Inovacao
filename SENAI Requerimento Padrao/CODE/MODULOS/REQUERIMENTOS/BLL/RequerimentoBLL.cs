using System;
using System.Data;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.FUNCTIONS;

namespace SENAI_Requerimento_Padrao.CODE.BLL
{
    class RequerimentoBLL
    {
		Querys querys = new Querys();
		public RetornoDTO Inserir(RequerimentoDTO requerimentoDTO)
		{
			return querys.Inserir("REQUERIMENTO", "id_modalidade_curso, item_requerimento, modulo_periodo, turno, informacoes_adicionais, data_hora_periodo, situacao",
				$"'{requerimentoDTO.IdModalidadeCurso}'," +
				$"'{requerimentoDTO.ItemRequerimento}'," +
				$"'{requerimentoDTO.ModuloPeriodo}'," +
				$"'{requerimentoDTO.Turno}'," +
				$"'{requerimentoDTO.InformacoesAdicionais}'," +
				$"'{requerimentoDTO.DataHoraPedido}'," +
				$"'{requerimentoDTO.Situacao}'"
			);
		}

		public RetornoDTO Excluir(RequerimentoDTO requerimentoDTO)
		{
			return querys.Excluir("REQUERIMENTO", "id_endereco_usuario", requerimentoDTO.IdRequerimento.ToString());
		}

		public RetornoDTO Alterar(RequerimentoDTO requerimentoDTO)
		{
			return querys.Alterar("REQUERIMENTO", 
				$"id_modalidade_curso = '{requerimentoDTO.IdModalidadeCurso}'," +
				$"item_requerimento = '{requerimentoDTO.ItemRequerimento}'," +
				$"modulo_periodo = '{requerimentoDTO.ModuloPeriodo}'," +
				$"turno = '{requerimentoDTO.Turno}'," +
				$"informacoes_adicionais = '{requerimentoDTO.InformacoesAdicionais}'," +
				$"data_hora_pedido = '{requerimentoDTO.DataHoraPedido}'," +
				$"situacao = '{requerimentoDTO.Situacao}'",
				"id_requerimento", requerimentoDTO.IdRequerimento.ToString()
			);
		}

		public SelecionarRetornoDTO SelecionarTodos()
		{
			return querys.SelecionarTodos("REQUERIMENTO");
		}

		public SelecionarRetornoDTO SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("REQUERIMENTO", condicao);
		}
	}
}
