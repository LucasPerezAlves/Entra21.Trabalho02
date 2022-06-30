namespace LocadoraForm.jao
{
    partial class BiografiaForm
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
            this.labelBiografiaLocadora = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBiografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelDiaFundacao = new System.Windows.Forms.Label();
            this.dateTimePickerDiaFundacao = new System.Windows.Forms.DateTimePicker();
            this.labelMotivoFundacao = new System.Windows.Forms.Label();
            this.textBoxMotivoFundacao = new System.Windows.Forms.TextBox();
            this.labelParcerias = new System.Windows.Forms.Label();
            this.textBoxParcerias = new System.Windows.Forms.TextBox();
            this.labelSinopse = new System.Windows.Forms.Label();
            this.textBoxSinopse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBiografiaLocadora
            // 
            this.labelBiografiaLocadora.AutoSize = true;
            this.labelBiografiaLocadora.Location = new System.Drawing.Point(13, 13);
            this.labelBiografiaLocadora.Name = "labelBiografiaLocadora";
            this.labelBiografiaLocadora.Size = new System.Drawing.Size(151, 16);
            this.labelBiografiaLocadora.TabIndex = 0;
            this.labelBiografiaLocadora.Text = "Biografia das locadoras";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnLocadora,
            this.ColumnBiografia});
            this.dataGridView1.Location = new System.Drawing.Point(16, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(386, 379);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnLocadora
            // 
            this.ColumnLocadora.HeaderText = "Locadora";
            this.ColumnLocadora.MinimumWidth = 6;
            this.ColumnLocadora.Name = "ColumnLocadora";
            this.ColumnLocadora.ReadOnly = true;
            this.ColumnLocadora.Width = 125;
            // 
            // ColumnBiografia
            // 
            this.ColumnBiografia.HeaderText = "Biografia";
            this.ColumnBiografia.MinimumWidth = 6;
            this.ColumnBiografia.Name = "ColumnBiografia";
            this.ColumnBiografia.ReadOnly = true;
            this.ColumnBiografia.Width = 125;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(409, 32);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 16);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(412, 52);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(152, 22);
            this.textBoxNome.TabIndex = 3;
            // 
            // labelDiaFundacao
            // 
            this.labelDiaFundacao.AutoSize = true;
            this.labelDiaFundacao.Location = new System.Drawing.Point(409, 82);
            this.labelDiaFundacao.Name = "labelDiaFundacao";
            this.labelDiaFundacao.Size = new System.Drawing.Size(106, 16);
            this.labelDiaFundacao.TabIndex = 4;
            this.labelDiaFundacao.Text = "Dia da fundação";
            // 
            // dateTimePickerDiaFundacao
            // 
            this.dateTimePickerDiaFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDiaFundacao.Location = new System.Drawing.Point(412, 101);
            this.dateTimePickerDiaFundacao.Name = "dateTimePickerDiaFundacao";
            this.dateTimePickerDiaFundacao.Size = new System.Drawing.Size(152, 22);
            this.dateTimePickerDiaFundacao.TabIndex = 5;
            // 
            // labelMotivoFundacao
            // 
            this.labelMotivoFundacao.AutoSize = true;
            this.labelMotivoFundacao.Location = new System.Drawing.Point(409, 130);
            this.labelMotivoFundacao.Name = "labelMotivoFundacao";
            this.labelMotivoFundacao.Size = new System.Drawing.Size(106, 16);
            this.labelMotivoFundacao.TabIndex = 6;
            this.labelMotivoFundacao.Text = "Motivo fundação";
            // 
            // textBoxMotivoFundacao
            // 
            this.textBoxMotivoFundacao.Location = new System.Drawing.Point(412, 149);
            this.textBoxMotivoFundacao.Name = "textBoxMotivoFundacao";
            this.textBoxMotivoFundacao.Size = new System.Drawing.Size(152, 22);
            this.textBoxMotivoFundacao.TabIndex = 7;
            // 
            // labelParcerias
            // 
            this.labelParcerias.AutoSize = true;
            this.labelParcerias.Location = new System.Drawing.Point(409, 179);
            this.labelParcerias.Name = "labelParcerias";
            this.labelParcerias.Size = new System.Drawing.Size(65, 16);
            this.labelParcerias.TabIndex = 8;
            this.labelParcerias.Text = "Parcerias";
            // 
            // textBoxParcerias
            // 
            this.textBoxParcerias.Location = new System.Drawing.Point(412, 198);
            this.textBoxParcerias.Name = "textBoxParcerias";
            this.textBoxParcerias.Size = new System.Drawing.Size(152, 22);
            this.textBoxParcerias.TabIndex = 9;
            // 
            // labelSinopse
            // 
            this.labelSinopse.AutoSize = true;
            this.labelSinopse.Location = new System.Drawing.Point(412, 227);
            this.labelSinopse.Name = "labelSinopse";
            this.labelSinopse.Size = new System.Drawing.Size(133, 16);
            this.labelSinopse.TabIndex = 10;
            this.labelSinopse.Text = "Sinopce da locadora";
            // 
            // textBoxSinopse
            // 
            this.textBoxSinopse.Location = new System.Drawing.Point(415, 246);
            this.textBoxSinopse.Name = "textBoxSinopse";
            this.textBoxSinopse.Size = new System.Drawing.Size(149, 22);
            this.textBoxSinopse.TabIndex = 11;
            // 
            // BiografiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSinopse);
            this.Controls.Add(this.labelSinopse);
            this.Controls.Add(this.textBoxParcerias);
            this.Controls.Add(this.labelParcerias);
            this.Controls.Add(this.textBoxMotivoFundacao);
            this.Controls.Add(this.labelMotivoFundacao);
            this.Controls.Add(this.dateTimePickerDiaFundacao);
            this.Controls.Add(this.labelDiaFundacao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelBiografiaLocadora);
            this.Name = "BiografiaForm";
            this.Text = "BiografiaForm";
            this.Load += new System.EventHandler(this.BiografiaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBiografiaLocadora;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBiografia;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelDiaFundacao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiaFundacao;
        private System.Windows.Forms.Label labelMotivoFundacao;
        private System.Windows.Forms.TextBox textBoxMotivoFundacao;
        private System.Windows.Forms.Label labelParcerias;
        private System.Windows.Forms.TextBox textBoxParcerias;
        private System.Windows.Forms.Label labelSinopse;
        private System.Windows.Forms.TextBox textBoxSinopse;
    }
}