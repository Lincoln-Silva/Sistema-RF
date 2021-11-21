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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal(Form form)
        {
            InitializeComponent();
            ChamarTela(form);
        }

        private void ChamarTela(Form form)
        {
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Text = "";
            form.Show();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
