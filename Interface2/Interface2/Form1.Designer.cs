namespace Interface2
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
            this.lblAresta = new System.Windows.Forms.Label();
            this.txtAresta = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAresta
            // 
            this.lblAresta.AutoSize = true;
            this.lblAresta.Location = new System.Drawing.Point(69, 38);
            this.lblAresta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAresta.Name = "lblAresta";
            this.lblAresta.Size = new System.Drawing.Size(40, 13);
            this.lblAresta.TabIndex = 0;
            this.lblAresta.Text = "Aresta:";
            // 
            // txtAresta
            // 
            this.txtAresta.Location = new System.Drawing.Point(184, 36);
            this.txtAresta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAresta.Name = "txtAresta";
            this.txtAresta.Size = new System.Drawing.Size(68, 20);
            this.txtAresta.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(176, 190);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 38);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Área";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(78, 109);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(32, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Área:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAresta);
            this.Controls.Add(this.lblAresta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAresta;
        private System.Windows.Forms.TextBox txtAresta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}

