namespace LocadoraForm.jao
{
    partial class LocadoraFisicaForm
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
            this.labelLocadoraFisica = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHorarioAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.labelEnderecoCompleto = new System.Windows.Forms.Label();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerHoraAtendimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxNomeLocadora = new System.Windows.Forms.TextBox();
            this.labelNomeLocadora = new System.Windows.Forms.Label();
            this.ColumnNomeLocadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLocadoraFisica
            // 
            this.labelLocadoraFisica.AutoSize = true;
            this.labelLocadoraFisica.Location = new System.Drawing.Point(12, 12);
            this.labelLocadoraFisica.Name = "labelLocadoraFisica";
            this.labelLocadoraFisica.Size = new System.Drawing.Size(94, 13);
            this.labelLocadoraFisica.TabIndex = 0;
            this.labelLocadoraFisica.Text = "Locadoras Físicas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnCep,
            this.ColumnEnderecoCompleto,
            this.ColumnHorarioAtendimento,
            this.ColumnNomeLocadora});
            this.dataGridView1.Location = new System.Drawing.Point(15, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(372, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnCep
            // 
            this.ColumnCep.HeaderText = "CEP";
            this.ColumnCep.MinimumWidth = 6;
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.ReadOnly = true;
            this.ColumnCep.Width = 125;
            // 
            // ColumnEnderecoCompleto
            // 
            this.ColumnEnderecoCompleto.HeaderText = "Endereço completo";
            this.ColumnEnderecoCompleto.MinimumWidth = 6;
            this.ColumnEnderecoCompleto.Name = "ColumnEnderecoCompleto";
            this.ColumnEnderecoCompleto.ReadOnly = true;
            this.ColumnEnderecoCompleto.Width = 125;
            // 
            // ColumnHorarioAtendimento
            // 
            this.ColumnHorarioAtendimento.HeaderText = "Horario de atendimento";
            this.ColumnHorarioAtendimento.MinimumWidth = 6;
            this.ColumnHorarioAtendimento.Name = "ColumnHorarioAtendimento";
            this.ColumnHorarioAtendimento.ReadOnly = true;
            this.ColumnHorarioAtendimento.Width = 125;
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(394, 119);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(171, 20);
            this.textBoxEnderecoCompleto.TabIndex = 2;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(395, 82);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxCep.TabIndex = 3;
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave);
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(393, 66);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(28, 13);
            this.labelCep.TabIndex = 4;
            this.labelCep.Text = "CEP";
            // 
            // labelEnderecoCompleto
            // 
            this.labelEnderecoCompleto.AutoSize = true;
            this.labelEnderecoCompleto.Location = new System.Drawing.Point(393, 103);
            this.labelEnderecoCompleto.Name = "labelEnderecoCompleto";
            this.labelEnderecoCompleto.Size = new System.Drawing.Size(99, 13);
            this.labelEnderecoCompleto.TabIndex = 5;
            this.labelEnderecoCompleto.Text = "Endereço completo";
            this.labelEnderecoCompleto.Click += new System.EventHandler(this.labelEndereco_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(314, 1);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 6;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(233, 1);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(521, 394);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 34);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(623, 394);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(96, 34);
            this.buttonCadastrar.TabIndex = 9;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Horario de atendemento";
            // 
            // dateTimePickerHoraAtendimento
            // 
            this.dateTimePickerHoraAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraAtendimento.Location = new System.Drawing.Point(394, 156);
            this.dateTimePickerHoraAtendimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerHoraAtendimento.Name = "dateTimePickerHoraAtendimento";
            this.dateTimePickerHoraAtendimento.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerHoraAtendimento.TabIndex = 12;
            // 
            // textBoxNomeLocadora
            // 
            this.textBoxNomeLocadora.Location = new System.Drawing.Point(394, 46);
            this.textBoxNomeLocadora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNomeLocadora.Name = "textBoxNomeLocadora";
            this.textBoxNomeLocadora.Size = new System.Drawing.Size(122, 20);
            this.textBoxNomeLocadora.TabIndex = 13;
            // 
            // labelNomeLocadora
            // 
            this.labelNomeLocadora.AutoSize = true;
            this.labelNomeLocadora.Location = new System.Drawing.Point(392, 30);
            this.labelNomeLocadora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeLocadora.Name = "labelNomeLocadora";
            this.labelNomeLocadora.Size = new System.Drawing.Size(98, 13);
            this.labelNomeLocadora.TabIndex = 14;
            this.labelNomeLocadora.Text = "Nome da Locadora";
            // 
            // ColumnNomeLocadora
            // 
            this.ColumnNomeLocadora.HeaderText = "Nome da Locadora";
            this.ColumnNomeLocadora.Name = "ColumnNomeLocadora";
            this.ColumnNomeLocadora.ReadOnly = true;
            // 
            // LocadoraFisicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 440);
            this.Controls.Add(this.labelNomeLocadora);
            this.Controls.Add(this.textBoxNomeLocadora);
            this.Controls.Add(this.dateTimePickerHoraAtendimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.labelEnderecoCompleto);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.textBoxEnderecoCompleto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelLocadoraFisica);
            this.Name = "LocadoraFisicaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadoras Fisicas";
            this.Load += new System.EventHandler(this.LocadoraFisicaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocadoraFisica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxEnderecoCompleto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.Label labelEnderecoCompleto;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnderecoCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHorarioAtendimento;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraAtendimento;
        private System.Windows.Forms.TextBox textBoxNomeLocadora;
        private System.Windows.Forms.Label labelNomeLocadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeLocadora;
    }
}