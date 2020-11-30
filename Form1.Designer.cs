namespace cobrinha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbCenario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPontos = new System.Windows.Forms.Label();
            this.labelFimDeJogo = new System.Windows.Forms.Label();
            this.cronometro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCenario)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCenario
            // 
            this.pbCenario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbCenario.Location = new System.Drawing.Point(13, 13);
            this.pbCenario.Name = "pbCenario";
            this.pbCenario.Size = new System.Drawing.Size(541, 560);
            this.pbCenario.TabIndex = 0;
            this.pbCenario.TabStop = false;
            this.pbCenario.Paint += new System.Windows.Forms.PaintEventHandler(this.AtualizarGraficos);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontos:";
            // 
            // labelPontos
            // 
            this.labelPontos.AutoSize = true;
            this.labelPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPontos.Location = new System.Drawing.Point(109, 68);
            this.labelPontos.Name = "labelPontos";
            this.labelPontos.Size = new System.Drawing.Size(32, 24);
            this.labelPontos.TabIndex = 2;
            this.labelPontos.Text = "00";
            // 
            // labelFimDeJogo
            // 
            this.labelFimDeJogo.AutoSize = true;
            this.labelFimDeJogo.BackColor = System.Drawing.Color.Black;
            this.labelFimDeJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFimDeJogo.ForeColor = System.Drawing.Color.Yellow;
            this.labelFimDeJogo.Location = new System.Drawing.Point(215, 226);
            this.labelFimDeJogo.Name = "labelFimDeJogo";
            this.labelFimDeJogo.Size = new System.Drawing.Size(135, 25);
            this.labelFimDeJogo.TabIndex = 3;
            this.labelFimDeJogo.Text = "Fim de jogo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 631);
            this.Controls.Add(this.labelFimDeJogo);
            this.Controls.Add(this.labelPontos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCenario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(592, 670);
            this.MinimumSize = new System.Drawing.Size(592, 670);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "cobrinha";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressionada);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TeclaLiberada);
            ((System.ComponentModel.ISupportInitialize)(this.pbCenario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCenario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPontos;
        private System.Windows.Forms.Label labelFimDeJogo;
        private System.Windows.Forms.Timer cronometro;
    }
}

