using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SENAI_Requerimento_Padrao
{
    public partial class FrmPrincipal : Form
    {
		private Button currentButton;
        private Form activeForm;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(0, 74, 160);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 92, 160);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btn_nvreq_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNovoRequerimento(), sender);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDashboard(), sender);
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCursos(), sender);
        }



        private void btn_clientes_Click(object sender, EventArgs e)
        {
           // FrmLigthBox loadingWindow = new FrmLigthBox();
           // try
         //   {
                //loadingWindow.Show();
                OpenChildForm(new FrmClientes(), sender);
               // loadingWindow.Close();
         //   }
         //   catch (Exception ex)
         //   {
         //       MessageBox.Show("Exception EXPORT: " + ex.Message);
         //   }
        }

        private void btn_itens_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormItensRequerimento(), sender);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUsuarios(), sender);
        }

        private void panelDesktopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

		private void btnSair_Click(object sender, EventArgs e)
		{
            Close();
		}
	}
}
