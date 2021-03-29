using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //para manipulação de arquivos
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.BLL;
using System.Reflection;

namespace SENAI_Requerimento_Padrao
{
	public partial class FrmClientes : Form
	{
		//using SENAI_Requerimento_Padrao.CODE.DTO;
		//using SENAI_Requerimento_Padrao.CODE.BLL;
		ClienteDTO dto = new ClienteDTO();
		ClienteBLL bll = new ClienteBLL();
		CategoriaClienteDTO dtoCategoriaClienteBLL = new CategoriaClienteDTO();
		CategoriaClienteBLL bllCategoriaClienteBLL = new CategoriaClienteBLL();
		private int id_cliente_PK;
		private string url_foto;
		private string DiretorioArquivo;
		private string NomeArquivoComExtensao;
		private string fileName;
		private string sourcePath;
		private string targetPath;
		private string sourceFile;
		private string destFile;

		public FrmClientes()
		{
			InitializeComponent();
		}

		private void FrmClientes_Load(object sender, EventArgs e)
		{
			InicializarComponentes();
			CarregarGrid("selecionar todos");
		}

		private void InicializarComponentes()
		{
			id_cliente_PK = 0;
			LimparImagem();
			txtNomeCompleto.Focus();
			txtNomeCompleto.Clear();
			txtNomeSocial.Clear();
			txtMatricula.Clear();
			txtCPF.Clear();
			txtRG.Clear();
			txtOrgaoEmissor.Clear();
			txtEmail.Clear();

			comboSituacao.SelectedIndex = 0;
			InicializarComboCategoriaCliente();

			btnFechar.Text = "Fechar";
			GridView.Visible = false;
		}
		
		private void LimparImagem()
		{
			var diretorio_atual = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			var diretorio_imagem = diretorio_atual.Substring(0, diretorio_atual.Length - 24) + "\\Resources\\img_foto.png";

			imgCliente.Image = Image.FromFile(@diretorio_imagem);
			imgCliente.SizeMode = PictureBoxSizeMode.StretchImage;
			url_foto = "";
		}

		private void InicializarComboCategoriaCliente() {
			comboCategoriaCliente.DataSource = null;
			SelecionarRetornoDTO resposta = bllCategoriaClienteBLL.SelecionarTodos();
			comboCategoriaCliente.DataSource = resposta.tabela;

			comboCategoriaCliente.DisplayMember = "categoria_cliente";
			comboCategoriaCliente.ValueMember = "id_categoria_cliente";
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
				SelecionarRetornoDTO resposta = bll.SelecionarComCategoria();

				GridView.DataSource = resposta.tabela;

				PersonalizarGrid();
				//tratamento do título com a quantidade cadastradas
				if (GridView.Rows.Count == 0)
				{
					lblTitulo.Text = "Nenhum Cliente Cadastrado";
					GridView.Visible = false;
				}
				else if (GridView.Rows.Count == 1)
				{
					lblTitulo.Text = "1 Cliente Cadastrado";
					GridView.Visible = true;
				}
				else if (GridView.Rows.Count > 1)
				{
					lblTitulo.Text = GridView.Rows.Count.ToString() + " Clientes Cadastrados";
					GridView.Visible = true;
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
			GridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(73, 174, 200); ;
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


			// LAYOUT
			GridView.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);

			//Margem externa para a tabela
			GridView.Margin = new Padding(0, 15, 0, 15);

			//GridView.Location = new Point(25, 295);

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

			var diretorio_atual = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			var diretorio_imagem = diretorio_atual.Substring(0, diretorio_atual.Length - 24) + "\\Resources\\img_btn_editar.png";

			imageColumnEditar.Image = Image.FromFile(@diretorio_imagem);
			GridView.Columns.Add(imageColumnEditar);
			//GridView.Columns[""].HeaderText = "Editar";
			GridView.Columns[""].Name = "editar";

			diretorio_imagem = diretorio_atual.Substring(0, diretorio_atual.Length - 24) + "\\Resources\\img_btn_editar.png";

			DataGridViewImageColumn imageColumnExcluir = new DataGridViewImageColumn();
			imageColumnExcluir.Image = Image.FromFile(@diretorio_imagem);
			GridView.Columns.Add(imageColumnExcluir);
			//GridView.Columns[""].HeaderText = "Editar";
			GridView.Columns[""].Name = "excluir";

			//Ocultar colunas no controle DataGridView do Windows Forms
			GridView.Columns["id_categoria_cliente"].Visible = false;
			GridView.Columns["id_categoria_cliente1"].Visible = false;
			GridView.Columns["nome_social"].Visible = false;
			GridView.Columns["cpf"].Visible = false;
			GridView.Columns["rg"].Visible = false;
			GridView.Columns["orgao_emissor"].Visible = false;
			GridView.Columns["url_foto_usuario"].Visible = false;
			GridView.Columns["situacao"].Visible = false;

			//customiza a posicao das colunas no grid;
			GridView.Columns["editar"].DisplayIndex = 0;
			GridView.Columns["excluir"].DisplayIndex = 1;
			GridView.Columns["id_cliente"].DisplayIndex = 2;
			GridView.Columns["nome_completo"].DisplayIndex = 3;
			GridView.Columns["matricula"].DisplayIndex = 4;
			GridView.Columns["categoria_cliente"].DisplayIndex = 5;
			GridView.Columns["email"].DisplayIndex = 6;
			/*
			GridView.Columns["cpf"].DisplayIndex = 8;
			GridView.Columns["rg"].DisplayIndex = 9;
			GridView.Columns["orgao_emissor"].DisplayIndex = 10;
			GridView.Columns["url_foto_usuario"].DisplayIndex = 11;
			GridView.Columns["situacao"].DisplayIndex = 12;
			*/

			//alinhando e alteração dos nomes exibidos no cabecalho do gridview
			GridView.Columns["editar"].HeaderText = "";
			GridView.Columns["excluir"].HeaderText = "";

			//Centralizando a fonte titulo do cabecalho
			GridView.Columns["id_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			GridView.Columns["categoria_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			GridView.Columns["matricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			GridView.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			GridView.Columns["id_cliente"].HeaderText = "Código";
			GridView.Columns["categoria_cliente"].HeaderText = "Categoria";
			GridView.Columns["url_foto_usuario"].HeaderText = "Foto";
			GridView.Columns["nome_completo"].HeaderText = "Nome Completo";
			GridView.Columns["matricula"].HeaderText = "Matrícula";
			GridView.Columns["nome_social"].HeaderText = "Nome Social";
			GridView.Columns["cpf"].HeaderText = "CPF";
			GridView.Columns["rg"].HeaderText = "RG";
			GridView.Columns["orgao_emissor"].HeaderText = "Orgão Emissor";
			GridView.Columns["email"].HeaderText = "e-mail";
			GridView.Columns["situacao"].HeaderText = "Situação";

			//Dimensionando a largura das colunas
			//0 = editar //1= excluir
			GridView.Columns["editar"].Width = (int)(GridView.Width * 0.02);
			GridView.Columns["excluir"].Width = (int)(GridView.Width * 0.02);

			GridView.Columns["id_cliente"].Width = (int)(GridView.Width * 0.06);
			GridView.Columns["nome_completo"].Width = (int)(GridView.Width * 0.25);
			GridView.Columns["matricula"].Width = (int)(GridView.Width * 0.15);
			GridView.Columns["categoria_cliente"].Width = (int)(GridView.Width * 0.15);
			GridView.Columns["email"].Width = (int)(GridView.Width * 0.25);
			GridView.Columns["nome_completo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			/*
			GridView.Columns["nome_social"].Width = (int)(GridView.Width * 0);
			GridView.Columns["cpf"].Width = (int)(GridView.Width * 0.3);
			GridView.Columns["rg"].Width = (int)(GridView.Width * 0.6);
			GridView.Columns["orgao_emissor"].Width = (int)(GridView.Width * 0.3);
			GridView.Columns["url_foto_usuario"].Width = (int)(GridView.Width * 0.3);
			GridView.Columns["situacao"].Width = (int)(GridView.Width * 0.6);
			*/
			//	GridView.Columns["url_foto_usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
						id_cliente_PK = Int32.Parse(dr["id_cliente"].ToString());
						LimparImagem();
						url_foto = dr["url_foto_usuario"].ToString();
						txtNomeCompleto.Text = dr["nome_completo"].ToString();
						txtNomeSocial.Text = dr["nome_social"].ToString();
						txtMatricula.Text = dr["matricula"].ToString();
						txtCPF.Text = dr["cpf"].ToString();
						txtRG.Text = dr["rg"].ToString();
						txtOrgaoEmissor.Text = dr["orgao_emissor"].ToString();
						txtEmail.Text = dr["email"].ToString();
						comboCategoriaCliente.Text = dr["categoria_cliente"].ToString();
						comboSituacao.Text = dr["situacao"].ToString();
						btnFechar.Text = "Cancelar Alteração";
						//Tratamento para carregar a foto caso exista ou nao a imagem
						if (File.Exists(url_foto) == true)
						{
							imgCliente.Image = Image.FromFile(url_foto);
							imgCliente.SizeMode = PictureBoxSizeMode.StretchImage;
						}
						else
						{
							LimparImagem();
						}
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
					dto.IdCliente = Int32.Parse(dr["id_cliente"].ToString());
					var result = MessageBox.Show("Deseja realmente excluir este registro?", "EXCLUSÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (result == System.Windows.Forms.DialogResult.Yes)
					{
						RetornoDTO resposta = bll.Excluir(dto);
						if (resposta.codigo == 0) //caso retorne 1 entao foi executado a exclusao com sucesso!
						{
							MessageBox.Show("Resgistro excluído com sucesso!");
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
						MostrarGrid();
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
			if ((txtNomeCompleto.Text != "") && (txtCPF.Text != "") && (txtRG.Text != ""))
			{
				dto.Cpf = txtCPF.Text;
				dto.Email = txtEmail.Text;
				dto.IdCategoria = Int32.Parse(comboCategoriaCliente.SelectedValue.ToString());
				dto.Url = url_foto;
				dto.Matricula = txtMatricula.Text;
				dto.NomeCompleto = txtNomeCompleto.Text;
				dto.NomeSocial = txtNomeSocial.Text;
				dto.OrgaoEmissor = txtOrgaoEmissor.Text;
				dto.Rg = txtRG.Text;
				dto.Situacao = comboSituacao.Text;

				if (id_cliente_PK == 0)
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
				else if (id_cliente_PK > 0)
				{
					dto.IdCliente = id_cliente_PK;
					RetornoDTO resposta = bll.Alterar(dto);
					if (resposta.codigo == 0) //Resposta de sucesso ao gravar vindo da BLL -- forma de tratar a resposta
					{
						MessageBox.Show("Registro inserido com sucesso!");
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
				MessageBox.Show("Preencha todos os campos obrigatórios!");
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
				MostrarGrid();
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			InicializarComponentes();
			MostrarGrid();
		}

		private void btnCadastrarCategoria_Click(object sender, EventArgs e)
		{
			//	var FrmLigthBox = new FrmLigthBox();
			//	FrmLigthBox.Show();
			var Frm = new FrmCategoriaCliente();
			Frm.ShowDialog();
		}

		private void imgCliente_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "jpg|*.jpg|png|*.png";
			if (file.ShowDialog() == DialogResult.OK)
			{
				//imgFoto.ImageLocation = file.FileName;
				imgCliente.SizeMode = PictureBoxSizeMode.StretchImage;

				string DiretorioComNomeArquivo = file.FileName;
				DiretorioArquivo = Path.GetDirectoryName(DiretorioComNomeArquivo);
				NomeArquivoComExtensao = Path.GetFileName(DiretorioComNomeArquivo);
				//string NomeArquivoSemExtensao = Path.GetFileNameWithoutExtension(DiretorioComNomeArquivo);

				long tamanho = new FileInfo(DiretorioComNomeArquivo).Length;
				tamanho = tamanho / 1000;
				if (tamanho < 2200)
				{
					fileName = NomeArquivoComExtensao;
					sourcePath = @DiretorioArquivo;
					targetPath = @"E:\IMAGES";
					sourceFile = Path.Combine(sourcePath, fileName);
					destFile = Path.Combine(targetPath, fileName);
					url_foto = sourceFile;
					imgCliente.Image = Image.FromFile(url_foto);
					imgCliente.SizeMode = PictureBoxSizeMode.StretchImage;
				}
				else
				{
					MessageBox.Show("A imagem deve ser menor que 2MB");
				}
			}
		}

		private void TransferirImagemFoto()
		{
			File.Copy(sourceFile, destFile, true);
		}

		private void lblLimparFoto_Click(object sender, EventArgs e)
		{
			LimparImagem();
		}
	}
}