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
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private bool ValidarCampos()
        {
            if(String.IsNullOrEmpty(txtCodigoRfid.Text)){
                MessageBox.Show("Preencha o campo de Código RFID.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoRfid.Focus();
                return false;
            }
            if(String.IsNullOrEmpty(txtNome.Text)){
                MessageBox.Show("Preencha o campo de Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            if(String.IsNullOrEmpty(nudValor.Text)){
                MessageBox.Show("Preencha o campo de Valor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudValor.Focus();
                return false;
            }
            if(String.IsNullOrEmpty(nudQuantidade.Text)){
                MessageBox.Show("Preencha o campo de Quantidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQuantidade.Focus();
                return false;
            }
            return true;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Cursor = Cursors.WaitCursor;
                if(ConexaoSQL.SQLCommandCadastroProduto(txtCodigoRfid.Text, txtNome.Text, Convert.ToDecimal(nudValor.Text), Convert.ToInt32(nudQuantidade.Text)))                
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Cursor = Cursors.Default;
            }            
        }
    }
}
