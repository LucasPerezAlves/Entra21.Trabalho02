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
            this.comboBoxLocadora = new System.Windows.Forms.ComboBox();
            this.labelLocadora = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBiografiaLocadora
            // 
            this.labelBiografiaLocadora.AutoSize = true;
            this.labelBiografiaLocadora.Location = new System.Drawing.Point(10, 11);
            this.labelBiografiaLocadora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBiografiaLocadora.Name = "labelBiografiaLocadora";
            this.labelBiografiaLocadora.Size = new System.Drawing.Size(117, 13);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(290, 308);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.labelNome.Location = new System.Drawing.Point(307, 26);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(309, 42);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(115, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // labelDiaFundacao
            // 
            this.labelDiaFundacao.AutoSize = true;
            this.labelDiaFundacao.Location = new System.Drawing.Point(307, 67);
            this.labelDiaFundacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiaFundacao.Name = "labelDiaFundacao";
            this.labelDiaFundacao.Size = new System.Drawing.Size(86, 13);
            this.labelDiaFundacao.TabIndex = 4;
            this.labelDiaFundacao.Text = "Dia da fundação";
            // 
            // dateTimePickerDiaFundacao
            // 
            this.dateTimePickerDiaFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDiaFundacao.Location = new System.Drawing.Point(309, 82);
            this.dateTimePickerDiaFundacao.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDiaFundacao.Name = "dateTimePickerDiaFundacao";
            this.dateTimePickerDiaFundacao.Size = new System.Drawing.Size(115, 20);
            this.dateTimePickerDiaFundacao.TabIndex = 5;
            // 
            // labelMotivoFundacao
            // 
            this.labelMotivoFundacao.AutoSize = true;
            this.labelMotivoFundacao.Location = new System.Drawing.Point(307, 106);
            this.labelMotivoFundacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMotivoFundacao.Name = "labelMotivoFundacao";
            this.labelMotivoFundacao.Size = new System.Drawing.Size(87, 13);
            this.labelMotivoFundacao.TabIndex = 6;
            this.labelMotivoFundacao.Text = "Motivo fundação";
            // 
            // textBoxMotivoFundacao
            // 
            this.textBoxMotivoFundacao.Location = new System.Drawing.Point(309, 121);
            this.textBoxMotivoFundacao.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMotivoFundacao.Name = "textBoxMotivoFundacao";
            this.textBoxMotivoFundacao.Size = new System.Drawing.Size(115, 20);
            this.textBoxMotivoFundacao.TabIndex = 7;
            // 
            // labelParcerias
            // 
            this.labelParcerias.AutoSize = true;
            this.labelParcerias.Location = new System.Drawing.Point(307, 145);
            this.labelParcerias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParcerias.Name = "labelParcerias";
            this.labelParcerias.Size = new System.Drawing.Size(51, 13);
            this.labelParcerias.TabIndex = 8;
            this.labelParcerias.Text = "Parcerias";
            // 
            // textBoxParcerias
            // 
            this.textBoxParcerias.Location = new System.Drawing.Point(309, 161);
            this.textBoxParcerias.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParcerias.Name = "textBoxParcerias";
            this.textBoxParcerias.Size = new System.Drawing.Size(115, 20);
            this.textBoxParcerias.TabIndex = 9;
            // 
            // labelSinopse
            // 
            this.labelSinopse.AutoSize = true;
            this.labelSinopse.Location = new System.Drawing.Point(309, 184);
            this.labelSinopse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSinopse.Name = "labelSinopse";
            this.labelSinopse.Size = new System.Drawing.Size(105, 13);
            this.labelSinopse.TabIndex = 10;
            this.labelSinopse.Text = "Sinopce da locadora";
            // 
            // textBoxSinopse
            // 
            this.textBoxSinopse.Location = new System.Drawing.Point(311, 200);
            this.textBoxSinopse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSinopse.Name = "textBoxSinopse";
            this.textBoxSinopse.Size = new System.Drawing.Size(113, 20);
            this.textBoxSinopse.TabIndex = 11;
            // 
            // comboBoxLocadora
            // 
            this.comboBoxLocadora.FormattingEnabled = true;
            this.comboBoxLocadora.Location = new System.Drawing.Point(311, 236);
            this.comboBoxLocadora.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLocadora.Name = "comboBoxLocadora";
            this.comboBoxLocadora.Size = new System.Drawing.Size(113, 21);
            this.comboBoxLocadora.TabIndex = 12;
            // 
            // labelLocadora
            // 
            this.labelLocadora.AutoSize = true;
            this.labelLocadora.Location = new System.Drawing.Point(309, 220);
            this.labelLocadora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocadora.Name = "labelLocadora";
            this.labelLocadora.Size = new System.Drawing.Size(52, 13);
            this.labelLocadora.TabIndex = 13;
            this.labelLocadora.Text = "Locadora";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(244, 2);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(56, 19);
            this.buttonEditar.TabIndex = 14;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(164, 2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 15;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(352, 331);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(433, 331);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 17;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // BiografiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 366);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelLocadora);
            this.Controls.Add(this.comboBoxLocadora);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BiografiaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ComboBox comboBoxLocadora;
        private System.Windows.Forms.Label labelLocadora;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
    }
}