using System;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.BLL;
using SENAI_Requerimento_Padrao.CODE.DTO;

namespace SENAI_Requerimento_Padrao.CODE.GUI
{
    public partial class TesteCRUD : Form
    {
        DocumentoClienteBLL bll = new DocumentoClienteBLL();
        DocumentoClienteDTO data = new DocumentoClienteDTO();
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
            data.IdCliente = 2;
            data.IdDocumento = 2;
            data.DiretorioArquivo = "https://";

            DataGridViewRow linhaAtual = dataGrid.CurrentRow;

            int indice = linhaAtual.Index;
            data.IdDocumentoCliente = Int32.Parse(dataGrid.Rows[indice].Cells[0].Value.ToString());

            RetornoDTO retornoAlterar = bll.Alterar(data);

            if(retornoAlterar.codigo != 0)
            {
                MessageBox.Show(retornoAlterar.mensagem);
            }

            this.atualizarGrid();
        }

        private void excluir(object sender, EventArgs e)
        {
            DataGridViewRow linhaAtual = dataGrid.CurrentRow;

            int indice = linhaAtual.Index;
            data.IdDocumentoCliente = Int32.Parse(dataGrid.Rows[indice].Cells[0].Value.ToString());

            bll.Excluir(data);

            this.atualizarGrid();
        }

        private void inserir(object sender, EventArgs e)
        {
            data.IdCliente = 2;
            data.IdDocumento = 2;
            data.DiretorioArquivo = "://";

            RetornoDTO retornoInsercao = bll.Inserir(data);

            if(retornoInsercao.codigo != 0)
            {
                MessageBox.Show(retornoInsercao.mensagem);
            }

            this.atualizarGrid();
        }
    }
}
