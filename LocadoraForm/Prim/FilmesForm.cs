using LocadoraForm.Prim;
using System;
using System.Windows.Forms;

namespace LocadoraForm
{
    public partial class FilmesForm : Form
    {
        private FilmeServico filmeServico;
        public FilmesForm()
        {
            InitializeComponent();

            filmeServico = new FilmeServico();
        }

        private void LimparCampos()
        {
            textBoxNomeFilme.Clear();
            comboBoxGeneroFilme.SelectedIndex = -1;
            radioButtonLivre.Checked = false;
            radioButton12Anos.Checked = false;
            radioButton16Anos.Checked = false;
            radioButton18Anos.Checked = false;
        }

        private void DadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione o filme que deseja editar");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var filme = filmeServico.ObterPorCodigo(codigo);

            textBoxNomeFilme.Text = filme.NomeFilme;
        }

        private void FilmesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um filme para editar");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var linhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (linhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente para apagar");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "AVISO", MessageBoxButtons.YesNo);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                var linhaSelecionada = dataGridView1.SelectedRows[0];

                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            }
        }
    }
}
