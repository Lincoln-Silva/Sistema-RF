using MySql.Data.MySqlClient;
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
    public partial class TelaEstoque : Form
    {
        public TelaEstoque()
        {
            InitializeComponent();
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaAdmin telaAdmin = new TelaAdmin()
            {
                MdiParent = this.MdiParent,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                Text = ""
            };
            telaAdmin.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtCodigo.Text))
                ConsultarEstoque(txtCodigo.Text);
            else
                ConsultarEstoque();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {
            ConsultarEstoque();
        }

        private void ConsultarEstoque()
        {
            DataTable dt = ConexaoSQL.SQLCommandConsultaEstoque();
            gridEstoque.DataSource = dt;
        }

        private void ConsultarEstoque(string rfid)
        {
            DataTable dt = ConexaoSQL.SQLCommandConsultaEstoque(txtCodigo.Text);
            gridEstoque.DataSource = dt;
        }
    }
}
