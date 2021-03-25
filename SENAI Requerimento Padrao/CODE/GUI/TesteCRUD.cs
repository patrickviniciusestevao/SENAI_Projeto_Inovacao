using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.BLL;
using SENAI_Requerimento_Padrao.CODE.DTO;

namespace SENAI_Requerimento_Padrao.CODE.GUI
{
    public partial class TesteCRUD : Form
    {
        FuncaoBLL funcaoBLL = new FuncaoBLL();
        FuncaoDTO dataFuncao = new FuncaoDTO();
        public TesteCRUD()
        {
            InitializeComponent();
        }

        private void atualizarGrid()
        {
            dataGrid.DataSource = funcaoBLL.SelecionarTodos();
        }

        private void carregarDados(object sender, EventArgs e)
        {
            this.atualizarGrid();
        }

        private void atualizar(object sender, EventArgs e)
        {
            dataFuncao.Funcao = "Gabriel";
            dataFuncao.NivelPermissao = 3;

            DataGridViewRow linhaAtual = dataGrid.CurrentRow;

            int indice = linhaAtual.Index;
            dataFuncao.IdFuncao = Int32.Parse(dataGrid.Rows[indice].Cells[0].Value.ToString());

            funcaoBLL.Alterar(dataFuncao);

            this.atualizarGrid();
        }

        private void excluir(object sender, EventArgs e)
        {
            DataGridViewRow linhaAtual = dataGrid.CurrentRow;

            int indice = linhaAtual.Index;
            dataFuncao.IdFuncao = Int32.Parse(dataGrid.Rows[indice].Cells[0].Value.ToString());

            funcaoBLL.Excluir(dataFuncao);

            this.atualizarGrid();
        }

        private void inserir(object sender, EventArgs e)
        {
            dataFuncao.Funcao = "Administrador";
            dataFuncao.NivelPermissao = 1;

            funcaoBLL.Inserir(dataFuncao);
        }
    }
}
