
namespace Lucas
{
    partial class TelaHistorico
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
            this.lbOla = new System.Windows.Forms.Label();
            this.lbConsulte = new System.Windows.Forms.Label();
            this.gridHistorico = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOla
            // 
            this.lbOla.AutoSize = true;
            this.lbOla.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOla.Location = new System.Drawing.Point(12, 9);
            this.lbOla.Name = "lbOla";
            this.lbOla.Size = new System.Drawing.Size(142, 32);
            this.lbOla.TabIndex = 0;
            this.lbOla.Text = "Olá, Usuário";
            // 
            // lbConsulte
            // 
            this.lbConsulte.AutoSize = true;
            this.lbConsulte.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbConsulte.Location = new System.Drawing.Point(56, 66);
            this.lbConsulte.Name = "lbConsulte";
            this.lbConsulte.Size = new System.Drawing.Size(601, 41);
            this.lbConsulte.TabIndex = 2;
            this.lbConsulte.Text = "Consulte aqui o seu histórico de compras:";
            // 
            // gridHistorico
            // 
            this.gridHistorico.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistorico.Location = new System.Drawing.Point(12, 110);
            this.gridHistorico.Name = "gridHistorico";
            this.gridHistorico.RowTemplate.Height = 25;
            this.gridHistorico.Size = new System.Drawing.Size(776, 301);
            this.gridHistorico.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 417);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 22);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbData.Location = new System.Drawing.Point(562, 9);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(0, 32);
            this.lbData.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gridHistorico);
            this.Controls.Add(this.lbConsulte);
            this.Controls.Add(this.lbOla);
            this.DoubleBuffered = true;
            this.Name = "TelaHistorico";
            this.Text = "TelaHistorico";
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOla;
        private System.Windows.Forms.Label lbConsulte;
        private System.Windows.Forms.DataGridView gridHistorico;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Timer timer1;
    }
}