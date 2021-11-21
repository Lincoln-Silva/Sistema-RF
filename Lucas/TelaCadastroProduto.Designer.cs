
namespace Lucas
{
    partial class TelaCadastroProduto
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
            this.lbCodigoRFID = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picLeitora = new System.Windows.Forms.PictureBox();
            this.txtCodigoRfid = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.lbOla = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLeitora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCodigoRFID
            // 
            this.lbCodigoRFID.AutoSize = true;
            this.lbCodigoRFID.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCodigoRFID.Location = new System.Drawing.Point(375, 70);
            this.lbCodigoRFID.Name = "lbCodigoRFID";
            this.lbCodigoRFID.Size = new System.Drawing.Size(167, 37);
            this.lbCodigoRFID.TabIndex = 2;
            this.lbCodigoRFID.Text = "Código RFID";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(375, 140);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(90, 37);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValor.Location = new System.Drawing.Point(375, 210);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(78, 37);
            this.lbValor.TabIndex = 4;
            this.lbValor.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(375, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantidade";
            // 
            // picLeitora
            // 
            this.picLeitora.BackColor = System.Drawing.Color.Transparent;
            this.picLeitora.BackgroundImage = global::Lucas.Properties.Resources.leitora;
            this.picLeitora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLeitora.Location = new System.Drawing.Point(12, 70);
            this.picLeitora.Name = "picLeitora";
            this.picLeitora.Size = new System.Drawing.Size(290, 249);
            this.picLeitora.TabIndex = 6;
            this.picLeitora.TabStop = false;
            // 
            // txtCodigoRfid
            // 
            this.txtCodigoRfid.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoRfid.Location = new System.Drawing.Point(548, 70);
            this.txtCodigoRfid.MaxLength = 20;
            this.txtCodigoRfid.Name = "txtCodigoRfid";
            this.txtCodigoRfid.Size = new System.Drawing.Size(240, 39);
            this.txtCodigoRfid.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(548, 140);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 39);
            this.txtNome.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(568, 397);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(220, 41);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbData.Location = new System.Drawing.Point(562, 9);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(0, 32);
            this.lbData.TabIndex = 13;
            // 
            // lbOla
            // 
            this.lbOla.AutoSize = true;
            this.lbOla.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOla.Location = new System.Drawing.Point(12, 9);
            this.lbOla.Name = "lbOla";
            this.lbOla.Size = new System.Drawing.Size(132, 32);
            this.lbOla.TabIndex = 12;
            this.lbOla.Text = "Olá, Admin";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 416);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 22);
            this.btnVoltar.TabIndex = 14;
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
            // nudValor
            // 
            this.nudValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Dock = System.Windows.Forms.DockStyle.Right;
            this.nudValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudValor.Location = new System.Drawing.Point(47, 0);
            this.nudValor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(189, 35);
            this.nudValor.TabIndex = 9;
            this.nudValor.ThousandsSeparator = true;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudQuantidade.Location = new System.Drawing.Point(548, 280);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(240, 39);
            this.nudQuantidade.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "R$";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nudValor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(548, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 39);
            this.panel1.TabIndex = 9;
            // 
            // TelaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbOla);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigoRfid);
            this.Controls.Add(this.picLeitora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCodigoRFID);
            this.DoubleBuffered = true;
            this.Name = "TelaCadastroProduto";
            this.Text = "TelaCadastroProduto";
            ((System.ComponentModel.ISupportInitialize)(this.picLeitora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCodigoRFID;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picLeitora;
        private System.Windows.Forms.TextBox txtCodigoRfid;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbOla;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}