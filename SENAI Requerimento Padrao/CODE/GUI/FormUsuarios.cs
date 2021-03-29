using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENAI_Requerimento_Padrao
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

		private void FormUsuarios_Load(object sender, EventArgs e)
		{
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 92, 160);
		}
	}
}
