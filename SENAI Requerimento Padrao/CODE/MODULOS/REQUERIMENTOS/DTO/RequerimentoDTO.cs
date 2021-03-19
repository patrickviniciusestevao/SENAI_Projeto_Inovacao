using System;
using System.Collections.Generic;
using System.Text;

namespace SENAI_Requerimento_Padrao.CODE.DTO
{
    class RequerimentoDTO
    {
        private int id_requerimento;
        private int id_modalidade_curso;
        private int item_requerimento;
        private int modulo_periodo;
        private string turno;
        private string informacoes_adicionais;
        private DateTime data_hora_pedido;
        private string situacao;

        public int IdRequerimento { get => id_requerimento; set => id_requerimento = value; }
        public int IdModalidadeCurso { get => id_modalidade_curso; set => id_modalidade_curso = value; }
        public int ItemRequerimento { get => item_requerimento; set => item_requerimento = value; }
        public int ModuloPeriodo { get => modulo_periodo; set => modulo_periodo = value; }
        public string Turno { get => turno; set => turno = value; }
        public string InformacoesAdicionais { get => informacoes_adicionais; set => informacoes_adicionais = value; }
        public DateTime DataHoraPedido { get => data_hora_pedido; set => data_hora_pedido = value; }
        public string Situacao { get => situacao; set => situacao = value; }
    }
}
