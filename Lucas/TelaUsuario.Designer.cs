
namespace Lucas
{
    partial class TelaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEfetuarCompra = new System.Windows.Forms.Button();
            this.btnVerHistorico = new System.Windows.Forms.Button();
            this.lbBemVindo = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnEfetuarCompra
            // 
            this.btnEfetuarCompra.BackColor = System.Drawing.Color.Firebrick;
            this.btnEfetuarCompra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEfetuarCompra.Location = new System.Drawing.Point(300, 227);
            this.btnEfetuarCompra.Name = "btnEfetuarCompra";
            this.btnEfetuarCompra.Size = new System.Drawing.Size(220, 41);
            this.btnEfetuarCompra.TabIndex = 0;
            this.btnEfetuarCompra.Text = "Efetuar &Compra";
            this.btnEfetuarCompra.UseVisualStyleBackColor = false;
            this.btnEfetuarCompra.Click += new System.EventHandler(this.btnEfetuarCompra_Click);
            // 
            // btnVerHistorico
            // 
            this.btnVerHistorico.BackColor = System.Drawing.Color.Firebrick;
            this.btnVerHistorico.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerHistorico.Location = new System.Drawing.Point(300, 280);
            this.btnVerHistorico.Name = "btnVerHistorico";
            this.btnVerHistorico.Size = new System.Drawing.Size(220, 41);
            this.btnVerHistorico.TabIndex = 1;
            this.btnVerHistorico.Text = "Ver &Histórico";
            this.btnVerHistorico.UseVisualStyleBackColor = false;
            this.btnVerHistorico.Click += new System.EventHandler(this.btnVerHistorico_Click);
            // 
            // lbBemVindo
            // 
            this.lbBemVindo.AutoSize = true;
            this.lbBemVindo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBemVindo.Location = new System.Drawing.Point(100, 120);
            this.lbBemVindo.Name = "lbBemVindo";
            this.lbBemVindo.Size = new System.Drawing.Size(606, 54);
            this.lbBemVindo.TabIndex = 2;
            this.lbBemVindo.Text = "Olá Usuário, bem-vindo de volta!";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbData.Location = new System.Drawing.Point(562, 9);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(0, 32);
            this.lbData.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 416);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 22);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbBemVindo);
            this.Controls.Add(this.btnVerHistorico);
            this.Controls.Add(this.btnEfetuarCompra);
            this.DoubleBuffered = true;
            this.Name = "TelaUsuario";
            this.Text = "TelaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEfetuarCompra;
        private System.Windows.Forms.Button btnVerHistorico;
        private System.Windows.Forms.Label lbBemVindo;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Timer timer1;
    }
}