using System;
using System.Windows.Forms;
using LocadoraForm.Perez;
using LocadoraForm.Prim;

// LINHAS COMENTADAS, FAZER CORREÇÃO
namespace LocadoraForm
{
    public partial class FilmesForm : Form
    {
        private FilmeServico filmeServico;
        private ClienteServico clienteServico;

        public FilmesForm()
        {
            InitializeComponent();

            filmeServico = new FilmeServico();

            clienteServico = new ClienteServico();

            PreencherDataGrideViewComFilmes();
            PreencherComboBoxGeneroFilme();
        }

        private void LimparCampos()
        {
            textBoxNomeFilme.Clear();
            comboBoxGeneroFilme.ResetText();
            maskedTextBox1.Clear();
        }

        private void FilmesForm_Load(object sender, EventArgs e)
        {
            PreencherDataGrideViewComFilmes();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DadosParaEditar();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente para apagar");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "AVISO", MessageBoxButtons.YesNo);

            if (opcaoEscolhida != DialogResult.Yes)
            {
                MessageBox.Show("Filme não retirado do cadastro");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var filme = filmeServico.ObterPorCodigo(codigo);

            filmeServico.Apagar(filme);

            PreencherDataGrideViewComFilmes();

            dataGridView1.ClearSelection();
        }

        private void comboBoxGeneroFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nomeFilme = textBoxNomeFilme.Text;
            var generoFilme = comboBoxGeneroFilme.SelectedItem.ToString();
            var anoLancamento = maskedTextBox1.Text;
        }

        private void DadosParaEditar()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um filme que deseja editar");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var filme = filmeServico.ObterPorCodigo(codigo);

            textBoxNomeFilme.Text = filme.NomeFilme;
            comboBoxGeneroFilme.Text = filme.GeneroFilme.ToString();
            maskedTextBox1.Text = filme.AnoLancamento.ToString();
        }

        private void PreencherDataGrideViewComFilmes()
        {
            var filmes = filmeServico.ObterTodos();

            dataGridView1.Rows.Clear();

            dataGridView1.ClearSelection();

            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    filme.Codigo,
                    filme.NomeFilme,
                    filme.GeneroFilme,
                    filme.AnoLancamento
                });
            }
        }

        private void PreencherComboBoxGeneroFilme()
        {
            var generos = clienteServico.ObterTodos();

            for (var i = 0; i < generos.Count; i++)
            {
                var cliente = generos[i];
                comboBoxGeneroFilme.Items.Add(generos); 
            }
        }

        private void ValidarDados(string nomeFilme, string generoFilme, string anoLancamento)
        {
            try
            {
                if (nomeFilme.Length < 3 && nomeFilme.Length > 30)
                {
                    MessageBox.Show("Nome do filme é inválido");

                    textBoxNomeFilme.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Nome do filme é inválido");
            }

            if (comboBoxGeneroFilme.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um paciente");

                comboBoxGeneroFilme.DroppedDown = true;
            }


        }
    }
}
