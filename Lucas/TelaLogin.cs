using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucas
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        private void RealizarLogin()
        {
            Cursor = Cursors.WaitCursor;
            ConexaoSQL.Conecta("127.0.0.1", "Cadastro", "root", "root");
            ConexaoSQL.SQLCommandLogin(txtLogin.Text, ConexaoSQL.HashValue(txtSenha.Text));
            Cursor = Cursors.Default;
            if (ConexaoSQL.id > 0)
            {
                if (ConexaoSQL.admin)
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
                else
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
            }
            else
            {
                ConexaoSQL.id = 0;
                ConexaoSQL.admin = false;
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            ConexaoSQL.id = 0;
            ConexaoSQL.admin = false;
        }
    }
}
