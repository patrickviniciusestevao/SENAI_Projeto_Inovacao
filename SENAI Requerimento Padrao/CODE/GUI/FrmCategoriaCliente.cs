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
	public partial class FrmCategoriaCliente : Form
	{
		//using SENAI_Requerimento_Padrao.CODE.DTO;
		//using SENAI_Requerimento_Padrao.CODE.BLL;
		CategoriaClienteDTO dto = new CategoriaClienteDTO();
		CategoriaClienteBLL bll = new CategoriaClienteBLL();
		private int id_categoria_cliente_PK;

		public FrmCategoriaCliente()
		{
			InitializeComponent();
		}

		private void FrmCategoriaCliente_Load(object sender, EventArgs e)
		{
			InicializarComponentes();
			CarregarGrid("selecionar todos");
		}

		private void InicializarComponentes()
		{
			id_categoria_cliente_PK = 0;
			txtCategoriaCliente.Clear();
			btnFechar.Text = "Fechar";
			txtCategoriaCliente.Focus();
			GridView.Visible = false;
		}

		private void CarregarGrid(String tipoSelecao)
		{
			if (GridView.Rows.Count > 0)
			{
				GridView.Columns.Remove("editar");
				GridView.Columns.Remove("excluir");
			}

			if (tipoSelecao == "selecionar todos")
			{
				GridView.DataSource = bll.SelecionarTodos();
				//tratamento do título com a quantidade cadastradas
				if (GridView.Rows.Count == 0)
				{
					lblTitulo.Text = "Nenhuma Categoria Cadastrada";
					GridView.Visible = false;
				}
				else if (GridView.Rows.Count == 1)
				{
					lblTitulo.Text = "1 Categoria Cadastrada";
					GridView.Visible = true;
					PersonalizarGrid();
				}
				else if (GridView.Rows.Count > 1)
				{
					lblTitulo.Text = GridView.Rows.Count.ToString() + " Categorias Cadastradas";
					GridView.Visible = true;
					PersonalizarGrid();
				}
			}
			/*
			else if (tipoSelecao == "selecionar por filtro")
			{
				GridView.DataSource = bll.SelecionarComCondicao(dto);
				//tratamento do título com a quantidade cadastradas
				if (GridView.Rows.Count == 0)
				{
					lblTitulo.Text = "Nenhuma Função Localizada";
					GridView.Visible = false;
				}
				else if (GridView.Rows.Count == 1)
				{
					lblTitulo.Text = "1 Função Localizada";
					GridView.Visible = true;
					PersonalizarGrid();
				}
				else if (GridView.Rows.Count > 1)
				{
					lblTitulo.Text = GridView.Rows.Count.ToString() + " Funções Localizadas";
					GridView.Visible = true;
					PersonalizarGrid();
				}
			}
			*/

		}

		private void PersonalizarGrid()
		{
			//Color.FromArgb(73, 174, 200); Azul Claro
			//Color.FromArgb(0, 92, 160); Azul Royal

			//Obtém ou define o estilo de célula padrão aplicado a linhas ímpares do DataGridView.
			GridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
			GridView.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 12);
			GridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(73, 174, 200);
			GridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(73, 174, 200);
			GridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

			//BackgroundColor (cor do fundo do grid)
			GridView.BackgroundColor = Color.White;

			//BorderStyle (estilo da borda externa do grid)
			GridView.BorderStyle = BorderStyle.None;

			//CellBorderStyle (borda das celulas)
			GridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

			//ColumnHeadersBorderStyle (Estilo da borda do cabecalho)
			GridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

			//btém ou define o estilo do cabeçalho de coluna padrão.
			GridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 174, 200);
			GridView.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 14, FontStyle.Bold);
			GridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			GridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(73, 174, 200);
			GridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
			GridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			//ColumnHeadersHeightSizeMode (Habilita a possibilidade de alterar a altura da linha do cabecalho) 
			GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			//ColumnHeadersHeight (Altua da linha do cabecalho) 
			GridView.ColumnHeadersHeight = 30;
			//ColumnHeadersHeightSizeMode (Desabilita a possibilidade de alterar a altura da linha do cabecalho) 
			GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

			//ColumnHeadersVisible (Exibe a linha do cabeçalho)
			GridView.ColumnHeadersVisible = true;

			//Tipo do cursor
			GridView.Cursor = default;

			//Obtém ou define o estilo de célula padrão a ser aplicado às células no DataGridView
			//se nenhuma outra propriedade de estilo de célula for definida.
			GridView.DefaultCellStyle.BackColor = Color.White;
			GridView.DefaultCellStyle.Font = new Font("Roboto", 12);
			GridView.DefaultCellStyle.ForeColor = Color.FromArgb(73, 174, 200);
			GridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(73, 174, 200);
			GridView.DefaultCellStyle.SelectionForeColor = Color.White;

			// FALSE para valer as config via codigo, TRUE para valer as config via componente
			GridView.EnableHeadersVisualStyles = false;

			//Obtém ou define a cor das linhas de grade que separam as células do DataGridView.
			GridView.GridColor = Color.FromArgb(73, 174, 200);

			//Obtém ou define um valor que indica se os elementos do controle estão alinhados
			//para dar suporte a localidades que usam fontes da direita para a esquerda.
			GridView.RightToLeft = RightToLeft.No;

			//Obtém ou define o estilo de borda das células de cabeçalho da linha.
			GridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

			//Obtém ou define o estilo padrão aplicado às células de cabeçalho de linha.
			GridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 174, 200);
			GridView.RowHeadersDefaultCellStyle.Font = new Font("Roboto", 12);
			GridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
			GridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(73, 174, 200);
			GridView.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;

			//Obtém ou define um valor que indica se a coluna que contém os cabeçalhos de linha é exibida.
			//Ocultando controle de linha (primeira coluna de selecao de linha SETINHA)
			GridView.RowHeadersVisible = false;

			//Obtém ou define o estilo padrão aplicado às células de linha do DataGridView.
			GridView.RowsDefaultCellStyle.BackColor = Color.White;
			GridView.RowsDefaultCellStyle.Font = new Font("Roboto", 12);
			GridView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(73, 174, 200);
			GridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(73, 174, 200);
			GridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;

			//RowTemplate: Obtém ou define a linha que representa o modelo de todas as linhas no controle.
			//Obtém ou define o menu de atalho da linha.
			GridView.RowTemplate.ContextMenuStrip = null;
			//Obtém ou define a linha que representa o modelo de todas as linhas no controle.
			GridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
			GridView.RowTemplate.DefaultCellStyle.Font = new Font("Roboto", 12);
			GridView.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(73, 174, 200);
			//Este SELECTION é reponsavel por iniciar a selecao da primeira linha do grid selecionada
			GridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
			GridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(73, 174, 200);
			//Obtém ou define a altura, em pixels, do divisor de linhas.
			GridView.RowTemplate.DividerHeight = 0;
			//Obtém ou define texto de erro
			GridView.RowTemplate.ErrorText = "";
			//Obtém ou define altura
			GridView.RowTemplate.Height = 35;
			//Somente leitura
			GridView.RowTemplate.ReadOnly = true;
			//Se pode ou nao redimensionar (manualmente)
			GridView.RowTemplate.Resizable = 0;

			GridView.ShowCellErrors = true;
			GridView.ShowCellToolTips = true;
			GridView.ShowEditingIcon = true;
			GridView.ShowRowErrors = true;

			//Trocar curso para curso de espera enquanto estiver processando
			GridView.UseWaitCursor = false;

			// ABA COMPORTAMENTO (Tirando previlégios de alteração do usuário com o FALSE)
			GridView.AllowDrop = false;
			GridView.AllowUserToAddRows = false;
			GridView.AllowUserToDeleteRows = false;
			GridView.AllowUserToOrderColumns = false;
			GridView.AllowUserToResizeColumns = false;
			GridView.AllowUserToResizeRows = false;
			GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			GridView.ContextMenuStrip = null;
			GridView.Enabled = true;
			//Desabilitando a possibilidade de selecionar varias linhas
			GridView.MultiSelect = false;
			GridView.ReadOnly = true;
			GridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			//Modo de Seleção da Linha (Selecionar toda a linha independente de qual celula for selecionada)
			GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



			// ABA DIVERSOS (COLUMNS -> Coleção)

			//Exemplo Adicionando um combobox com valores
			//DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
			//comboBoxColumn.Items.AddRange(Color.Red, Color.Yellow, Color.Green, Color.Blue);
			//comboBoxColumn.ValueType = typeof(Color);
			//GridView.Columns.Add(comboBoxColumn);
			//GridView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);

			//DataGridViewImageColumn.Image
			//Obtém ou define a imagem exibida nas células desta coluna quando a propriedade Value da célula não
			//está definida e a propriedade ValueIsIcon da célula está definida como false.
			DataGridViewImageColumn imageColumnEditar = new DataGridViewImageColumn();
			imageColumnEditar.Image = Image.FromFile(@"..\\..\\Resources\\img_btn_editar.png");
			GridView.Columns.Add(imageColumnEditar);
			//GridView.Columns[""].HeaderText = "Editar";
			GridView.Columns[""].Name = "editar";

			DataGridViewImageColumn imageColumnExcluir = new DataGridViewImageColumn();
			imageColumnExcluir.Image = Image.FromFile(@"..\\..\\Resources\\img_btn_excluir.png");
			GridView.Columns.Add(imageColumnExcluir);
			//GridView.Columns[""].HeaderText = "Editar";
			GridView.Columns[""].Name = "excluir";

			// LAYOUT
			GridView.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);

			//Margem externa para a tabela
			GridView.Margin = new Padding(0, 15, 0, 15);

			//GridView.Location = new Point(27, 97);

			//customiza a posicao das colunas no grid;
			GridView.Columns["editar"].DisplayIndex = 0;
			GridView.Columns["excluir"].DisplayIndex = 1;
			GridView.Columns["id_categoria_cliente"].DisplayIndex = 2;
			GridView.Columns["categoria_cliente"].DisplayIndex = 3;

			//alinhando e alteração dos nomes exibidos no cabecalho do gridview
			GridView.Columns["id_categoria_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			GridView.Columns["categoria_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			GridView.Columns["editar"].HeaderText = "";
			GridView.Columns["excluir"].HeaderText = "";
			GridView.Columns["id_categoria_cliente"].HeaderText = "Código";
			GridView.Columns["categoria_cliente"].HeaderText = "Categoria do Cliente";

			//Dimensionando a largura das colunas
			//0 = editar //1= excluir
			GridView.Columns["editar"].Width = (int)(GridView.Width * 0.05);
			GridView.Columns["excluir"].Width = (int)(GridView.Width * 0.05);
			//2 = id funcao //3 = funcao // 4 = nivel permissao
			GridView.Columns["id_categoria_cliente"].Width = (int)(GridView.Width * 0.3);
			GridView.Columns["categoria_cliente"].Width = (int)(GridView.Width * 0.6);
			GridView.Columns["categoria_cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			MostrarGrid();
		}

		private void MostrarGrid()
		{
			GridView.Visible = true;
		}

		private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (GridView.Columns["editar"].Index == e.ColumnIndex)
			{
				EditarGridView();
			}
			else if (GridView.Columns["excluir"].Index == e.ColumnIndex)
			{
				ExcluirGridView();
			}
		}
		
		private void EditarGridView()
		{
			int indiceselecionado = -1;
			// Se o usuário selecionou a Linha
			if (GridView.SelectedRows.Count > 0)
			{
				indiceselecionado = GridView.SelectedRows[0].Index;
			}
			else
			{ // Se o usuário selecionou a célula
				if (GridView.SelectedCells.Count > 0)
				{
					indiceselecionado = GridView.SelectedCells[0].RowIndex;
				}
			}

			if (indiceselecionado != -1)
			{
				DataRowView dr = (DataRowView)GridView.Rows[indiceselecionado].DataBoundItem;
				if (dr != null)
				{
					try
					{
						id_categoria_cliente_PK = Int32.Parse(dr["id_categoria_cliente"].ToString());
						txtCategoriaCliente.Text = dr["categoria_cliente"].ToString();
						btnFechar.Text = "Cancelar Alteração";
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex);
					}
				}
				else if (dr == null)
				{
					InicializarComponentes();
				}
			}
		}
		
		private void ExcluirGridView()
		{
			int indiceselecionado = -1;
			// Se o usuário selecionou a Linha
			if (GridView.SelectedRows.Count > 0)
			{
				indiceselecionado = GridView.SelectedRows[0].Index;
			}
			else
			{ // Se o usuário selecionou a célula
				if (GridView.SelectedCells.Count > 0)
				{
					indiceselecionado = GridView.SelectedCells[0].RowIndex;
				}
			}
			if (indiceselecionado != -1)
			{
				DataRowView dr = (DataRowView)GridView.Rows[indiceselecionado].DataBoundItem;
				if (dr != null)
				{
					dto.IdCategoriaCliente = Int32.Parse(dr["id_categoria_cliente"].ToString());
					//MessageBox.Show(dto.IdCategoriaCliente.ToString());
					var result = MessageBox.Show("Deseja realmente excluir este registro?", "EXCLUSÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (result == System.Windows.Forms.DialogResult.Yes)
					{
						RetornoDTO resposta = bll.Excluir(dto);
						if (resposta.codigo == 0) //caso retorne 1 entao foi executado a exclusao com sucesso!
						{
							resposta.mensagem = "Resgistro excluído com sucesso!";
							MessageBox.Show(resposta.mensagem);
							InicializarComponentes();
							CarregarGrid("selecionar todos");
						}
						else
						{
							MessageBox.Show("Não foi possível excluir o registro, " +
								"verifique com a equipe de TI! - Erro: " + resposta.mensagem, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
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

		private void btnGravar_Click(object sender, EventArgs e)
		{
			if (txtCategoriaCliente.Text != "")
			{
				dto.CategoriaCliente = txtCategoriaCliente.Text;
				if (id_categoria_cliente_PK == 0)
				{
					RetornoDTO resposta = bll.Inserir(dto);
					if (resposta.codigo == 0) //Resposta de sucesso ao gravar vindo da BLL -- forma de tratar a resposta
					{
						MessageBox.Show("Registro inserido com sucesso!"); //Resposta de sucesso ao gravar vindo da BLL - forma de tratar a resposta
						InicializarComponentes();
						CarregarGrid("selecionar todos");
					}
					else
					{
						MessageBox.Show("Não foi possível gravar o registro," +
							"verifique com a equipe de TI! - Erro: " + resposta.mensagem, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else if (id_categoria_cliente_PK > 0)
				{
					dto.IdCategoriaCliente = id_categoria_cliente_PK;
					RetornoDTO resposta = bll.Alterar(dto);
					if (resposta.codigo == 0) //Resposta de sucesso ao gravar vindo da BLL -- forma de tratar a resposta
					{
						MessageBox.Show("Registro alterado com sucesso!");
						InicializarComponentes();
						CarregarGrid("selecionar todos");
					}
					else
					{
						MessageBox.Show("Não foi possível alterar o registro," +
							"verifique com a equipe de TI! - Erro: " + resposta.mensagem, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			else
			{
				MessageBox.Show("A função é campo obrigatório!");
			}
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

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			InicializarComponentes();
			MostrarGrid();
		}

		private void FrmCategoriaCliente_FormClosed(object sender, FormClosedEventArgs e)
		{
			// acessar o carregamento do combobox categoria cliente no form pai
		}
	}
}