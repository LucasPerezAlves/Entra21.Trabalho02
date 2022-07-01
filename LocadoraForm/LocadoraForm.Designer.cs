namespace LocadoraForm
{
    partial class LocadoraForm
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
            this.buttonLocadoraFisica = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonBiografia = new System.Windows.Forms.Button();
            this.buttonCatalogo = new System.Windows.Forms.Button();
            this.buttonFilmes = new System.Windows.Forms.Button();
            this.buttonFeedBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLocadoraFisica
            // 
            this.buttonLocadoraFisica.Location = new System.Drawing.Point(13, 13);
            this.buttonLocadoraFisica.Name = "buttonLocadoraFisica";
            this.buttonLocadoraFisica.Size = new System.Drawing.Size(75, 23);
            this.buttonLocadoraFisica.TabIndex = 0;
            this.buttonLocadoraFisica.Text = "Locadora fisica";
            this.buttonLocadoraFisica.UseVisualStyleBackColor = true;
            this.buttonLocadoraFisica.Click += new System.EventHandler(this.buttonLocadoraFisica_Click_1);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(13, 43);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click_1);
            // 
            // buttonBiografia
            // 
            this.buttonBiografia.Location = new System.Drawing.Point(95, 13);
            this.buttonBiografia.Name = "buttonBiografia";
            this.buttonBiografia.Size = new System.Drawing.Size(75, 23);
            this.buttonBiografia.TabIndex = 2;
            this.buttonBiografia.Text = "Biografia";
            this.buttonBiografia.UseVisualStyleBackColor = true;
            this.buttonBiografia.Click += new System.EventHandler(this.buttonBiografia_Click_1);
            // 
            // buttonCatalogo
            // 
            this.buttonCatalogo.Location = new System.Drawing.Point(95, 43);
            this.buttonCatalogo.Name = "buttonCatalogo";
            this.buttonCatalogo.Size = new System.Drawing.Size(75, 23);
            this.buttonCatalogo.TabIndex = 3;
            this.buttonCatalogo.Text = "Catalogo";
            this.buttonCatalogo.UseVisualStyleBackColor = true;
            // 
            // buttonFilmes
            // 
            this.buttonFilmes.Location = new System.Drawing.Point(177, 13);
            this.buttonFilmes.Name = "buttonFilmes";
            this.buttonFilmes.Size = new System.Drawing.Size(75, 23);
            this.buttonFilmes.TabIndex = 4;
            this.buttonFilmes.Text = "Filmes";
            this.buttonFilmes.UseVisualStyleBackColor = true;
            this.buttonFilmes.Click += new System.EventHandler(this.buttonFilmes_Click);
            // 
            // buttonFeedBack
            // 
            this.buttonFeedBack.Location = new System.Drawing.Point(177, 43);
            this.buttonFeedBack.Name = "buttonFeedBack";
            this.buttonFeedBack.Size = new System.Drawing.Size(75, 23);
            this.buttonFeedBack.TabIndex = 5;
            this.buttonFeedBack.Text = "FeedBack";
            this.buttonFeedBack.UseVisualStyleBackColor = true;
            this.buttonFeedBack.Click += new System.EventHandler(this.buttonFeedBack_Click);
            // 
            // LocadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFeedBack);
            this.Controls.Add(this.buttonFilmes);
            this.Controls.Add(this.buttonCatalogo);
            this.Controls.Add(this.buttonBiografia);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.buttonLocadoraFisica);
            this.Name = "LocadoraForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLocadoraFisica;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonBiografia;
        private System.Windows.Forms.Button buttonCatalogo;
        private System.Windows.Forms.Button buttonFilmes;
        private System.Windows.Forms.Button buttonFeedBack;
    }
}

