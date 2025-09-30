namespace Interface6
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
            this.lblMilhas = new System.Windows.Forms.Label();
            this.txtMilhas = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMilhas
            // 
            this.lblMilhas.AutoSize = true;
            this.lblMilhas.Location = new System.Drawing.Point(131, 108);
            this.lblMilhas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMilhas.Name = "lblMilhas";
            this.lblMilhas.Size = new System.Drawing.Size(47, 13);
            this.lblMilhas.TabIndex = 0;
            this.lblMilhas.Text = "Milhas:";
            // 
            // txtMilhas
            // 
            this.txtMilhas.Location = new System.Drawing.Point(198, 108);
            this.txtMilhas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMilhas.Name = "txtMilhas";
            this.txtMilhas.Size = new System.Drawing.Size(79, 20);
            this.txtMilhas.TabIndex = 1;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConverter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConverter.BackgroundImage")));
            this.btnConverter.Location = new System.Drawing.Point(180, 209);
            this.btnConverter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(127, 61);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter para Km";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(131, 152);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(68, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(622, 292);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtMilhas);
            this.Controls.Add(this.lblMilhas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMilhas;
        private System.Windows.Forms.TextBox txtMilhas;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
    }
}

