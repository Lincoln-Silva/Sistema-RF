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
    public partial class TelaAdmin : Form
    {
        public TelaAdmin()
        {
            InitializeComponent();
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telaCadastroProduto = new TelaCadastroProduto()
            {
                MdiParent = this.MdiParent,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                Text = ""
            };
            telaCadastroProduto.Show();
        }

        private void btnConsultarEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque()
            {
                MdiParent = this.MdiParent,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                Text = ""
            };
            telaEstoque.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin()
            {
                MdiParent = this.MdiParent,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                Text = ""
            };
            telaLogin.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
