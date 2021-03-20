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
            this.txtNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.txtNomeCompleto.Location = new System.Drawing.Point(237, 92);
            this.txtNomeCompleto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(440, 30);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.ForeColor = System.Drawing.Color.White;
            this.txtMatricula.Location = new System.Drawing.Point(685, 92);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(251, 30);
            this.txtMatricula.TabIndex = 2;
            // 
            // comboFuncao
            // 
            this.comboFuncao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.comboFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboFuncao.ForeColor = System.Drawing.Color.White;
            this.comboFuncao.FormattingEnabled = true;
            this.comboFuncao.Location = new System.Drawing.Point(237, 161);
            this.comboFuncao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboFuncao.Name = "comboFuncao";
            this.comboFuncao.Size = new System.Drawing.Size(439, 33);
            this.comboFuncao.TabIndex = 3;
            // 
            // comboSituacao
            // 
            this.comboSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.comboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboSituacao.ForeColor = System.Drawing.Color.White;
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Location = new System.Drawing.Point(685, 161);
            this.comboSituacao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(251, 33);
            this.comboSituacao.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(237, 233);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(652, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Location = new System.Drawing.Point(897, 233);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(38, 52);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.TabStop = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(88, 345);
            this.GridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 25;
            this.GridView.Size = new System.Drawing.Size(849, 519);
            this.GridView.TabIndex = 14;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(841, 895);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(141, 43);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCadastrarFuncao
            // 
            this.btnCadastrarFuncao.Location = new System.Drawing.Point(495, 895);
            this.btnCadastrarFuncao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCadastrarFuncao.Name = "btnCadastrarFuncao";
            this.btnCadastrarFuncao.Size = new System.Drawing.Size(190, 43);
            this.btnCadastrarFuncao.TabIndex = 16;
            this.btnCadastrarFuncao.Text = "Cadastrar Funções";
            this.btnCadastrarFuncao.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncao.Click += new System.EventHandler(this.btnCadastrarFuncao_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.lblTitulo.Location = new System.Drawing.Point(478, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 26);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "lblTitulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.lblInfo.Location = new System.Drawing.Point(88, 300);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(647, 20);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "* Clique sobre o nome para detalhar e adicionar dados de telefone, endereço e sen" +
    "ha.";
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(98, 445);
            this.btnCarregarImagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(123, 32);
            this.btnCarregarImagem.TabIndex = 19;
            this.btnCarregarImagem.Text = "Carregar Imagem";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(606, 671);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 32);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(37, 660);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 3);
            this.panel1.TabIndex = 24;
            // 
            // imgFoto
            // 
            this.imgFoto.Location = new System.Drawing.Point(77, 69);
            this.imgFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(123, 144);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 25;
            this.imgFoto.TabStop = false;
            // 
            // FrmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1050, 967);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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