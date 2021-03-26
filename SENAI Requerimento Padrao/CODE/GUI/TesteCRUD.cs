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
        TelefoneUsuarioBLL bll = new TelefoneUsuarioBLL();
        TelefoneUsuarioDTO data = new TelefoneUsuarioDTO();
        public TesteCRUD()
        {
            InitializeComponent();
        }

        private void atualizarGrid()
        {
            dataGrid.DataSource = bll.SelecionarTodos().tabela;
        }

        private void carregarDados(object sender, EventArgs e)
        {
            this.atualizarGrid();
        }

        private void atualizar(object sender, EventArgs e)
        {
            data.IdUsuario = 5;
            data.NumeroTelefone = "39393393939";
            data.Whatsapp = false;
            data.CategoriaTelefone = "Casa";

            DataGridViewRow linhaAtual = dataGrid.CurrentRow;

            int indice = linhaAtual.Index;
            data.IdTelefoneUsuario = Int32.Parse(dataGrid.Rows[indice].Cells[0].Value.ToString());

            bll.Alterar(data);

            this.atualizarGrid();
        }

        private void excluir(object sender, EventArgs e)
        {
            DataGridViewRow linhaAtual = dataGrid.CurrentRow;

            int indice = linhaAtual.Index;
            data.IdTelefoneUsuario = Int32.Parse(dataGrid.Rows[indice].Cells[0].Value.ToString());

            bll.Excluir(data);

            this.atualizarGrid();
        }

        private void inserir(object sender, EventArgs e)
        {
            data.IdUsuario = 5;
            data.NumeroTelefone = "95445960";
            data.Whatsapp = true;
            data.CategoriaTelefone = "Casa";

            RetornoDTO retornoInsercao = bll.Inserir(data);

            if(retornoInsercao.codigo != 0)
            {
                MessageBox.Show(retornoInsercao.mensagem);
            }

            this.atualizarGrid();
        }
    }
}
