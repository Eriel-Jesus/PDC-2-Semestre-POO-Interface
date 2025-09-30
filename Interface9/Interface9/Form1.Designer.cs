namespace Interface9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(161, 27);
            this.lblValor1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(43, 13);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(253, 27);
            this.txtValor1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(68, 20);
            this.txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(253, 73);
            this.txtValor2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(68, 20);
            this.txtValor2.TabIndex = 3;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(161, 76);
            this.lblValor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(43, 13);
            this.lblValor2.TabIndex = 2;
            this.lblValor2.Text = "Valor 2:";
            // 
            // btnComparar
            // 
            this.btnComparar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComparar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComparar.BackgroundImage")));
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.ForeColor = System.Drawing.Color.Red;
            this.btnComparar.Location = new System.Drawing.Point(196, 182);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(125, 52);
            this.btnComparar.TabIndex = 4;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = false;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(321, 92);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblResultado;
    }
}

