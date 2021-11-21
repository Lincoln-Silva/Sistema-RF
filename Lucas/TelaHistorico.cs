using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucas
{
    public partial class TelaHistorico : Form
    {
        public TelaHistorico()
        {
            InitializeComponent();
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaUsuario telaUsuario = new TelaUsuario()
            {
                MdiParent = this.MdiParent,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                Text = ""
            };
            telaUsuario.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
