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
		public void Inserir(RequerimentoDTO requerimentoDTO)
		{
			querys.Inserir("REQUERIMENTO", "id_modalidade_curso, item_requerimento, modulo_periodo, turno, informacoes_adicionais, data_hora_periodo, situacao",
				$"'{requerimentoDTO.IdModalidadeCurso}'," +
				$"'{requerimentoDTO.ItemRequerimento}'," +
				$"'{requerimentoDTO.ModuloPeriodo}'," +
				$"'{requerimentoDTO.Turno}'," +
				$"'{requerimentoDTO.InformacoesAdicionais}'," +
				$"'{requerimentoDTO.DataHoraPedido}'," +
				$"'{requerimentoDTO.Situacao}'"
			);
		}

		public void Excluir(RequerimentoDTO requerimentoDTO)
		{
			querys.Excluir("REQUERIMENTO", "id_endereco_usuario", requerimentoDTO.IdRequerimento.ToString());
		}

		public void Alterar(RequerimentoDTO requerimentoDTO)
		{
			querys.Alterar("REQUERIMENTO", 
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

		public DataTable SelecionarTodos()
		{
			return querys.SelecionarTodos("REQUERIMENTO");
		}

		public DataTable SelecionarComCondicao(string condicao)
		{
			return querys.SelecionarComCondicao("REQUERIMENTO", condicao);
		}
	}
}
