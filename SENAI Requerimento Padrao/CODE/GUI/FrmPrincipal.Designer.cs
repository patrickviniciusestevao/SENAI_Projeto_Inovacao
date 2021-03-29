
namespace SENAI_Requerimento_Padrao
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btn_users = new System.Windows.Forms.Button();
			this.btn_itens = new System.Windows.Forms.Button();
			this.btn_clientes = new System.Windows.Forms.Button();
			this.btn_cursos = new System.Windows.Forms.Button();
			this.btn_dashboard = new System.Windows.Forms.Button();
			this.btn_nvreq = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.btnSair = new System.Windows.Forms.Button();
			this.BtnFechar = new System.Windows.Forms.Button();
			this.BtnMaximizar = new System.Windows.Forms.Button();
			this.BtnMinimizar = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panelDesktopPanel = new System.Windows.Forms.Panel();
			this.panelMenu.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(160)))));
			this.panelMenu.Controls.Add(this.btn_users);
			this.panelMenu.Controls.Add(this.btn_itens);
			this.panelMenu.Controls.Add(this.btn_clientes);
			this.panelMenu.Controls.Add(this.btn_cursos);
			this.panelMenu.Controls.Add(this.btn_dashboard);
			this.panelMenu.Controls.Add(this.btn_nvreq);
			this.panelMenu.Controls.Add(this.flowLayoutPanel1);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(160)))));
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(252, 600);
			this.panelMenu.TabIndex = 1;
			// 
			// btn_users
			// 
			this.btn_users.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_users.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_users.FlatAppearance.BorderSize = 0;
			this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_users.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_users.ForeColor = System.Drawing.Color.White;
			this.btn_users.Image = global::SENAI_Requerimento_Padrao.Properties.Resources.Usuário;
			this.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_users.Location = new System.Drawing.Point(0, 420);
			this.btn_users.Name = "btn_users";
			this.btn_users.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_users.Size = new System.Drawing.Size(252, 70);
			this.btn_users.TabIndex = 7;
			this.btn_users.Text = "  Usuários";
			this.btn_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_users.UseVisualStyleBackColor = true;
			this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
			// 
			// btn_itens
			// 
			this.btn_itens.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_itens.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_itens.FlatAppearance.BorderSize = 0;
			this.btn_itens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_itens.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_itens.ForeColor = System.Drawing.Color.White;
			this.btn_itens.Image = global::SENAI_Requerimento_Padrao.Properties.Resources.Itens_de_Requerimento;
			this.btn_itens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_itens.Location = new System.Drawing.Point(0, 350);
			this.btn_itens.Name = "btn_itens";
			this.btn_itens.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_itens.Size = new System.Drawing.Size(252, 70);
			this.btn_itens.TabIndex = 6;
			this.btn_itens.Text = "  Itens de Requerimento";
			this.btn_itens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_itens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_itens.UseVisualStyleBackColor = true;
			this.btn_itens.Click += new System.EventHandler(this.btn_itens_Click);
			// 
			// btn_clientes
			// 
			this.btn_clientes.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_clientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_clientes.FlatAppearance.BorderSize = 0;
			this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_clientes.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clientes.ForeColor = System.Drawing.Color.White;
			this.btn_clientes.Image = global::SENAI_Requerimento_Padrao.Properties.Resources.Clientes;
			this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_clientes.Location = new System.Drawing.Point(0, 280);
			this.btn_clientes.Name = "btn_clientes";
			this.btn_clientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_clientes.Size = new System.Drawing.Size(252, 70);
			this.btn_clientes.TabIndex = 5;
			this.btn_clientes.Text = "  Clientes";
			this.btn_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_clientes.UseVisualStyleBackColor = true;
			this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
			// 
			// btn_cursos
			// 
			this.btn_cursos.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_cursos.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_cursos.FlatAppearance.BorderSize = 0;
			this.btn_cursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cursos.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cursos.ForeColor = System.Drawing.Color.White;
			this.btn_cursos.Image = global::SENAI_Requerimento_Padrao.Properties.Resources.Cursos;
			this.btn_cursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cursos.Location = new System.Drawing.Point(0, 210);
			this.btn_cursos.Name = "btn_cursos";
			this.btn_cursos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_cursos.Size = new System.Drawing.Size(252, 70);
			this.btn_cursos.TabIndex = 4;
			this.btn_cursos.Text = "  Cursos";
			this.btn_cursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_cursos.UseVisualStyleBackColor = true;
			this.btn_cursos.Click += new System.EventHandler(this.btn_cursos_Click);
			// 
			// btn_dashboard
			// 
			this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_dashboard.FlatAppearance.BorderSize = 0;
			this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_dashboard.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dashboard.ForeColor = System.Drawing.Color.White;
			this.btn_dashboard.Image = global::SENAI_Requerimento_Padrao.Properties.Resources.Dashboard;
			this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_dashboard.Location = new System.Drawing.Point(0, 140);
			this.btn_dashboard.Name = "btn_dashboard";
			this.btn_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_dashboard.Size = new System.Drawing.Size(252, 70);
			this.btn_dashboard.TabIndex = 3;
			this.btn_dashboard.Text = "  Dashboard";
			this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_dashboard.UseVisualStyleBackColor = true;
			this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
			// 
			// btn_nvreq
			// 
			this.btn_nvreq.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_nvreq.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_nvreq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_nvreq.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_nvreq.ForeColor = System.Drawing.Color.White;
			this.btn_nvreq.Image = global::SENAI_Requerimento_Padrao.Properties.Resources.Novo_Requerimento;
			this.btn_nvreq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_nvreq.Location = new System.Drawing.Point(0, 70);
			this.btn_nvreq.Name = "btn_nvreq";
			this.btn_nvreq.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_nvreq.Size = new System.Drawing.Size(252, 70);
			this.btn_nvreq.TabIndex = 2;
			this.btn_nvreq.Text = "  Novo Requerimento";
			this.btn_nvreq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_nvreq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_nvreq.UseVisualStyleBackColor = true;
			this.btn_nvreq.Click += new System.EventHandler(this.btn_nvreq_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackgroundImage = global::SENAI_Requerimento_Padrao.Properties.Resources.senai_logomarca_fundo_escuro_21;
			this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(252, 70);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(160)))));
			this.panelTitle.Controls.Add(this.btnSair);
			this.panelTitle.Controls.Add(this.BtnFechar);
			this.panelTitle.Controls.Add(this.BtnMaximizar);
			this.panelTitle.Controls.Add(this.BtnMinimizar);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(252, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(948, 70);
			this.panelTitle.TabIndex = 2;
			this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktopPanel_MouseDown);
			// 
			// btnSair
			// 
			this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSair.BackColor = System.Drawing.Color.White;
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Roboto", 12F);
			this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(160)))));
			this.btnSair.Location = new System.Drawing.Point(843, 15);
			this.btnSair.Margin = new System.Windows.Forms.Padding(0);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(94, 40);
			this.btnSair.TabIndex = 12;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// BtnFechar
			// 
			this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnFechar.FlatAppearance.BorderSize = 0;
			this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnFechar.ForeColor = System.Drawing.Color.White;
			this.BtnFechar.Location = new System.Drawing.Point(1198, 0);
			this.BtnFechar.Name = "BtnFechar";
			this.BtnFechar.Size = new System.Drawing.Size(30, 30);
			this.BtnFechar.TabIndex = 3;
			this.BtnFechar.Text = "X";
			this.BtnFechar.UseVisualStyleBackColor = true;
			this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
			// 
			// BtnMaximizar
			// 
			this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMaximizar.FlatAppearance.BorderSize = 0;
			this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnMaximizar.ForeColor = System.Drawing.Color.White;
			this.BtnMaximizar.Location = new System.Drawing.Point(1164, 0);
			this.BtnMaximizar.Name = "BtnMaximizar";
			this.BtnMaximizar.Size = new System.Drawing.Size(31, 30);
			this.BtnMaximizar.TabIndex = 2;
			this.BtnMaximizar.Text = "O";
			this.BtnMaximizar.UseVisualStyleBackColor = true;
			this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
			// 
			// BtnMinimizar
			// 
			this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMinimizar.FlatAppearance.BorderSize = 0;
			this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnMinimizar.ForeColor = System.Drawing.Color.White;
			this.BtnMinimizar.Location = new System.Drawing.Point(1131, -1);
			this.BtnMinimizar.Name = "BtnMinimizar";
			this.BtnMinimizar.Size = new System.Drawing.Size(30, 30);
			this.BtnMinimizar.TabIndex = 1;
			this.BtnMinimizar.Text = "-";
			this.BtnMinimizar.UseVisualStyleBackColor = true;
			this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(56, 16);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(310, 37);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Requerimento Padrão";
			// 
			// panelDesktopPanel
			// 
			this.panelDesktopPanel.BackColor = System.Drawing.Color.White;
			this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktopPanel.Location = new System.Drawing.Point(252, 70);
			this.panelDesktopPanel.Name = "panelDesktopPanel";
			this.panelDesktopPanel.Size = new System.Drawing.Size(948, 530);
			this.panelDesktopPanel.TabIndex = 3;
			this.panelDesktopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktopPanel_MouseDown);
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1200, 600);
			this.Controls.Add(this.panelDesktopPanel);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.panelMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(1200, 600);
			this.Name = "FrmPrincipal";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Requerimento";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panelMenu.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Button btn_users;
		private System.Windows.Forms.Button btn_itens;
		private System.Windows.Forms.Button btn_clientes;
		private System.Windows.Forms.Button btn_cursos;
		private System.Windows.Forms.Button btn_dashboard;
		private System.Windows.Forms.Button btn_nvreq;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Panel panelDesktopPanel;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button BtnFechar;
		private System.Windows.Forms.Button BtnMaximizar;
		private System.Windows.Forms.Button BtnMinimizar;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnSair;
	}
}

