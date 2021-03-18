using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SENAI_Requerimento_Padrao.CODE.DTO;
using SENAI_Requerimento_Padrao.CODE.BLL;
using System.IO;
using MySql.Data.MySqlClient;

namespace SENAI_Requerimento_Padrao
{
	public partial class FrmCadastrarUsuario : Form
	{
		// Teste

		UsuarioDTO dto = new UsuarioDTO();
		UsuarioBLL bll = new UsuarioBLL();

		private string id_usuario_PK;

		public FrmCadastrarUsuario()
		{
			InitializeComponent();
		}

		private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
		{
			InicializarComponentes();
			CarregarGrid("selecionar todos");
		}

		private void InicializarComponentes()
		{
			//layout para o formulario
			var Frm = new FrmCadastrarUsuario();
			Frm.BackColor = Color.FromArgb(34, 34, 77);
			Frm.FormBorderStyle = FormBorderStyle.None;
			Frm.StartPosition = FormStartPosition.CenterScreen;
		

			//texto input (TXT)
			txtNomeCompleto.BackColor = Color.FromArgb(34, 34, 77);
			txtNomeCompleto.BorderStyle = BorderStyle.FixedSingle;
			txtNomeCompleto.ForeColor = Color.White;
			txtNomeCompleto.Font = new Font("Roboto", 12, FontStyle.Regular);

			txtMatricula.BackColor = Color.FromArgb(34, 34, 77);
			txtMatricula.BorderStyle = BorderStyle.FixedSingle;
			txtMatricula.ForeColor = Color.White;
			txtMatricula.Font = new Font("Roboto", 12, FontStyle.Regular);

			txtEmail.BackColor = Color.FromArgb(34, 34, 77);
			txtEmail.BorderStyle = BorderStyle.FixedSingle;
			txtEmail.ForeColor = Color.White;
			txtEmail.Font = new Font("Roboto", 12, FontStyle.Regular);

			comboFuncao.BackColor = Color.FromArgb(34, 34, 77);
			comboFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
			comboFuncao.FlatStyle = FlatStyle.Flat;
			comboFuncao.ForeColor = Color.White;
			comboFuncao.Font = new Font("Roboto", 12, FontStyle.Regular);

			comboSituacao.BackColor = Color.FromArgb(34, 34, 77);
			comboSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
			comboSituacao.FlatStyle = FlatStyle.Flat;
			comboSituacao.ForeColor = Color.White;
			comboSituacao.Font = new Font("Roboto", 12, FontStyle.Regular);

			//botões
			btnFechar.Text = "Fechar";

			//labels: Texto/Titulos
			lblTitulo.BackColor = Color.FromArgb(34, 34, 77);
			lblTitulo.ForeColor = Color.FromArgb(0, 175, 239);
			lblTitulo.Font = new Font("Roboto", 12, FontStyle.Italic);
			lblTitulo.TextAlign = ContentAlignment.MiddleCenter;


			lblInfo.Text = "*Clique sobre o nome para detalhar e adicionar dados de telefone, endereço e senha.";
			lblInfo.BackColor = Color.FromArgb(34, 34, 77);
			lblInfo.ForeColor = Color.FromArgb(0, 175, 239);
			lblInfo.Font = new Font("Roboto", 10, FontStyle.Italic);

			//Imagem (FOTO):
			imgFoto.ImageLocation = "E:\\IMAGES\\imgFotoUsuario.jpg";
			imgFoto.SizeMode = PictureBoxSizeMode.StretchImage;

			//combos:
			//inicializar combo funcao
			InicializarComboFuncao();

			//inicializar combo situacao
			comboSituacao.Items.Add("Ativo");
			comboSituacao.Items.Add("Inativo");
		}

		private void InicializarComboFuncao()
		{

			comboFuncao.DataSource = bll.SelecionaTodosFuncoes();
			comboFuncao.DisplayMember = "funcao";
			comboFuncao.ValueMember = "id_funcao";

			//comboFuncao.Items.Insert(0, "Selecione o Produto");
			//comboFuncao.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
		}

		private void CarregarGrid(String tipoSelecao)
		{
			if (tipoSelecao == "selecionar todos")
			{
				GridView.DataSource = bll.SelecionaTodosUsuarios();
				if (GridView.Rows.Count == 0)
				{
					lblTitulo.Text = "Nenhum Usuário Cadastrado";
					GridView.Visible = false;
				}
				else if (GridView.Rows.Count == 1)
				{
					lblTitulo.Text = "1 Usuário Cadastrado";
					GridView.Visible = true;
					//PersonalizarGrid();
				}
				else if (GridView.Rows.Count > 1)
				{
					lblTitulo.Text = GridView.Rows.Count.ToString() + " Usuários Cadastrados";
					GridView.Visible = true;
					//PersonalizarGrid();
				}
			}
			/*
			else if (tipoSelecao == "selecionar por filtro")
			{
				GridView.DataSource = bll.SelecionaFiltro(dto);
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
			*/
		}

		private void btnGravar_Click(object sender, EventArgs e)
		{
			id_usuario_PK = "0";
			MessageBox.Show(id_usuario_PK);
			
			if (txtNomeCompleto.Text != "")
			{
				dto.Nome_completo = txtNomeCompleto.Text;

				if (txtMatricula.Text != "")
				{
					dto.Matricula = txtMatricula.Text;

					if (comboFuncao.Text != "Selecione Função")
					{
						dto.Id_funcao = Int32.Parse(comboFuncao.SelectedValue.ToString());
						dto.Situacao = comboSituacao.Text;

						if (txtEmail.Text != "")
						{
							dto.Email_institucional = txtEmail.Text;

							if (id_usuario_PK == "0")
							{
								//bll.VerificarRegistroDuplicidade(dto);
								//CarregarGrid("selecionar por filtro");
								//if (gridFuncoes.Rows.Count == 0)
								//{
								bll.Inserir(dto);
								MessageBox.Show("O usuário: " + (dto.Nome_completo) + ", foi cadastrado com sucesso!", "Inserido com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
								//}
								//else
								//{
								//MessageBox.Show("A função: " + (dto.Funcao) + ", já está na base de dados e não pode ser cadastrada novamente!", "Registro já Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
								//}
							}
							else if (Int32.Parse(id_usuario_PK) > 0)
							{
								dto.Id_usuario = Int32.Parse(id_usuario_PK);
								bll.Alterar(dto);
								MessageBox.Show("O usuário foi alterado com sucesso!", "Alterado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							InicializarComponentes();
							CarregarGrid("selecionar todos");
						}
						else
						{
							MessageBox.Show("O campo email é obrigatório!");
						}
					}
					else
					{
						MessageBox.Show("A seleção de uma função é obrigatória!");
					}
				}
				else
				{
					MessageBox.Show("A matrícula é campo obrigatório!");
				}
			}
			else
			{
				MessageBox.Show("O nome é campo obrigatório!");
			}
		}

		private void btnCadastrarFuncao_Click(object sender, EventArgs e)
		{
			var Frm = new FrmCadastrarFuncao();
			Frm.ShowDialog();
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

		private void FrmCadastrarUsuario_Activated(object sender, EventArgs e)
		{
			InicializarComboFuncao();
		}

		private void imgFoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "jpg|*.jpg";
			if (file.ShowDialog() == DialogResult.OK)
			{
				imgFoto.ImageLocation = file.FileName;
				imgFoto.SizeMode = PictureBoxSizeMode.StretchImage;

				string DiretorioComNomeArquivo = file.FileName;
				string DiretorioArquivo = Path.GetDirectoryName(DiretorioComNomeArquivo);
				string NomeArquivoComExtensao = Path.GetFileName(DiretorioComNomeArquivo);
				//string NomeArquivoSemExtensao = Path.GetFileNameWithoutExtension(DiretorioComNomeArquivo);

				long tamanho = new FileInfo(DiretorioComNomeArquivo).Length;
				tamanho = tamanho / 1000;
				if (tamanho < 1100)
				{
					MessageBox.Show("imagem menor que 1MB, pode gravar");

					string fileName = NomeArquivoComExtensao;
					string sourcePath = @DiretorioArquivo;
					string targetPath = @"E:\IMAGES";

					string sourceFile = Path.Combine(sourcePath, fileName);
					string destFile = Path.Combine(targetPath, fileName);

					Directory.CreateDirectory(targetPath);

					File.Copy(sourceFile, destFile, true);
				}
				else
				{
					MessageBox.Show("A imagem deve ser menor que 1MB");
				}

				/* Para copiar todos os arquivos do diretorio
				if (Directory.Exists(sourcePath))
				{
				
				string[] files = Directory.GetFiles(sourcePath);
				foreach (string s in files)
				{
					fileName = Path.GetFileName(s);
					destFile = Path.Combine(targetPath, fileName);
					File.Copy(s, destFile, true);
				}
				
				}
				else
					{
						MessageBox.Show("Source path does not exist!");
					}

				*/
			}
		}

		private void btnCarregarImagem_Click(object sender, EventArgs e)
		{
			try
			{
				imgFoto.Image = Image.FromFile("E:\\IMAGES\\"+ txtNomeCompleto.Text);
				imgFoto.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			IDataReader dr;
			dr = bll.SelecionaTodosUsuariosDATAREADER();
			try
			{
				
				
				while (dr.Read())
				{
					Console.WriteLine(dr.GetString(1));
					MessageBox.Show(dr["nome_completo"].ToString());
					//dr["nome_da_Coluna"]
					//dr[0]
					//dr.getString(0)
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro." + ex);
			}
			finally
			{
				dr.Close();
			}

		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			InicializarComponentes();
		}
	}
}