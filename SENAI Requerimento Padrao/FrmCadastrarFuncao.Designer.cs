
namespace SENAI_Requerimento_Padrao
{
	partial class FrmCadastrarFuncao
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnFechar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtFuncao = new System.Windows.Forms.TextBox();
			this.lblTituloFuncoes = new System.Windows.Forms.Label();
			this.comboNivelPermissao = new System.Windows.Forms.ComboBox();
			this.btnGravar = new System.Windows.Forms.PictureBox();
			this.gridFuncoes = new System.Windows.Forms.DataGridView();
			this.editar = new System.Windows.Forms.DataGridViewImageColumn();
			this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.btnGravar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFuncoes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnFechar.Location = new System.Drawing.Point(390, 350);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(170, 30);
			this.btnFechar.TabIndex = 0;
			this.btnFechar.Text = "&Fechar";
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Location = new System.Drawing.Point(40, 325);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(520, 2);
			this.panel1.TabIndex = 1;
			// 
			// txtFuncao
			// 
			this.txtFuncao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.txtFuncao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFuncao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtFuncao.ForeColor = System.Drawing.Color.White;
			this.txtFuncao.Location = new System.Drawing.Point(75, 75);
			this.txtFuncao.Name = "txtFuncao";
			this.txtFuncao.Size = new System.Drawing.Size(250, 29);
			this.txtFuncao.TabIndex = 2;
			this.txtFuncao.TextChanged += new System.EventHandler(this.txtFuncao_TextChanged);
			// 
			// lblTituloFuncoes
			// 
			this.lblTituloFuncoes.AutoSize = true;
			this.lblTituloFuncoes.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lblTituloFuncoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
			this.lblTituloFuncoes.Location = new System.Drawing.Point(217, 34);
			this.lblTituloFuncoes.Name = "lblTituloFuncoes";
			this.lblTituloFuncoes.Size = new System.Drawing.Size(167, 23);
			this.lblTituloFuncoes.TabIndex = 3;
			this.lblTituloFuncoes.Text = "Funções Cadastradas";
			this.lblTituloFuncoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboNivelPermissao
			// 
			this.comboNivelPermissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.comboNivelPermissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboNivelPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboNivelPermissao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.comboNivelPermissao.ForeColor = System.Drawing.Color.White;
			this.comboNivelPermissao.FormattingEnabled = true;
			this.comboNivelPermissao.Items.AddRange(new object[] {
            "Selecione Nível",
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.comboNivelPermissao.Location = new System.Drawing.Point(333, 75);
			this.comboNivelPermissao.Name = "comboNivelPermissao";
			this.comboNivelPermissao.Size = new System.Drawing.Size(155, 29);
			this.comboNivelPermissao.TabIndex = 11;
			// 
			// btnGravar
			// 
			this.btnGravar.BackgroundImage = global::SENAI_Requerimento_Padrao.Properties.Resources.icone_salvar;
			this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGravar.Location = new System.Drawing.Point(495, 74);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(30, 30);
			this.btnGravar.TabIndex = 12;
			this.btnGravar.TabStop = false;
			this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
			// 
			// gridFuncoes
			// 
			this.gridFuncoes.AllowUserToAddRows = false;
			this.gridFuncoes.AllowUserToDeleteRows = false;
			this.gridFuncoes.AllowUserToResizeColumns = false;
			this.gridFuncoes.AllowUserToResizeRows = false;
			this.gridFuncoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.gridFuncoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridFuncoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gridFuncoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFuncoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.excluir});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridFuncoes.DefaultCellStyle = dataGridViewCellStyle1;
			this.gridFuncoes.Location = new System.Drawing.Point(75, 115);
			this.gridFuncoes.MultiSelect = false;
			this.gridFuncoes.Name = "gridFuncoes";
			this.gridFuncoes.ReadOnly = true;
			this.gridFuncoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gridFuncoes.RowHeadersVisible = false;
			this.gridFuncoes.RowTemplate.Height = 25;
			this.gridFuncoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.gridFuncoes.Size = new System.Drawing.Size(450, 200);
			this.gridFuncoes.TabIndex = 13;
			this.gridFuncoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFuncoes_CellContentClick);
			// 
			// editar
			// 
			this.editar.HeaderText = "Editar";
			this.editar.Image = global::SENAI_Requerimento_Padrao.Properties.Resources.icone_salvar;
			this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.editar.Name = "editar";
			this.editar.ReadOnly = true;
			this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.editar.Width = 30;
			// 
			// excluir
			// 
			this.excluir.HeaderText = "Excluir";
			this.excluir.Image = global::SENAI_Requerimento_Padrao.Properties.Resources.icone_salvar;
			this.excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.excluir.Name = "excluir";
			this.excluir.ReadOnly = true;
			this.excluir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// FrmCadastrarFuncao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.gridFuncoes);
			this.Controls.Add(this.btnGravar);
			this.Controls.Add(this.comboNivelPermissao);
			this.Controls.Add(this.lblTituloFuncoes);
			this.Controls.Add(this.txtFuncao);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnFechar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCadastrarFuncao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FrmCadastroFuncao_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnGravar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFuncoes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtFuncao;
		private System.Windows.Forms.Label lblTituloFuncoes;
		private System.Windows.Forms.ComboBox comboNivelPermissao;
		private System.Windows.Forms.PictureBox btnGravar;
		private System.Windows.Forms.DataGridView gridFuncoes;
		private System.Windows.Forms.DataGridViewImageColumn editar;
		private System.Windows.Forms.DataGridViewImageColumn excluir;
	}
}

