namespace SENAI_Requerimento_Padrao
{
	partial class FrmCadastrarUsuario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarUsuario));
			this.txtNomeCompleto = new System.Windows.Forms.TextBox();
			this.txtMatricula = new System.Windows.Forms.TextBox();
			this.comboFuncao = new System.Windows.Forms.ComboBox();
			this.comboSituacao = new System.Windows.Forms.ComboBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btnGravar = new System.Windows.Forms.PictureBox();
			this.GridView = new System.Windows.Forms.DataGridView();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnCadastrarFuncao = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.btnCarregarImagem = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.imgFoto = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.btnGravar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNomeCompleto
			// 
			this.txtNomeCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.txtNomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNomeCompleto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtNomeCompleto.ForeColor = System.Drawing.Color.White;
			this.txtNomeCompleto.Location = new System.Drawing.Point(181, 52);
			this.txtNomeCompleto.Name = "txtNomeCompleto";
			this.txtNomeCompleto.Size = new System.Drawing.Size(337, 29);
			this.txtNomeCompleto.TabIndex = 1;
			// 
			// txtMatricula
			// 
			this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMatricula.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtMatricula.ForeColor = System.Drawing.Color.White;
			this.txtMatricula.Location = new System.Drawing.Point(524, 52);
			this.txtMatricula.Name = "txtMatricula";
			this.txtMatricula.Size = new System.Drawing.Size(193, 29);
			this.txtMatricula.TabIndex = 2;
			// 
			// comboFuncao
			// 
			this.comboFuncao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.comboFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboFuncao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.comboFuncao.ForeColor = System.Drawing.Color.White;
			this.comboFuncao.FormattingEnabled = true;
			this.comboFuncao.Location = new System.Drawing.Point(181, 91);
			this.comboFuncao.Name = "comboFuncao";
			this.comboFuncao.Size = new System.Drawing.Size(337, 29);
			this.comboFuncao.TabIndex = 3;
			// 
			// comboSituacao
			// 
			this.comboSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.comboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboSituacao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.comboSituacao.ForeColor = System.Drawing.Color.White;
			this.comboSituacao.FormattingEnabled = true;
			this.comboSituacao.Location = new System.Drawing.Point(524, 91);
			this.comboSituacao.Name = "comboSituacao";
			this.comboSituacao.Size = new System.Drawing.Size(193, 29);
			this.comboSituacao.TabIndex = 4;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtEmail.ForeColor = System.Drawing.Color.White;
			this.txtEmail.Location = new System.Drawing.Point(181, 131);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(500, 29);
			this.txtEmail.TabIndex = 5;
			// 
			// btnGravar
			// 
			this.btnGravar.BackgroundImage = global::SENAI_Requerimento_Padrao.Properties.Resources.icone_salvar;
			this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGravar.Location = new System.Drawing.Point(687, 131);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(29, 29);
			this.btnGravar.TabIndex = 13;
			this.btnGravar.TabStop = false;
			this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
			// 
			// GridView
			// 
			this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridView.Location = new System.Drawing.Point(67, 194);
			this.GridView.Name = "GridView";
			this.GridView.RowTemplate.Height = 25;
			this.GridView.Size = new System.Drawing.Size(650, 292);
			this.GridView.TabIndex = 14;
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(644, 503);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(108, 24);
			this.btnFechar.TabIndex = 15;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnCadastrarFuncao
			// 
			this.btnCadastrarFuncao.Location = new System.Drawing.Point(379, 503);
			this.btnCadastrarFuncao.Name = "btnCadastrarFuncao";
			this.btnCadastrarFuncao.Size = new System.Drawing.Size(145, 24);
			this.btnCadastrarFuncao.TabIndex = 16;
			this.btnCadastrarFuncao.Text = "Cadastrar Funções";
			this.btnCadastrarFuncao.UseVisualStyleBackColor = true;
			this.btnCadastrarFuncao.Click += new System.EventHandler(this.btnCadastrarFuncao_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
			this.lblTitulo.Location = new System.Drawing.Point(366, 16);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(68, 23);
			this.lblTitulo.TabIndex = 17;
			this.lblTitulo.Text = "lblTitulo";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
			this.lblInfo.Location = new System.Drawing.Point(67, 169);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(522, 19);
			this.lblInfo.TabIndex = 18;
			this.lblInfo.Text = "* Clique sobre o nome para detalhar e adicionar dados de telefone, endereço e sen" +
    "ha.";
			// 
			// btnCarregarImagem
			// 
			this.btnCarregarImagem.Location = new System.Drawing.Point(86, 334);
			this.btnCarregarImagem.Name = "btnCarregarImagem";
			this.btnCarregarImagem.Size = new System.Drawing.Size(108, 24);
			this.btnCarregarImagem.TabIndex = 19;
			this.btnCarregarImagem.Text = "Carregar Imagem";
			this.btnCarregarImagem.UseVisualStyleBackColor = true;
			this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(258, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(530, 503);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(108, 24);
			this.btnLimpar.TabIndex = 21;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Location = new System.Drawing.Point(32, 495);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(720, 2);
			this.panel1.TabIndex = 24;
			// 
			// imgFoto
			// 
			this.imgFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.imgFoto.ErrorImage = null;
			this.imgFoto.Image = ((System.Drawing.Image)(resources.GetObject("imgFoto.Image")));
			this.imgFoto.InitialImage = null;
			this.imgFoto.Location = new System.Drawing.Point(67, 52);
			this.imgFoto.Name = "imgFoto";
			this.imgFoto.Size = new System.Drawing.Size(108, 108);
			this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgFoto.TabIndex = 0;
			this.imgFoto.TabStop = false;
			this.imgFoto.Click += new System.EventHandler(this.imgFoto_Click);
			// 
			// FrmCadastrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnCarregarImagem);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnCadastrarFuncao);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.GridView);
			this.Controls.Add(this.btnGravar);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.comboSituacao);
			this.Controls.Add(this.comboFuncao);
			this.Controls.Add(this.txtMatricula);
			this.Controls.Add(this.txtNomeCompleto);
			this.Controls.Add(this.imgFoto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCadastrarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCadastrarUsuario";
			this.Activated += new System.EventHandler(this.FrmCadastrarUsuario_Activated);
			this.Load += new System.EventHandler(this.FrmCadastrarUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnGravar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtNomeCompleto;
		private System.Windows.Forms.TextBox txtMatricula;
		private System.Windows.Forms.ComboBox comboFuncao;
		private System.Windows.Forms.ComboBox comboSituacao;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.PictureBox btnGravar;
		private System.Windows.Forms.DataGridView GridView;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Button btnCadastrarFuncao;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Button btnCarregarImagem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox imgFoto;
	}
}