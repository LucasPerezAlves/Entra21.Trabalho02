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
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGeneroFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFilmesCadastrados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeFilme = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelAnoLancamento = new System.Windows.Forms.Label();
            this.dateTimePickerAnoLancamento = new System.Windows.Forms.DateTimePicker();
            this.textBoxGeneroFilme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNomeFilme,
            this.ColumnGeneroFilme,
            this.ColumnAnoLancamento});
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(424, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnNomeFilme
            // 
            this.ColumnNomeFilme.HeaderText = "Nome do filme";
            this.ColumnNomeFilme.Name = "ColumnNomeFilme";
            this.ColumnNomeFilme.ReadOnly = true;
            // 
            // ColumnGeneroFilme
            // 
            this.ColumnGeneroFilme.HeaderText = "Gênero do filme";
            this.ColumnGeneroFilme.Name = "ColumnGeneroFilme";
            this.ColumnGeneroFilme.ReadOnly = true;
            // 
            // ColumnAnoLancamento
            // 
            this.ColumnAnoLancamento.HeaderText = "Ano de lançamento";
            this.ColumnAnoLancamento.Name = "ColumnAnoLancamento";
            this.ColumnAnoLancamento.ReadOnly = true;
            // 
            // labelFilmesCadastrados
            // 
            this.labelFilmesCadastrados.AutoSize = true;
            this.labelFilmesCadastrados.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilmesCadastrados.Location = new System.Drawing.Point(8, 27);
            this.labelFilmesCadastrados.MaximumSize = new System.Drawing.Size(300, 50);
            this.labelFilmesCadastrados.MinimumSize = new System.Drawing.Size(150, 20);
            this.labelFilmesCadastrados.Name = "labelFilmesCadastrados";
            this.labelFilmesCadastrados.Size = new System.Drawing.Size(158, 20);
            this.labelFilmesCadastrados.TabIndex = 1;
            this.labelFilmesCadastrados.Text = "Filmes Cadastrados";
            this.labelFilmesCadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gênero do filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do filme:";
            // 
            // textBoxNomeFilme
            // 
            this.textBoxNomeFilme.Location = new System.Drawing.Point(445, 62);
            this.textBoxNomeFilme.Name = "textBoxNomeFilme";
            this.textBoxNomeFilme.Size = new System.Drawing.Size(227, 20);
            this.textBoxNomeFilme.TabIndex = 5;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(500, 268);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(78, 31);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(595, 268);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(77, 31);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(273, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(67, 37);
            this.buttonEditar.TabIndex = 13;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.Location = new System.Drawing.Point(346, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 37);
            this.buttonApagar.TabIndex = 14;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelAnoLancamento
            // 
            this.labelAnoLancamento.AutoSize = true;
            this.labelAnoLancamento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnoLancamento.Location = new System.Drawing.Point(442, 130);
            this.labelAnoLancamento.Name = "labelAnoLancamento";
            this.labelAnoLancamento.Size = new System.Drawing.Size(162, 14);
            this.labelAnoLancamento.TabIndex = 16;
            this.labelAnoLancamento.Text = "Data de lançamento do filme";
            // 
            // dateTimePickerAnoLancamento
            // 
            this.dateTimePickerAnoLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAnoLancamento.Location = new System.Drawing.Point(445, 147);
            this.dateTimePickerAnoLancamento.Name = "dateTimePickerAnoLancamento";
            this.dateTimePickerAnoLancamento.Size = new System.Drawing.Size(106, 20);
            this.dateTimePickerAnoLancamento.TabIndex = 18;
            // 
            // textBoxGeneroFilme
            // 
            this.textBoxGeneroFilme.Location = new System.Drawing.Point(445, 103);
            this.textBoxGeneroFilme.Name = "textBoxGeneroFilme";
            this.textBoxGeneroFilme.Size = new System.Drawing.Size(227, 20);
            this.textBoxGeneroFilme.TabIndex = 19;
            // 
            // FilmesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.textBoxGeneroFilme);
            this.Controls.Add(this.dateTimePickerAnoLancamento);
            this.Controls.Add(this.labelAnoLancamento);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxNomeFilme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFilmesCadastrados);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FilmesForm";
            this.Text = "FilmesForm";
            this.Load += new System.EventHandler(this.FilmesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelFilmesCadastrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeFilme;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label labelAnoLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGeneroFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnoLancamento;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnoLancamento;
        private System.Windows.Forms.TextBox textBoxGeneroFilme;
    }
}