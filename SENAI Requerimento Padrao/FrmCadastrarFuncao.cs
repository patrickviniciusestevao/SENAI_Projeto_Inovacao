using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.BLL;

namespace SENAI_Requerimento_Padrao
{
	public partial class FrmCadastrarFuncao : Form
	{

		FuncaoDTO dto = new FuncaoDTO();
		FuncaoBLL bll = new FuncaoBLL();
		private string id_funcao_PK;

		public FrmCadastrarFuncao()
		{
			InitializeComponent();
		}

		private void FrmCadastroFuncao_Load(object sender, EventArgs e)
		{
			InicializarComponentes();
			CarregarGrid("selecionar todos");
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			if (btnFechar.Text == "Fechar")
			{
				Close();
			}
			else if (btnFechar.Text == "Cancelar Alteração")
			{
				InicializarComponentes();
			}

		}

		private void btnGravar_Click(object sender, EventArgs e)
		{
				if (txtFuncao.Text != "")
				{
					dto.Funcao = txtFuncao.Text;
					
					if (comboNivelPermissao.Text == "Selecione Nível")
					{
						MessageBox.Show("Selecione um nível de permissão válido!");
					}
					else
					{
						dto.Nivel_permissao = Int32.Parse(comboNivelPermissao.Text);

						if (id_funcao_PK == "")
						{
							//bll.VerificarRegistroDuplicidade(dto);
							//CarregarGrid("selecionar por filtro");
							//if (gridFuncoes.Rows.Count == 0)
							//{
								bll.Inserir(dto);
								MessageBox.Show("A função: " + (dto.Funcao) + ", foi cadastrada com sucesso!", "Inserido com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
							//	FrmCadastrarUsuario frm = new FrmCadastrarUsuario();
							//	frm.
						//}
							//else
							//{
							//MessageBox.Show("A função: " + (dto.Funcao) + ", já está na base de dados e não pode ser cadastrada novamente!", "Registro já Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
							//}
						}
						else if (Int32.Parse(id_funcao_PK) > 0)
						{
							dto.Id_funcao = Int32.Parse(id_funcao_PK);
							bll.Alterar(dto);
							MessageBox.Show("a função foi alterada para: " + (dto.Funcao) + ", com sucesso!", "Alterado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						InicializarComponentes();
						CarregarGrid("selecionar todos");
					}
				}
				else
				{
					MessageBox.Show("A função é campo obrigatório!");
				}
			
		
		}

		private void CarregarGrid(String tipoSelecao)
		{
			if (tipoSelecao == "selecionar todos")
			{
				gridFuncoes.DataSource = bll.SelecionaTodosFuncoes();
				//tratamento do título com a quantidade cadastradas
				if (gridFuncoes.Rows.Count == 0)
				{
					lblTituloFuncoes.Text = "Nenhuma Função Cadastrada";
					gridFuncoes.Visible = false;
				}
				else if (gridFuncoes.Rows.Count == 1)
				{
					lblTituloFuncoes.Text = "1 Função Cadastrada";
					gridFuncoes.Visible = true;
					PersonalizarGrid();
				}
				else if (gridFuncoes.Rows.Count > 1)
				{
					lblTituloFuncoes.Text = gridFuncoes.Rows.Count.ToString() + " Funções Cadastradas";
					gridFuncoes.Visible = true;
					PersonalizarGrid();
				}
			}
			else if (tipoSelecao == "selecionar por filtro")
			{
				gridFuncoes.DataSource = bll.SelecionaFiltro(dto);
				//tratamento do título com a quantidade cadastradas
				if (gridFuncoes.Rows.Count == 0)
				{
					lblTituloFuncoes.Text = "Nenhuma Função Localizada";
					gridFuncoes.Visible = false;
				}
				else if (gridFuncoes.Rows.Count == 1)
				{
					lblTituloFuncoes.Text = "1 Função Localizada";
					gridFuncoes.Visible = true;
					PersonalizarGrid();
				}
				else if (gridFuncoes.Rows.Count > 1)
				{
					lblTituloFuncoes.Text = gridFuncoes.Rows.Count.ToString() + " Funções Localizadas";
					gridFuncoes.Visible = true;
					PersonalizarGrid();
				}
			}
			


			
		}

		private void PersonalizarGrid()
		{
			//gridFuncoes.Columns["id_funcao"].Visible = false;
			gridFuncoes.Columns["editar"].DisplayIndex = 0;
			gridFuncoes.Columns["excluir"].DisplayIndex = 1;
			gridFuncoes.Columns["id_funcao"].DisplayIndex = 2;
			gridFuncoes.Columns["funcao"].DisplayIndex = 3;
			gridFuncoes.Columns["nivel_permissao"].DisplayIndex = 4;


			//aparência do datagridview
			gridFuncoes.DefaultCellStyle.Font = new Font("Roboto", 11);
			gridFuncoes.DefaultCellStyle.ForeColor = Color.White;
			gridFuncoes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 175, 239);

			//alinhando no centro o conteudo do codigo e do nivel de permissao
			gridFuncoes.Columns["id_funcao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			gridFuncoes.Columns["nivel_permissao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			gridFuncoes.ColumnHeadersVisible = true;
			gridFuncoes.ColumnHeadersHeight = 50;

			gridFuncoes.Columns["editar"].HeaderText = "";
			gridFuncoes.Columns["excluir"].HeaderText = "";
			gridFuncoes.Columns["id_funcao"].HeaderText = "Código";
			gridFuncoes.Columns["funcao"].HeaderText = "Função";
			gridFuncoes.Columns["nivel_permissao"].HeaderText = "Nível Permissão";


			gridFuncoes.EnableHeadersVisualStyles = false;
			gridFuncoes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 175, 239);
			gridFuncoes.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 77);
			gridFuncoes.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10, FontStyle.Bold);
			gridFuncoes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			gridFuncoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridFuncoes.MultiSelect = false;


			//0 = editar //1= excluir
			gridFuncoes.Columns["editar"].Width = (int)(gridFuncoes.Width * 0.05);
			gridFuncoes.Columns["excluir"].Width = (int)(gridFuncoes.Width * 0.05);

			//2 = id funcao //3 = funcao // 4 = nivel permissao
			gridFuncoes.Columns["id_funcao"].Width = (int)(gridFuncoes.Width * 0.2);
			gridFuncoes.Columns["funcao"].Width = (int)(gridFuncoes.Width * 0.4);
			gridFuncoes.Columns["nivel_permissao"].Width = (int)(gridFuncoes.Width * 0.3);
			gridFuncoes.Columns["funcao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void InicializarComponentes()
		{
			id_funcao_PK = "";
			txtFuncao.Clear();
			comboNivelPermissao.SelectedIndex = 0;
			txtFuncao.PlaceholderText = "Função";
			btnFechar.Text = "Fechar";
			txtFuncao.Focus();
		}

		private void gridFuncoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				//e.ColumnIndex == 0 é a celula do LAPIS para EDICAO
				EditarGridView();
			}
			else if(e.ColumnIndex == 1)
			{
				//e.ColumnIndex == 1 é a celula da LIXEIRA para EXCLUSAO
				ExcluirGridView();
			}
		}
		private void ExcluirGridView()
		{ 
			int indiceselecionado = -1;
			// Se o usuário selecionou a Linha
			if (gridFuncoes.SelectedRows.Count > 0)
			{
				indiceselecionado = gridFuncoes.SelectedRows[0].Index;
			}
			else
			{ // Se o usuário selecionou a célula
				if (gridFuncoes.SelectedCells.Count > 0)
				{
					indiceselecionado = gridFuncoes.SelectedCells[0].RowIndex;
				}
			}

			if (indiceselecionado != -1)
			{
				DataRowView dr = (DataRowView)gridFuncoes.Rows[indiceselecionado].DataBoundItem;
				if (dr != null)
				{
					dto.Id_funcao = Int32.Parse(dr["id_funcao"].ToString());
					var result = MessageBox.Show("Deseja realmente excluir a função: " + (dr["funcao"].ToString()) + "?", "Exclusão de Função", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (result == System.Windows.Forms.DialogResult.Yes)
					{
						bll.Excluir(dto);
						InicializarComponentes();
						CarregarGrid("selecionar todos");
					}
					else if (result == System.Windows.Forms.DialogResult.No)
					{
						InicializarComponentes();
					}
				}
				else if (dr == null)
				{
					InicializarComponentes();
				}
			}
		}

		private void EditarGridView()
		{
			int indiceselecionado = -1;
			// Se o usuário selecionou a Linha
			if (gridFuncoes.SelectedRows.Count > 0)
			{
				indiceselecionado = gridFuncoes.SelectedRows[0].Index;
			}
			else
			{ // Se o usuário selecionou a célula
				if (gridFuncoes.SelectedCells.Count > 0)
				{
					indiceselecionado = gridFuncoes.SelectedCells[0].RowIndex;
				}
			}

			if (indiceselecionado != -1)
			{
				DataRowView dr = (DataRowView)gridFuncoes.Rows[indiceselecionado].DataBoundItem;
				if (dr != null)
				{
					id_funcao_PK = dr["id_funcao"].ToString();
					txtFuncao.Text = dr["funcao"].ToString();
					comboNivelPermissao.Text = dr["nivel_permissao"].ToString();
					btnFechar.Text = "Cancelar Alteração";
				}
				else if (dr == null)
				{
					InicializarComponentes();
				}
			}
		}

		private void txtFuncao_TextChanged(object sender, EventArgs e)
		{
			if (txtFuncao.Text != "")
			{
				dto.Funcao = txtFuncao.Text;
				bll.SelecionaFiltro(dto);
				CarregarGrid("selecionar por filtro");
			}
			else
			{
				bll.SelecionaTodosFuncoes();
				CarregarGrid("selecionar todos");
			}
		}
	}
}
