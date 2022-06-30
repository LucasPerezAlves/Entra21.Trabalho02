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
            this.comboBoxGeneroFilme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeFilme = new System.Windows.Forms.TextBox();
            this.radioButtonLivre = new System.Windows.Forms.RadioButton();
            this.radioButton12Anos = new System.Windows.Forms.RadioButton();
            this.radioButton16Anos = new System.Windows.Forms.RadioButton();
            this.radioButton18Anos = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(367, 249);
            this.dataGridView1.TabIndex = 0;
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
            // comboBoxGeneroFilme
            // 
            this.comboBoxGeneroFilme.FormattingEnabled = true;
            this.comboBoxGeneroFilme.Location = new System.Drawing.Point(384, 102);
            this.comboBoxGeneroFilme.Name = "comboBoxGeneroFilme";
            this.comboBoxGeneroFilme.Size = new System.Drawing.Size(227, 21);
            this.comboBoxGeneroFilme.TabIndex = 2;
            this.comboBoxGeneroFilme.SelectedIndexChanged += new System.EventHandler(this.comboBoxGeneroFilme_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gênero do filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do filme:";
            // 
            // textBoxNomeFilme
            // 
            this.textBoxNomeFilme.Location = new System.Drawing.Point(384, 62);
            this.textBoxNomeFilme.Name = "textBoxNomeFilme";
            this.textBoxNomeFilme.Size = new System.Drawing.Size(227, 20);
            this.textBoxNomeFilme.TabIndex = 5;
            // 
            // radioButtonLivre
            // 
            this.radioButtonLivre.AutoSize = true;
            this.radioButtonLivre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLivre.Location = new System.Drawing.Point(384, 143);
            this.radioButtonLivre.Name = "radioButtonLivre";
            this.radioButtonLivre.Size = new System.Drawing.Size(49, 18);
            this.radioButtonLivre.TabIndex = 6;
            this.radioButtonLivre.TabStop = true;
            this.radioButtonLivre.Text = "Livre";
            this.radioButtonLivre.UseVisualStyleBackColor = true;
            // 
            // radioButton12Anos
            // 
            this.radioButton12Anos.AutoSize = true;
            this.radioButton12Anos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton12Anos.Location = new System.Drawing.Point(384, 167);
            this.radioButton12Anos.Name = "radioButton12Anos";
            this.radioButton12Anos.Size = new System.Drawing.Size(65, 18);
            this.radioButton12Anos.TabIndex = 7;
            this.radioButton12Anos.TabStop = true;
            this.radioButton12Anos.Text = "12 Anos";
            this.radioButton12Anos.UseVisualStyleBackColor = true;
            // 
            // radioButton16Anos
            // 
            this.radioButton16Anos.AutoSize = true;
            this.radioButton16Anos.Location = new System.Drawing.Point(384, 191);
            this.radioButton16Anos.Name = "radioButton16Anos";
            this.radioButton16Anos.Size = new System.Drawing.Size(64, 17);
            this.radioButton16Anos.TabIndex = 8;
            this.radioButton16Anos.TabStop = true;
            this.radioButton16Anos.Text = "16 Anos";
            this.radioButton16Anos.UseVisualStyleBackColor = true;
            // 
            // radioButton18Anos
            // 
            this.radioButton18Anos.AutoSize = true;
            this.radioButton18Anos.Location = new System.Drawing.Point(384, 214);
            this.radioButton18Anos.Name = "radioButton18Anos";
            this.radioButton18Anos.Size = new System.Drawing.Size(64, 17);
            this.radioButton18Anos.TabIndex = 9;
            this.radioButton18Anos.TabStop = true;
            this.radioButton18Anos.Text = "18 Anos";
            this.radioButton18Anos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Classificação indicativa:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(464, 268);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(78, 31);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(548, 268);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(77, 31);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(231, 12);
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
            this.buttonApagar.Location = new System.Drawing.Point(304, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 37);
            this.buttonApagar.TabIndex = 14;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // FilmesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 311);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton18Anos);
            this.Controls.Add(this.radioButton16Anos);
            this.Controls.Add(this.radioButton12Anos);
            this.Controls.Add(this.radioButtonLivre);
            this.Controls.Add(this.textBoxNomeFilme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGeneroFilme);
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
        private System.Windows.Forms.ComboBox comboBoxGeneroFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeFilme;
        private System.Windows.Forms.RadioButton radioButtonLivre;
        private System.Windows.Forms.RadioButton radioButton12Anos;
        private System.Windows.Forms.RadioButton radioButton16Anos;
        private System.Windows.Forms.RadioButton radioButton18Anos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonApagar;
    }
}