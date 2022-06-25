namespace LocadoraForm
{
    partial class FilmesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelFilmesCadastrados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelFilmesCadastrados
            // 
            this.labelFilmesCadastrados.AutoSize = true;
            this.labelFilmesCadastrados.Location = new System.Drawing.Point(12, 23);
            this.labelFilmesCadastrados.MaximumSize = new System.Drawing.Size(300, 50);
            this.labelFilmesCadastrados.MinimumSize = new System.Drawing.Size(150, 20);
            this.labelFilmesCadastrados.Name = "labelFilmesCadastrados";
            this.labelFilmesCadastrados.Size = new System.Drawing.Size(150, 20);
            this.labelFilmesCadastrados.TabIndex = 1;
            this.labelFilmesCadastrados.Text = "Filmes Cadastrados";
            this.labelFilmesCadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilmesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.labelFilmesCadastrados);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FilmesForm";
            this.Text = "FilmesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelFilmesCadastrados;
    }
}