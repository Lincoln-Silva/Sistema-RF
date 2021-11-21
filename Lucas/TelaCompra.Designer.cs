
namespace Lucas
{
    partial class TelaCompra
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
            this.lbData = new System.Windows.Forms.Label();
            this.lbLeitora = new System.Windows.Forms.Label();
            this.gridCompras = new System.Windows.Forms.DataGridView();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnReiniciarCompra = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picLeitora = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeitora)).BeginInit();
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
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbData.Location = new System.Drawing.Point(562, 9);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(0, 32);
            this.lbData.TabIndex = 1;
            // 
            // lbLeitora
            // 
            this.lbLeitora.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLeitora.Location = new System.Drawing.Point(12, 41);
            this.lbLeitora.Name = "lbLeitora";
            this.lbLeitora.Size = new System.Drawing.Size(276, 88);
            this.lbLeitora.TabIndex = 2;
            this.lbLeitora.Text = "Aproxime os produtos da leitora:";
            // 
            // gridCompras
            // 
            this.gridCompras.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompras.Location = new System.Drawing.Point(303, 66);
            this.gridCompras.Name = "gridCompras";
            this.gridCompras.RowTemplate.Height = 25;
            this.gridCompras.Size = new System.Drawing.Size(485, 315);
            this.gridCompras.TabIndex = 3;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.Firebrick;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarCompra.Location = new System.Drawing.Point(303, 387);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(220, 41);
            this.btnFinalizarCompra.TabIndex = 4;
            this.btnFinalizarCompra.Text = "&Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            // 
            // btnReiniciarCompra
            // 
            this.btnReiniciarCompra.BackColor = System.Drawing.Color.Firebrick;
            this.btnReiniciarCompra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReiniciarCompra.Location = new System.Drawing.Point(568, 387);
            this.btnReiniciarCompra.Name = "btnReiniciarCompra";
            this.btnReiniciarCompra.Size = new System.Drawing.Size(220, 41);
            this.btnReiniciarCompra.TabIndex = 5;
            this.btnReiniciarCompra.Text = "&Reiniciar Compra";
            this.btnReiniciarCompra.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 416);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 22);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // picLeitora
            // 
            this.picLeitora.BackColor = System.Drawing.Color.Transparent;
            this.picLeitora.BackgroundImage = global::Lucas.Properties.Resources.leitora;
            this.picLeitora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLeitora.Location = new System.Drawing.Point(7, 132);
            this.picLeitora.Name = "picLeitora";
            this.picLeitora.Size = new System.Drawing.Size(290, 249);
            this.picLeitora.TabIndex = 11;
            this.picLeitora.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picLeitora);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnReiniciarCompra);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.gridCompras);
            this.Controls.Add(this.lbLeitora);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbOla);
            this.DoubleBuffered = true;
            this.Name = "TelaCompra";
            this.Text = "TelaCompra";
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeitora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOla;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbLeitora;
        private System.Windows.Forms.DataGridView gridCompras;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Button btnReiniciarCompra;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox picLeitora;
        private System.Windows.Forms.Timer timer1;
    }
}